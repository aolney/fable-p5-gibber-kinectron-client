namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

//NOTE: most functions have not been tested. This was hand written off the docs
//Currently loading as script in index.html rather than using npm/webpack
module kinectron =
    type [<AllowNullLiteral>] [<Global>] Data() =
        member __.src with get(): obj = jsNative
    and [<AllowNullLiteral>] [<Global>] Joint() =
        member __.cameraX with get(): float = jsNative  
        member __.cameraY with get(): float = jsNative
        member __.cameraZ with get(): float = jsNative
        member __.colorX with get(): float = jsNative  
        member __.colorY with get(): float = jsNative
        member __.depthX with get(): float = jsNative  
        member __.depthY with get(): float = jsNative 
        member __.orientationW with get(): float = jsNative  
        member __.orientationX with get(): float = jsNative
        member __.orientationY with get(): float = jsNative
        member __.orientationZ with get(): float = jsNative 
        member __.jointType with get(): int = jsNative
        member __.trackingState with get(): int = jsNative
    and [<AllowNullLiteral>] [<Global>] Body() =
        member __.bodyIndex with get(): int = jsNative 
        member __.tracked with get(): bool = jsNative 
        member __.record_starttime with get(): obj = jsNative
        member __.record_timestamp with get(): obj = jsNative
        member __.joints with get(): ResizeArray<Joint> = jsNative
        member __.trackingId with get(): string = jsNative
        member __.leftHandState with get(): int = jsNative
        member __.rightHandState with get(): int = jsNative
    and [<AllowNullLiteral>] [<Global>] Hands() =
        member __.leftHand with get(): Joint = jsNative
        member __.rightHand with get(): Joint = jsNative
        member __.leftHandState with get(): int = jsNative
        member __.rightHandState with get(): int = jsNative
    and [<AllowNullLiteral>] [<Global>] Kinectron(ip:string,?networkConfig:obj) =
        member __.makeConnection(): unit = jsNative
        member __.SPINEBASE with get(): int = jsNative
        member __.SPINEMID with get(): int = jsNative
        member __.NECK with get(): int = jsNative
        member __.HEAD with get(): int = jsNative
        member __.SHOULDERLEFT with get(): int = jsNative
        member __.ELBOWLEFT with get(): int = jsNative
        member __.WRISTLEFT with get(): int = jsNative
        member __.HANDLEFT with get(): int = jsNative
        member __.SHOULDERRIGHT with get(): int = jsNative
        member __.ELBOWRIGHT with get(): int = jsNative
        member __.WRISTRIGHT with get(): int = jsNative
        member __.HANDRIGHT with get(): int = jsNative
        member __.HIPLEFT with get(): int = jsNative
        member __.KNEELEFT with get(): int = jsNative
        member __.ANKLELEFT with get(): int = jsNative
        member __.FOOTLEFT with get(): int = jsNative
        member __.HIPRIGHT with get(): int = jsNative
        member __.KNEERIGHT with get(): int = jsNative
        member __.ANKLERIGHT with get(): int = jsNative
        member __.FOOTRIGHT with get(): int = jsNative
        member __.SPINESHOULDER with get(): int = jsNative
        member __.HANDTIPLEFT  with get(): int = jsNative
        member __.THUMBLEFT with get(): int = jsNative
        member __.HANDTIPRIGHT with get(): int = jsNative
        member __.THUMBRIGHT with get(): int = jsNative

        member __.startColor(callback: Data -> unit): unit = jsNative
        member __.startDepth(callback: Data -> unit): unit = jsNative
        member __.startRawDepth(callback: Data -> unit): unit = jsNative
        member __.startTrackedBodies(callback: Body -> unit): unit = jsNative
        member __.startTrackedJoint(id:int, callback: Joint -> unit): unit = jsNative 
        member __.startBodies(callback: Body -> unit): unit = jsNative
        member __.startInfrared(callback: Data -> unit): unit = jsNative
        member __.startLEInfrared(callback: Data -> unit): unit = jsNative
        member __.startKey(callback: Data -> unit): unit = jsNative
        member __.startRGBD(callback: Data -> unit): unit = jsNative

        member __.setColorCallback(callback: Data -> unit): unit = jsNative
        member __.setDepthCallback(callback: Data -> unit): unit = jsNative
        member __.setRawDepthCallback(callback: Data -> unit): unit = jsNative
        member __.setTrackedBodiesCallback(callback: Body -> unit): unit = jsNative
        member __.setBodiesCallback(callback: Body -> unit): unit = jsNative
        member __.setInfraredCallback(callback: Data -> unit): unit = jsNative
        member __.setLeInfraredCallback(callback: Data -> unit): unit = jsNative
        member __.setKeyCallback(callback: Data -> unit): unit = jsNative
        member __.setRGBDCallback(callback: Data -> unit): unit = jsNative

        member __.startMultiFrame( frames: string[], callback: Data -> unit): unit = jsNative
        member __.stopAll() : unit = jsNative
        member __.getJoints(callback: Joint[] -> unit): unit = jsNative
        member __.getHands(callback: Hands -> unit): unit = jsNative
