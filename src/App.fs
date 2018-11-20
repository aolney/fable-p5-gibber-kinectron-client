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

importAll "../sass/main.sass"

//Domain
//-----------------------------------------------------------------------------
type BodyMode = 
  | Programming | Performance


type BodyModel =
  {

    Mode : BodyMode
    Id : int
    LeftHandX : float
    LeftHandY : float
    RightHandX : float
    RightHandY : float
  }

type Model = 
  {
    KinectronIP : string
    P5 : p5
    Debug : string
  }
 

type Msg =
  | ChangeIPStr of string
  | ConnectKinectron 
  | Body of BodyModel

let init () : Model * Cmd<Msg> =
  { 
    KinectronIP = "10.101.135.121"//"192.168.128.20"
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

[<Emit("p.textAlign(CENTER)")>]
let textAlign() : unit = jsNative

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
              let leftHandX = ( body.joints.[kinectron.HANDLEFT].depthX - body.joints.[kinectron.SHOULDERLEFT].depthX )/(width * 2.0) 
              let leftHandY = ( body.joints.[kinectron.HANDLEFT].depthY - body.joints.[kinectron.SPINEBASE].depthY )/(width * 3.0) 
              let rightHandX = (body.joints.[kinectron.SHOULDERRIGHT].depthX - body.joints.[kinectron.HANDRIGHT].depthX)/(width * 2.0) 
              let rightHandY = ( body.joints.[kinectron.HANDRIGHT].depthY - body.joints.[kinectron.SPINEBASE].depthY)/(width * 3.0) 
              
              //display state
              p.fill( 255.0 |> U4.Case1 )
              p.noStroke()
              p.textSize(20.0 ) |> ignore // |> U2.Case2)
              let rs (f:float) =
                System.Math.Round(f,1).ToString()
              
              p.text( bodyMode.ToString() + " " + rs(leftHandX) + "," + rs(leftHandY) + "|" + rs(rightHandX) + "," + rs(rightHandY), body.joints.[kinectron.SHOULDERLEFT].depthX * canvasWidth, body.joints.[3].depthY * canvasHeight, 200.0,200.0  ) |> ignore
             


              //Dispatch message for body state
              mapEvent.Trigger ( Msg.Body( {Id=body.bodyIndex; Mode=bodyMode; LeftHandX=leftHandX; LeftHandY=leftHandY; RightHandX=rightHandX; RightHandY=rightHandY}  ) )

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

let update msg model : Model * Cmd<Msg> =
  match msg with
  | ChangeIPStr str ->
      { model with KinectronIP = str}, []
  | ConnectKinectron -> 
      { model with P5 = p5( getSketch model.KinectronIP 700.0 410.0)},[]
  | Body bodyModel ->
    
      { model with Debug = unbox<string>(obj) }, []
      //model, []

//View
//-----------------------------------------------------------------------------
let simpleButton txt action dispatch =
    div
      [ ClassName "column is-narrow" ]
      [ a
          [ ClassName "button"
            OnClick (fun _ -> action |> dispatch) ]
[ str txt ] ]
let root model dispatch =
  div [ ] [ 
    input [ ClassName "input"
            //Type "text"
            Placeholder "Type Kinectron IP Address"
            DefaultValue model.KinectronIP
            AutoFocus true
            OnChange (fun ev -> !!ev.target?value |> ChangeIPStr |> dispatch ) 
          ] 
    simpleButton "Connect" ConnectKinectron dispatch
    //simpleButton "Debug button" Debug dispatch
    span [ ] [ 
      //model.Debug |> str ] 
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
