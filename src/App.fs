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
    P5 : p5
    Debug : string
  }
 

type Msg =
  | ToggleMode
  | MouseMove of float * float
  | MouseClick of float * float
  | ChangeIPStr of string
  | ConnectKinectron 
  | Body of BodyModel

let init () : Model * Cmd<Msg> =
  { 
    Mode = Kinect
    MousePosition = 0.0,0.0
    MouseMoveHandler = null
    MouseClickHandler = null
    KinectronIP = "10.101.135.121"//"192.168.128.20"
    DefaultBody = 0
    Bodies = Array.init 6 (fun i -> {Mode=Programming; Id=i; LeftHand=0.0,0.0; RightHand=0.0,0.0})
    P5 = null
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


let GetColors(p : p5) =  //NOTE: string based color apis not working?
  [|
    p.color( 255.0 |> U2.Case1, 0.0, 0.0);
    p.color( 0.0 |> U2.Case1, 128.0, 0.0);
    p.color( 0.0 |> U2.Case1, 0.0, 255.0);
    p.color( 255.0 |> U2.Case1, 165.0, 0.0);
    p.color( 255.0 |> U2.Case1, 255.0, 0.0);
    p.color( 128.0 |> U2.Case1, 0.0, 128.0);
  |]

// [<Emit("p.textAlign(CENTER)")>]
// let textAlign() : unit = jsNative

let getSketch ip canvasWidth canvasHeight = 
    new System.Func<obj,unit>(
        fun o ->
            let p = o |> unbox<p5>

            let colors = GetColors(p)

            //Set  up kinnectron
            let kinectron = new Kinectron( ip )
            kinectron.makeConnection()

            let processFrame(body:kinectron.Body)=
              //We choose not to dispatch Elmish messages for drawing
              p.background( 0.0 |> U4.Case1 )// , 20.0 ) //blank the background
              for j in body.joints do 
                //draw closed right hand differently (large white)
                if j.jointType = kinectron.HANDRIGHT && body.rightHandState = 2  then
                  p.fill( 255.0 |> U4.Case1 )
                  p.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
                //draw closed left hand differently (large white)
                elif j.jointType = kinectron.HANDLEFT && body.leftHandState = 2 then
                  p.fill( 255.0 |> U4.Case1 )
                  p.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
                //draw all other joints with body color
                else
                  p.fill( colors.[body.bodyIndex] |> U4.Case2 )
                  p.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 15.0,15.0) |> ignore

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
              p.fill( 255.0 |> U4.Case1 )
              p.noStroke()
              p.textSize(20.0 ) |> ignore // |> U2.Case2)
              let rs (f:float) =
                System.Math.Round(f,1).ToString()
              
              p.text( bodyMode.ToString() + " " + rs(leftX) + "," + rs(leftY) + "|" + rs(rightX) + "," + rs(rightY), body.joints.[kinectron.SHOULDERLEFT].depthX * canvasWidth, body.joints.[3].depthY * canvasHeight, 200.0,200.0  ) |> ignore
             


              //Dispatch message for body state
              mapEvent.Trigger ( Msg.Body( {Id=body.bodyIndex; Mode=bodyMode; LeftHand=leftX,leftY; RightHand=rightX,rightY}  ) )

            //canoncial p5 setup function
            p.setup <- fun() -> 
                p.createCanvas(canvasWidth, canvasHeight) |> ignore   
                p.background(0.0 |> U4.Case1 )
                //textAlign()
                p.textAlign( p5.Alignment.CENTER )
                kinectron.startTrackedBodies(processFrame)            
                ()

            //canonical p5 draw function; subsumed by kinectron draw
            p.draw <- fun() -> ()

            ()
    )

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
      //update the left hand with a body command
      | VitruvianLeft (xrel,yrel) ->  { model with MousePosition = x,y }, Msg.Body( {Id=model.DefaultBody; Mode=model.Bodies.[model.DefaultBody].Mode ; LeftHand=xrel,yrel; RightHand=model.Bodies.[model.DefaultBody].RightHand}  ) |> Cmd.ofMsg
      //update the right hand with a body command
      | VitruvianRight (xrel,yrel) -> { model with MousePosition = x,y }, Msg.Body( {Id=model.DefaultBody; Mode=model.Bodies.[model.DefaultBody].Mode ; RightHand=xrel,yrel; LeftHand=model.Bodies.[model.DefaultBody].LeftHand}  ) |> Cmd.ofMsg
      //either the image does not exist or we are outside the vitruvian regions
      | _ -> model, []

    // //get image relative coordinates
    // let image = Browser.document.getElementById("vitruvian")
    // if image <> null then
    //   let rect = image.getBoundingClientRect()
    //   let xrel,yrel = x - rect.left,y - rect.top
    //   //if we are within left/right hand bounding box, register as kinect data
    //   let validLeft = xrel > 65.0 && xrel < 320.0 && yrel > 220.0 && yrel < 600.0
    //   let validRight = xrel > 455.0 && xrel < 710.0 && yrel > 220.0 && yrel < 595.0

    //   let bodyCmd = 
    //     if validLeft then
    //       Msg.Body( {Id=0; Mode=model.Bodies.[model.DefaultBody].Mode ; LeftHand=xrel,yrel; RightHand=model.Bodies.[model.DefaultBody].RightHand}  ) |> Cmd.ofMsg
    //     elif validRight then
    //       Msg.Body( {Id=0; Mode=model.Bodies.[model.DefaultBody].Mode ; RightHand=xrel,yrel; LeftHand=model.Bodies.[model.DefaultBody].LeftHand}  ) |> Cmd.ofMsg
    //     else
    //       []
          
    //   { model with MousePosition = xrel,yrel }, bodyCmd
    // else
    //   model,[]
  | MouseClick(x,y) ->
      match (x,y) with
      //update the right hand with a programming body command
      | VitruvianRight (xrel,yrel) -> { model with MousePosition = x,y;Debug = ("mouse click " + x.ToString() + " " + y.ToString() ) }, Msg.Body( {Id=model.DefaultBody; Mode=Programming ; RightHand=xrel,yrel; LeftHand=model.Bodies.[model.DefaultBody].LeftHand}  ) |> Cmd.ofMsg
      //ignore all other cases
      | _ -> model,[]
    //{ model with Debug = ("mouse click " + x.ToString() + " " + y.ToString() ) }, []
  | ChangeIPStr str ->
      { model with KinectronIP = str}, []
  | ConnectKinectron -> 
      { model with P5 = p5( getSketch model.KinectronIP 700.0 410.0)},[]
  | Body b ->
    //TODO: ENGAGE GIBBER HERE
    let newBodies = model.Bodies
    newBodies.[b.Id] <- b
    { model with Bodies = newBodies},[]
      //{ model with Debug = unbox<string>(bodyModel) }, []
      //model, []

//View
//-----------------------------------------------------------------------------
let simpleButton txt action dispatch =
    div [ ClassName "column is-narrow" ] [ 
      a [ ClassName "button" 
          Style [CSSProp.FontSize 28 ]
          OnClick (fun _ -> action |> dispatch) ]
        [ str txt ] 
      ]

let kinectView model dispatch =
  div [ ] [ 
    input [ ClassName "input"
            Style [CSSProp.FontSize 28 ]
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
      str "Move your mouse to adjust parameters within each red region. To program and lock in a rhythm, click the mouse." 
      ]
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
|> Program.withDebugger
|> Program.withHMR
#endif
|> Program.withReact "elmish-app"
|> Program.run
