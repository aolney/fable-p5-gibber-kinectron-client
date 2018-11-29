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
type UIMode =
  | Kinect | Mouse

type BodyMode = 
  | Programming | Performance


type BodyModel =
  {

    Mode : BodyMode
    Id : int
    LeftHand : float * float
    RightHand : float * float
  }


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
 

type Msg =
  | ToggleMode
  | MouseMove of float * float
  | MouseClick of float * float
  | ChangeIPStr of string
  | ConnectKinectron 
  | Body of BodyModel
  | ChangeInstrument
  | Debug of string

type GibberInstrument =
  {
    Name : string
    PlayCode : string
    KillCode : string
  }

let gibberInstruments = 
  [|
    //TODO: add effects
    { Name="Kick"; PlayCode="kick = Kick().play( 55, Euclid( {0},{1} ) ); "; KillCode = "kick.kill(); "}
    { Name="Snare"; PlayCode="snare = Snare().play( 1, Euclid( {0},{1} ) ); "; KillCode = "snare.kill(); "}
    { Name="Hat Closed"; PlayCode="hatc = Hat().play( 5000, Euclid( {0},{1} ) ); "; KillCode = "hatc.kill(); "}
    { Name="Hat Open"; PlayCode="hato = Hat().play( 30000, Euclid( {0},{1} ) ); "; KillCode = "hato.kill(); "}
    //TODO: find the doc specifying the magic number below which gibber interprets as notes and above which interprets as frequencies
    { Name="Bass"; PlayCode="bass = FM( 'bass' ).note.seq( function(){return Math.round(rightMouseY * 40)}, Euclid( {0},{1} ) ); "; KillCode = "bass.kill(); "}
    { Name="Melody"; PlayCode="melody = Synth2({ maxVoices:4, waveform:'PWM'} ); melody.chord.seq( function(){return [ Math.round(rightMouseY * 40),Math.round(rightMouseY * 40), Math.round( (rightMouseY + rightMouseX) * 20) ]}, Euclid( {0},{1} ) ); "; KillCode = "melody.kill(); "}
  |]

let init () : Model * Cmd<Msg> =
  { 
    Mode = Kinect
    MousePosition = 0.0,0.0
    MouseMoveHandler = null
    MouseClickHandler = null
    KinectronIP = "10.101.135.121"//"192.168.128.20"
    DefaultBody = 0
    Bodies = Array.init 6 (fun i -> {Mode=Programming; Id=i; LeftHand=0.0,0.0; RightHand=0.0,0.0})
    InstrumentMap = Array.init 6 ( fun i -> i)
    Debug = ""
  }, [] 

//Update
//-----------------------------------------------------------------------------
let mapEvent = Event<Msg>() 

let mapEventSubscription initial =
    let sub dispatch =
        let msgSender msg = 
            msg
            |> dispatch
            
        mapEvent.Publish.Add(msgSender)

    Cmd.ofSub sub


let GetColors() =  
  [|
    p5.color( 255.0, 0.0, 0.0)
    p5.color( 0.0, 128.0, 0.0);
    p5.color( 0.0, 0.0, 255.0);
    p5.color( 255.0, 165.0, 0.0);
    p5.color(255.0, 255.0, 0.0);
    p5.color( 128.0, 0.0, 128.0);
  |]

//Process a kinectron data frame as a P5 sketch
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
  Browser.window?setup <- fun() -> ()


//Does not play immediately but rather waits until muscially appropriate (?next measure?)
let gibberPlay( code : string ) =
  p5.Gibber.Clock.codeToExecute.push( %[ "code"=> code ] )

//let myp5 = p5(  getSketch ) //"192.168.128.20");
let onMouseMove (ev : Fable.Import.Browser.MouseEvent) =
  mapEvent.Trigger ( Msg.MouseMove(ev.clientX,ev.clientY) )
  null

let onMouseClick (ev : Fable.Import.Browser.MouseEvent) =
  mapEvent.Trigger ( Msg.MouseClick(ev.clientX,ev.clientY) )
  null

//get image relative coordinates for each hand
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
        //set some global mouse position variables for Gibber
        Browser.window?leftMouseX <- xrel
        Browser.window?leftMouseY <- yrel
        //update the left hand with a body command
        { model with MousePosition = x,y }, Msg.Body( {Id=model.DefaultBody; Mode=model.Bodies.[model.DefaultBody].Mode ; LeftHand=xrel,yrel; RightHand=model.Bodies.[model.DefaultBody].RightHand}  ) |> Cmd.ofMsg
      | VitruvianRight (xrel,yrel) -> 
        //set some global mouse position variables for Gibber
        Browser.window?rightMouseX <- xrel
        Browser.window?rightMouseY <- yrel
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
    //TODO: This message seems to happen without clicking
    let mutable debug = ""
    match b.Mode with
    | Programming -> 
        let x,y = b.RightHand
        let sx,sy = Math.Round(x * 16.0),Math.Round(y * 16.0) //NOTE: 16 is an arbitrary scaling factor
        let instrument = gibberInstruments.[ model.InstrumentMap.[b.Id] ]
        let playWithRhythm = String.Format( instrument.PlayCode, sx, sy )
        debug <- sx.ToString() + ":" + sy.ToString() + ":" + instrument.Name
        gibberPlay ( instrument.KillCode ) //this will throw a harmless error if the instrument is not defined
        gibberPlay ( playWithRhythm )
        
    | Performance -> ()

    //access the model's body array to update this body, turning off programming mode
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
  

    //P5 global instance initialization
    // Browser.window?setup <- fun() -> 
    //     (
    //       p5.createCanvas(600.0, 400.0) |> ignore   
    //       p5.background(0.0 )
    //     )
    // //p5.draw <- fun() -> 
    // Browser.window?draw <- fun() -> 
    //     (
    //       p5.fill( 255.0 |> U4.Case1 )
    //       p5.ellipse( p5.mouseX ,  p5.mouseY , 30.0,30.0) |> ignore
    //       //p5.ellipse( unbox<float>(Browser.window?mouseX),  unbox<float>(Browser.window?mouseY), 30.0,30.0) |> ignore
    //     )

//View
//-----------------------------------------------------------------------------
let simpleButton txt action dispatch =
    div [ ClassName "column is-narrow" ] [ 
      a [ ClassName "button" 
          //Style [CSSProp.FontSize 28 ]
          OnClick (fun _ -> action |> dispatch) ]
        [ str txt ] 
      ]
let button txt action dispatch =
  Fable.Helpers.React.button [
    ClassName "button" 
    OnClick (fun _ -> action |> dispatch)  ] [  str txt ]


let kinectView model dispatch =
  div [ ] [ 
    input [ ClassName "input"
            //Style [CSSProp.FontSize 28 ]
            //Type "text"
            Placeholder "Type Kinectron IP Address"
            DefaultValue model.KinectronIP
            AutoFocus true
            OnChange (fun ev -> !!ev.target?value |> ChangeIPStr |> dispatch ) 
          ] 
    simpleButton "Connect" ConnectKinectron dispatch
    ]
let mouseView model dispatch =
  div [ ] [ 
    span [ Style [CSSProp.FontSize 28 ] ] [ 
      str ( gibberInstruments.[model.InstrumentMap.[model.DefaultBody]].Name )
      ]
    simpleButton "Change instrument" ChangeInstrument dispatch
    span [ Style [CSSProp.FontSize 28 ] ] [ 
      str "Move your mouse to adjust parameters within each red region. To program and lock in a rhythm, click the mouse." 
      ]
    //if we attach mouse event handlers to img, e.g. img [ OnMouseMove (fun ev -> MouseMove(ev) |> dispatch) ; OnClick (fun ev -> MouseClick(ev) |> dispatch) ; ... ] 
    //we get hundreds of annoying react warnings "Warning: This synthetic event is reused for performance reasons. If you're seeing this, you're accessing the method ..."
    img [ Id "vitruvian"; Src "img/vitruvian-r2.jpg"]
    ]
let root model dispatch =
  div [ ] [ 
    simpleButton "Toggle Mode" ToggleMode dispatch
    (
      if model.Mode = Kinect then
        kinectView model dispatch
      else
        mouseView model dispatch
    )
    span [ ] [ 
      str (sprintf "%s" (model.ToString()) )]
    ]



// App
//-----------------------------------------------------------------------------
Program.mkProgram init update root
|> Program.withSubscription mapEventSubscription
#if DEBUG
//|> Program.withDebugger 
|> Program.withHMR
#endif
|> Program.withReact "elmish-app"
|> Program.run
