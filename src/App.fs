module App

open Elmish
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Elmish.React
open Elmish.Debug
open Elmish.HMR
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.kinectron
open System
open Fable.PowerPack.Fetch.Fetch_types
open Fable.Import.React


importAll "../sass/main.sass"

//Helpers
//-----------------------------------------------------------------------------
[<Fable.Core.Emit("$0.push($1)")>]
let push (sb:'a[]) (v:'a) = failwith "js"
[<Fable.Core.Emit("$0.join($1)")>]
let join (sb:'a[]) (sep:string) = failwith "js"

type ``[]``<'a> with
  member x.push(v) = push x v
  member x.join(s) = join x s

let inline private (~%) x = createObj x

let inline private (=>) x y = x ==> y

//Domain
//-----------------------------------------------------------------------------
///Kinect v2 mode (requires Kinect and Kinectron) or Mouse mode (useful for development)
type UIMode =
  | Kinect | Mouse

///Programming mode sets rhythm (right only) and Performance sets pitch (on pitched instruments) and effects
type BodyMode = 
  | Programming | Performance

type BodyModel =
  {

    Mode : BodyMode
    Id : int
    LeftHand : float * float
    RightHand : float * float
  }

///Primary model in Elmish; represents total state of application
type Model = 
  {
    Mode : UIMode
    MousePosition : float * float
    MouseMoveHandler : obj
    MouseClickHandler : obj
    KinectronIP : string
    DefaultBody : int
    Bodies : BodyModel []
    InstrumentMap : int []
    Debug : string
  }
 
///Elmish messages definiing all UI actions and wrapped external events
type Msg =
  ///Toggle between Kinect and Mouse modes
  | ToggleMode
  | MouseMove of float * float
  | MouseClick of float * float
  | ChangeIPStr of string
  | ConnectKinectron 
  | Body of BodyModel
  | ChangeInstrument
  | Debug of string

///Gibber instruments are defined by quoted code to make use of Gibber's synchronization mechanism (codeToExecute; see documentation)
type GibberInstrument =
  {
    Name : string
    PlayCode : string
    KillCode : string
    CreateEffectCode : string
    UpdateEffectCode : string
  }

///Static array initializer of GibberInstruments; six instruments for up to six Kinect bodies
let gibberInstruments = 
  [|
    { 
      Name="Kick"; 
      PlayCode="kick = Kick().play( 55, Euclid( {0},{1} ) ); "; 
      KillCode = "kick.kill(); "
      CreateEffectCode = "hpf = HPF(); hpf.cutoff={0}/10; kick.fx.add(hpf); reverb = Reverb(); reverb.roomSize={1}; kick.fx.add(reverb); " 
      UpdateEffectCode = "hpf.cutoff={0}/10; reverb.roomSize={1}; " 
    }
    { 
      Name="Snare"; 
      PlayCode="snare = Snare().play( 1, Euclid( {0},{1} ) ); "; 
      KillCode = "snare.kill(); "
      CreateEffectCode = "snare.snappy={0}; snare.decay={1}*20000; " 
      UpdateEffectCode = "snare.snappy={0}; snare.decay={1}*20000; "
    }
    { 
      Name="Hat Closed"; 
      PlayCode="hatc = Hat().play( 5000, Euclid( {0},{1} ) ); "; 
      KillCode = "hatc.kill(); "
      CreateEffectCode = "flanger=Flanger(); flanger.rate={1}*20; flanger.amount={1}*300; flanger.feedback={1}; hatc.fx.add(flanger); lpf=LPF(); lpf.cutoff=1-{0}/2; hatc.fx.add(lpf); hatc.amp=6; " //y,x
      UpdateEffectCode = "flanger.rate={1}*20; flanger.amount={1}*300; flanger.feedback={1}; lpf.cutoff=1-{0}/2; "
    }
    { 
      Name="Hat Open"; 
      PlayCode="hato = Hat().play( 30000, Euclid( {0},{1} ) ); "; 
      KillCode = "hato.kill(); "
      CreateEffectCode = "ringmod=RingMod(); ringmod.frequency={1}*3000; ringmod.amp={0}; hato.fx.add(ringmod); hpf2=HPF(); hpf2.cutoff={0}/2; hato.fx.add(hpf2); "
      UpdateEffectCode = "ringmod.frequency={1}*3000; ringmod.amp={0}; hpf2.cutoff={0}/2; "
    }
    //TODO: find the doc specifying the magic number below which gibber interprets as notes and above which interprets as frequencies (guess to be in 40-50 range)
    { 
      Name="Bass"; 
      PlayCode="bass = FM( 'bass' ).note.seq( function(){return Math.round(bassPitch * 20)}, Euclid( {0},{1} ) ); "; 
      KillCode = "bass.kill(); "
      CreateEffectCode = "crush=Crush(); crush.bitDepth={0}*16; crush.sampleRate={1}; bass.fx.add(crush); bass.amp={0}; "
      UpdateEffectCode = "crush.bitDepth={0}*16; crush.sampleRate={1}; bass.amp={0}; "
    }
    { 
      Name="Melody"; 
      PlayCode="melody = Synth2({ maxVoices:4, waveform:'PWM'} ); melody.chord.seq( function(){return [ Math.round(melodyPitch1 * 20),Math.round(melodyPitch2 * 20), Math.round( (melodyPitch1 + melodyPitch2) * 10) ]}, Euclid( {0},{1} ) ); "; 
      KillCode = "melody.kill(); "
      CreateEffectCode = "melody.cutoff= .2 + {0}/2; melody.resonance={1}*5; "
      UpdateEffectCode = "melody.cutoff= .2 + {0}/2; melody.resonance={1}*5; "
    }
  |]

///Elmish init used to create intiial application state on start up
let init () : Model * Cmd<Msg> =
  { 
    Mode = Kinect
    MousePosition = 0.0,0.0
    MouseMoveHandler = null
    MouseClickHandler = null
    KinectronIP = "127.0.0.1"
    DefaultBody = 0
    Bodies = Array.init 6 (fun i -> {Mode=Programming; Id=i; LeftHand=0.0,0.0; RightHand=0.0,0.0})
    InstrumentMap = Array.init 6 ( fun i -> i)
    Debug = ""
  }, [] 

//Update
//-----------------------------------------------------------------------------
///External event wrapping a message
let mapEvent = Event<Msg>() 
///Subscription on external events to bring them into Elmish message queue
let mapEventSubscription initial =
    let sub dispatch =
        let msgSender msg = 
            msg
            |> dispatch
            
        mapEvent.Publish.Add(msgSender)

    Cmd.ofSub sub

///Static array initializer for colors for bodies tracked by Kinect
let GetColors() =  
  [|
    p5.color( 255.0, 0.0, 0.0)
    p5.color( 0.0, 128.0, 0.0);
    p5.color( 0.0, 0.0, 255.0);
    p5.color( 255.0, 165.0, 0.0);
    p5.color(255.0, 255.0, 0.0);
    p5.color( 128.0, 0.0, 128.0);
  |]

///P5 sketch for Kinect body tracking creation and update; calls Kinectron server
let kinectronSketch ip canvasWidth canvasHeight = 
  let colors = GetColors()

  //Set  up kinnectron
  let kinectron = new Kinectron( ip )
  kinectron.makeConnection()

  let processFrame(body:kinectron.Body)=
    //We choose not to dispatch Elmish messages for drawing
    p5.background( 0.0 )// , 20.0 ) //blank the background
    for j in body.joints do 
      //draw closed right hand differently (large white)
      if j.jointType = kinectron.HANDRIGHT && body.rightHandState = 2  then
        p5.fill( 255.0 |> U4.Case1 )
        p5.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
      //draw closed left hand differently (large white)
      elif j.jointType = kinectron.HANDLEFT && body.leftHandState = 2 then
        p5.fill( 255.0 |> U4.Case1 )
        p5.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
      //draw all other joints with body color
      else
        p5.fill( colors.[body.bodyIndex] |> U4.Case2 )
        p5.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 15.0,15.0) |> ignore

    //open hands means rhythm programming; closed means melody live performance
    let bodyMode = 
      if body.rightHandState = 2 && body.leftHandState = 2 then  
        BodyMode.Performance
      else
        BodyMode.Programming

    //Construct body relative coordinates based on shoulder width
    let width = body.joints.[kinectron.SHOULDERLEFT].depthX - body.joints.[kinectron.SHOULDERRIGHT].depthX 
    let leftX = ( body.joints.[kinectron.HANDLEFT].depthX - body.joints.[kinectron.SHOULDERLEFT].depthX )/(width * 2.0) 
    let leftY = ( body.joints.[kinectron.HANDLEFT].depthY - body.joints.[kinectron.SPINEBASE].depthY )/(width * 3.0) 
    let rightX = (body.joints.[kinectron.SHOULDERRIGHT].depthX - body.joints.[kinectron.HANDRIGHT].depthX)/(width * 2.0) 
    let rightY = ( body.joints.[kinectron.HANDRIGHT].depthY - body.joints.[kinectron.SPINEBASE].depthY)/(width * 3.0) 

    //display state
    p5.fill( 255.0 |> U4.Case1 )
    p5.noStroke() |> ignore
    p5.textSize(20.0 ) |> ignore // |> U2.Case2)
    let rs (f:float) =
      System.Math.Round(f,1).ToString()
    
    p5.text( bodyMode.ToString() + " " + rs(leftX) + "," + rs(leftY) + "|" + rs(rightX) + "," + rs(rightY), body.joints.[kinectron.SHOULDERLEFT].depthX * canvasWidth, body.joints.[3].depthY * canvasHeight, 200.0,200.0  ) |> ignore

    //Dispatch message for body state
    mapEvent.Trigger ( Msg.Body( {Id=body.bodyIndex; Mode=bodyMode; LeftHand=leftX,leftY; RightHand=rightX,rightY}  ) )

  //canoncial p5 setup function
  Browser.window?setup <- fun() -> 
      p5.createCanvas(canvasWidth, canvasHeight) |> ignore   
      p5.background(0.0 )
      p5.textAlign( p5.Alignment.CENTER )
      kinectron.startTrackedBodies(processFrame)            


  //canonical p5 draw function; subsumed by kinectron draw
  Browser.window?draw <- fun() -> ()


///Delays playing Gibber code until muscially appropriate (?next measure?)
let gibberPlayDelayed( code : string ) =
  p5.Gibber.Clock.codeToExecute.push( %[ "code"=> code ] )

///Plays Gibber code immediately, useful for effects
let gibberPlayImmediate( code: string) =
  Browser.window?eval(code) |> ignore

///Map native mouse move to Elmish messages
let onMouseMove (ev : Fable.Import.Browser.MouseEvent) =
  mapEvent.Trigger ( Msg.MouseMove(ev.clientX,ev.clientY) )
  null

///Map native mouse click to Elmish messages
let onMouseClick (ev : Fable.Import.Browser.MouseEvent) =
  mapEvent.Trigger ( Msg.MouseClick(ev.clientX,ev.clientY) )
  null

///Mouse mode active pattern for image relative coordinates of LEFT hand
let (|VitruvianLeft|_|) (x,y) =
    let image = Browser.document.getElementById("vitruvian")
    if image <> null then
      let rect = image.getBoundingClientRect()
      let xrel,yrel = x - rect.left,y - rect.top
      if xrel > 65.0 && xrel < 320.0 && yrel > 220.0 && yrel < 600.0 then
        Some( (xrel - 65.0 )/255.0, (yrel - 220.0)/380.0 ) //bound to [0,1]
      else
        None
    else
      None

///Mouse mode active pattern for image relative coordinates of RIGHT hand
let (|VitruvianRight|_|) (x,y) =
    let image = Browser.document.getElementById("vitruvian")
    if image <> null then
      let rect = image.getBoundingClientRect()
      let xrel,yrel = x - rect.left,y - rect.top
      if xrel > 455.0 && xrel < 710.0 && yrel > 220.0 && yrel < 595.0 then
        Some( (xrel - 455.0)/255.0, (yrel - 220.0)/380.0 ) //bound to [0,1]
      else
        None
    else
      None

///Elmish cannonical update function that maps incoming messages and model to a new model and commands
let update msg model : Model * Cmd<Msg> =
  match msg with
  | ToggleMode ->
      if model.Mode = Mouse then
        Fable.Import.Browser.window.removeEventListener ("mousemove",  unbox model.MouseMoveHandler) 
        Fable.Import.Browser.window.removeEventListener ("mousemove",  unbox model.MouseClickHandler) 
        { model with Mode = Kinect }, []
      else
        let moveHandler = System.Func<_,_>( onMouseMove )
        let clickHandler = System.Func<_,_>( onMouseClick )
        //since handler must be Func, which is anonymous, we must store a reference in our model to unsubscribe later
        Fable.Import.Browser.window.addEventListener_mousemove moveHandler 
        Fable.Import.Browser.window.addEventListener_click clickHandler 
        { model with Mode = Mouse; MouseMoveHandler=moveHandler; MouseClickHandler=clickHandler }, []
  | MouseMove(x,y) ->
      match (x,y) with
      | VitruvianLeft (xrel,yrel) ->  
        //update the left hand with a body command
        { model with MousePosition = x,y }, Msg.Body( {Id=model.DefaultBody; Mode=model.Bodies.[model.DefaultBody].Mode ; LeftHand=xrel,yrel; RightHand=model.Bodies.[model.DefaultBody].RightHand}  ) |> Cmd.ofMsg
      | VitruvianRight (xrel,yrel) -> 
        //update the right hand with a body command
        { model with MousePosition = x,y }, Msg.Body( {Id=model.DefaultBody; Mode=model.Bodies.[model.DefaultBody].Mode ; RightHand=xrel,yrel; LeftHand=model.Bodies.[model.DefaultBody].LeftHand}  ) |> Cmd.ofMsg
      //either the image does not exist or we are outside the vitruvian regions
      | _ -> model, []

  | MouseClick(x,y) ->
      match (x,y) with
      //update the right hand with a programming body command
      | VitruvianRight (xrel,yrel) -> { model with MousePosition = x,y;Debug = ("mouse click " + x.ToString() + " " + y.ToString() ) }, Msg.Body( {Id=model.DefaultBody; Mode=Programming ; RightHand=xrel,yrel; LeftHand=model.Bodies.[model.DefaultBody].LeftHand}  ) |> Cmd.ofMsg
      //ignore all other cases
      | _ -> model,[]
  | ChangeIPStr str ->
      { model with KinectronIP = str}, []
  | ConnectKinectron -> 
      kinectronSketch model.KinectronIP 700.0 410.0
      model,[]
  | Body b ->
    let instrument = gibberInstruments.[ model.InstrumentMap.[b.Id] ]
    //TODO: This message seems to happen without clicking on load sometimes
    let mutable debug = ""
    match b.Mode with
    | Programming -> 
      let x,y = b.RightHand
      let sx,sy = Math.Round(x * 16.0),Math.Round(y * 16.0) //NOTE: arbitrary limit to 16th notes
      let playEuclid = String.Format( instrument.PlayCode, sx, sy )
      let playEffect = String.Format( instrument.CreateEffectCode, x, y )
      debug <- sx.ToString() + ":" + sy.ToString() + ":" + instrument.Name
      gibberPlayDelayed ( instrument.KillCode ) //this will throw a harmless error if the instrument is not defined
      gibberPlayDelayed ( playEuclid )
      gibberPlayDelayed ( playEffect )
    | Performance -> 
      //Left hand performance is effects and requires updating those based on x/y coordinates
      let xLeft,yLeft = b.LeftHand
      let updateEffect = String.Format( instrument.UpdateEffectCode, xLeft, yLeft )
      gibberPlayImmediate ( updateEffect )
      //Right hand performance updates global variables that are referenced in the pitch functions for pitched instruments   
      let xRight,yRight = b.RightHand
      Browser.window?bassPitch <- yRight
      Browser.window?melodyPitch1 <- yRight
      Browser.window?melodyPitch2 <- xRight
      //TODO: only update the pitches when the appropriate instrument is active; currently all are being updated
      
    //access the model's body array to update this body, turning off programming mode if we were in it
    let newBodies = model.Bodies
    newBodies.[b.Id] <- {b with Mode=Performance}
    { model with Bodies = newBodies}, Debug( debug ) |> Cmd.ofMsg

  | ChangeInstrument ->
    //shift in circular array style
    let len =  model.InstrumentMap.Length
    let newMap = Array.create len 0
    newMap.[len-1] <- model.InstrumentMap.[0]
    for i = 0 to len - 2 do
        newMap.[i] <- model.InstrumentMap.[i+1]
    { model with InstrumentMap = newMap},[]
  | Debug x ->

    {model with Debug=x},[]

//View
//-----------------------------------------------------------------------------
///A simple button widget
let simpleButton txt action dispatch =
    div [ ClassName "column is-narrow" ] [ 
      a [ ClassName "button" 
          OnClick (fun _ -> action |> dispatch) ]
        [ str txt ] 
      ]

///Interface in Kinect mode
let kinectView model dispatch =
  div [ ClassName "container"] [
    div [ ClassName "level"; ClassName "is-size-6" ][
      div [ ClassName "level-left"][
        div [ ClassName "level-item"][
          p [][ str "Kinectron IP Address"]
        ]
        div [ ClassName "level-item"][
          input [ ClassName "input" 
                  Placeholder "Type Kinectron IP Address"
                  DefaultValue model.KinectronIP
                  AutoFocus true
                  OnChange (fun ev -> !!ev.target?value |> ChangeIPStr |> dispatch ) 
                ] 
        ]
        simpleButton "Connect" ConnectKinectron dispatch
        ]
    ]
  ]

///Interface in Mouse mode
let mouseView model dispatch =
  div [] [
    div [ClassName "container"] [
      div [ ClassName "level"; ClassName "is-size-6" ][
        div [ ClassName "level-left"][
          div [ ClassName "level-item"][
            span [ ] [ str (sprintf "Instrument is %s"  gibberInstruments.[model.InstrumentMap.[model.DefaultBody]].Name ) ]
            ]
          div [ ClassName "level-item"][
            span [] [ simpleButton "Change instrument" ChangeInstrument dispatch ]
            ]
        ]
      ]
    ];
    div [ ClassName "columns" ][
      div [ ClassName "column" ][
        span [ ][ 
          str "Simulate hand position by moving mouse in red regions (left/right). Your left hand is effects (requires playing sound). Your right hand programs "; 
          a [ Href "https://en.wikipedia.org/wiki/Euclidean_rhythm"] [ str "a Euclidean rhythm" ];
          str " by clicking once. For pitched instruments, moving right hand also changes pitch. Six instruments can play simultaneously. Click somewhere in right region to get started."]
        ]
      ];
    //if we attach mouse event handlers to img, e.g. img [ OnMouseMove (fun ev -> MouseMove(ev) |> dispatch) ; OnClick (fun ev -> MouseClick(ev) |> dispatch) ; ... ] 
    //we get hundreds of annoying react warnings "Warning: This synthetic event is reused for performance reasons. If you're seeing this, you're accessing the method ..."
    img [ ClassName "img-noscale"; Id "vitruvian"; Src "img/vitruvian-r2.jpg"; ]
  ]

///Root interface
let root model dispatch =
  let page = function
  | Kinect -> kinectView model dispatch
  | Mouse -> mouseView model dispatch

  div [] [
    h1 [ ClassName "is-size-1"] [ str "Fable Tekno"];
    div [ ClassName "columns" ][
      div [ ClassName "column" ][
        span [] [
              str "Compose music in real time using six instruments (4 piece drum kit/bass/melody). Kinect mode requires a Kinect v2 but Mouse mode requires only a mouse. "
              a [ Href "TODO INSERT LINK TO POST" ] [ str "See here for more details." ]
            ]
      ]
    ];
    div [ ClassName "container"] [ 
      div [ ClassName "level"; ClassName "is-size-6"] [
        div [ ClassName "level-left"][
          div [ ClassName "level-item"][
            span [] [  str (sprintf "Mode is %s" (model.Mode.ToString()) ) ]
          ]
          div [ ClassName "level-item"][
            span [] [ simpleButton "Toggle Mode" ToggleMode dispatch ]
          ]
        ]
      ]
    ];

    page model.Mode;
    
    span [ ] [ str (sprintf "%s" (model.ToString()) )]
  ]
  
    




// App
//-----------------------------------------------------------------------------
Program.mkProgram init update root
|> Program.withSubscription mapEventSubscription
#if DEBUG
//|> Program.withDebugger //getting some annoying messages on this; probably not using it properly
|> Program.withHMR
#endif
|> Program.withReact "elmish-app"
|> Program.run
