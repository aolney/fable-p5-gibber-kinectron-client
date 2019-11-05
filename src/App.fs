module App

open Fable.Core
open Fable.Core.JsInterop

open Browser

open Fable.Import

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props
open Elmish.Debug
open Elmish.HMR

open Fulma
open Fable.FontAwesome

open Fable.Import.kinectron

open System

// open Fable.Helpers.React
// open Fable.Helpers.React.Props
// open Fable.PowerPack.Fetch.Fetch_types
// open Fable.Import.React


importAll "./style.sass"

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

type KinectronState  =
  | Connected | Disconnected

[<StringEnum>]
type MouseState =
  | [<CompiledName("Tracking")>]Tracking | [<CompiledName("Not Tracking")>]NotTracking

///Programming mode sets rhythm (right only) and Performance sets pitch (on pitched instruments) and effects
type BodyMode = 
  | Programming | Performance | ChangeInstrument

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
    KinectronState : KinectronState
    MouseState : MouseState
    MousePosition : float * float
    MouseMoveHandler : obj
    MouseClickHandler : obj
    KinectronIP : string
    DefaultBody : int
    Bodies : BodyModel []
    ///Last time of instrument change; purposely global to slow down instrument changes 
    InstrumentChangeTime : DateTime
    Debug : string
  }
 
///Elmish messages definiing all UI actions and wrapped external events
type Msg =
  ///Toggle between Kinect and Mouse modes
  | ToggleMode
  | MouseMove of float * float
  | MouseLeftClick of float * float
  | MouseAltClick of float * float
  | ChangeIPStr of string
  | ConnectKinectron 
  | Body of BodyModel
  | ChangeInstrument
  | ResumeAudioContext //Chrome req https://github.com/processing/p5.js-sound/issues/249
  | Debug of string

///Our universe of instruments
[<StringEnum>]
type Instrument =
    | [<CompiledName("Kick")>] Kick
    | [<CompiledName("Snare")>] Snare
    | [<CompiledName("Hat Closed")>] HatClosed
    | [<CompiledName("Hat Open")>] HatOpen
    | [<CompiledName("Bass")>] Bass
    | [<CompiledName("Melody")>] Melody

///Gibber instruments are defined by quoted code to make use of Gibber's synchronization mechanism (codeToExecute; see documentation)
type GibberInstrument =
  {
    Instrument : Instrument
    PlayCode : string
    KillCode : string
    CreateEffectCode : string
    UpdateEffectCode : string
  }

///Static array initializer of GibberInstruments; six instruments for up to six Kinect bodies
let gibberInstruments = 
  [|
    { 
      Instrument=Kick;
      PlayCode="kick = Kick().play( 55, Euclid( {0},{1} ) ); kick.amp = 5; "; 
      KillCode = "kick.kill(); "
      CreateEffectCode = "hpf = HPF(); hpf.cutoff={0}/10; kick.fx.add(hpf); reverb = Reverb(); reverb.roomSize={1}; kick.fx.add(reverb); " 
      UpdateEffectCode = "hpf.cutoff={0}/10; reverb.roomSize={1}; " 
    }
    { 
      Instrument=Snare;
      PlayCode="snare = Snare().play( 1, Euclid( {0},{1} ) ); snare.amp = .5 "; 
      KillCode = "snare.kill(); "
      CreateEffectCode = "snare.snappy={0}; snare.decay={1}*20000; " 
      UpdateEffectCode = "snare.snappy={0}; snare.decay={1}*20000; "
    }
    { 
      Instrument=HatClosed;
      PlayCode="hatc = Hat().play( 5000, Euclid( {0},{1} ) ); hatc.amp=6 "; 
      KillCode = "hatc.kill(); "
      CreateEffectCode = "flanger=Flanger(); flanger.rate={1}*20; flanger.amount={1}*300; flanger.feedback={1}; hatc.fx.add(flanger); lpf=LPF(); lpf.cutoff=1-{0}/2; hatc.fx.add(lpf);  " //y,x
      UpdateEffectCode = "flanger.rate={1}*20; flanger.amount={1}*300; flanger.feedback={1}; lpf.cutoff=1-{0}/2; "
    }
    { 
      Instrument=HatOpen;
      PlayCode="hato = Hat().play( 30000, Euclid( {0},{1} ) ); hato.amp=6"; 
      KillCode = "hato.kill(); "
      CreateEffectCode = "ringmod=RingMod(); ringmod.frequency={1}*3000; ringmod.amp={0}; hato.fx.add(ringmod); hpf2=HPF(); hpf2.cutoff={0}/2; hato.fx.add(hpf2); "
      UpdateEffectCode = "ringmod.frequency={1}*3000; ringmod.amp={0}; hpf2.cutoff={0}/2; "
    }
    //TODO: find the doc specifying the magic number below which gibber interprets as notes and above which interprets as frequencies (guess to be in 40-50 range)
    { 
      Instrument=Bass;
      PlayCode="bass = FM( 'bass' ).note.seq( function(){return Math.round(bassPitch * 20)}, Euclid( {0},{1} ) ); "; 
      KillCode = "bass.kill(); "
      CreateEffectCode = "crush=Crush(); crush.bitDepth={0}*16; crush.sampleRate={1}; bass.fx.add(crush); bass.amp={0}; "
      UpdateEffectCode = "crush.bitDepth={0}*16; crush.sampleRate={1}; bass.amp={0}; "
    }
    { 
      Instrument=Melody;
      PlayCode="melody = Synth2({ maxVoices:4, waveform:'PWM'} ); melody.chord.seq( function(){return [ Math.round(melodyPitch1 * 20),Math.round(melodyPitch2 * 20), Math.round( (melodyPitch1 + melodyPitch2) * 10) ]}, Euclid( {0},{1} ) ); melody.amp = 1; "; 
      KillCode = "melody.kill(); "
      CreateEffectCode = "melody.cutoff= .2 + {0}/2; melody.resonance={1}*5; "
      UpdateEffectCode = "melody.cutoff= .2 + {0}/2; melody.resonance={1}*5; "
    }
  |]

///Elmish init used to create intiial application state on start up
let init () : Model * Cmd<Msg> =
  { 
    Mode = Kinect
    KinectronState = Disconnected
    MouseState = Tracking
    MousePosition = 0.0,0.0
    MouseMoveHandler = null
    MouseClickHandler = null
    KinectronIP = "127.0.0.1"
    DefaultBody = 0
    Bodies = Array.init 6 (fun i -> {Mode=Programming; Id=i; LeftHand=0.0,0.0; RightHand=0.0,0.0})
    InstrumentChangeTime = System.DateTime.Now
    Debug = ""
  }, [] 

///Map instruments to tracked bodies; must be outside model to access in kinectron draw loop 
let mutable InstrumentMap = Array.init 6 ( fun i -> i)

//Update
//-----------------------------------------------------------------------------
///External event wrapping a message
let mapEvent = Microsoft.FSharp.Control.Event<Msg>() 
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

  //We choose not to dispatch Elmish messages for drawing and instead do all drawing here
  let processFrame(body:kinectron.Body)=
    //blank the background, 100% opacity (prevents drawing of all players?)
    //p5.background( 0.0, 255 )
    //blank the background, partial opacity (to allow drawing of all players?)
    p5.background( 0.0, 20 ) 

    for j in body.joints do 
      //draw closed right hand differently (large white)
      if j.jointType = kinectron.HANDRIGHT && body.rightHandState = 2  then
        p5.fill( 255.0 |> U4.Case1 )
        p5.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
      //draw closed left hand differently (large white)
      elif j.jointType = kinectron.HANDLEFT && body.leftHandState = 2 then
        p5.fill( 255.0 |> U4.Case1 )
        p5.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
      //draw all other joints with body color; skip head/neck b/c we will draw text there
      elif j.jointType <> kinectron.HEAD && j.jointType <> kinectron.NECK then
        p5.fill( colors.[body.bodyIndex] |> U4.Case2 )
        p5.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 15.0,15.0) |> ignore

    //Lasso both hands (peace sign) is change insturments; closed hands (3) means rhythm programming; everything else is melody live performance
    let bodyMode = 
      if body.rightHandState = 4 && body.leftHandState = 4 then
      //clap loses pitch and effects
      //(Math.Abs(body.joints.[kinectron.HANDLEFT].depthX - body.joints.[kinectron.HANDRIGHT].depthX) < 0.01) && (Math.Abs(body.joints.[kinectron.HANDLEFT].depthY - body.joints.[kinectron.HANDRIGHT].depthY) < 0.01) then
        BodyMode.ChangeInstrument
      elif body.rightHandState = 3 && body.leftHandState = 3 then  
        BodyMode.Programming
      else
        BodyMode.Performance

    //Construct body relative coordinates based on shoulder width
    let width = body.joints.[kinectron.SHOULDERLEFT].depthX - body.joints.[kinectron.SHOULDERRIGHT].depthX 
    let leftX = ( body.joints.[kinectron.HANDLEFT].depthX - body.joints.[kinectron.SHOULDERLEFT].depthX )/(width * 2.0) 
    let leftY = ( body.joints.[kinectron.HANDLEFT].depthY - body.joints.[kinectron.SPINEBASE].depthY )/(width * 3.0) 
    let rightX = (body.joints.[kinectron.SHOULDERRIGHT].depthX - body.joints.[kinectron.HANDRIGHT].depthX)/(width * 2.0) 
    let rightY = ( body.joints.[kinectron.HANDRIGHT].depthY - body.joints.[kinectron.SPINEBASE].depthY)/(width * 3.0) 

    //display state
    p5.fill( 255.0 |> U4.Case1 )
    p5.noStroke() |> ignore
    p5.textSize(20.0 ) |> ignore 
    let rs (f:float) =
      System.Math.Round(f,1).ToString()
    
    p5.text(gibberInstruments.[ InstrumentMap.[body.bodyIndex] ].Instrument.ToString() + " " + bodyMode.ToString() + " " + rs(leftX) + "," + rs(leftY) + "|" + rs(rightX) + "," + rs(rightY), body.joints.[kinectron.HEAD].depthX * canvasWidth, body.joints.[kinectron.HEAD].depthY * canvasHeight, 200.0,200.0  ) |> ignore

    //Dispatch message for body state
    mapEvent.Trigger ( Msg.Body( {Id=body.bodyIndex; Mode=bodyMode; LeftHand=leftX,leftY; RightHand=rightX,rightY}  ) )

  //set up p5 and start tracking bodies
  p5.createCanvas(canvasWidth, canvasHeight) |> ignore   
  p5.background(0.0, 255 )
  p5.textAlign( p5.Alignment.CENTER )
  kinectron.startTrackedBodies(processFrame)            


///Delays playing Gibber code until muscially appropriate (?next measure?)
let gibberPlayDelayed( code : string ) =
  p5.Gibber.Clock.codeToExecute.push( %[ "code"=> code ] )

///Plays Gibber code immediately, useful for effects
let gibberPlayImmediate( code: string) =
  Browser.Dom.window?eval(code) |> ignore

///Map native mouse move to Elmish messages
let onMouseMove (ev : Browser.Types.Event) =
  let evm = ev |> unbox<Browser.Types.MouseEvent>
  mapEvent.Trigger ( Msg.MouseMove(evm.clientX,evm.clientY) )
  

///Map native mouse click to Elmish messages
let onMouseClick (ev : Browser.Types.Event) =
  let evm = ev |> unbox<Browser.Types.MouseEvent>
  if evm.altKey |> not then 
    mapEvent.Trigger ( MouseLeftClick(evm.clientX,evm.clientY) )
  else
    mapEvent.Trigger ( MouseAltClick(evm.clientX,evm.clientY) )
  

///Mouse mode active pattern for image relative coordinates of LEFT hand
let (|VitruvianLeft|_|) (x,y) =
    let image = Browser.Dom.document.getElementById("vitruvian")
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
    let image = Browser.Dom.document.getElementById("vitruvian")
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
        Browser.Dom.window.removeEventListener ("mousemove",  unbox model.MouseMoveHandler) 
        Browser.Dom.window.removeEventListener ("click",  unbox model.MouseClickHandler) 
        { model with Mode = Kinect; }, []
      else
        // let moveHandler = System.Func<_,_>( onMouseMove )
        // let clickHandler = System.Func<_,_>( onMouseClick )
        //since handler must be Func, which is anonymous, we must store a reference in our model to unsubscribe later
        Browser.Dom.window.addEventListener( "mousemove", onMouseMove )
        Browser.Dom.window.addEventListener("click", onMouseClick )
        { model with Mode = Mouse; MouseMoveHandler=onMouseMove; MouseClickHandler=onMouseClick; }, []
  | MouseMove(x,y) ->
      match model.MouseState,(x,y) with
      | Tracking,VitruvianLeft (xrel,yrel) ->  
        //update the left hand with a body command
        { model with MousePosition = x,y }, Msg.Body( {Id=model.DefaultBody; Mode=model.Bodies.[model.DefaultBody].Mode ; LeftHand=xrel,yrel; RightHand=model.Bodies.[model.DefaultBody].RightHand}  ) |> Cmd.ofMsg
      | Tracking,VitruvianRight (xrel,yrel) -> 
        //update the right hand with a body command
        { model with MousePosition = x,y }, Msg.Body( {Id=model.DefaultBody; Mode=model.Bodies.[model.DefaultBody].Mode ; RightHand=xrel,yrel; LeftHand=model.Bodies.[model.DefaultBody].LeftHand}  ) |> Cmd.ofMsg
      //either the image does not exist or we are outside the vitruvian regions
      | _,_ -> model, []
  | MouseLeftClick(x,y) ->
      match model.MouseState,(x,y) with
      //update the right hand with a programming body command
      | Tracking,VitruvianRight (xrel,yrel) -> { model with MousePosition = x,y;Debug = ("mouse click " + x.ToString() + " " + y.ToString() ) }, Msg.Body( {Id=model.DefaultBody; Mode=Programming ; RightHand=xrel,yrel; LeftHand=model.Bodies.[model.DefaultBody].LeftHand}  ) |> Cmd.ofMsg
      //ignore all other cases
      | _,_ -> model,[]
  | MouseAltClick(x,y) ->
    let newMouseState =
      match model.MouseState with
      | Tracking -> NotTracking
      | NotTracking -> Tracking
    {model with MouseState=newMouseState},[]
  | ChangeIPStr str ->
      { model with KinectronIP = str}, []
  | ConnectKinectron -> 
      kinectronSketch model.KinectronIP 1980.0 600.0
      {model with KinectronState=Connected},[]
  //Body messages are issued in both mouse and kinect mode
  //TODO: This message seems to happen without clicking on load sometimes
  | Body b ->
    //get instrument for this body
    let instrument = gibberInstruments.[ InstrumentMap.[b.Id] ]
    //access the model's body array to update this body, turning off programming mode if we were in it
    let newBodies = model.Bodies
    newBodies.[b.Id] <- {b with Mode=Performance}
    let mutable debug = ""

    match b.Mode with
    | Programming -> 
      let x,y = b.RightHand
      let sx,sy = Math.Round(x * 16.0),Math.Round(y * 16.0) //NOTE: arbitrary limit to 16th notes
      let playEuclid = String.Format( instrument.PlayCode, sx, sy )
      let playEffect = String.Format( instrument.CreateEffectCode, x, y )
      debug <- sx.ToString() + ":" + sy.ToString() + ":" + instrument.Instrument.ToString()
      gibberPlayDelayed ( instrument.KillCode ) //this will throw a harmless error if the instrument is not defined
      gibberPlayDelayed ( playEuclid )
      gibberPlayDelayed ( playEffect )
      { model with Bodies = newBodies}, Debug( debug ) |> Cmd.ofMsg
    | Performance -> 
      //Left hand performance is effects and requires updating those based on x/y coordinates
      let xLeft,yLeft = b.LeftHand
      let updateEffect = String.Format( instrument.UpdateEffectCode, xLeft, yLeft )
      gibberPlayImmediate ( updateEffect )
      //Right hand performance updates global variables that are referenced in the pitch functions for pitched instruments   
      let xRight,yRight = b.RightHand
      if instrument.Instrument = Bass then
        Browser.Dom.window?bassPitch <- yRight
      elif instrument.Instrument = Melody then
        Browser.Dom.window?melodyPitch1 <- yRight
        Browser.Dom.window?melodyPitch2 <- xRight
      { model with Bodies = newBodies}, []
    | BodyMode.ChangeInstrument ->
      //Enforce two second delay between messages so users can shift one instrument at a time
      if (System.DateTime.Now - model.InstrumentChangeTime).Seconds < 2 then
        { model with Bodies = newBodies}, []
      else
        { model with Bodies = newBodies}, ChangeInstrument |> Cmd.ofMsg
  | ChangeInstrument ->
    //shift in circular array style
    let len =  InstrumentMap.Length
    let newMap = Array.create len 0
    newMap.[len-1] <- InstrumentMap.[0]
    for i = 0 to len - 2 do
        newMap.[i] <- InstrumentMap.[i+1]

    InstrumentMap <- newMap
    {model with InstrumentChangeTime = DateTime.Now},[]
  | ResumeAudioContext ->
    //p5.getAudioContext()?resume() |> ignore
    //Gibber.Audio.Core.context.resume()
    p5.Gibber.Audio.Core.context?resume()

    model,[]
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
  div [] [
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
          div [ ClassName "level-item"][
            (
              match model.KinectronState with
              | Disconnected -> simpleButton "Connect" ConnectKinectron dispatch
              | Connected -> 
                span [ ClassName "has-text-success" ][ str "You are connected. Refresh to make a new connection. " ] //TODO: Not sure how to tear down kinectron; perhaps should move to model
            )
          ]
        ]
      ];
      div [ ClassName "columns" ][
        div [ ClassName "column" ][
          (
            match model.KinectronState with
            | Connected -> str ""
            | Disconnected ->
                span [ ClassName "has-text-danger" ][ 
                  str "You are currently disconnected. Connect to Kinectron or switch to mouse mode. "; 
                ]
          )
        ]
      ]
    ];
    div [ ClassName "columns" ][
      div [ ClassName "column" ][
        (
          match model.KinectronState with
          | Connected -> 
              span [ ][ 
                str "Your right hand position programs "; 
                a [ Href "https://en.wikipedia.org/wiki/Euclidean_rhythm"] [ str "a Euclidean rhythm" ];
                str " if BOTH hands are closed. Once a rhythm is programmed, your open left hand position modulates effects, and for pitched instruments, your open right hand changes pitch. Peace/victory signs on both hands changes instruments for all players. Close both hands while being tracked to get started."
              ]
          | Disconnected -> str ""
        )
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
            span [ ] [ str (sprintf "Instrument is %s"  (gibberInstruments.[ InstrumentMap.[model.DefaultBody] ].Instrument.ToString()) ) ]
            ]
          div [ ClassName "level-item"][
            span [] [ simpleButton "Change Instrument" ChangeInstrument dispatch ]
            ]
        ]
      ]
      div [ ClassName "level"; ClassName "is-size-6" ][
        div [ ClassName "level-left"][
          div [ ClassName "level-item"][
            (
              match model.MouseState with
              | Tracking -> span [ ClassName "has-text-success"] [ str (sprintf "Mouse is %s" ( model.MouseState.ToString() ) ) ]
              | NotTracking -> span [ ClassName "has-text-danger"  ] [ str (sprintf "Mouse is %s" ( model.MouseState.ToString() ) ) ]
            )
          ]
          div [ ClassName "level-item"] [
            span [] [ simpleButton "Toggle Tracking" (MouseAltClick(0.0,0.0)) dispatch ]
          ]
        ]
      ]
    ];
    div [ ClassName "columns" ][
      div [ ClassName "column" ][
        span [ ][ 
          str "Simulate hand position by moving mouse in red regions (left/right). Your left hand is effects (requires playing sound). Your right hand programs "; 
          a [ Href "https://en.wikipedia.org/wiki/Euclidean_rhythm"] [ str "a Euclidean rhythm" ];
          str " by clicking once. For pitched instruments, moving right hand also changes pitch. Turn on/off mouse tracking by holding down ALT and clicking. Six instruments can play simultaneously. Click somewhere in right region to get started."]
        ]
      ];
    //if we attach mouse event handlers to img, e.g. img [ OnMouseMove (fun ev -> MouseMove(ev) |> dispatch) ; OnClick (fun ev -> MouseClick(ev) |> dispatch) ; ... ] 
    //we get hundreds of annoying react warnings "Warning: This synthetic event is reused for performance reasons. If you're seeing this, you're accessing the method ..."
    img [ ClassName "img-noscale"; Id "vitruvian"; Src "img/vitruvian-r2-santa.jpg"; ]
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
              str "Compose music in real time using six instruments (4 piece drum kit/bass/melody). Kinect/team mode requires a Kinect v2 but Mouse/single mode requires only a mouse. "
              a [ Href "https://olney.ai/category/2018/12/02/fabletekno.html" ] [ str "Click here for more details." ]
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
            span [] [ simpleButton "Start/resume Audio" ResumeAudioContext dispatch ]
          ]
        ]
      ]
    ];

    page model.Mode;
    
    // span [ ] [ str (sprintf "%s" (model.ToString()) )]
  ]
  
    




// App
//-----------------------------------------------------------------------------
Program.mkProgram init update root
|> Program.withSubscription mapEventSubscription
#if DEBUG
|> Program.withDebugger
|> Program.withConsoleTrace
#endif
|> Program.withReactSynchronous "elmish-app"
// |> Program.withReactBatched "elmish-app"
|> Program.run
