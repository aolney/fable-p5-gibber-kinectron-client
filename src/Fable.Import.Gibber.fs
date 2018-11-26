namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

//AFAIK Gibber must be a global object http://charlie-roberts.com/gibber/gibber-lib-js/
//So we handle it like Kinectron and load as script in index.html rather than using npm/webpack
module Gibber =
    type  [<AllowNullLiteral>] [<Global>] Clock() =
        static member Beats(args: ResizeArray<obj>): obj = jsNative
        static member Measures(args: ResizeArray<obj>): obj = jsNative
        
        static member Time(args: ResizeArray<obj>): obj = jsNative
        
        static member addMetronome(args: ResizeArray<obj>): obj = jsNative
        static member baseBPM with get(): int = jsNative and set(v: int): unit = jsNative

        static member beatsPerMeasure with get(): int = jsNative and set(v: int): unit = jsNative
        static member codeToExecute with get(): obj[] = jsNative and set(v: obj[]): unit = jsNative

    //Before we were global
    // type [<AllowNullLiteral>] [<Global>] IGibber =
    //     abstract init: ResizeArray<obj> -> unit 

    type [<AllowNullLiteral>] [<Global>] Gibber =
        static member init () : unit = jsNative
        //static member init (args: ResizeArray<obj>) : unit = jsNative
        
    let AD(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let ADSR(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Abs(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Add(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Additive(props: obj, args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Arp(notation: obj, beats: obj, pattern: obj, mult: obj, scale: obj): obj = jsNative
    [<Global>]
    let Beats(``val``: obj): obj = jsNative
    [<Global>]
    let Biquad(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Bus(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Chorus(rate: obj, feedback: obj, amount: obj): obj = jsNative
    [<Global>]
    let Clamp(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Clap(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Clave(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Compressor(position: obj): obj = jsNative
    [<Global>]
    let Conga(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Cowbell(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Crush(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Curve(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Delay(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Distortion(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Div(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Drums(_sequence: obj, _timeValue: obj, _amp: obj, _freq: obj, args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let EDrums( args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Ease(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Ensemble(props: obj, args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Euclid(ones: obj, length: obj, dur: obj): obj = jsNative
    [<Global>]
    let FFT(fftSize: obj, updateRate: obj): obj = jsNative
    [<Global>]
    let FM(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Filter24(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Flanger(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Follow(ugen: obj, bufferSize: obj): obj = jsNative
    [<Global>]
    let Freesound(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Freesound2(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Gain(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Grains(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Group(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let HPF(cutoff: obj, resonance: obj): obj = jsNative
    [<Global>]
    let Hat(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let HiShelf(position: obj): obj = jsNative
    [<Global>]
    let Input(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Kick(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let LPF(cutoff: obj, resonance: obj): obj = jsNative
    [<Global>]
    let Line(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Lines(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Looper(input: obj, length: obj, numberOfLoops: obj): obj = jsNative
    [<Global>]
    let LowShelf(position: obj): obj = jsNative
    [<Global>]
    let Map(prop: obj, _outputMin: obj, _outputMax: obj, _inputMin: obj, _inputMax: obj, _curve: obj, _wrap: obj): obj = jsNative
    [<Global>]
    let MasterVerb(verb: obj): obj = jsNative
    [<Global>]
    let Measures(``val``: obj): obj = jsNative
    [<Global>]
    let Merge(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Mod(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Mono(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Mul(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Noise(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let PWM(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Pattern(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Pluck(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Pow(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Reverb(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let RingMod(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Rndf(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Rndi(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Robot(_options: obj): obj = jsNative
    [<Global>]
    let Sampler(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Saw(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Scale(_root: obj, _mode: obj, args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let ScaleSeq(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Schizo(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Score(data: obj, opts: obj, args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Seq(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Sine(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Snare(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let SoundFont(soundFontName: obj, args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Sqrt(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Square(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let StereoVerb(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Sub(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Synth(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Synth2(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Tom(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Tremolo(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Triangle(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Ugen(desc: obj, args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Vibrato(args: ResizeArray<obj>): obj = jsNative
    [<Global>]
    let Vocoder(carrier: obj, modulator: obj, numBands: obj, startFreq: obj, endFreq: obj, Q: obj): obj = jsNative
    [<Global>]
    let Wavetable(table: obj): obj = jsNative
    [<Global>]
    let XOX(_sequence: obj, _timeValue: obj, _amp: obj, _freq: obj, args: ResizeArray<obj>): obj = jsNative

    //before we were global
    //let [<Import("*","gibber.audio.lib")>] Gibber: IGibber = jsNative