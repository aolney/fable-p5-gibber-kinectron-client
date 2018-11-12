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

importAll "../sass/main.sass"

//Domain
//-----------------------------------------------------------------------------
type Model = 
  {
    KinectronIP : string
    P5 : p5
  }
 

type Msg =
  | ChangeIPStr of string
  | ConnectKinectron 

let init () : Model * Cmd<Msg> =
  { 
    KinectronIP = "192.168.128.20"
    P5 = null
  }, []

//Update
//-----------------------------------------------------------------------------
let GetColors(p : p5) =  //NOTE: string based color apis not working?
  [|
    p.color( 255.0 |> U2.Case1, 0.0, 0.0);
    p.color( 0.0 |> U2.Case1, 128.0, 0.0);
    p.color( 0.0 |> U2.Case1, 0.0, 255.0);
    p.color( 255.0 |> U2.Case1, 165.0, 0.0);
    p.color( 255.0 |> U2.Case1, 255.0, 0.0);
    p.color( 128.0 |> U2.Case1, 0.0, 128.0);
  |]
  
let getSketch ip = 
    new System.Func<obj,unit>(
        fun o ->
            let mutable drums = null
            let x = 100.0;
            let y = 100.0;
            let p = o |> unbox<p5>

            let canvasWidth,canvasHeight = 700.0,410.0
            let colors = GetColors(p)

            let doDraw(body:kinectron.Body)=
              p.background( 0.0 |> U4.Case1 , 20.0 )
              for j in body.joints do 
                p.fill( colors.[body.bodyIndex] |> U4.Case2 )
                if j.jointType = 11 && body.rightHandState = 2  then
                  p.fill( 255.0 |> U4.Case1 )
                  p.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
                  //p.triangle(j.depthX * canvasWidth - 8.0, j.depthY * canvasHeight - 8.0, j.depthX * canvasWidth + 8.0, j.depthY * canvasHeight - 8.0, j.depthX * canvasWidth, j.depthY * canvasHeight - 8.0) |> ignore
                  //p.rect(j.depthX - 8.0, j.depthY - 8.0, j.depthX + 8.0, j.depthY + 8.0) |> ignore
                elif j.jointType = 7 && body.leftHandState = 2 then
                  p.fill( 255.0 |> U4.Case1 )
                  p.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 30.0,30.0) |> ignore
                  //p.triangle(j.depthX * canvasWidth - 8.0, j.depthY * canvasHeight - 8.0, j.depthX * canvasWidth + 8.0, j.depthY * canvasHeight - 8.0, j.depthX * canvasWidth, j.depthY * canvasHeight - 8.0) |> ignore
                else
                  p.fill( colors.[body.bodyIndex] |> U4.Case2 )
                  p.ellipse( j.depthX * canvasWidth, j.depthY * canvasHeight, 15.0,15.0) |> ignore

            p.setup <- fun() -> 
                //do kinectron stuff here
                let kinectron = new Kinectron( ip )
                p.background(0.0 |> U4.Case1 )
                kinectron.makeConnection()
                kinectron.startTrackedBodies(doDraw)

                //old p5 demo stuff here
                p.createCanvas(700.0, 410.0) |> ignore
                drums <- p.EDrums("x*o*x*o-")                
                ()
            p.draw <- fun() -> ()
            // p.draw <- fun() ->
                
            //     if p.mouseIsPressed |> unbox<bool> then
            //         p.fill(0.0 |> U4.Case1)
            //     else
            //         p.fill(255.0 |> U4.Case1)
            //     p.rect(p.mouseX |> unbox<float>, p.mouseY |> unbox<float>, 50.0,50.0)
            //     |> ignore
            ()
    )

//let myp5 = p5(  getSketch ) //"192.168.128.20");

let update msg model : Model * Cmd<Msg> =
  match msg with
  | ChangeIPStr str ->
      { model with KinectronIP = str}, []
  | ConnectKinectron -> 
      { model with P5 = p5( getSketch model.KinectronIP )},[]
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
            Type "text"
            Placeholder "Type Kinectron IP Address"
            DefaultValue model.KinectronIP
            AutoFocus true
            OnChange (fun ev -> !!ev.target?value |> ChangeIPStr |> dispatch ) 
          ] 
    simpleButton "Connect" ConnectKinectron dispatch
    ]


// App
//-----------------------------------------------------------------------------
Program.mkProgram init update root
#if DEBUG
|> Program.withDebugger
|> Program.withHMR
#endif
|> Program.withReact "elmish-app"
|> Program.run
