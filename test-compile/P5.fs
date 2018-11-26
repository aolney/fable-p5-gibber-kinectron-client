// ts2fable 0.6.1
module rec P5
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Extracts the alpha value from a color or pixel
        /// array.</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract alpha: color: U3<Color, ResizeArray<float>, string> -> float
        /// <summary>Extracts the blue value from a color or pixel
        /// array.</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract blue: color: U3<Color, ResizeArray<float>, string> -> float
        /// <summary>Extracts the HSB brightness value from a color or
        /// pixel array.</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract brightness: color: U3<Color, ResizeArray<float>, string> -> float
        /// <summary>Creates colors for storing in variables of the
        /// color datatype. The parameters are interpreted as
        /// RGB or HSB values depending on the current
        /// colorMode(). The default mode is RGB values from 0
        /// to 255 and, therefore, the function call
        /// color(255, 204, 0) will return a bright yellow
        /// color.  Note that if only one value is provided to
        /// color(), it will be interpreted as a grayscale
        /// value. Add a second value, and it will be used for
        /// alpha transparency. When three values are
        /// specified, they are interpreted as either RGB or
        /// HSB values. Adding a fourth value applies alpha
        /// transparency.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.</summary>
        /// <param name="gray">number specifying value between white
        /// and black.</param>
        /// <param name="alpha">alpha value relative to current
        /// color range (default is 0-255)</param>
        abstract color: gray: float * ?alpha: float -> Color
        /// <summary>Creates colors for storing in variables of the
        /// color datatype. The parameters are interpreted as
        /// RGB or HSB values depending on the current
        /// colorMode(). The default mode is RGB values from 0
        /// to 255 and, therefore, the function call
        /// color(255, 204, 0) will return a bright yellow
        /// color.  Note that if only one value is provided to
        /// color(), it will be interpreted as a grayscale
        /// value. Add a second value, and it will be used for
        /// alpha transparency. When three values are
        /// specified, they are interpreted as either RGB or
        /// HSB values. Adding a fourth value applies alpha
        /// transparency.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.</summary>
        /// <param name="v1">red or hue value relative to the current
        /// color range</param>
        /// <param name="v2">green or saturation value relative to
        /// the current color range</param>
        /// <param name="v3">blue or brightness value relative to the
        /// current color range</param>
        /// <param name="alpha">alpha value relative to current
        /// color range (default is 0-255)</param>
        abstract color: v1: float * v2: float * v3: float * ?alpha: float -> Color
        /// <summary>Creates colors for storing in variables of the
        /// color datatype. The parameters are interpreted as
        /// RGB or HSB values depending on the current
        /// colorMode(). The default mode is RGB values from 0
        /// to 255 and, therefore, the function call
        /// color(255, 204, 0) will return a bright yellow
        /// color.  Note that if only one value is provided to
        /// color(), it will be interpreted as a grayscale
        /// value. Add a second value, and it will be used for
        /// alpha transparency. When three values are
        /// specified, they are interpreted as either RGB or
        /// HSB values. Adding a fourth value applies alpha
        /// transparency.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.</summary>
        /// <param name="value">a color string</param>
        abstract color: value: string -> Color
        /// <summary>Creates colors for storing in variables of the
        /// color datatype. The parameters are interpreted as
        /// RGB or HSB values depending on the current
        /// colorMode(). The default mode is RGB values from 0
        /// to 255 and, therefore, the function call
        /// color(255, 204, 0) will return a bright yellow
        /// color.  Note that if only one value is provided to
        /// color(), it will be interpreted as a grayscale
        /// value. Add a second value, and it will be used for
        /// alpha transparency. When three values are
        /// specified, they are interpreted as either RGB or
        /// HSB values. Adding a fourth value applies alpha
        /// transparency.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.</summary>
        /// <param name="values">an array containing the
        /// red,green,blue & and alpha components of the color</param>
        abstract color: values: ResizeArray<float> -> Color
        /// Creates colors for storing in variables of the
        /// color datatype. The parameters are interpreted as
        /// RGB or HSB values depending on the current
        /// colorMode(). The default mode is RGB values from 0
        /// to 255 and, therefore, the function call
        /// color(255, 204, 0) will return a bright yellow
        /// color.  Note that if only one value is provided to
        /// color(), it will be interpreted as a grayscale
        /// value. Add a second value, and it will be used for
        /// alpha transparency. When three values are
        /// specified, they are interpreted as either RGB or
        /// HSB values. Adding a fourth value applies alpha
        /// transparency.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.
        abstract color: color: Color -> Color
        /// <summary>Extracts the green value from a color or pixel
        /// array.</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract green: color: U3<Color, ResizeArray<float>, string> -> float
        /// <summary>Extracts the hue value from a color or pixel
        /// array. Hue exists in both HSB and HSL. This
        /// function will return the HSB-normalized hue when
        /// supplied with an HSB color object (or when
        /// supplied with a pixel array while the color mode
        /// is HSB), but will default to the HSL-normalized
        /// hue otherwise. (The values will only be different
        /// if the maximum hue setting for each system is
        /// different.)</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract hue: color: U3<Color, ResizeArray<float>, string> -> float
        /// <summary>Blends two colors to find a third color somewhere
        /// between them. The amt parameter is the amount to
        /// interpolate between the two values where 0.0 equal
        /// to the first color, 0.1 is very near the first
        /// color, 0.5 is halfway in between, etc. An amount
        /// below 0 will be treated as 0. Likewise, amounts
        /// above 1 will be capped at 1. This is different
        /// from the behavior of lerp(), but necessary because
        /// otherwise numbers outside the range will produce
        /// strange and unexpected colors.  The way that
        /// colours are interpolated depends on the current
        /// color mode.</summary>
        /// <param name="c1">interpolate from this color</param>
        /// <param name="c2">interpolate to this color</param>
        /// <param name="amt">number between 0 and 1</param>
        abstract lerpColor: c1: Color * c2: Color * amt: float -> Color
        /// <summary>Extracts the HSL lightness value from a color or
        /// pixel array.</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract lightness: color: U3<Color, ResizeArray<float>, string> -> float
        /// <summary>Extracts the red value from a color or pixel
        /// array.</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract red: color: U3<Color, ResizeArray<float>, string> -> float
        /// <summary>Extracts the saturation value from a color or
        /// pixel array. Saturation is scaled differently in
        /// HSB and HSL. This function will return the HSB
        /// saturation when supplied with an HSB color object
        /// (or when supplied with a pixel array while the
        /// color mode is HSB), but will default to the HSL
        /// saturation otherwise.</summary>
        /// <param name="color">p5.Color object, color components, or
        /// CSS color</param>
        abstract saturation: color: U3<Color, ResizeArray<float>, string> -> float
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>The background() function sets the color used for
        /// the background of the p5.js canvas. The default
        /// background is light gray. This function is
        /// typically used within draw() to clear the display
        /// window at the beginning of each frame, but it can
        /// be used inside setup() to set the background on
        /// the first frame of animation or if the background
        /// need only be set once.  The color is either
        /// specified in terms of the RGB, HSB, or HSL color
        /// depending on the current colorMode. (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5.Color object can also be provided to set the
        /// background color.
        /// 
        /// 
        /// A p5.Image can also be provided to set the
        /// background image.</summary>
        /// <param name="color">any value created by the color()
        /// function</param>
        abstract background: color: Color -> p5
        /// <summary>The background() function sets the color used for
        /// the background of the p5.js canvas. The default
        /// background is light gray. This function is
        /// typically used within draw() to clear the display
        /// window at the beginning of each frame, but it can
        /// be used inside setup() to set the background on
        /// the first frame of animation or if the background
        /// need only be set once.  The color is either
        /// specified in terms of the RGB, HSB, or HSL color
        /// depending on the current colorMode. (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5.Color object can also be provided to set the
        /// background color.
        /// 
        /// 
        /// A p5.Image can also be provided to set the
        /// background image.</summary>
        /// <param name="colorstring">color string, possible formats
        /// include: integer rgb() or rgba(), percentage rgb()
        /// or rgba(), 3-digit hex, 6-digit hex</param>
        /// <param name="a">opacity of the background relative to
        /// current color range (default is 0-255)</param>
        abstract background: colorstring: string * ?a: float -> p5
        /// <summary>The background() function sets the color used for
        /// the background of the p5.js canvas. The default
        /// background is light gray. This function is
        /// typically used within draw() to clear the display
        /// window at the beginning of each frame, but it can
        /// be used inside setup() to set the background on
        /// the first frame of animation or if the background
        /// need only be set once.  The color is either
        /// specified in terms of the RGB, HSB, or HSL color
        /// depending on the current colorMode. (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5.Color object can also be provided to set the
        /// background color.
        /// 
        /// 
        /// A p5.Image can also be provided to set the
        /// background image.</summary>
        /// <param name="gray">specifies a value between white and
        /// black</param>
        /// <param name="a">opacity of the background relative to
        /// current color range (default is 0-255)</param>
        abstract background: gray: float * ?a: float -> p5
        /// <summary>The background() function sets the color used for
        /// the background of the p5.js canvas. The default
        /// background is light gray. This function is
        /// typically used within draw() to clear the display
        /// window at the beginning of each frame, but it can
        /// be used inside setup() to set the background on
        /// the first frame of animation or if the background
        /// need only be set once.  The color is either
        /// specified in terms of the RGB, HSB, or HSL color
        /// depending on the current colorMode. (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5.Color object can also be provided to set the
        /// background color.
        /// 
        /// 
        /// A p5.Image can also be provided to set the
        /// background image.</summary>
        /// <param name="v1">red or hue value (depending on the
        /// current color mode)</param>
        /// <param name="v2">green or saturation value (depending on
        /// the current color mode)</param>
        /// <param name="v3">blue or brightness value (depending on
        /// the current color mode)</param>
        /// <param name="a">opacity of the background relative to
        /// current color range (default is 0-255)</param>
        abstract background: v1: float * v2: float * v3: float * ?a: float -> p5
        /// <summary>The background() function sets the color used for
        /// the background of the p5.js canvas. The default
        /// background is light gray. This function is
        /// typically used within draw() to clear the display
        /// window at the beginning of each frame, but it can
        /// be used inside setup() to set the background on
        /// the first frame of animation or if the background
        /// need only be set once.  The color is either
        /// specified in terms of the RGB, HSB, or HSL color
        /// depending on the current colorMode. (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5.Color object can also be provided to set the
        /// background color.
        /// 
        /// 
        /// A p5.Image can also be provided to set the
        /// background image.</summary>
        /// <param name="values">an array containing the
        /// red,green,blue & and alpha components of the color</param>
        abstract background: values: ResizeArray<float> -> p5
        /// <summary>The background() function sets the color used for
        /// the background of the p5.js canvas. The default
        /// background is light gray. This function is
        /// typically used within draw() to clear the display
        /// window at the beginning of each frame, but it can
        /// be used inside setup() to set the background on
        /// the first frame of animation or if the background
        /// need only be set once.  The color is either
        /// specified in terms of the RGB, HSB, or HSL color
        /// depending on the current colorMode. (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.
        /// 
        /// 
        /// If a single string argument is provided, RGB, RGBA
        /// and Hex CSS color strings and all named color
        /// strings are supported. In this case, an alpha
        /// number value as a second argument is not
        /// supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5.Color object can also be provided to set the
        /// background color.
        /// 
        /// 
        /// A p5.Image can also be provided to set the
        /// background image.</summary>
        /// <param name="image">image created with loadImage() or
        /// createImage(), to set as background (must be same
        /// size as the sketch window)</param>
        /// <param name="a">opacity of the background relative to
        /// current color range (default is 0-255)</param>
        abstract background: image: Image * ?a: float -> p5
        /// Clears the pixels within a buffer. This function
        /// only works on p5.Canvas objects created with the
        /// createCanvas() function; it won't work with the
        /// main display window. Unlike the main graphics
        /// context, pixels in additional graphics areas
        /// created with createGraphics() can be entirely or
        /// partially transparent. This function clears
        /// everything to make all of the pixels 100%%c        /// transparent.
        abstract clear: unit -> p5
        /// <summary>colorMode() changes the way p5.js interprets color
        /// data. By default, the parameters for fill(),
        /// stroke(), background(), and color() are defined by
        /// values between 0 and 255 using the RGB color
        /// model. This is equivalent to setting
        /// colorMode(RGB, 255). Setting colorMode(HSB) lets
        /// you use the HSB system instead. By default, this
        /// is colorMode(HSB, 360, 100, 100, 1). You can also
        /// use HSL.  Note: existing color objects remember
        /// the mode that they were created in, so you can
        /// change modes as you like without affecting their
        /// appearance.</summary>
        /// <param name="mode">either RGB, HSB or HSL, corresponding
        /// to Red/Green/Blue and Hue/Saturation/Brightness
        /// (or Lightness)</param>
        /// <param name="max">range for all values</param>
        abstract colorMode: mode: COLOR_MODE * ?max: float -> p5
        /// <summary>colorMode() changes the way p5.js interprets color
        /// data. By default, the parameters for fill(),
        /// stroke(), background(), and color() are defined by
        /// values between 0 and 255 using the RGB color
        /// model. This is equivalent to setting
        /// colorMode(RGB, 255). Setting colorMode(HSB) lets
        /// you use the HSB system instead. By default, this
        /// is colorMode(HSB, 360, 100, 100, 1). You can also
        /// use HSL.  Note: existing color objects remember
        /// the mode that they were created in, so you can
        /// change modes as you like without affecting their
        /// appearance.</summary>
        /// <param name="mode">either RGB, HSB or HSL, corresponding
        /// to Red/Green/Blue and Hue/Saturation/Brightness
        /// (or Lightness)</param>
        /// <param name="max1">range for the red or hue depending on
        /// the current color mode</param>
        /// <param name="max2">range for the green or saturation
        /// depending on the current color mode</param>
        /// <param name="max3">range for the blue or
        /// brightness/lighntess depending on the current
        /// color mode</param>
        /// <param name="maxA">range for the alpha</param>
        abstract colorMode: mode: UNKNOWN_P5_CONSTANT * max1: float * max2: float * max3: float * ?maxA: float -> p5
        /// <summary>Sets the color used to fill shapes. For example,
        /// if you run fill(204, 102, 0), all subsequent
        /// shapes will be filled with orange. This color is
        /// either specified in terms of the RGB or HSB color
        /// depending on the current colorMode(). (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.  If a single string argument is
        /// provided, RGB, RGBA and Hex CSS color strings and
        /// all named color strings are supported. In this
        /// case, an alpha number value as a second argument
        /// is not supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// fill color.</summary>
        /// <param name="v1">red or hue value relative to the current
        /// color range</param>
        /// <param name="v2">green or saturation value relative to
        /// the current color range</param>
        /// <param name="v3">blue or brightness value relative to the
        /// current color range</param>
        abstract fill: v1: float * v2: float * v3: float * ?alpha: float -> p5
        /// <summary>Sets the color used to fill shapes. For example,
        /// if you run fill(204, 102, 0), all subsequent
        /// shapes will be filled with orange. This color is
        /// either specified in terms of the RGB or HSB color
        /// depending on the current colorMode(). (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.  If a single string argument is
        /// provided, RGB, RGBA and Hex CSS color strings and
        /// all named color strings are supported. In this
        /// case, an alpha number value as a second argument
        /// is not supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// fill color.</summary>
        /// <param name="value">a color string</param>
        abstract fill: value: string -> p5
        /// <summary>Sets the color used to fill shapes. For example,
        /// if you run fill(204, 102, 0), all subsequent
        /// shapes will be filled with orange. This color is
        /// either specified in terms of the RGB or HSB color
        /// depending on the current colorMode(). (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.  If a single string argument is
        /// provided, RGB, RGBA and Hex CSS color strings and
        /// all named color strings are supported. In this
        /// case, an alpha number value as a second argument
        /// is not supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// fill color.</summary>
        /// <param name="gray">a gray value</param>
        abstract fill: gray: float * ?alpha: float -> p5
        /// <summary>Sets the color used to fill shapes. For example,
        /// if you run fill(204, 102, 0), all subsequent
        /// shapes will be filled with orange. This color is
        /// either specified in terms of the RGB or HSB color
        /// depending on the current colorMode(). (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.  If a single string argument is
        /// provided, RGB, RGBA and Hex CSS color strings and
        /// all named color strings are supported. In this
        /// case, an alpha number value as a second argument
        /// is not supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// fill color.</summary>
        /// <param name="values">an array containing the
        /// red,green,blue & and alpha components of the color</param>
        abstract fill: values: ResizeArray<float> -> p5
        /// <summary>Sets the color used to fill shapes. For example,
        /// if you run fill(204, 102, 0), all subsequent
        /// shapes will be filled with orange. This color is
        /// either specified in terms of the RGB or HSB color
        /// depending on the current colorMode(). (The default
        /// color space is RGB, with each value in the range
        /// from 0 to 255). The alpha range by default is also
        /// 0 to 255.  If a single string argument is
        /// provided, RGB, RGBA and Hex CSS color strings and
        /// all named color strings are supported. In this
        /// case, an alpha number value as a second argument
        /// is not supported, the RGBA form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// fill color.</summary>
        /// <param name="color">the fill color</param>
        abstract fill: color: Color -> p5
        /// Disables filling geometry. If both noStroke() and
        /// noFill() are called, nothing will be drawn to the
        /// screen.
        abstract noFill: unit -> p5
        /// Disables drawing the stroke (outline). If both
        /// noStroke() and noFill() are called, nothing will
        /// be drawn to the screen.
        abstract noStroke: unit -> p5
        /// <summary>Sets the color used to draw lines and borders
        /// around shapes. This color is either specified in
        /// terms of the RGB or HSB color depending on the
        /// current colorMode() (the default color space is
        /// RGB, with each value in the range from 0 to 255).
        /// The alpha range by default is also 0 to 255.  If a
        /// single string argument is provided, RGB, RGBA and
        /// Hex CSS color strings and all named color strings
        /// are supported. In this case, an alpha number value
        /// as a second argument is not supported, the RGBA
        /// form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// stroke color.</summary>
        /// <param name="v1">red or hue value relative to the current
        /// color range</param>
        /// <param name="v2">green or saturation value relative to
        /// the current color range</param>
        /// <param name="v3">blue or brightness value relative to the
        /// current color range</param>
        abstract stroke: v1: float * v2: float * v3: float * ?alpha: float -> p5
        /// <summary>Sets the color used to draw lines and borders
        /// around shapes. This color is either specified in
        /// terms of the RGB or HSB color depending on the
        /// current colorMode() (the default color space is
        /// RGB, with each value in the range from 0 to 255).
        /// The alpha range by default is also 0 to 255.  If a
        /// single string argument is provided, RGB, RGBA and
        /// Hex CSS color strings and all named color strings
        /// are supported. In this case, an alpha number value
        /// as a second argument is not supported, the RGBA
        /// form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// stroke color.</summary>
        /// <param name="value">a color string</param>
        abstract stroke: value: string -> p5
        /// <summary>Sets the color used to draw lines and borders
        /// around shapes. This color is either specified in
        /// terms of the RGB or HSB color depending on the
        /// current colorMode() (the default color space is
        /// RGB, with each value in the range from 0 to 255).
        /// The alpha range by default is also 0 to 255.  If a
        /// single string argument is provided, RGB, RGBA and
        /// Hex CSS color strings and all named color strings
        /// are supported. In this case, an alpha number value
        /// as a second argument is not supported, the RGBA
        /// form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// stroke color.</summary>
        /// <param name="gray">a gray value</param>
        abstract stroke: gray: float * ?alpha: float -> p5
        /// <summary>Sets the color used to draw lines and borders
        /// around shapes. This color is either specified in
        /// terms of the RGB or HSB color depending on the
        /// current colorMode() (the default color space is
        /// RGB, with each value in the range from 0 to 255).
        /// The alpha range by default is also 0 to 255.  If a
        /// single string argument is provided, RGB, RGBA and
        /// Hex CSS color strings and all named color strings
        /// are supported. In this case, an alpha number value
        /// as a second argument is not supported, the RGBA
        /// form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// stroke color.</summary>
        /// <param name="values">an array containing the
        /// red,green,blue & and alpha components of the color</param>
        abstract stroke: values: ResizeArray<float> -> p5
        /// <summary>Sets the color used to draw lines and borders
        /// around shapes. This color is either specified in
        /// terms of the RGB or HSB color depending on the
        /// current colorMode() (the default color space is
        /// RGB, with each value in the range from 0 to 255).
        /// The alpha range by default is also 0 to 255.  If a
        /// single string argument is provided, RGB, RGBA and
        /// Hex CSS color strings and all named color strings
        /// are supported. In this case, an alpha number value
        /// as a second argument is not supported, the RGBA
        /// form should be used.
        /// 
        /// 
        /// A p5 Color object can also be provided to set the
        /// stroke color.</summary>
        /// <param name="color">the stroke color</param>
        abstract stroke: color: Color -> p5
module P5 = _________index

module _________index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Draw an arc to the screen. If called with only x,
        /// y, w, h, start, and stop, the arc will be drawn
        /// and filled as an open pie segment. If a mode
        /// parameter is provided, the arc will be filled like
        /// an open semi-circle (OPEN) , a closed semi-circle
        /// (CHORD), or as a closed pie segment (PIE). The
        /// origin may be changed with the ellipseMode()
        /// function. Note that drawing a full circle (ex: 0
        /// to TWO_PI) will appear blank because 0 and TWO_PI
        /// are the same position on the unit circle. The best
        /// way to handle this is by using the ellipse()
        /// function instead to create a closed ellipse, and
        /// to use the arc() function only to draw parts of an
        /// ellipse.</summary>
        /// <param name="x">x-coordinate of the arc's ellipse</param>
        /// <param name="y">y-coordinate of the arc's ellipse</param>
        /// <param name="w">width of the arc's ellipse by default</param>
        /// <param name="h">height of the arc's ellipse by default</param>
        /// <param name="start">angle to start the arc, specified in
        /// radians</param>
        /// <param name="stop">angle to stop the arc, specified in
        /// radians</param>
        /// <param name="mode">optional parameter to determine the
        /// way of drawing the arc. either CHORD, PIE or OPEN</param>
        /// <param name="detail">optional parameter for WebGL mode
        /// only. This is to specify the number of vertices
        /// that makes up the perimeter of the arc. Default
        /// value is 25.</param>
        abstract arc: x: float * y: float * w: float * h: float * start: float * stop: float * ?mode: ARC_MODE * ?detail: float -> p5
        /// <summary>Draws an ellipse (oval) to the screen. An ellipse
        /// with equal width and height is a circle. By
        /// default, the first two parameters set the
        /// location, and the third and fourth parameters set
        /// the shape's width and height. If no height is
        /// specified, the value of width is used for both the
        /// width and height. If a negative height or width is
        /// specified, the absolute value is taken. The origin
        /// may be changed with the ellipseMode() function.</summary>
        /// <param name="x">x-coordinate of the ellipse.</param>
        /// <param name="y">y-coordinate of the ellipse.</param>
        /// <param name="w">width of the ellipse.</param>
        /// <param name="h">height of the ellipse.</param>
        abstract ellipse: x: float * y: float * w: float * ?h: float -> p5
        /// <summary>Draws an ellipse (oval) to the screen. An ellipse
        /// with equal width and height is a circle. By
        /// default, the first two parameters set the
        /// location, and the third and fourth parameters set
        /// the shape's width and height. If no height is
        /// specified, the value of width is used for both the
        /// width and height. If a negative height or width is
        /// specified, the absolute value is taken. The origin
        /// may be changed with the ellipseMode() function.</summary>
        /// <param name="x">x-coordinate of the ellipse.</param>
        /// <param name="y">y-coordinate of the ellipse.</param>
        /// <param name="w">width of the ellipse.</param>
        /// <param name="h">height of the ellipse.</param>
        /// <param name="detail">number of radial sectors to draw</param>
        abstract ellipse: x: float * y: float * w: float * h: float * detail: float -> unit
        /// <summary>Draws a line (a direct path between two points) to
        /// the screen. The version of line() with four
        /// parameters draws the line in 2D. To color a line,
        /// use the stroke() function. A line cannot be
        /// filled, therefore the fill() function will not
        /// affect the color of a line. 2D lines are drawn
        /// with a width of one pixel by default, but this can
        /// be changed with the strokeWeight() function.</summary>
        /// <param name="x1">the x-coordinate of the first point</param>
        /// <param name="y1">the y-coordinate of the first point</param>
        /// <param name="x2">the x-coordinate of the second point</param>
        /// <param name="y2">the y-coordinate of the second point</param>
        abstract line: x1: float * y1: float * x2: float * y2: float -> p5
        /// <summary>Draws a line (a direct path between two points) to
        /// the screen. The version of line() with four
        /// parameters draws the line in 2D. To color a line,
        /// use the stroke() function. A line cannot be
        /// filled, therefore the fill() function will not
        /// affect the color of a line. 2D lines are drawn
        /// with a width of one pixel by default, but this can
        /// be changed with the strokeWeight() function.</summary>
        /// <param name="x1">the x-coordinate of the first point</param>
        /// <param name="y1">the y-coordinate of the first point</param>
        /// <param name="z1">the z-coordinate of the first point</param>
        /// <param name="x2">the x-coordinate of the second point</param>
        /// <param name="y2">the y-coordinate of the second point</param>
        /// <param name="z2">the z-coordinate of the second point</param>
        abstract line: x1: float * y1: float * z1: float * x2: float * y2: float * z2: float -> p5
        /// <summary>Draws a point, a coordinate in space at the
        /// dimension of one pixel. The first parameter is the
        /// horizontal value for the point, the second value
        /// is the vertical value for the point. The color of
        /// the point is determined by the current stroke.</summary>
        /// <param name="x">the x-coordinate</param>
        /// <param name="y">the y-coordinate</param>
        /// <param name="z">the z-coordinate (for WEBGL mode)</param>
        abstract point: x: float * y: float * ?z: float -> p5
        /// <summary>Draw a quad. A quad is a quadrilateral, a four
        /// sided polygon. It is similar to a rectangle, but
        /// the angles between its edges are not constrained
        /// to ninety degrees. The first pair of parameters
        /// (x1,y1) sets the first vertex and the subsequent
        /// pairs should proceed clockwise or
        /// counter-clockwise around the defined shape.</summary>
        /// <param name="x1">the x-coordinate of the first point</param>
        /// <param name="y1">the y-coordinate of the first point</param>
        /// <param name="x2">the x-coordinate of the second point</param>
        /// <param name="y2">the y-coordinate of the second point</param>
        /// <param name="x3">the x-coordinate of the third point</param>
        /// <param name="y3">the y-coordinate of the third point</param>
        /// <param name="x4">the x-coordinate of the fourth point</param>
        /// <param name="y4">the y-coordinate of the fourth point</param>
        abstract quad: x1: float * y1: float * x2: float * y2: float * x3: float * y3: float * x4: float * y4: float -> p5
        /// <summary>Draw a quad. A quad is a quadrilateral, a four
        /// sided polygon. It is similar to a rectangle, but
        /// the angles between its edges are not constrained
        /// to ninety degrees. The first pair of parameters
        /// (x1,y1) sets the first vertex and the subsequent
        /// pairs should proceed clockwise or
        /// counter-clockwise around the defined shape.</summary>
        /// <param name="x1">the x-coordinate of the first point</param>
        /// <param name="y1">the y-coordinate of the first point</param>
        /// <param name="z1">the z-coordinate of the first point</param>
        /// <param name="x2">the x-coordinate of the second point</param>
        /// <param name="y2">the y-coordinate of the second point</param>
        /// <param name="z2">the z-coordinate of the second point</param>
        /// <param name="x3">the x-coordinate of the third point</param>
        /// <param name="y3">the y-coordinate of the third point</param>
        /// <param name="z3">the z-coordinate of the third point</param>
        /// <param name="x4">the x-coordinate of the fourth point</param>
        /// <param name="y4">the y-coordinate of the fourth point</param>
        /// <param name="z4">the z-coordinate of the fourth point</param>
        abstract quad: x1: float * y1: float * z1: float * x2: float * y2: float * z2: float * x3: float * y3: float * z3: float * x4: float * y4: float * z4: float -> p5
        /// <summary>Draws a rectangle to the screen. A rectangle is a
        /// four-sided shape with every angle at ninety
        /// degrees. By default, the first two parameters set
        /// the location of the upper-left corner, the third
        /// sets the width, and the fourth sets the height.
        /// The way these parameters are interpreted, however,
        /// may be changed with the rectMode() function.  The
        /// fifth, sixth, seventh and eighth parameters, if
        /// specified, determine corner radius for the
        /// top-left, top-right, lower-right and lower-left
        /// corners, respectively. An omitted corner radius
        /// parameter is set to the value of the previously
        /// specified radius value in the parameter list.</summary>
        /// <param name="x">x-coordinate of the rectangle.</param>
        /// <param name="y">y-coordinate of the rectangle.</param>
        /// <param name="w">width of the rectangle.</param>
        /// <param name="h">height of the rectangle.</param>
        /// <param name="tl">optional radius of top-left corner.</param>
        /// <param name="tr">optional radius of top-right corner.</param>
        /// <param name="br">optional radius of bottom-right
        /// corner.</param>
        /// <param name="bl">optional radius of bottom-left corner.</param>
        abstract rect: x: float * y: float * w: float * h: float * ?tl: float * ?tr: float * ?br: float * ?bl: float -> p5
        /// <summary>Draws a rectangle to the screen. A rectangle is a
        /// four-sided shape with every angle at ninety
        /// degrees. By default, the first two parameters set
        /// the location of the upper-left corner, the third
        /// sets the width, and the fourth sets the height.
        /// The way these parameters are interpreted, however,
        /// may be changed with the rectMode() function.  The
        /// fifth, sixth, seventh and eighth parameters, if
        /// specified, determine corner radius for the
        /// top-left, top-right, lower-right and lower-left
        /// corners, respectively. An omitted corner radius
        /// parameter is set to the value of the previously
        /// specified radius value in the parameter list.</summary>
        /// <param name="x">x-coordinate of the rectangle.</param>
        /// <param name="y">y-coordinate of the rectangle.</param>
        /// <param name="w">width of the rectangle.</param>
        /// <param name="h">height of the rectangle.</param>
        /// <param name="detailX">number of segments in the
        /// x-direction</param>
        /// <param name="detailY">number of segments in the
        /// y-direction</param>
        abstract rect: x: float * y: float * w: float * h: float * ?detailX: float * ?detailY: float -> p5
        /// <summary>A triangle is a plane created by connecting three
        /// points. The first two arguments specify the first
        /// point, the middle two arguments specify the second
        /// point, and the last two arguments specify the
        /// third point.</summary>
        /// <param name="x1">x-coordinate of the first point</param>
        /// <param name="y1">y-coordinate of the first point</param>
        /// <param name="x2">x-coordinate of the second point</param>
        /// <param name="y2">y-coordinate of the second point</param>
        /// <param name="x3">x-coordinate of the third point</param>
        /// <param name="y3">y-coordinate of the third point</param>
        abstract triangle: x1: float * y1: float * x2: float * y2: float * x3: float * y3: float -> p5
module P5 = _________index

module _________index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Modifies the location from which ellipses are
        /// drawn by changing the way in which parameters
        /// given to ellipse() are interpreted.  The default
        /// mode is ellipseMode(CENTER), which interprets the
        /// first two parameters of ellipse() as the shape's
        /// center point, while the third and fourth
        /// parameters are its width and height.
        /// 
        /// 
        /// ellipseMode(RADIUS) also uses the first two
        /// parameters of ellipse() as the shape's center
        /// point, but uses the third and fourth parameters to
        /// specify half of the shapes's width and height.
        /// 
        /// 
        /// ellipseMode(CORNER) interprets the first two
        /// parameters of ellipse() as the upper-left corner
        /// of the shape, while the third and fourth
        /// parameters are its width and height.
        /// 
        /// 
        /// ellipseMode(CORNERS) interprets the first two
        /// parameters of ellipse() as the location of one
        /// corner of the ellipse's bounding box, and the
        /// third and fourth parameters as the location of the
        /// opposite corner.
        /// 
        /// 
        /// The parameter must be written in ALL CAPS because
        /// Javascript is a case-sensitive language.</summary>
        /// <param name="mode">either CENTER, RADIUS, CORNER, or
        /// CORNERS</param>
        abstract ellipseMode: mode: ELLIPSE_MODE -> p5
        /// Draws all geometry with jagged (aliased) edges.
        /// Note that smooth() is active by default in 2D
        /// mode, so it is necessary to call noSmooth() to
        /// disable smoothing of geometry, images, and fonts.
        /// In 3D mode, noSmooth() is enabled by default, so
        /// it is necessary to call smooth() if you would like
        /// smooth (antialiased) edges on your geometry.
        abstract noSmooth: unit -> p5
        /// <summary>Modifies the location from which rectangles are
        /// drawn by changing the way in which parameters
        /// given to rect() are interpreted.  The default mode
        /// is rectMode(CORNER), which interprets the first
        /// two parameters of rect() as the upper-left corner
        /// of the shape, while the third and fourth
        /// parameters are its width and height.
        /// 
        /// 
        /// rectMode(CORNERS) interprets the first two
        /// parameters of rect() as the location of one
        /// corner, and the third and fourth parameters as the
        /// location of the opposite corner.
        /// 
        /// 
        /// rectMode(CENTER) interprets the first two
        /// parameters of rect() as the shape's center point,
        /// while the third and fourth parameters are its
        /// width and height.
        /// 
        /// 
        /// rectMode(RADIUS) also uses the first two
        /// parameters of rect() as the shape's center point,
        /// but uses the third and fourth parameters to
        /// specify half of the shapes's width and height.
        /// 
        /// 
        /// The parameter must be written in ALL CAPS because
        /// Javascript is a case-sensitive language.</summary>
        /// <param name="mode">either CORNER, CORNERS, CENTER, or
        /// RADIUS</param>
        abstract rectMode: mode: RECT_MODE -> p5
        /// Draws all geometry with smooth (anti-aliased)
        /// edges. smooth() will also improve image quality of
        /// resized images. Note that smooth() is active by
        /// default in 2D mode; noSmooth() can be used to
        /// disable smoothing of geometry, images, and fonts.
        /// In 3D mode, noSmooth() is enabled by default, so
        /// it is necessary to call smooth() if you would like
        /// smooth (antialiased) edges on your geometry.
        abstract smooth: unit -> p5
        /// <summary>Sets the style for rendering line endings. These
        /// ends are either squared, extended, or rounded,
        /// each of which specified with the corresponding
        /// parameters: SQUARE, PROJECT, and ROUND. The
        /// default cap is ROUND.</summary>
        /// <param name="cap">either SQUARE, PROJECT, or ROUND</param>
        abstract strokeCap: cap: STROKE_CAP -> p5
        /// <summary>Sets the style of the joints which connect line
        /// segments. These joints are either mitered,
        /// beveled, or rounded and specified with the
        /// corresponding parameters MITER, BEVEL, and ROUND.
        /// The default joint is MITER.</summary>
        /// <param name="join">either MITER, BEVEL, ROUND</param>
        abstract strokeJoin: join: STROKE_JOIN -> p5
        /// <summary>Sets the width of the stroke used for lines,
        /// points, and the border around shapes. All widths
        /// are set in units of pixels.</summary>
        /// <param name="weight">the weight (in pixels) of the stroke</param>
        abstract strokeWeight: weight: float -> p5
module P5 = _________index

module _________index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Draws a cubic Bezier curve on the screen. These
        /// curves are defined by a series of anchor and
        /// control points. The first two parameters specify
        /// the first anchor point and the last two parameters
        /// specify the other anchor point, which become the
        /// first and last points on the curve. The middle
        /// parameters specify the two control points which
        /// define the shape of the curve. Approximately
        /// speaking, control points "pull" the curve towards
        /// them.Bezier curves were developed by French
        /// automotive engineer Pierre Bezier, and are
        /// commonly used in computer graphics to define
        /// gently sloping curves. See also curve().</summary>
        /// <param name="x1">x-coordinate for the first anchor point</param>
        /// <param name="y1">y-coordinate for the first anchor point</param>
        /// <param name="x2">x-coordinate for the first control point</param>
        /// <param name="y2">y-coordinate for the first control point</param>
        /// <param name="x3">x-coordinate for the second control
        /// point</param>
        /// <param name="y3">y-coordinate for the second control
        /// point</param>
        /// <param name="x4">x-coordinate for the second anchor point</param>
        /// <param name="y4">y-coordinate for the second anchor point</param>
        abstract bezier: x1: float * y1: float * x2: float * y2: float * x3: float * y3: float * x4: float * y4: float -> p5
        /// <summary>Draws a cubic Bezier curve on the screen. These
        /// curves are defined by a series of anchor and
        /// control points. The first two parameters specify
        /// the first anchor point and the last two parameters
        /// specify the other anchor point, which become the
        /// first and last points on the curve. The middle
        /// parameters specify the two control points which
        /// define the shape of the curve. Approximately
        /// speaking, control points "pull" the curve towards
        /// them.Bezier curves were developed by French
        /// automotive engineer Pierre Bezier, and are
        /// commonly used in computer graphics to define
        /// gently sloping curves. See also curve().</summary>
        /// <param name="x1">x-coordinate for the first anchor point</param>
        /// <param name="y1">y-coordinate for the first anchor point</param>
        /// <param name="z1">z-coordinate for the first anchor point</param>
        /// <param name="x2">x-coordinate for the first control point</param>
        /// <param name="y2">y-coordinate for the first control point</param>
        /// <param name="z2">z-coordinate for the first control point</param>
        /// <param name="x3">x-coordinate for the second control
        /// point</param>
        /// <param name="y3">y-coordinate for the second control
        /// point</param>
        /// <param name="z3">z-coordinate for the second control
        /// point</param>
        /// <param name="x4">x-coordinate for the second anchor point</param>
        /// <param name="y4">y-coordinate for the second anchor point</param>
        /// <param name="z4">z-coordinate for the second anchor point</param>
        abstract bezier: x1: float * y1: float * z1: float * x2: float * y2: float * z2: float * x3: float * y3: float * z3: float * x4: float * y4: float * z4: float -> p5
        /// <summary>Sets the resolution at which Beziers display. The
        /// default value is 20.
        /// 
        /// This function is only useful when using the WEBGL
        /// renderer as the default canvas renderer does not
        /// use this information.</summary>
        /// <param name="detail">resolution of the curves</param>
        abstract bezierDetail: detail: float -> p5
        /// <summary>Evaluates the Bezier at position t for points a,
        /// b, c, d. The parameters a and d are the first and
        /// last points on the curve, and b and c are the
        /// control points. The final parameter t varies
        /// between 0 and 1. This can be done once with the x
        /// coordinates and a second time with the y
        /// coordinates to get the location of a bezier curve
        /// at t.</summary>
        /// <param name="a">coordinate of first point on the curve</param>
        /// <param name="b">coordinate of first control point</param>
        /// <param name="c">coordinate of second control point</param>
        /// <param name="d">coordinate of second point on the curve</param>
        /// <param name="t">value between 0 and 1</param>
        abstract bezierPoint: a: float * b: float * c: float * d: float * t: float -> float
        /// <summary>Evaluates the tangent to the Bezier at position t
        /// for points a, b, c, d. The parameters a and d are
        /// the first and last points on the curve, and b and
        /// c are the control points. The final parameter t
        /// varies between 0 and 1.</summary>
        /// <param name="a">coordinate of first point on the curve</param>
        /// <param name="b">coordinate of first control point</param>
        /// <param name="c">coordinate of second control point</param>
        /// <param name="d">coordinate of second point on the curve</param>
        /// <param name="t">value between 0 and 1</param>
        abstract bezierTangent: a: float * b: float * c: float * d: float * t: float -> float
        /// <summary>Draws a curved line on the screen between two
        /// points, given as the middle four parameters. The
        /// first two parameters are a control point, as if
        /// the curve came from this point even though it's
        /// not drawn. The last two parameters similarly
        /// describe the other control point.  Longer curves
        /// can be created by putting a series of curve()
        /// functions together or using curveVertex(). An
        /// additional function called curveTightness()
        /// provides control for the visual quality of the
        /// curve. The curve() function is an implementation
        /// of Catmull-Rom splines.</summary>
        /// <param name="x1">x-coordinate for the beginning control
        /// point</param>
        /// <param name="y1">y-coordinate for the beginning control
        /// point</param>
        /// <param name="x2">x-coordinate for the first point</param>
        /// <param name="y2">y-coordinate for the first point</param>
        /// <param name="x3">x-coordinate for the second point</param>
        /// <param name="y3">y-coordinate for the second point</param>
        /// <param name="x4">x-coordinate for the ending control
        /// point</param>
        /// <param name="y4">y-coordinate for the ending control
        /// point</param>
        abstract curve: x1: float * y1: float * x2: float * y2: float * x3: float * y3: float * x4: float * y4: float -> p5
        /// <summary>Draws a curved line on the screen between two
        /// points, given as the middle four parameters. The
        /// first two parameters are a control point, as if
        /// the curve came from this point even though it's
        /// not drawn. The last two parameters similarly
        /// describe the other control point.  Longer curves
        /// can be created by putting a series of curve()
        /// functions together or using curveVertex(). An
        /// additional function called curveTightness()
        /// provides control for the visual quality of the
        /// curve. The curve() function is an implementation
        /// of Catmull-Rom splines.</summary>
        /// <param name="x1">x-coordinate for the beginning control
        /// point</param>
        /// <param name="y1">y-coordinate for the beginning control
        /// point</param>
        /// <param name="z1">z-coordinate for the beginning control
        /// point</param>
        /// <param name="x2">x-coordinate for the first point</param>
        /// <param name="y2">y-coordinate for the first point</param>
        /// <param name="z2">z-coordinate for the first point</param>
        /// <param name="x3">x-coordinate for the second point</param>
        /// <param name="y3">y-coordinate for the second point</param>
        /// <param name="z3">z-coordinate for the second point</param>
        /// <param name="x4">x-coordinate for the ending control
        /// point</param>
        /// <param name="y4">y-coordinate for the ending control
        /// point</param>
        /// <param name="z4">z-coordinate for the ending control
        /// point</param>
        abstract curve: x1: float * y1: float * z1: float * x2: float * y2: float * z2: float * x3: float * y3: float * z3: float * x4: float * y4: float * z4: float -> p5
        /// <summary>Sets the resolution at which curves display. The
        /// default value is 20 while the minimum value is 3.
        /// 
        /// This function is only useful when using the WEBGL
        /// renderer as the default canvas renderer does not
        /// use this information.</summary>
        /// <param name="resolution">resolution of the curves</param>
        abstract curveDetail: resolution: float -> p5
        /// <summary>Modifies the quality of forms created with curve()
        /// and curveVertex(). The parameter tightness
        /// determines how the curve fits to the vertex
        /// points. The value 0.0 is the default value for
        /// tightness (this value defines the curves to be
        /// Catmull-Rom splines) and the value 1.0 connects
        /// all the points with straight lines. Values within
        /// the range -5.0 and 5.0 will deform the curves but
        /// will leave them recognizable and as values
        /// increase in magnitude, they will continue to
        /// deform.</summary>
        /// <param name="amount">amount of deformation from the
        /// original vertices</param>
        abstract curveTightness: amount: float -> p5
        /// <summary>Evaluates the curve at position t for points a, b,
        /// c, d. The parameter t varies between 0 and 1, a
        /// and d are control points of the curve, and b and c
        /// are the start and end points of the curve. This
        /// can be done once with the x coordinates and a
        /// second time with the y coordinates to get the
        /// location of a curve at t.</summary>
        /// <param name="a">coordinate of first control point of the
        /// curve</param>
        /// <param name="b">coordinate of first point</param>
        /// <param name="c">coordinate of second point</param>
        /// <param name="d">coordinate of second control point</param>
        /// <param name="t">value between 0 and 1</param>
        abstract curvePoint: a: float * b: float * c: float * d: float * t: float -> float
        /// <summary>Evaluates the tangent to the curve at position t
        /// for points a, b, c, d. The parameter t varies
        /// between 0 and 1, a and d are points on the curve,
        /// and b and c are the control points.</summary>
        /// <param name="a">coordinate of first point on the curve</param>
        /// <param name="b">coordinate of first control point</param>
        /// <param name="c">coordinate of second control point</param>
        /// <param name="d">coordinate of second point on the curve</param>
        /// <param name="t">value between 0 and 1</param>
        abstract curveTangent: a: float * b: float * c: float * d: float * t: float -> float
module P5 = _________index

module _________index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// Use the beginContour() and endContour() functions
        /// to create negative shapes within shapes such as
        /// the center of the letter 'O'. beginContour()
        /// begins recording vertices for the shape and
        /// endContour() stops recording. The vertices that
        /// define a negative shape must "wind" in the
        /// opposite direction from the exterior shape. First
        /// draw vertices for the exterior clockwise order,
        /// then for internal shapes, draw vertices shape in
        /// counter-clockwise.  These functions can only be
        /// used within a beginShape()/endShape() pair and
        /// transformations such as translate(), rotate(), and
        /// scale() do not work within a
        /// beginContour()/endContour() pair. It is also not
        /// possible to use other shapes, such as ellipse() or
        /// rect() within.
        abstract beginContour: unit -> p5
        /// <summary>Using the beginShape() and endShape() functions
        /// allow creating more complex forms. beginShape()
        /// begins recording vertices for a shape and
        /// endShape() stops recording. The value of the kind
        /// parameter tells it which types of shapes to create
        /// from the provided vertices. With no mode
        /// specified, the shape can be any irregular polygon.
        /// The parameters available for beginShape() are
        /// POINTS, LINES, TRIANGLES, TRIANGLE_FAN,
        /// TRIANGLE_STRIP, QUADS, and QUAD_STRIP. After
        /// calling the beginShape() function, a series of
        /// vertex() commands must follow. To stop drawing the
        /// shape, call endShape(). Each shape will be
        /// outlined with the current stroke color and filled
        /// with the fill color.
        /// 
        /// 
        /// Transformations such as translate(), rotate(), and
        /// scale() do not work within beginShape(). It is
        /// also not possible to use other shapes, such as
        /// ellipse() or rect() within beginShape().</summary>
        /// <param name="kind">either POINTS, LINES, TRIANGLES,
        /// TRIANGLE_FAN TRIANGLE_STRIP, QUADS, or QUAD_STRIP</param>
        abstract beginShape: ?kind: BEGIN_KIND -> p5
        /// <summary>Specifies vertex coordinates for Bezier curves.
        /// Each call to bezierVertex() defines the position
        /// of two control points and one anchor point of a
        /// Bezier curve, adding a new segment to a line or
        /// shape. For WebGL mode bezierVertex() can be used
        /// in 2D as well as 3D mode. 2D mode expects 6
        /// parameters, while 3D mode expects 9 parameters
        /// (including z coordinates).  The first time
        /// bezierVertex() is used within a beginShape() call,
        /// it must be prefaced with a call to vertex() to set
        /// the first anchor point. This function must be used
        /// between beginShape() and endShape() and only when
        /// there is no MODE or POINTS parameter specified to
        /// beginShape().</summary>
        /// <param name="x2">x-coordinate for the first control point</param>
        /// <param name="y2">y-coordinate for the first control point</param>
        /// <param name="x3">x-coordinate for the second control
        /// point</param>
        /// <param name="y3">y-coordinate for the second control
        /// point</param>
        /// <param name="x4">x-coordinate for the anchor point</param>
        /// <param name="y4">y-coordinate for the anchor point</param>
        abstract bezierVertex: x2: float * y2: float * x3: float * y3: float * x4: float * y4: float -> p5
        /// <summary>Specifies vertex coordinates for Bezier curves.
        /// Each call to bezierVertex() defines the position
        /// of two control points and one anchor point of a
        /// Bezier curve, adding a new segment to a line or
        /// shape. For WebGL mode bezierVertex() can be used
        /// in 2D as well as 3D mode. 2D mode expects 6
        /// parameters, while 3D mode expects 9 parameters
        /// (including z coordinates).  The first time
        /// bezierVertex() is used within a beginShape() call,
        /// it must be prefaced with a call to vertex() to set
        /// the first anchor point. This function must be used
        /// between beginShape() and endShape() and only when
        /// there is no MODE or POINTS parameter specified to
        /// beginShape().</summary>
        /// <param name="x2">x-coordinate for the first control point</param>
        /// <param name="y2">y-coordinate for the first control point</param>
        /// <param name="z2">z-coordinate for the first control point
        /// (for WebGL mode)</param>
        /// <param name="x3">x-coordinate for the second control
        /// point</param>
        /// <param name="y3">y-coordinate for the second control
        /// point</param>
        /// <param name="z3">z-coordinate for the second control
        /// point (for WebGL mode)</param>
        /// <param name="x4">x-coordinate for the anchor point</param>
        /// <param name="y4">y-coordinate for the anchor point</param>
        /// <param name="z4">z-coordinate for the anchor point (for
        /// WebGL mode)</param>
        abstract bezierVertex: x2: float * y2: float * z2: float * x3: float * y3: float * z3: float * x4: float * y4: float * z4: float -> p5
        /// <summary>Specifies vertex coordinates for curves. This
        /// function may only be used between beginShape() and
        /// endShape() and only when there is no MODE
        /// parameter specified to beginShape(). For WebGL
        /// mode curveVertex() can be used in 2D as well as 3D
        /// mode. 2D mode expects 2 parameters, while 3D mode
        /// expects 3 parameters.  The first and last points
        /// in a series of curveVertex() lines will be used to
        /// guide the beginning and end of a the curve. A
        /// minimum of four points is required to draw a tiny
        /// curve between the second and third points. Adding
        /// a fifth point with curveVertex() will draw the
        /// curve between the second, third, and fourth
        /// points. The curveVertex() function is an
        /// implementation of Catmull-Rom splines.</summary>
        /// <param name="x">x-coordinate of the vertex</param>
        /// <param name="y">y-coordinate of the vertex</param>
        abstract curveVertex: x: float * y: float -> p5
        /// <summary>Specifies vertex coordinates for curves. This
        /// function may only be used between beginShape() and
        /// endShape() and only when there is no MODE
        /// parameter specified to beginShape(). For WebGL
        /// mode curveVertex() can be used in 2D as well as 3D
        /// mode. 2D mode expects 2 parameters, while 3D mode
        /// expects 3 parameters.  The first and last points
        /// in a series of curveVertex() lines will be used to
        /// guide the beginning and end of a the curve. A
        /// minimum of four points is required to draw a tiny
        /// curve between the second and third points. Adding
        /// a fifth point with curveVertex() will draw the
        /// curve between the second, third, and fourth
        /// points. The curveVertex() function is an
        /// implementation of Catmull-Rom splines.</summary>
        /// <param name="x">x-coordinate of the vertex</param>
        /// <param name="y">y-coordinate of the vertex</param>
        /// <param name="z">z-coordinate of the vertex (for WebGL
        /// mode)</param>
        abstract curveVertex: x: float * y: float * ?z: float -> p5
        /// Use the beginContour() and endContour() functions
        /// to create negative shapes within shapes such as
        /// the center of the letter 'O'. beginContour()
        /// begins recording vertices for the shape and
        /// endContour() stops recording. The vertices that
        /// define a negative shape must "wind" in the
        /// opposite direction from the exterior shape. First
        /// draw vertices for the exterior clockwise order,
        /// then for internal shapes, draw vertices shape in
        /// counter-clockwise.  These functions can only be
        /// used within a beginShape()/endShape() pair and
        /// transformations such as translate(), rotate(), and
        /// scale() do not work within a
        /// beginContour()/endContour() pair. It is also not
        /// possible to use other shapes, such as ellipse() or
        /// rect() within.
        abstract endContour: unit -> p5
        /// <summary>The endShape() function is the companion to
        /// beginShape() and may only be called after
        /// beginShape(). When endshape() is called, all of
        /// image data defined since the previous call to
        /// beginShape() is written into the image buffer. The
        /// constant CLOSE as the value for the MODE parameter
        /// to close the shape (to connect the beginning and
        /// the end).</summary>
        /// <param name="mode">use CLOSE to close the shape</param>
        abstract endShape: ?mode: END_MODE -> p5
        /// <summary>Specifies vertex coordinates for quadratic Bezier
        /// curves. Each call to quadraticVertex() defines the
        /// position of one control points and one anchor
        /// point of a Bezier curve, adding a new segment to a
        /// line or shape. The first time quadraticVertex() is
        /// used within a beginShape() call, it must be
        /// prefaced with a call to vertex() to set the first
        /// anchor point. For WebGL mode quadraticVertex() can
        /// be used in 2D as well as 3D mode. 2D mode expects
        /// 4 parameters, while 3D mode expects 6 parameters
        /// (including z coordinates).  This function must be
        /// used between beginShape() and endShape() and only
        /// when there is no MODE or POINTS parameter
        /// specified to beginShape().</summary>
        /// <param name="cx">x-coordinate for the control point</param>
        /// <param name="cy">y-coordinate for the control point</param>
        /// <param name="x3">x-coordinate for the anchor point</param>
        /// <param name="y3">y-coordinate for the anchor point</param>
        abstract quadraticVertex: cx: float * cy: float * x3: float * y3: float -> p5
        /// <summary>Specifies vertex coordinates for quadratic Bezier
        /// curves. Each call to quadraticVertex() defines the
        /// position of one control points and one anchor
        /// point of a Bezier curve, adding a new segment to a
        /// line or shape. The first time quadraticVertex() is
        /// used within a beginShape() call, it must be
        /// prefaced with a call to vertex() to set the first
        /// anchor point. For WebGL mode quadraticVertex() can
        /// be used in 2D as well as 3D mode. 2D mode expects
        /// 4 parameters, while 3D mode expects 6 parameters
        /// (including z coordinates).  This function must be
        /// used between beginShape() and endShape() and only
        /// when there is no MODE or POINTS parameter
        /// specified to beginShape().</summary>
        /// <param name="cx">x-coordinate for the control point</param>
        /// <param name="cy">y-coordinate for the control point</param>
        /// <param name="cz">z-coordinate for the control point (for
        /// WebGL mode)</param>
        /// <param name="x3">x-coordinate for the anchor point</param>
        /// <param name="y3">y-coordinate for the anchor point</param>
        /// <param name="z3">z-coordinate for the anchor point (for
        /// WebGL mode)</param>
        abstract quadraticVertex: cx: float * cy: float * cz: float * x3: float * y3: float * z3: float -> p5
        /// <summary>All shapes are constructed by connecting a series
        /// of vertices. vertex() is used to specify the
        /// vertex coordinates for points, lines, triangles,
        /// quads, and polygons. It is used exclusively within
        /// the beginShape() and endShape() functions.</summary>
        /// <param name="x">x-coordinate of the vertex</param>
        /// <param name="y">y-coordinate of the vertex</param>
        abstract vertex: x: float * y: float -> p5
        /// <summary>All shapes are constructed by connecting a series
        /// of vertices. vertex() is used to specify the
        /// vertex coordinates for points, lines, triangles,
        /// quads, and polygons. It is used exclusively within
        /// the beginShape() and endShape() functions.</summary>
        /// <param name="x">x-coordinate of the vertex</param>
        /// <param name="y">y-coordinate of the vertex</param>
        /// <param name="z">z-coordinate of the vertex</param>
        /// <param name="u">the vertex's texture u-coordinate</param>
        /// <param name="v">the vertex's texture v-coordinate</param>
        abstract vertex: x: float * y: float * z: float * ?u: float * ?v: float -> p5
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        abstract P2D: P2D
        abstract WEBGL: WEBGL
        abstract ARROW: ARROW
        abstract CROSS: CROSS
        abstract HAND: HAND
        abstract MOVE: MOVE
        abstract TEXT: TEXT
        abstract WAIT: WAIT
        /// HALF_PI is a mathematical constant with the value
        /// 1.57079632679489661923. It is half the ratio of
        /// the circumference of a circle to its diameter. It
        /// is useful in combination with the trigonometric
        /// functions sin() and cos().
        abstract HALF_PI: float
        /// PI is a mathematical constant with the value
        /// 3.14159265358979323846. It is the ratio of the
        /// circumference of a circle to its diameter. It is
        /// useful in combination with the trigonometric
        /// functions sin() and cos().
        abstract PI: float
        /// QUARTER_PI is a mathematical constant with the
        /// value 0.7853982. It is one quarter the ratio of
        /// the circumference of a circle to its diameter. It
        /// is useful in combination with the trigonometric
        /// functions sin() and cos().
        abstract QUARTER_PI: float
        /// TAU is an alias for TWO_PI, a mathematical
        /// constant with the value 6.28318530717958647693. It
        /// is twice the ratio of the circumference of a
        /// circle to its diameter. It is useful in
        /// combination with the trigonometric functions sin()
        /// and cos().
        abstract TAU: float
        /// TWO_PI is a mathematical constant with the value
        /// 6.28318530717958647693. It is twice the ratio of
        /// the circumference of a circle to its diameter. It
        /// is useful in combination with the trigonometric
        /// functions sin() and cos().
        abstract TWO_PI: float
        /// Constant to be used with angleMode() function, to
        /// set the mode which p5.js interprates and
        /// calculates angles (either DEGREES or RADIANS).
        abstract DEGREES: DEGREES
        /// Constant to be used with angleMode() function, to
        /// set the mode which p5.js interprates and
        /// calculates angles (either RADIANS or DEGREES).
        abstract RADIANS: RADIANS
        abstract CORNER: CORNER
        abstract CORNERS: CORNERS
        abstract RADIUS: RADIUS
        abstract RIGHT: RIGHT
        abstract LEFT: LEFT
        abstract CENTER: CENTER
        abstract TOP: TOP
        abstract BOTTOM: BOTTOM
        abstract BASELINE: BASELINE
        abstract POINTS: POINTS
        abstract LINES: LINES
        abstract LINE_STRIP: LINE_STRIP
        abstract LINE_LOOP: LINE_LOOP
        abstract TRIANGLES: TRIANGLES
        abstract TRIANGLE_FAN: TRIANGLE_FAN
        abstract TRIANGLE_STRIP: TRIANGLE_STRIP
        abstract QUADS: QUADS
        abstract QUAD_STRIP: QUAD_STRIP
        abstract CLOSE: CLOSE
        abstract OPEN: OPEN
        abstract CHORD: CHORD
        abstract PIE: PIE
        abstract PROJECT: PROJECT
        abstract SQUARE: SQUARE
        abstract ROUND: ROUND
        abstract BEVEL: BEVEL
        abstract MITER: MITER
        abstract RGB: RGB
        abstract HSB: HSB
        abstract HSL: HSL
        abstract AUTO: AUTO
        abstract BLEND: BLEND
        abstract ADD: ADD
        abstract DARKEST: DARKEST
        abstract LIGHTEST: LIGHTEST
        abstract DIFFERENCE: DIFFERENCE
        abstract EXCLUSION: EXCLUSION
        abstract MULTIPLY: MULTIPLY
        abstract SCREEN: SCREEN
        abstract REPLACE: REPLACE
        abstract OVERLAY: OVERLAY
        abstract HARD_LIGHT: HARD_LIGHT
        abstract SOFT_LIGHT: SOFT_LIGHT
        abstract DODGE: DODGE
        abstract BURN: BURN
        abstract THRESHOLD: THRESHOLD
        abstract GRAY: GRAY
        abstract OPAQUE: OPAQUE
        abstract INVERT: INVERT
        abstract POSTERIZE: POSTERIZE
        abstract DILATE: DILATE
        abstract ERODE: ERODE
        abstract BLUR: BLUR
        abstract NORMAL: NORMAL
        abstract ITALIC: ITALIC
        abstract BOLD: BOLD
        abstract LANDSCAPE: LANDSCAPE
        abstract PORTRAIT: PORTRAIT
        abstract GRID: GRID
        abstract AXES: AXES
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>The print() function writes to the console area of
        /// your browser. This function is often helpful for
        /// looking at the data a program is producing. This
        /// function creates a new line of text for each call
        /// to the function. Individual elements can be
        /// separated with quotes ("") and joined with the
        /// addition operator (+). Note that calling print()
        /// without any arguments invokes the window.print()
        /// function which opens the browser's print dialog.
        /// To print a blank line to console you can write
        /// print('\n').</summary>
        /// <param name="contents">any combination of Number, String,
        /// Object, Boolean, Array to print</param>
        abstract print: contents: obj option -> unit
        /// <summary>Sets the cursor to a predefined symbol or an
        /// image, or makes it visible if already hidden. If
        /// you are trying to set an image as the cursor, the
        /// recommended size is 16x16 or 32x32 pixels. The
        /// values for parameters x and y must be less than
        /// the dimensions of the image.</summary>
        /// <param name="type">either ARROW, CROSS, HAND, MOVE, TEXT,
        /// or WAIT, or path for image</param>
        /// <param name="x">the horizontal active spot of the
        /// cursor</param>
        /// <param name="y">the vertical active spot of the cursor</param>
        abstract cursor: ``type``: U2<string, CURSOR_TYPE> * ?x: float * ?y: float -> unit
        /// <summary>Specifies the number of frames to be displayed
        /// every second. For example, the function call
        /// frameRate(30) will attempt to refresh 30 times a
        /// second. If the processor is not fast enough to
        /// maintain the specified rate, the frame rate will
        /// not be achieved. Setting the frame rate within
        /// setup() is recommended. The default frame rate is
        /// based on the frame rate of the display (here also
        /// called "refresh rate"), which is set to 60 frames
        /// per second on most computers. A frame rate of 24
        /// frames per second (usual for movies) or above will
        /// be enough for smooth animations This is the same
        /// as setFrameRate(val).  Calling frameRate() with no
        /// arguments returns the current framerate. The draw
        /// function must run at least once before it will
        /// return a value. This is the same as
        /// getFrameRate().
        /// 
        /// 
        /// Calling frameRate() with arguments that are not of
        /// the type numbers or are non positive also returns
        /// current framerate.</summary>
        /// <param name="fps">number of frames to be displayed every
        /// second</param>
        abstract frameRate: fps: float -> p5
        /// Specifies the number of frames to be displayed
        /// every second. For example, the function call
        /// frameRate(30) will attempt to refresh 30 times a
        /// second. If the processor is not fast enough to
        /// maintain the specified rate, the frame rate will
        /// not be achieved. Setting the frame rate within
        /// setup() is recommended. The default frame rate is
        /// based on the frame rate of the display (here also
        /// called "refresh rate"), which is set to 60 frames
        /// per second on most computers. A frame rate of 24
        /// frames per second (usual for movies) or above will
        /// be enough for smooth animations This is the same
        /// as setFrameRate(val).  Calling frameRate() with no
        /// arguments returns the current framerate. The draw
        /// function must run at least once before it will
        /// return a value. This is the same as
        /// getFrameRate().
        /// 
        /// 
        /// Calling frameRate() with arguments that are not of
        /// the type numbers or are non positive also returns
        /// current framerate.
        abstract frameRate: unit -> float
        /// Hides the cursor from view.
        abstract noCursor: unit -> unit
        /// The windowResized() function is called once every
        /// time the browser window is resized. This is a good
        /// place to resize the canvas or do any other
        /// adjustments to accommodate the new window size.
        abstract windowResized: unit -> unit
        /// <summary>If argument is given, sets the sketch to
        /// fullscreen or not based on the value of the
        /// argument. If no argument is given, returns the
        /// current fullscreen state. Note that due to browser
        /// restrictions this can only be called on user
        /// input, for example, on mouse press like the
        /// example below.</summary>
        /// <param name="val">whether the sketch should be in
        /// fullscreen mode or not</param>
        abstract fullscreen: ?``val``: bool -> bool
        /// <summary>Sets the pixel scaling for high pixel density
        /// displays. By default pixel density is set to match
        /// display density, call pixelDensity(1) to turn this
        /// off. Calling pixelDensity() with no arguments
        /// returns the current pixel density of the sketch.</summary>
        /// <param name="val">whether or how much the sketch should
        /// scale</param>
        abstract pixelDensity: ``val``: float -> p5
        /// Sets the pixel scaling for high pixel density
        /// displays. By default pixel density is set to match
        /// display density, call pixelDensity(1) to turn this
        /// off. Calling pixelDensity() with no arguments
        /// returns the current pixel density of the sketch.
        abstract pixelDensity: unit -> float
        /// Returns the pixel density of the current display
        /// the sketch is running on.
        abstract displayDensity: unit -> float
        /// Gets the current URL.
        abstract getURL: unit -> string
        /// Gets the current URL path as an array.
        abstract getURLPath: unit -> ResizeArray<string>
        /// Gets the current URL params as an Object.
        abstract getURLParams: unit -> obj
        /// The system variable frameCount contains the number
        /// of frames that have been displayed since the
        /// program started. Inside setup() the value is 0,
        /// after the first iteration of draw it is 1, etc.
        abstract frameCount: float with get, set
        /// Confirms if the window a p5.js program is in is
        /// "focused," meaning that the sketch will accept
        /// mouse or keyboard input. This variable is "true"
        /// if the window is focused and "false" if not.
        abstract focused: bool with get, set
        /// System variable that stores the width of the
        /// screen display according to The default
        /// pixelDensity. This is used to run a full-screen
        /// program on any display size. To return actual
        /// screen size, multiply this by pixelDensity.
        abstract displayWidth: float with get, set
        /// System variable that stores the height of the
        /// screen display according to The default
        /// pixelDensity. This is used to run a full-screen
        /// program on any display size. To return actual
        /// screen size, multiply this by pixelDensity.
        abstract displayHeight: float with get, set
        /// System variable that stores the width of the inner
        /// window, it maps to window.innerWidth.
        abstract windowWidth: float with get, set
        /// System variable that stores the height of the
        /// inner window, it maps to window.innerHeight.
        abstract windowHeight: float with get, set
        /// System variable that stores the width of the
        /// drawing canvas. This value is set by the first
        /// parameter of the createCanvas() function. For
        /// example, the function call createCanvas(320, 240)
        /// sets the width variable to the value 320. The
        /// value of width defaults to 100 if createCanvas()
        /// is not used in a program.
        abstract width: float with get, set
        /// System variable that stores the height of the
        /// drawing canvas. This value is set by the second
        /// parameter of the createCanvas() function. For
        /// example, the function call createCanvas(320, 240)
        /// sets the height variable to the value 240. The
        /// value of height defaults to 100 if createCanvas()
        /// is not used in a program.
        abstract height: float with get, set
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Creates a canvas element in the document, and sets
        /// the dimensions of it in pixels. This method should
        /// be called only once at the start of setup. Calling
        /// createCanvas more than once in a sketch will
        /// result in very unpredictable behavior. If you want
        /// more than one drawing canvas you could use
        /// createGraphics (hidden by default but it can be
        /// shown).  The system variables width and height are
        /// set by the parameters passed to this function. If
        /// createCanvas() is not used, the window will be
        /// given a default size of 100x100 pixels.
        /// 
        /// 
        /// For more ways to position the canvas, see the
        /// positioning the canvas wiki page.</summary>
        /// <param name="w">width of the canvas</param>
        /// <param name="h">height of the canvas</param>
        /// <param name="renderer">either P2D or WEBGL</param>
        abstract createCanvas: w: float * h: float * ?renderer: RENDERER -> Renderer
        /// <summary>Resizes the canvas to given width and height. The
        /// canvas will be cleared and draw will be called
        /// immediately, allowing the sketch to re-render
        /// itself in the resized canvas.</summary>
        /// <param name="w">width of the canvas</param>
        /// <param name="h">height of the canvas</param>
        /// <param name="noRedraw">don't redraw the canvas
        /// immediately</param>
        abstract resizeCanvas: w: float * h: float * ?noRedraw: bool -> unit
        /// Removes the default canvas for a p5 sketch that
        /// doesn't require a canvas
        abstract noCanvas: unit -> unit
        /// <summary>Creates and returns a new p5.Renderer object. Use
        /// this class if you need to draw into an off-screen
        /// graphics buffer. The two parameters define the
        /// width and height in pixels.</summary>
        /// <param name="w">width of the offscreen graphics buffer</param>
        /// <param name="h">height of the offscreen graphics buffer</param>
        /// <param name="renderer">either P2D or WEBGL undefined
        /// defaults to p2d</param>
        abstract createGraphics: w: float * h: float * ?renderer: RENDERER -> Graphics
        /// <summary>Blends the pixels in the display window according
        /// to the defined mode. There is a choice of the
        /// following modes to blend the source pixels (A)
        /// with the ones of pixels already in the display
        /// window (B): - BLEND - linear interpolation of
        /// colours: C = A*factor + B. This is the default
        /// blending mode.
        /// - ADD - sum of A and B
        /// - DARKEST - only the darkest colour succeeds: C =
        /// min(A*factor, B).
        /// - LIGHTEST - only the lightest colour succeeds: C
        /// = max(A*factor, B).
        /// - DIFFERENCE - subtract colors from underlying
        /// image.
        /// - EXCLUSION - similar to DIFFERENCE, but less
        /// extreme.
        /// - MULTIPLY - multiply the colors, result will
        /// always be darker.
        /// - SCREEN - opposite multiply, uses inverse values
        /// of the colors.
        /// - REPLACE - the pixels entirely replace the others
        /// and don't utilize alpha (transparency) values.
        /// - OVERLAY - mix of MULTIPLY and SCREEN .
        /// Multiplies dark values, and screens light values.
        /// - HARD_LIGHT - SCREEN when greater than 50% gray,
        /// MULTIPLY when lower.
        /// - SOFT_LIGHT - mix of DARKEST and LIGHTEST. Works
        /// like OVERLAY, but not as harsh.
        /// - DODGE - lightens light tones and increases
        /// contrast, ignores darks.
        /// - BURN - darker areas are applied, increasing
        /// contrast, ignores lights.</summary>
        /// <param name="mode">blend mode to set for canvas. either
        /// BLEND, DARKEST, LIGHTEST, DIFFERENCE, MULTIPLY,
        /// EXCLUSION, SCREEN, REPLACE, OVERLAY, HARD_LIGHT,
        /// SOFT_LIGHT, DODGE, BURN, ADD or NORMAL</param>
        abstract blendMode: mode: BLEND_MODE -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// Stops p5.js from continuously executing the code
        /// within draw(). If loop() is called, the code in
        /// draw() begins to run continuously again. If using
        /// noLoop() in setup(), it should be the last line
        /// inside the block.  When noLoop() is used, it's not
        /// possible to manipulate or access the screen inside
        /// event handling functions such as mousePressed() or
        /// keyPressed(). Instead, use those functions to call
        /// redraw() or loop(), which will run draw(), which
        /// can update the screen properly. This means that
        /// when noLoop() has been called, no drawing can
        /// happen, and functions like saveFrame() or
        /// loadPixels() may not be used.
        /// 
        /// 
        /// Note that if the sketch is resized, redraw() will
        /// be called to update the sketch, even after
        /// noLoop() has been specified. Otherwise, the sketch
        /// would enter an odd state until loop() was called.
        abstract noLoop: unit -> unit
        /// By default, p5.js loops through draw()
        /// continuously, executing the code within it.
        /// However, the draw() loop may be stopped by calling
        /// noLoop(). In that case, the draw() loop can be
        /// resumed with loop().
        abstract loop: unit -> unit
        /// The push() function saves the current drawing
        /// style settings and transformations, while pop()
        /// restores these settings. Note that these functions
        /// are always used together. They allow you to change
        /// the style and transformation settings and later
        /// return to what you had. When a new state is
        /// started with push(), it builds on the current
        /// style and transform information. The push() and
        /// pop() functions can be embedded to provide more
        /// control. (See the second example for a
        /// demonstration.)  push() stores information related
        /// to the current transformation state and style
        /// settings controlled by the following functions:
        /// fill(), stroke(), tint(), strokeWeight(),
        /// strokeCap(), strokeJoin(), imageMode(),
        /// rectMode(), ellipseMode(), colorMode(),
        /// textAlign(), textFont(), textMode(), textSize(),
        /// textLeading().
        abstract push: unit -> unit
        /// The push() function saves the current drawing
        /// style settings and transformations, while pop()
        /// restores these settings. Note that these functions
        /// are always used together. They allow you to change
        /// the style and transformation settings and later
        /// return to what you had. When a new state is
        /// started with push(), it builds on the current
        /// style and transform information. The push() and
        /// pop() functions can be embedded to provide more
        /// control. (See the second example for a
        /// demonstration.)  push() stores information related
        /// to the current transformation state and style
        /// settings controlled by the following functions:
        /// fill(), stroke(), tint(), strokeWeight(),
        /// strokeCap(), strokeJoin(), imageMode(),
        /// rectMode(), ellipseMode(), colorMode(),
        /// textAlign(), textFont(), textMode(), textSize(),
        /// textLeading().
        abstract pop: unit -> unit
        /// <summary>Executes the code within draw() one time. This
        /// functions allows the program to update the display
        /// window only when necessary, for example when an
        /// event registered by mousePressed() or keyPressed()
        /// occurs.  In structuring a program, it only makes
        /// sense to call redraw() within events such as
        /// mousePressed(). This is because redraw() does not
        /// run draw() immediately (it only sets a flag that
        /// indicates an update is needed).
        /// 
        /// 
        /// The redraw() function does not work properly when
        /// called inside draw(). To enable/disable
        /// animations, use loop() and noLoop().
        /// 
        /// 
        /// In addition you can set the number of redraws per
        /// method call. Just add an integer as single
        /// parameter for the number of redraws.</summary>
        /// <param name="n">Redraw for n-times. The default value
        /// is 1.</param>
        abstract redraw: ?n: float -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Multiplies the current matrix by the one specified
        /// through the parameters. This is a powerful
        /// operation that can perform the equivalent of
        /// translate, scale, shear and rotate all at once.
        /// You can learn more about transformation matrices
        /// on  Wikipedia. The naming of the arguments here
        /// follows the naming of the  WHATWG specification
        /// and corresponds to a transformation matrix of the
        /// form:</summary>
        /// <param name="a">numbers which define the 2x3 matrix to be
        /// multiplied</param>
        /// <param name="b">numbers which define the 2x3 matrix to be
        /// multiplied</param>
        /// <param name="c">numbers which define the 2x3 matrix to be
        /// multiplied</param>
        /// <param name="d">numbers which define the 2x3 matrix to be
        /// multiplied</param>
        /// <param name="e">numbers which define the 2x3 matrix to be
        /// multiplied</param>
        /// <param name="f">numbers which define the 2x3 matrix to be
        /// multiplied</param>
        abstract applyMatrix: a: float * b: float * c: float * d: float * e: float * f: float -> p5
        /// Replaces the current matrix with the identity
        /// matrix.
        abstract resetMatrix: unit -> p5
        /// <summary>Rotates a shape the amount specified by the angle
        /// parameter. This function accounts for angleMode,
        /// so angles can be entered in either RADIANS or
        /// DEGREES.  Objects are always rotated around their
        /// relative position to the origin and positive
        /// numbers rotate objects in a clockwise direction.
        /// Transformations apply to everything that happens
        /// after and subsequent calls to the function
        /// accumulates the effect. For example, calling
        /// rotate(HALF_PI) and then rotate(HALF_PI) is the
        /// same as rotate(PI). All tranformations are reset
        /// when draw() begins again.
        /// 
        /// 
        /// Technically, rotate() multiplies the current
        /// transformation matrix by a rotation matrix. This
        /// function can be further controlled by the push()
        /// and pop().</summary>
        /// <param name="angle">the angle of rotation, specified in
        /// radians or degrees, depending on current angleMode</param>
        /// <param name="axis">(in 3d) the axis to rotate around</param>
        abstract rotate: angle: float * ?axis: U2<Vector, ResizeArray<float>> -> p5
        /// <summary>Rotates around X axis.</summary>
        /// <param name="angle">the angle of rotation, specified in
        /// radians or degrees, depending on current angleMode</param>
        abstract rotateX: angle: float -> p5
        /// <summary>Rotates around Y axis.</summary>
        /// <param name="angle">the angle of rotation, specified in
        /// radians or degrees, depending on current angleMode</param>
        abstract rotateY: angle: float -> p5
        /// <summary>Rotates around Z axis. Webgl mode only.</summary>
        /// <param name="angle">the angle of rotation, specified in
        /// radians or degrees, depending on current angleMode</param>
        abstract rotateZ: angle: float -> p5
        /// <summary>Increases or decreases the size of a shape by
        /// expanding and contracting vertices. Objects always
        /// scale from their relative origin to the coordinate
        /// system. Scale values are specified as decimal
        /// percentages. For example, the function call
        /// scale(2.0) increases the dimension of a shape by
        /// 200%.  Transformations apply to everything that
        /// happens after and subsequent calls to the function
        /// multiply the effect. For example, calling
        /// scale(2.0) and then scale(1.5) is the same as
        /// scale(3.0). If scale() is called within draw(),
        /// the transformation is reset when the loop begins
        /// again.
        /// 
        /// 
        /// Using this function with the z parameter is only
        /// available in WEBGL mode. This function can be
        /// further controlled with push() and pop().</summary>
        /// <param name="s">percent to scale the object, or
        /// percentage to scale the object in the x-axis if
        /// multiple arguments are given</param>
        /// <param name="y">percent to scale the object in the
        /// y-axis</param>
        /// <param name="z">percent to scale the object in the
        /// z-axis (webgl only)</param>
        abstract scale: s: U3<float, Vector, ResizeArray<float>> * ?y: float * ?z: float -> p5
        /// <summary>Increases or decreases the size of a shape by
        /// expanding and contracting vertices. Objects always
        /// scale from their relative origin to the coordinate
        /// system. Scale values are specified as decimal
        /// percentages. For example, the function call
        /// scale(2.0) increases the dimension of a shape by
        /// 200%.  Transformations apply to everything that
        /// happens after and subsequent calls to the function
        /// multiply the effect. For example, calling
        /// scale(2.0) and then scale(1.5) is the same as
        /// scale(3.0). If scale() is called within draw(),
        /// the transformation is reset when the loop begins
        /// again.
        /// 
        /// 
        /// Using this function with the z parameter is only
        /// available in WEBGL mode. This function can be
        /// further controlled with push() and pop().</summary>
        /// <param name="scales">per-axis percents to scale the
        /// object</param>
        abstract scale: scales: U2<Vector, ResizeArray<float>> -> p5
        /// <summary>Shears a shape around the x-axis the amount
        /// specified by the angle parameter. Angles should be
        /// specified in the current angleMode. Objects are
        /// always sheared around their relative position to
        /// the origin and positive numbers shear objects in a
        /// clockwise direction.  Transformations apply to
        /// everything that happens after and subsequent calls
        /// to the function accumulates the effect. For
        /// example, calling shearX(PI/2) and then
        /// shearX(PI/2) is the same as shearX(PI). If
        /// shearX() is called within the draw(), the
        /// transformation is reset when the loop begins
        /// again.
        /// 
        /// 
        /// Technically, shearX() multiplies the current
        /// transformation matrix by a rotation matrix. This
        /// function can be further controlled by the push()
        /// and pop() functions.</summary>
        /// <param name="angle">angle of shear specified in radians
        /// or degrees, depending on current angleMode</param>
        abstract shearX: angle: float -> p5
        /// <summary>Shears a shape around the y-axis the amount
        /// specified by the angle parameter. Angles should be
        /// specified in the current angleMode. Objects are
        /// always sheared around their relative position to
        /// the origin and positive numbers shear objects in a
        /// clockwise direction.  Transformations apply to
        /// everything that happens after and subsequent calls
        /// to the function accumulates the effect. For
        /// example, calling shearY(PI/2) and then
        /// shearY(PI/2) is the same as shearY(PI). If
        /// shearY() is called within the draw(), the
        /// transformation is reset when the loop begins
        /// again.
        /// 
        /// 
        /// Technically, shearY() multiplies the current
        /// transformation matrix by a rotation matrix. This
        /// function can be further controlled by the push()
        /// and pop() functions.</summary>
        /// <param name="angle">angle of shear specified in radians
        /// or degrees, depending on current angleMode</param>
        abstract shearY: angle: float -> p5
        /// <summary>Specifies an amount to displace objects within the
        /// display window. The x parameter specifies
        /// left/right translation, the y parameter specifies
        /// up/down translation.  Transformations are
        /// cumulative and apply to everything that happens
        /// after and subsequent calls to the function
        /// accumulates the effect. For example, calling
        /// translate(50, 0) and then translate(20, 0) is the
        /// same as translate(70, 0). If translate() is called
        /// within draw(), the transformation is reset when
        /// the loop begins again. This function can be
        /// further controlled by using push() and pop().</summary>
        /// <param name="x">left/right translation</param>
        /// <param name="y">up/down translation</param>
        /// <param name="z">forward/backward translation (webgl
        /// only)</param>
        abstract translate: x: float * y: float * ?z: float -> p5
        /// <summary>Specifies an amount to displace objects within the
        /// display window. The x parameter specifies
        /// left/right translation, the y parameter specifies
        /// up/down translation.  Transformations are
        /// cumulative and apply to everything that happens
        /// after and subsequent calls to the function
        /// accumulates the effect. For example, calling
        /// translate(50, 0) and then translate(20, 0) is the
        /// same as translate(70, 0). If translate() is called
        /// within draw(), the transformation is reset when
        /// the loop begins again. This function can be
        /// further controlled by using push() and pop().</summary>
        /// <param name="vector">the vector to translate by</param>
        abstract translate: vector: Vector -> p5
module P5 = ______index
let [<Import("*","p5/src/data/p5.TypedDict")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract TypedDict: TypedDictStatic
        abstract NumberDict: NumberDictStatic
        abstract StringDict: StringDictStatic

    type [<AllowNullLiteral>] TypedDict =
        /// Returns the number of key-value pairs currently
        /// stored in the Dictionary.
        abstract size: unit -> float
        /// <summary>Returns true if the given key exists in the
        /// Dictionary, otherwise returns false.</summary>
        /// <param name="key">that you want to look up</param>
        abstract hasKey: key: U2<float, string> -> bool
        /// <summary>Returns the value stored at the given key.</summary>
        /// <param name="the">key you want to access</param>
        abstract get: the: U2<float, string> -> U2<float, string>
        /// Updates the value associated with the given key in
        /// case it already exists in the Dictionary.
        /// Otherwise a new key-value pair is added.
        abstract set: key: U2<float, string> * value: U2<float, string> -> unit
        /// Creates a new key-value pair in the Dictionary.
        abstract create: key: U2<float, string> * value: U2<float, string> -> unit
        /// <summary>Creates a new key-value pair in the Dictionary.</summary>
        /// <param name="obj">key/value pair</param>
        abstract create: obj: obj -> unit
        /// Removes all previously stored key-value pairs from
        /// the Dictionary.
        abstract clear: unit -> unit
        /// <summary>Removes the key-value pair stored at the given key
        /// from the Dictionary.</summary>
        /// <param name="key">for the pair to remove</param>
        abstract remove: key: U2<float, string> -> unit
        /// Logs the set of items currently stored in the
        /// Dictionary to the console.
        abstract print: unit -> unit
        /// Converts the Dictionary into a CSV file for local
        /// download.
        abstract saveTable: unit -> unit
        /// Converts the Dictionary into a JSON file for local
        /// download.
        abstract saveJSON: unit -> unit

    type [<AllowNullLiteral>] TypedDictStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> TypedDict

    type [<AllowNullLiteral>] NumberDict =
        inherit TypedDict
        /// <summary>Add the given number to the value currently stored
        /// at the given key. The sum then replaces the value
        /// previously stored in the Dictionary.</summary>
        /// <param name="Key">for the value you wish to add to</param>
        /// <param name="Number">to add to the value</param>
        abstract add: Key: float * Number: float -> unit
        /// <summary>Subtract the given number from the value currently
        /// stored at the given key. The difference then
        /// replaces the value previously stored in the
        /// Dictionary.</summary>
        /// <param name="Key">for the value you wish to subtract from</param>
        /// <param name="Number">to subtract from the value</param>
        abstract sub: Key: float * Number: float -> unit
        /// <summary>Multiply the given number with the value currently
        /// stored at the given key. The product then replaces
        /// the value previously stored in the Dictionary.</summary>
        /// <param name="Key">for value you wish to multiply</param>
        /// <param name="Amount">to multiply the value by</param>
        abstract mult: Key: float * Amount: float -> unit
        /// <summary>Divide the given number with the value currently
        /// stored at the given key. The quotient then
        /// replaces the value previously stored in the
        /// Dictionary.</summary>
        /// <param name="Key">for value you wish to divide</param>
        /// <param name="Amount">to divide the value by</param>
        abstract div: Key: float * Amount: float -> unit
        /// Return the lowest number currently stored in the
        /// Dictionary.
        abstract minValue: unit -> float
        /// Return the highest number currently stored in the
        /// Dictionary.
        abstract maxValue: unit -> float
        /// Return the lowest key currently used in the
        /// Dictionary.
        abstract minKey: unit -> float
        /// Return the highest key currently used in the
        /// Dictionary.
        abstract maxKey: unit -> float

    type [<AllowNullLiteral>] NumberDictStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> NumberDict

    type [<AllowNullLiteral>] StringDict =
        inherit TypedDict

    type [<AllowNullLiteral>] StringDictStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> StringDict

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// Creates a new instance of p5.StringDict using the
        /// key-value pair or the object you provide.
        abstract createStringDict: key: string * value: string -> StringDict
        /// <summary>Creates a new instance of p5.StringDict using the
        /// key-value pair or the object you provide.</summary>
        /// <param name="object">object</param>
        abstract createStringDict: ``object``: obj -> StringDict
        /// Creates a new instance of p5.NumberDict using the
        /// key-value pair or object you provide.
        abstract createNumberDict: key: float * value: float -> NumberDict
        /// <summary>Creates a new instance of p5.NumberDict using the
        /// key-value pair or object you provide.</summary>
        /// <param name="object">object</param>
        abstract createNumberDict: ``object``: obj -> NumberDict
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>The setMoveThreshold() function is used to set the
        /// movement threshold for the deviceMoved() function.
        /// The default threshold is set to 0.5.</summary>
        /// <param name="value">The threshold value</param>
        abstract setMoveThreshold: value: float -> unit
        /// <summary>The setShakeThreshold() function is used to set
        /// the movement threshold for the deviceShaken()
        /// function. The default threshold is set to 30.</summary>
        /// <param name="value">The threshold value</param>
        abstract setShakeThreshold: value: float -> unit
        /// The deviceMoved() function is called when the
        /// device is moved by more than the threshold value
        /// along X, Y or Z axis. The default threshold is set
        /// to 0.5.
        abstract deviceMoved: unit -> unit
        /// The deviceTurned() function is called when the
        /// device rotates by more than 90 degrees
        /// continuously.  The axis that triggers the
        /// deviceTurned() method is stored in the turnAxis
        /// variable. The deviceTurned() method can be locked
        /// to trigger on any axis: X, Y or Z by comparing the
        /// turnAxis variable to 'X', 'Y' or 'Z'.
        abstract deviceTurned: unit -> unit
        /// The deviceShaken() function is called when the
        /// device total acceleration changes of accelerationX
        /// and accelerationY values is more than the
        /// threshold value. The default threshold is set to
        /// 30.
        abstract deviceShaken: unit -> unit
        /// The system variable deviceOrientation always
        /// contains the orientation of the device. The value
        /// of this variable will either be set 'landscape' or
        /// 'portrait'. If no data is available it will be set
        /// to 'undefined'. either LANDSCAPE or PORTRAIT.
        abstract deviceOrientation: UNKNOWN_P5_CONSTANT with get, set
        /// The system variable accelerationX always contains
        /// the acceleration of the device along the x axis.
        /// Value is represented as meters per second squared.
        abstract accelerationX: float with get, set
        /// The system variable accelerationY always contains
        /// the acceleration of the device along the y axis.
        /// Value is represented as meters per second squared.
        abstract accelerationY: float with get, set
        /// The system variable accelerationZ always contains
        /// the acceleration of the device along the z axis.
        /// Value is represented as meters per second squared.
        abstract accelerationZ: float with get, set
        /// The system variable pAccelerationX always contains
        /// the acceleration of the device along the x axis in
        /// the frame previous to the current frame. Value is
        /// represented as meters per second squared.
        abstract pAccelerationX: float with get, set
        /// The system variable pAccelerationY always contains
        /// the acceleration of the device along the y axis in
        /// the frame previous to the current frame. Value is
        /// represented as meters per second squared.
        abstract pAccelerationY: float with get, set
        /// The system variable pAccelerationZ always contains
        /// the acceleration of the device along the z axis in
        /// the frame previous to the current frame. Value is
        /// represented as meters per second squared.
        abstract pAccelerationZ: float with get, set
        /// The system variable rotationX always contains the
        /// rotation of the device along the x axis. Value is
        /// represented as 0 to +/-180 degrees.  Note: The
        /// order the rotations are called is important, ie.
        /// if used together, it must be called in the order
        /// Z-X-Y or there might be unexpected behaviour.
        abstract rotationX: float with get, set
        /// The system variable rotationY always contains the
        /// rotation of the device along the y axis. Value is
        /// represented as 0 to +/-90 degrees.  Note: The
        /// order the rotations are called is important, ie.
        /// if used together, it must be called in the order
        /// Z-X-Y or there might be unexpected behaviour.
        abstract rotationY: float with get, set
        /// The system variable rotationZ always contains the
        /// rotation of the device along the z axis. Value is
        /// represented as 0 to 359 degrees.  Unlike rotationX
        /// and rotationY, this variable is available for
        /// devices with a built-in compass only.
        /// 
        /// 
        /// Note: The order the rotations are called is
        /// important, ie. if used together, it must be called
        /// in the order Z-X-Y or there might be unexpected
        /// behaviour.
        abstract rotationZ: float with get, set
        /// The system variable pRotationX always contains the
        /// rotation of the device along the x axis in the
        /// frame previous to the current frame. Value is
        /// represented as 0 to +/-180 degrees.  pRotationX
        /// can also be used with rotationX to determine the
        /// rotate direction of the device along the X-axis.
        abstract pRotationX: float with get, set
        /// The system variable pRotationY always contains the
        /// rotation of the device along the y axis in the
        /// frame previous to the current frame. Value is
        /// represented as 0 to +/-90 degrees.  pRotationY can
        /// also be used with rotationY to determine the
        /// rotate direction of the device along the Y-axis.
        abstract pRotationY: float with get, set
        /// The system variable pRotationZ always contains the
        /// rotation of the device along the z axis in the
        /// frame previous to the current frame. Value is
        /// represented as 0 to 359 degrees.  pRotationZ can
        /// also be used with rotationZ to determine the
        /// rotate direction of the device along the Z-axis.
        abstract pRotationZ: float with get, set
        abstract turnAxis: string with get, set
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// The keyPressed() function is called once every
        /// time a key is pressed. The keyCode for the key
        /// that was pressed is stored in the keyCode
        /// variable.  For non-ASCII keys, use the keyCode
        /// variable. You can check if the keyCode equals
        /// BACKSPACE, DELETE, ENTER, RETURN, TAB, ESCAPE,
        /// SHIFT, CONTROL, OPTION, ALT, UP_ARROW, DOWN_ARROW,
        /// LEFT_ARROW, RIGHT_ARROW.
        /// 
        /// 
        /// For ASCII keys that was pressed is stored in the
        /// key variable. However, it does not distinguish
        /// between uppercase and lowercase. For this reason,
        /// it is recommended to use keyTyped() to read the
        /// key variable, in which the case of the variable
        /// will be distinguished.
        /// 
        /// 
        /// Because of how operating systems handle key
        /// repeats, holding down a key may cause multiple
        /// calls to keyTyped() (and keyReleased() as well).
        /// The rate of repeat is set by the operating system
        /// and how each computer is configured.
        /// 
        /// 
        /// Browsers may have different default behaviors
        /// attached to various key events. To prevent any
        /// default behavior for this event, add "return
        /// false" to the end of the method.
        abstract keyPressed: unit -> unit
        /// The keyReleased() function is called once every
        /// time a key is released. See key and keyCode for
        /// more information. Browsers may have different
        /// default behaviors attached to various key events.
        /// To prevent any default behavior for this event,
        /// add "return false" to the end of the method.
        abstract keyReleased: unit -> unit
        /// The keyTyped() function is called once every time
        /// a key is pressed, but action keys such as Ctrl,
        /// Shift, and Alt are ignored. The most recent key
        /// pressed will be stored in the key variable.
        /// Because of how operating systems handle key
        /// repeats, holding down a key will cause multiple
        /// calls to keyTyped() (and keyReleased() as well).
        /// The rate of repeat is set by the operating system
        /// and how each computer is configured.
        /// 
        /// 
        /// Browsers may have different default behaviors
        /// attached to various key events. To prevent any
        /// default behavior for this event, add "return
        /// false" to the end of the method.
        abstract keyTyped: unit -> unit
        /// <summary>The keyIsDown() function checks if the key is
        /// currently down, i.e. pressed. It can be used if
        /// you have an object that moves, and you want
        /// several keys to be able to affect its behaviour
        /// simultaneously, such as moving a sprite
        /// diagonally. You can put in any number representing
        /// the keyCode of the key, or use any of the variable
        /// keyCode names listed here.</summary>
        /// <param name="code">The key to check for.</param>
        abstract keyIsDown: code: float -> bool
        /// The boolean system variable keyIsPressed is true
        /// if any key is pressed and false if no keys are
        /// pressed.
        abstract keyIsPressed: bool with get, set
        /// The system variable key always contains the value
        /// of the most recent key on the keyboard that was
        /// typed. To get the proper capitalization, it is
        /// best to use it within keyTyped(). For non-ASCII
        /// keys, use the keyCode variable.
        abstract key: string with get, set
        /// The variable keyCode is used to detect special
        /// keys such as BACKSPACE, DELETE, ENTER, RETURN,
        /// TAB, ESCAPE, SHIFT, CONTROL, OPTION, ALT,
        /// UP_ARROW, DOWN_ARROW, LEFT_ARROW, RIGHT_ARROW. You
        /// can also check for custom keys by looking up the
        /// keyCode of any key on a site like this:
        /// keycode.info.
        abstract keyCode: float with get, set
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>The mouseMoved() function is called every time the
        /// mouse moves and a mouse button is not pressed.
        /// Browsers may have different default behaviors
        /// attached to various mouse events. To prevent any
        /// default behavior for this event, add "return
        /// false" to the end of the method.</summary>
        /// <param name="event">optional MouseEvent callback
        /// argument.</param>
        abstract mouseMoved: ?``event``: obj -> unit
        /// <summary>The mouseDragged() function is called once every
        /// time the mouse moves and a mouse button is
        /// pressed. If no mouseDragged() function is defined,
        /// the touchMoved() function will be called instead
        /// if it is defined. Browsers may have different
        /// default behaviors attached to various mouse
        /// events. To prevent any default behavior for this
        /// event, add "return false" to the end of the
        /// method.</summary>
        /// <param name="event">optional MouseEvent callback
        /// argument.</param>
        abstract mouseDragged: ?``event``: obj -> unit
        /// <summary>The mousePressed() function is called once after
        /// every time a mouse button is pressed. The
        /// mouseButton variable (see the related reference
        /// entry) can be used to determine which button has
        /// been pressed. If no mousePressed() function is
        /// defined, the touchStarted() function will be
        /// called instead if it is defined. Browsers may have
        /// different default behaviors attached to various
        /// mouse events. To prevent any default behavior for
        /// this event, add "return false" to the end of the
        /// method.</summary>
        /// <param name="event">optional MouseEvent callback
        /// argument.</param>
        abstract mousePressed: ?``event``: obj -> unit
        /// <summary>The mouseReleased() function is called every time
        /// a mouse button is released. If no mouseReleased()
        /// function is defined, the touchEnded() function
        /// will be called instead if it is defined. Browsers
        /// may have different default behaviors attached to
        /// various mouse events. To prevent any default
        /// behavior for this event, add "return false" to the
        /// end of the method.</summary>
        /// <param name="event">optional MouseEvent callback
        /// argument.</param>
        abstract mouseReleased: ?``event``: obj -> unit
        /// <summary>The mouseClicked() function is called once after a
        /// mouse button has been pressed and then released.
        /// Browsers handle clicks differently, so this
        /// function is only guaranteed to be run when the
        /// left mouse button is clicked. To handle other
        /// mouse buttons being pressed or released, see
        /// mousePressed() or mouseReleased().
        /// 
        /// 
        /// Browsers may have different default behaviors
        /// attached to various mouse events. To prevent any
        /// default behavior for this event, add "return
        /// false" to the end of the method.</summary>
        /// <param name="event">optional MouseEvent callback
        /// argument.</param>
        abstract mouseClicked: ?``event``: obj -> unit
        /// <summary>The doubleClicked() function is executed every
        /// time a event listener has detected a dblclick
        /// event which is a part of the DOM L3 specification.
        /// The doubleClicked event is fired when a pointing
        /// device button (usually a mouse's primary button)
        /// is clicked twice on a single element. For more
        /// info on the dblclick event refer to mozilla's
        /// documentation here:
        /// https://developer.mozilla.org/en-US/docs/Web/Events/dblclick</summary>
        /// <param name="event">optional MouseEvent callback
        /// argument.</param>
        abstract doubleClicked: ?``event``: obj -> unit
        /// <summary>The function mouseWheel() is executed every time a
        /// vertical mouse wheel event is detected either
        /// triggered by an actual mouse wheel or by a
        /// touchpad. The event.delta property returns the
        /// amount the mouse wheel have scrolled. The values
        /// can be positive or negative depending on the
        /// scroll direction (on OS X with "natural" scrolling
        /// enabled, the signs are inverted).
        /// 
        /// 
        /// Browsers may have different default behaviors
        /// attached to various mouse events. To prevent any
        /// default behavior for this event, add "return
        /// false" to the end of the method.
        /// 
        /// 
        /// Due to the current support of the "wheel" event on
        /// Safari, the function may only work as expected if
        /// "return false" is included while using Safari.</summary>
        /// <param name="event">optional WheelEvent callback
        /// argument.</param>
        abstract mouseWheel: ?``event``: obj -> unit
        /// The system variable mouseX always contains the
        /// current horizontal position of the mouse, relative
        /// to (0, 0) of the canvas. If touch is used instead
        /// of mouse input, mouseX will hold the x value of
        /// the most recent touch point.
        abstract mouseX: float with get, set
        /// The system variable mouseY always contains the
        /// current vertical position of the mouse, relative
        /// to (0, 0) of the canvas. If touch is used instead
        /// of mouse input, mouseY will hold the y value of
        /// the most recent touch point.
        abstract mouseY: float with get, set
        /// The system variable pmouseX always contains the
        /// horizontal position of the mouse or finger in the
        /// frame previous to the current frame, relative to
        /// (0, 0) of the canvas. Note: pmouseX will be reset
        /// to the current mouseX value at the start of each
        /// touch event.
        abstract pmouseX: float with get, set
        /// The system variable pmouseY always contains the
        /// vertical position of the mouse or finger in the
        /// frame previous to the current frame, relative to
        /// (0, 0) of the canvas. Note: pmouseY will be reset
        /// to the current mouseY value at the start of each
        /// touch event.
        abstract pmouseY: float with get, set
        /// The system variable winMouseX always contains the
        /// current horizontal position of the mouse, relative
        /// to (0, 0) of the window.
        abstract winMouseX: float with get, set
        /// The system variable winMouseY always contains the
        /// current vertical position of the mouse, relative
        /// to (0, 0) of the window.
        abstract winMouseY: float with get, set
        /// The system variable pwinMouseX always contains the
        /// horizontal position of the mouse in the frame
        /// previous to the current frame, relative to (0, 0)
        /// of the window. Note: pwinMouseX will be reset to
        /// the current winMouseX value at the start of each
        /// touch event.
        abstract pwinMouseX: float with get, set
        /// The system variable pwinMouseY always contains the
        /// vertical position of the mouse in the frame
        /// previous to the current frame, relative to (0, 0)
        /// of the window. Note: pwinMouseY will be reset to
        /// the current winMouseY value at the start of each
        /// touch event.
        abstract pwinMouseY: float with get, set
        /// Processing automatically tracks if the mouse
        /// button is pressed and which button is pressed. The
        /// value of the system variable mouseButton is either
        /// LEFT, RIGHT, or CENTER depending on which button
        /// was pressed last. Warning: different browsers may
        /// track mouseButton differently.
        abstract mouseButton: UNKNOWN_P5_CONSTANT with get, set
        /// The boolean system variable mouseIsPressed is true
        /// if the mouse is pressed and false if not.
        abstract mouseIsPressed: bool with get, set
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>The touchStarted() function is called once after
        /// every time a touch is registered. If no
        /// touchStarted() function is defined, the
        /// mousePressed() function will be called instead if
        /// it is defined. Browsers may have different default
        /// behaviors attached to various touch events. To
        /// prevent any default behavior for this event, add
        /// "return false" to the end of the method.</summary>
        /// <param name="event">optional TouchEvent callback
        /// argument.</param>
        abstract touchStarted: ?``event``: obj -> unit
        /// <summary>The touchMoved() function is called every time a
        /// touch move is registered. If no touchMoved()
        /// function is defined, the mouseDragged() function
        /// will be called instead if it is defined. Browsers
        /// may have different default behaviors attached to
        /// various touch events. To prevent any default
        /// behavior for this event, add "return false" to the
        /// end of the method.</summary>
        /// <param name="event">optional TouchEvent callback
        /// argument.</param>
        abstract touchMoved: ?``event``: obj -> unit
        /// <summary>The touchEnded() function is called every time a
        /// touch ends. If no touchEnded() function is
        /// defined, the mouseReleased() function will be
        /// called instead if it is defined. Browsers may have
        /// different default behaviors attached to various
        /// touch events. To prevent any default behavior for
        /// this event, add "return false" to the end of the
        /// method.</summary>
        /// <param name="event">optional TouchEvent callback
        /// argument.</param>
        abstract touchEnded: ?``event``: obj -> unit
        /// The system variable touches[] contains an array of
        /// the positions of all current touch points,
        /// relative to (0, 0) of the canvas, and IDs
        /// identifying a unique touch as it moves. Each
        /// element in the array is an object with x, y, and
        /// id properties. The touches[] array is not
        /// supported on Safari and IE on touch-based desktops
        /// (laptops).
        abstract touches: ResizeArray<obj> with get, set
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Creates a new p5.Image (the datatype for storing
        /// images). This provides a fresh buffer of pixels to
        /// play with. Set the size of the buffer with the
        /// width and height parameters.  .pixels gives access
        /// to an array containing the values for all the
        /// pixels in the display window. These values are
        /// numbers. This array is the size (including an
        /// appropriate factor for the pixelDensity) of the
        /// display window x4, representing the R, G, B, A
        /// values in order for each pixel, moving from left
        /// to right across each row, then down each column.
        /// See .pixels for more info. It may also be simpler
        /// to use set() or get().
        /// 
        /// 
        /// Before accessing the pixels of an image, the data
        /// must loaded with the loadPixels() function. After
        /// the array data has been modified, the
        /// updatePixels() function must be run to update the
        /// changes.</summary>
        /// <param name="width">width in pixels</param>
        /// <param name="height">height in pixels</param>
        abstract createImage: width: float * height: float -> Image
        /// <summary>Save the current canvas as an image. The browser
        /// will either save the file immediately, or prompt
        /// the user with a dialogue window.</summary>
        /// <param name="selectedCanvas">a variable representing a
        /// specific html5 canvas (optional)</param>
        /// <param name="extension">'jpg' or 'png'</param>
        abstract saveCanvas: selectedCanvas: U2<Element, HTMLCanvasElement> * ?filename: string * ?extension: string -> unit
        /// <summary>Save the current canvas as an image. The browser
        /// will either save the file immediately, or prompt
        /// the user with a dialogue window.</summary>
        /// <param name="extension">'jpg' or 'png'</param>
        abstract saveCanvas: ?filename: string * ?extension: string -> unit
        /// <summary>Capture a sequence of frames that can be used to
        /// create a movie. Accepts a callback. For example,
        /// you may wish to send the frames to a server where
        /// they can be stored or converted into a movie. If
        /// no callback is provided, the browser will pop up
        /// save dialogues in an attempt to download all of
        /// the images that have just been created. With the
        /// callback provided the image data isn't saved by
        /// default but instead passed as an argument to the
        /// callback function as an array of objects, with the
        /// size of array equal to the total number of frames.
        /// Note that saveFrames() will only save the first 15
        /// frames of an animation. To export longer
        /// animations, you might look into a library like
        /// ccapture.js.</summary>
        /// <param name="extension">'jpg' or 'png'</param>
        /// <param name="duration">Duration in seconds to save the
        /// frames for.</param>
        /// <param name="framerate">Framerate to save the frames in.</param>
        /// <param name="callback">A callback function that will be
        /// executed to handle the image data. This function
        /// should accept an array as argument. The array will
        /// contain the specified number of frames of objects.
        /// Each object has three properties: imageData - an
        /// image/octet-stream, filename and extension.</param>
        abstract saveFrames: filename: string * extension: string * duration: float * framerate: float * ?callback: (ResizeArray<obj option> -> obj option) -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Loads an image from a path and creates a p5.Image
        /// from it.  The image may not be immediately
        /// available for rendering If you want to ensure that
        /// the image is ready before doing anything with it,
        /// place the loadImage() call in preload(). You may
        /// also supply a callback function to handle the
        /// image when it's ready.
        /// 
        /// 
        /// The path to the image should be relative to the
        /// HTML file that links in your sketch. Loading an
        /// image from a URL or other remote location may be
        /// blocked due to your browser's built-in security.</summary>
        /// <param name="path">Path of the image to be loaded</param>
        /// <param name="successCallback">Function to be called
        /// once the image is loaded. Will be passed the
        /// p5.Image.</param>
        /// <param name="failureCallback">called with event error
        /// if the image fails to load.</param>
        abstract loadImage: path: string * ?successCallback: (Image -> obj option) * ?failureCallback: (Event -> obj option) -> Image
        /// <summary>Draw an image to the p5.js canvas. This function
        /// can be used with different numbers of parameters.
        /// The simplest use requires only three parameters:
        /// img, x, and y—where (x, y) is the position of the
        /// image. Two more parameters can optionally be added
        /// to specify the width and height of the image.
        /// 
        /// This function can also be used with all eight
        /// Number parameters. To differentiate between all
        /// these parameters, p5.js uses the language of
        /// "destination rectangle" (which corresponds to
        /// "dx", "dy", etc.) and "source image" (which
        /// corresponds to "sx", "sy", etc.) below. Specifying
        /// the "source image" dimensions can be useful when
        /// you want to display a subsection of the source
        /// image instead of the whole thing. Here's a diagram
        /// to explain further:</summary>
        /// <param name="img">the image to display</param>
        /// <param name="x">the x-coordinate of the top-left corner
        /// of the image</param>
        /// <param name="y">the y-coordinate of the top-left corner
        /// of the image</param>
        /// <param name="width">the width to draw the image</param>
        /// <param name="height">the height to draw the image</param>
        abstract image: img: U2<Image, Element> * x: float * y: float * ?width: float * ?height: float -> unit
        /// <summary>Draw an image to the p5.js canvas. This function
        /// can be used with different numbers of parameters.
        /// The simplest use requires only three parameters:
        /// img, x, and y—where (x, y) is the position of the
        /// image. Two more parameters can optionally be added
        /// to specify the width and height of the image.
        /// 
        /// This function can also be used with all eight
        /// Number parameters. To differentiate between all
        /// these parameters, p5.js uses the language of
        /// "destination rectangle" (which corresponds to
        /// "dx", "dy", etc.) and "source image" (which
        /// corresponds to "sx", "sy", etc.) below. Specifying
        /// the "source image" dimensions can be useful when
        /// you want to display a subsection of the source
        /// image instead of the whole thing. Here's a diagram
        /// to explain further:</summary>
        /// <param name="img">the image to display</param>
        /// <param name="dx">the x-coordinate of the destination
        /// rectangle in which to draw the source image</param>
        /// <param name="dy">the y-coordinate of the destination
        /// rectangle in which to draw the source image</param>
        /// <param name="dWidth">the width of the destination
        /// rectangle</param>
        /// <param name="dHeight">the height of the destination
        /// rectangle</param>
        /// <param name="sx">the x-coordinate of the subsection of
        /// the source image to draw into the destination
        /// rectangle</param>
        /// <param name="sy">the y-coordinate of the subsection of
        /// the source image to draw into the destination
        /// rectangle</param>
        /// <param name="sWidth">the width of the subsection of the
        /// source image to draw into the destination
        /// rectangle</param>
        /// <param name="sHeight">the height of the subsection of
        /// the source image to draw into the destination
        /// rectangle</param>
        abstract image: img: U2<Image, Element> * dx: float * dy: float * dWidth: float * dHeight: float * sx: float * sy: float * ?sWidth: float * ?sHeight: float -> unit
        /// <summary>Sets the fill value for displaying images. Images
        /// can be tinted to specified colors or made
        /// transparent by including an alpha value.  To apply
        /// transparency to an image without affecting its
        /// color, use white as the tint color and specify an
        /// alpha value. For instance, tint(255, 128) will
        /// make an image 50% transparent (assuming the
        /// default alpha range of 0-255, which can be changed
        /// with colorMode()).
        /// 
        /// 
        /// The value for the gray parameter must be less than
        /// or equal to the current maximum value as specified
        /// by colorMode(). The default maximum value is 255.</summary>
        /// <param name="v1">red or hue value relative to the current
        /// color range</param>
        /// <param name="v2">green or saturation value relative to
        /// the current color range</param>
        /// <param name="v3">blue or brightness value relative to the
        /// current color range</param>
        abstract tint: v1: float * v2: float * v3: float * ?alpha: float -> unit
        /// <summary>Sets the fill value for displaying images. Images
        /// can be tinted to specified colors or made
        /// transparent by including an alpha value.  To apply
        /// transparency to an image without affecting its
        /// color, use white as the tint color and specify an
        /// alpha value. For instance, tint(255, 128) will
        /// make an image 50% transparent (assuming the
        /// default alpha range of 0-255, which can be changed
        /// with colorMode()).
        /// 
        /// 
        /// The value for the gray parameter must be less than
        /// or equal to the current maximum value as specified
        /// by colorMode(). The default maximum value is 255.</summary>
        /// <param name="value">a color string</param>
        abstract tint: value: string -> unit
        /// <summary>Sets the fill value for displaying images. Images
        /// can be tinted to specified colors or made
        /// transparent by including an alpha value.  To apply
        /// transparency to an image without affecting its
        /// color, use white as the tint color and specify an
        /// alpha value. For instance, tint(255, 128) will
        /// make an image 50% transparent (assuming the
        /// default alpha range of 0-255, which can be changed
        /// with colorMode()).
        /// 
        /// 
        /// The value for the gray parameter must be less than
        /// or equal to the current maximum value as specified
        /// by colorMode(). The default maximum value is 255.</summary>
        /// <param name="gray">a gray value</param>
        abstract tint: gray: float * ?alpha: float -> unit
        /// <summary>Sets the fill value for displaying images. Images
        /// can be tinted to specified colors or made
        /// transparent by including an alpha value.  To apply
        /// transparency to an image without affecting its
        /// color, use white as the tint color and specify an
        /// alpha value. For instance, tint(255, 128) will
        /// make an image 50% transparent (assuming the
        /// default alpha range of 0-255, which can be changed
        /// with colorMode()).
        /// 
        /// 
        /// The value for the gray parameter must be less than
        /// or equal to the current maximum value as specified
        /// by colorMode(). The default maximum value is 255.</summary>
        /// <param name="values">an array containing the
        /// red,green,blue & and alpha components of the color</param>
        abstract tint: values: ResizeArray<float> -> unit
        /// <summary>Sets the fill value for displaying images. Images
        /// can be tinted to specified colors or made
        /// transparent by including an alpha value.  To apply
        /// transparency to an image without affecting its
        /// color, use white as the tint color and specify an
        /// alpha value. For instance, tint(255, 128) will
        /// make an image 50% transparent (assuming the
        /// default alpha range of 0-255, which can be changed
        /// with colorMode()).
        /// 
        /// 
        /// The value for the gray parameter must be less than
        /// or equal to the current maximum value as specified
        /// by colorMode(). The default maximum value is 255.</summary>
        /// <param name="color">the tint color</param>
        abstract tint: color: Color -> unit
        /// Removes the current fill value for displaying
        /// images and reverts to displaying images with their
        /// original hues.
        abstract noTint: unit -> unit
        /// <summary>Set image mode. Modifies the location from which
        /// images are drawn by changing the way in which
        /// parameters given to image() are interpreted. The
        /// default mode is imageMode(CORNER), which
        /// interprets the second and third parameters of
        /// image() as the upper-left corner of the image. If
        /// two additional parameters are specified, they are
        /// used to set the image's width and height.
        /// imageMode(CORNERS) interprets the second and third
        /// parameters of image() as the location of one
        /// corner, and the fourth and fifth parameters as the
        /// opposite corner.
        /// 
        /// 
        /// imageMode(CENTER) interprets the second and third
        /// parameters of image() as the image's center point.
        /// If two additional parameters are specified, they
        /// are used to set the image's width and height.</summary>
        /// <param name="mode">either CORNER, CORNERS, or CENTER</param>
        abstract imageMode: mode: IMAGE_MODE -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Copies a region of pixels from one image to
        /// another, using a specified blend mode to do the
        /// operation.</summary>
        /// <param name="srcImage">source image</param>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        /// <param name="blendMode">the blend mode. either BLEND,
        /// DARKEST, LIGHTEST, DIFFERENCE, MULTIPLY,
        /// EXCLUSION, SCREEN, REPLACE, OVERLAY, HARD_LIGHT,
        /// SOFT_LIGHT, DODGE, BURN, ADD or NORMAL.</param>
        abstract blend: srcImage: Image * sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float * blendMode: BLEND_MODE -> unit
        /// <summary>Copies a region of pixels from one image to
        /// another, using a specified blend mode to do the
        /// operation.</summary>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        /// <param name="blendMode">the blend mode. either BLEND,
        /// DARKEST, LIGHTEST, DIFFERENCE, MULTIPLY,
        /// EXCLUSION, SCREEN, REPLACE, OVERLAY, HARD_LIGHT,
        /// SOFT_LIGHT, DODGE, BURN, ADD or NORMAL.</param>
        abstract blend: sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float * blendMode: UNKNOWN_P5_CONSTANT -> unit
        /// <summary>Copies a region of the canvas to another region of
        /// the canvas and copies a region of pixels from an
        /// image used as the srcImg parameter into the canvas
        /// srcImage is specified this is used as the source.
        /// If the source and destination regions aren't the
        /// same size, it will automatically resize source
        /// pixels to fit the specified target region.</summary>
        /// <param name="srcImage">source image</param>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        abstract copy: srcImage: U2<Image, Element> * sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float -> unit
        /// <summary>Copies a region of the canvas to another region of
        /// the canvas and copies a region of pixels from an
        /// image used as the srcImg parameter into the canvas
        /// srcImage is specified this is used as the source.
        /// If the source and destination regions aren't the
        /// same size, it will automatically resize source
        /// pixels to fit the specified target region.</summary>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        abstract copy: sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float -> unit
        /// <summary>Applies a filter to the canvas.
        /// 
        /// The presets options are:
        /// 
        /// 
        /// 
        /// THRESHOLD Converts the image to black and white
        /// pixels depending if they are above or below the
        /// threshold defined by the level parameter. The
        /// parameter must be between 0.0 (black) and 1.0
        /// (white). If no level is specified, 0.5 is used.
        /// 
        /// 
        /// 
        /// GRAY Converts any colors in the image to grayscale
        /// equivalents. No parameter is used.
        /// 
        /// 
        /// 
        /// OPAQUE Sets the alpha channel to entirely opaque.
        /// No parameter is used.
        /// 
        /// 
        /// 
        /// INVERT Sets each pixel to its inverse value. No
        /// parameter is used.
        /// 
        /// 
        /// 
        /// POSTERIZE Limits each channel of the image to the
        /// number of colors specified as the parameter. The
        /// parameter can be set to values between 2 and 255,
        /// but results are most noticeable in the lower
        /// ranges.
        /// 
        /// 
        /// 
        /// BLUR Executes a Gaussian blur with the level
        /// parameter specifying the extent of the blurring.
        /// If no parameter is used, the blur is equivalent to
        /// Gaussian blur of radius 1. Larger values increase
        /// the blur.
        /// 
        /// 
        /// 
        /// ERODE Reduces the light areas. No parameter is
        /// used.
        /// 
        /// 
        /// 
        /// DILATE Increases the light areas. No parameter is
        /// used.</summary>
        /// <param name="filterType">either THRESHOLD, GRAY, OPAQUE,
        /// INVERT, POSTERIZE, BLUR, ERODE, DILATE or BLUR.
        /// See Filters.js for docs on each available filter</param>
        /// <param name="filterParam">an optional parameter unique
        /// to each filter, see above</param>
        abstract filter: filterType: FILTER_TYPE * ?filterParam: float -> unit
        /// <summary>Returns an array of [R,G,B,A] values for any pixel
        /// or grabs a section of an image. If no parameters
        /// are specified, the entire image is returned. Use
        /// the x and y parameters to get the value of one
        /// pixel. Get a section of the display window by
        /// specifying additional w and h parameters. When
        /// getting an image, the x and y parameters define
        /// the coordinates for the upper-left corner of the
        /// image, regardless of the current imageMode().  If
        /// the pixel requested is outside of the image
        /// window, [0,0,0,255] is returned. To get the
        /// numbers scaled according to the current color
        /// ranges and taking into account colorMode, use
        /// getColor instead of get.
        /// 
        /// 
        /// Getting the color of a single pixel with get(x, y)
        /// is easy, but not as fast as grabbing the data
        /// directly from pixels[]. The equivalent statement
        /// to get(x, y) using pixels[] with pixel density d
        /// is  var x, y, d; // set these to the coordinates
        /// var off = (y  width + x)  d * 4; var components =
        /// [ pixels[off], pixels[off + 1], pixels[off + 2],
        /// pixels[off + 3] ]; print(components);
        /// 
        /// 
        /// See the reference for pixels[] for more
        /// information.
        /// 
        /// If you want to extract an array of colors or a
        /// subimage from an p5.Image object, take a look at
        /// p5.Image.get()</summary>
        /// <param name="x">x-coordinate of the pixel</param>
        /// <param name="y">y-coordinate of the pixel</param>
        /// <param name="w">width</param>
        /// <param name="h">height</param>
        abstract get: ?x: float * ?y: float * ?w: float * ?h: float -> U2<ResizeArray<float>, Image>
        /// Loads the pixel data for the display window into
        /// the pixels[] array. This function must always be
        /// called before reading from or writing to pixels[].
        /// Note that only changes made with set() or direct
        /// manipulation of pixels[] will occur.
        abstract loadPixels: unit -> unit
        /// <summary>Changes the color of any pixel, or writes an image
        /// directly to the display window. The x and y
        /// parameters specify the pixel to change and the c
        /// parameter specifies the color value. This can be a
        /// p5.Color object, or [R, G, B, A] pixel array. It
        /// can also be a single grayscale value. When setting
        /// an image, the x and y parameters define the
        /// coordinates for the upper-left corner of the
        /// image, regardless of the current imageMode().
        /// 
        /// 
        /// After using set(), you must call updatePixels()
        /// for your changes to appear. This should be called
        /// once all pixels have been set, and must be called
        /// before calling .get() or drawing the image.
        /// 
        /// Setting the color of a single pixel with set(x, y)
        /// is easy, but not as fast as putting the data
        /// directly into pixels[]. Setting the pixels[]
        /// values directly may be complicated when working
        /// with a retina display, but will perform better
        /// when lots of pixels need to be set directly on
        /// every loop.
        /// 
        /// See the reference for pixels[] for more
        /// information.</summary>
        /// <param name="x">x-coordinate of the pixel</param>
        /// <param name="y">y-coordinate of the pixel</param>
        /// <param name="c">insert a grayscale value | a pixel array
        /// | a p5.Color object | a p5.Image to copy</param>
        abstract set: x: float * y: float * c: U3<float, ResizeArray<float>, obj> -> unit
        /// <summary>Updates the display window with the data in the
        /// pixels[] array. Use in conjunction with
        /// loadPixels(). If you're only reading pixels from
        /// the array, there's no need to call updatePixels()
        /// — updating is only necessary to apply changes.
        /// updatePixels() should be called anytime the pixels
        /// array is manipulated or set() is called, and only
        /// changes made with set() or direct changes to
        /// pixels[] will occur.</summary>
        /// <param name="x">x-coordinate of the upper-left corner
        /// of region to update</param>
        /// <param name="y">y-coordinate of the upper-left corner
        /// of region to update</param>
        /// <param name="w">width of region to update</param>
        /// <param name="h">height of region to update</param>
        abstract updatePixels: ?x: float * ?y: float * ?w: float * ?h: float -> unit
        /// Uint8ClampedArray containing the values for all
        /// the pixels in the display window. These values are
        /// numbers. This array is the size (include an
        /// appropriate factor for pixelDensity) of the
        /// display window x4, representing the R, G, B, A
        /// values in order for each pixel, moving from left
        /// to right across each row, then down each column.
        /// Retina and other high density displays will have
        /// more pixels[] (by a factor of pixelDensity^2). For
        /// example, if the image is 100x100 pixels, there
        /// will be 40,000. On a retina display, there will be
        /// 160,000.  The first four values (indices 0-3) in
        /// the array will be the R, G, B, A values of the
        /// pixel at (0, 0). The second four values (indices
        /// 4-7) will contain the R, G, B, A values of the
        /// pixel at (1, 0). More generally, to set values for
        /// a pixel at (x, y):
        /// 
        /// var d = pixelDensity(); for (var i = 0; i < d;
        /// i++) { for (var j = 0; j < d; j++) { // loop over
        /// idx = 4 * ((y * d + j) * width * d + (x * d + i));
        /// pixels[idx] = r; pixels[idx+1] = g; pixels[idx+2]
        /// = b; pixels[idx+3] = a; } }
        /// 
        /// While the above method is complex, it is flexible
        /// enough to work with any pixelDensity. Note that
        /// set() will automatically take care of setting all
        /// the appropriate values in pixels[] for a given (x,
        /// y) at any pixelDensity, but the performance may
        /// not be as fast when lots of modifications are made
        /// to the pixel array.
        /// 
        /// 
        /// Before accessing this array, the data must loaded
        /// with the loadPixels() function. After the array
        /// data has been modified, the updatePixels()
        /// function must be run to update the changes.
        /// 
        /// 
        /// Note that this is not a standard javascript array.
        /// This means that standard javascript functions such
        /// as slice() or arrayCopy() do not work.
        abstract pixels: ResizeArray<float> with get, set
module P5 = ______index
let [<Import("*","p5/src/io/files")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract PrintWriter: PrintWriterStatic

    type [<AllowNullLiteral>] PrintWriter =
        /// <summary>Writes data to the PrintWriter stream</summary>
        /// <param name="data">all data to be written by the
        /// PrintWriter</param>
        abstract write: data: ResizeArray<obj option> -> unit
        /// <summary>Writes data to the PrintWriter stream, and adds a
        /// new line at the end</summary>
        /// <param name="data">all data to be printed by the
        /// PrintWriter</param>
        abstract print: data: ResizeArray<obj option> -> unit
        /// Clears the data already written to the PrintWriter
        /// object
        abstract clear: unit -> unit
        /// Closes the PrintWriter
        abstract close: unit -> unit

    type [<AllowNullLiteral>] PrintWriterStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> PrintWriter

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Loads a JSON file from a file or a URL, and
        /// returns an Object. Note that even if the JSON file
        /// contains an Array, an Object will be returned with
        /// index numbers as keys. This method is
        /// asynchronous, meaning it may not finish before the
        /// next line in your sketch is executed. JSONP is
        /// supported via a polyfill and you can pass in as
        /// the second argument an object with definitions of
        /// the json callback following the syntax specified
        /// here.
        /// 
        /// This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="jsonpOptions">options object for jsonp
        /// related settings</param>
        /// <param name="datatype">"json" or "jsonp"</param>
        /// <param name="callback">function to be executed after
        /// loadJSON() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract loadJSON: path: string * ?jsonpOptions: obj * ?datatype: string * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> U2<obj, ResizeArray<obj option>>
        /// <summary>Loads a JSON file from a file or a URL, and
        /// returns an Object. Note that even if the JSON file
        /// contains an Array, an Object will be returned with
        /// index numbers as keys. This method is
        /// asynchronous, meaning it may not finish before the
        /// next line in your sketch is executed. JSONP is
        /// supported via a polyfill and you can pass in as
        /// the second argument an object with definitions of
        /// the json callback following the syntax specified
        /// here.
        /// 
        /// This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="datatype">"json" or "jsonp"</param>
        /// <param name="callback">function to be executed after
        /// loadJSON() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract loadJSON: path: string * datatype: string * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> U2<obj, ResizeArray<obj option>>
        /// <summary>Loads a JSON file from a file or a URL, and
        /// returns an Object. Note that even if the JSON file
        /// contains an Array, an Object will be returned with
        /// index numbers as keys. This method is
        /// asynchronous, meaning it may not finish before the
        /// next line in your sketch is executed. JSONP is
        /// supported via a polyfill and you can pass in as
        /// the second argument an object with definitions of
        /// the json callback following the syntax specified
        /// here.
        /// 
        /// This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="callback">function to be executed after
        /// loadJSON() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract loadJSON: path: string * callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> U2<obj, ResizeArray<obj option>>
        /// <summary>Reads the contents of a file and creates a String
        /// array of its individual lines. If the name of the
        /// file is used as the parameter, as in the above
        /// example, the file must be located in the sketch
        /// directory/folder.  Alternatively, the file maybe
        /// be loaded from anywhere on the local computer
        /// using an absolute path (something that starts with
        /// / on Unix and Linux, or a drive letter on
        /// Windows), or the filename parameter can be a URL
        /// for a file found on a network.
        /// 
        /// 
        /// This method is asynchronous, meaning it may not
        /// finish before the next line in your sketch is
        /// executed.
        /// 
        /// This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="filename">name of the file or url to load</param>
        /// <param name="callback">function to be executed after
        /// loadStrings() completes, Array is passed in as
        /// first argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract loadStrings: filename: string * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> ResizeArray<string>
        /// <summary>Reads the contents of a file or URL and creates a
        /// p5.Table object with its values. If a file is
        /// specified, it must be located in the sketch's
        /// "data" folder. The filename parameter can also be
        /// a URL to a file found online. By default, the file
        /// is assumed to be comma-separated (in CSV format).
        /// Table only looks for a header row if the 'header'
        /// option is included. Possible options include:
        /// 
        /// - csv - parse the table as comma-separated values
        /// - tsv - parse the table as tab-separated values
        /// - header - this table has a header (title) row
        /// 
        /// When passing in multiple options, pass them in as
        /// separate parameters, seperated by commas. For
        /// example:
        /// 
        /// 
        /// loadTable('my_csv_file.csv', 'csv', 'header');
        /// 
        /// 
        /// All files loaded and saved use UTF-8 encoding.
        /// 
        /// This method is asynchronous, meaning it may not
        /// finish before the next line in your sketch is
        /// executed. Calling loadTable() inside preload()
        /// guarantees to complete the operation before
        /// setup() and draw() are called.
        /// 
        /// Outside of preload(), you may supply a callback
        /// function to handle the object:
        /// 
        /// 
        /// 
        /// This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="filename">name of the file or URL to load</param>
        /// <param name="options">"header" "csv" "tsv"</param>
        /// <param name="callback">function to be executed after
        /// loadTable() completes. On success, the Table
        /// object is passed in as the first argument.</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract loadTable: filename: string * options: string * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> obj
        /// <summary>Reads the contents of a file or URL and creates a
        /// p5.Table object with its values. If a file is
        /// specified, it must be located in the sketch's
        /// "data" folder. The filename parameter can also be
        /// a URL to a file found online. By default, the file
        /// is assumed to be comma-separated (in CSV format).
        /// Table only looks for a header row if the 'header'
        /// option is included. Possible options include:
        /// 
        /// - csv - parse the table as comma-separated values
        /// - tsv - parse the table as tab-separated values
        /// - header - this table has a header (title) row
        /// 
        /// When passing in multiple options, pass them in as
        /// separate parameters, seperated by commas. For
        /// example:
        /// 
        /// 
        /// loadTable('my_csv_file.csv', 'csv', 'header');
        /// 
        /// 
        /// All files loaded and saved use UTF-8 encoding.
        /// 
        /// This method is asynchronous, meaning it may not
        /// finish before the next line in your sketch is
        /// executed. Calling loadTable() inside preload()
        /// guarantees to complete the operation before
        /// setup() and draw() are called.
        /// 
        /// Outside of preload(), you may supply a callback
        /// function to handle the object:
        /// 
        /// 
        /// 
        /// This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="filename">name of the file or URL to load</param>
        /// <param name="callback">function to be executed after
        /// loadTable() completes. On success, the Table
        /// object is passed in as the first argument.</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract loadTable: filename: string * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> obj
        /// <summary>Reads the contents of a file and creates an XML
        /// object with its values. If the name of the file is
        /// used as the parameter, as in the above example,
        /// the file must be located in the sketch
        /// directory/folder. Alternatively, the file maybe be
        /// loaded from anywhere on the local computer using
        /// an absolute path (something that starts with / on
        /// Unix and Linux, or a drive letter on Windows), or
        /// the filename parameter can be a URL for a file
        /// found on a network.
        /// 
        /// This method is asynchronous, meaning it may not
        /// finish before the next line in your sketch is
        /// executed. Calling loadXML() inside preload()
        /// guarantees to complete the operation before
        /// setup() and draw() are called.
        /// 
        /// Outside of preload(), you may supply a callback
        /// function to handle the object.
        /// 
        /// This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="filename">name of the file or URL to load</param>
        /// <param name="callback">function to be executed after
        /// loadXML() completes, XML object is passed in as
        /// first argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract loadXML: filename: string * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> obj
        /// <summary>This method is suitable for fetching files up to
        /// size of 64MB.</summary>
        /// <param name="file">name of the file or URL to load</param>
        /// <param name="callback">function to be executed after
        /// loadBytes() completes</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error</param>
        abstract loadBytes: file: string * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> obj
        /// <summary>Method for executing an HTTP GET request. If data
        /// type is not specified, p5 will try to guess based
        /// on the URL, defaulting to text. This is equivalent
        /// to calling httpDo(path, 'GET'). The 'binary'
        /// datatype will return a Blob object, and the
        /// 'arrayBuffer' datatype will return an ArrayBuffer
        /// which can be used to initialize typed arrays (such
        /// as Uint8Array).</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="datatype">"json", "jsonp", "binary",
        /// "arrayBuffer", "xml", or "text"</param>
        /// <param name="data">param data passed sent with request</param>
        /// <param name="callback">function to be executed after
        /// httpGet() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpGet: path: string * ?datatype: string * ?data: U2<obj, bool> * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        /// <summary>Method for executing an HTTP GET request. If data
        /// type is not specified, p5 will try to guess based
        /// on the URL, defaulting to text. This is equivalent
        /// to calling httpDo(path, 'GET'). The 'binary'
        /// datatype will return a Blob object, and the
        /// 'arrayBuffer' datatype will return an ArrayBuffer
        /// which can be used to initialize typed arrays (such
        /// as Uint8Array).</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="data">param data passed sent with request</param>
        /// <param name="callback">function to be executed after
        /// httpGet() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpGet: path: string * data: U2<obj, bool> * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        /// <summary>Method for executing an HTTP GET request. If data
        /// type is not specified, p5 will try to guess based
        /// on the URL, defaulting to text. This is equivalent
        /// to calling httpDo(path, 'GET'). The 'binary'
        /// datatype will return a Blob object, and the
        /// 'arrayBuffer' datatype will return an ArrayBuffer
        /// which can be used to initialize typed arrays (such
        /// as Uint8Array).</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="callback">function to be executed after
        /// httpGet() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpGet: path: string * callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        /// <summary>Method for executing an HTTP POST request. If data
        /// type is not specified, p5 will try to guess based
        /// on the URL, defaulting to text. This is equivalent
        /// to calling httpDo(path, 'POST').</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="datatype">"json", "jsonp", "xml", or
        /// "text". If omitted, httpPost() will guess.</param>
        /// <param name="data">param data passed sent with request</param>
        /// <param name="callback">function to be executed after
        /// httpPost() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpPost: path: string * ?datatype: string * ?data: U2<obj, bool> * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        /// <summary>Method for executing an HTTP POST request. If data
        /// type is not specified, p5 will try to guess based
        /// on the URL, defaulting to text. This is equivalent
        /// to calling httpDo(path, 'POST').</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="data">param data passed sent with request</param>
        /// <param name="callback">function to be executed after
        /// httpPost() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpPost: path: string * data: U2<obj, bool> * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        /// <summary>Method for executing an HTTP POST request. If data
        /// type is not specified, p5 will try to guess based
        /// on the URL, defaulting to text. This is equivalent
        /// to calling httpDo(path, 'POST').</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="callback">function to be executed after
        /// httpPost() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpPost: path: string * callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        /// <summary>Method for executing an HTTP request. If data type
        /// is not specified, p5 will try to guess based on
        /// the URL, defaulting to text. For more advanced
        /// use, you may also pass in the path as the first
        /// argument and a object as the second argument, the
        /// signature follows the one specified in the Fetch
        /// API specification. This method is suitable for
        /// fetching files up to size of 64MB when "GET" is
        /// used.</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="method">either "GET", "POST", or "PUT",
        /// defaults to "GET"</param>
        /// <param name="datatype">"json", "jsonp", "xml", or
        /// "text"</param>
        /// <param name="data">param data passed sent with request</param>
        /// <param name="callback">function to be executed after
        /// httpGet() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpDo: path: string * ?``method``: string * ?datatype: string * ?data: obj * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        /// <summary>Method for executing an HTTP request. If data type
        /// is not specified, p5 will try to guess based on
        /// the URL, defaulting to text. For more advanced
        /// use, you may also pass in the path as the first
        /// argument and a object as the second argument, the
        /// signature follows the one specified in the Fetch
        /// API specification. This method is suitable for
        /// fetching files up to size of 64MB when "GET" is
        /// used.</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="options">Request object options as
        /// documented in the "fetch" API reference</param>
        /// <param name="callback">function to be executed after
        /// httpGet() completes, data is passed in as first
        /// argument</param>
        /// <param name="errorCallback">function to be executed if
        /// there is an error, response is passed in as first
        /// argument</param>
        abstract httpDo: path: string * options: obj * ?callback: (ResizeArray<obj option> -> obj option) * ?errorCallback: (ResizeArray<obj option> -> obj option) -> Promise<obj option>
        abstract createWriter: name: string * ?extension: string -> PrintWriter
        /// <summary>Save an image, text, json, csv, wav, or html.
        /// Prompts download to the client's computer. Note
        /// that it is not recommended to call save() within
        /// draw if it's looping, as the save() function will
        /// open a new save dialog every frame. The default
        /// behavior is to save the canvas as an image. You
        /// can optionally specify a filename. For example:
        /// 
        /// 
        /// save(); save('myCanvas.jpg'); // save a specific
        /// canvas with a filename
        /// 
        /// Alternately, the first parameter can be a pointer
        /// to a canvas p5.Element, an Array of Strings, an
        /// Array of JSON, a JSON object, a p5.Table, a
        /// p5.Image, or a p5.SoundFile (requires p5.sound).
        /// The second parameter is a filename (including
        /// extension). The third parameter is for options
        /// specific to this type of object. This method will
        /// save a file that fits the given parameters. For
        /// example:
        /// 
        /// 
        /// // Saves canvas as an image save('myCanvas.jpg');
        /// // Saves pImage as a png image var img =
        /// createImage(10, 10); save(img, 'my.png'); // Saves
        /// canvas as an image var cnv = createCanvas(100,
        /// 100); save(cnv, 'myCanvas.jpg'); // Saves
        /// p5.Renderer object as an image var gb =
        /// createGraphics(100, 100); save(gb,
        /// 'myGraphics.jpg'); var myTable = new p5.Table();
        /// // Saves table as html file save(myTable,
        /// 'myTable.html'); // Comma Separated Values
        /// save(myTable, 'myTable.csv'); // Tab Separated
        /// Values save(myTable, 'myTable.tsv'); var myJSON =
        /// { a: 1, b: true }; // Saves pretty JSON
        /// save(myJSON, 'my.json'); // Optimizes JSON
        /// filesize save(myJSON, 'my.json', true); // Saves
        /// array of strings to a text file with line breaks
        /// after each item var arrayOfStrings = ['a', 'b'];
        /// save(arrayOfStrings, 'my.txt');</summary>
        /// <param name="objectOrFilename">If filename is provided,
        /// will save canvas as an image with either png or
        /// jpg extension depending on the filename. If object
        /// is provided, will save depending on the object and
        /// filename (see examples above).</param>
        /// <param name="filename">If an object is provided as the
        /// first parameter, then the second parameter
        /// indicates the filename, and should include an
        /// appropriate file extension (see examples above).</param>
        /// <param name="options">Additional options depend on
        /// filetype. For example, when saving JSON, true
        /// indicates that the output will be optimized for
        /// filesize, rather than readability.</param>
        abstract save: ?objectOrFilename: U2<obj, string> * ?filename: string * ?options: U2<bool, string> -> unit
        /// <summary>Writes the contents of an Array or a JSON object
        /// to a .json file. The file saving process and
        /// location of the saved file will vary between web
        /// browsers.</summary>
        /// <param name="optimize">If true, removes line breaks and
        /// spaces from the output file to optimize filesize
        /// (but not readability).</param>
        abstract saveJSON: json: U2<ResizeArray<obj option>, obj> * filename: string * ?optimize: bool -> unit
        /// <summary>Writes an array of Strings to a text file, one
        /// line per String. The file saving process and
        /// location of the saved file will vary between web
        /// browsers.</summary>
        /// <param name="list">string array to be written</param>
        /// <param name="filename">filename for output</param>
        /// <param name="extension">the filename's extension</param>
        abstract saveStrings: list: ResizeArray<string> * filename: string * ?extension: string -> unit
        /// <summary>Writes the contents of a Table object to a file.
        /// Defaults to a text file with
        /// comma-separated-values ('csv') but can also use
        /// tab separation ('tsv'), or generate an HTML table
        /// ('html'). The file saving process and location of
        /// the saved file will vary between web browsers.</summary>
        /// <param name="Table">the Table object to save to a file</param>
        /// <param name="filename">the filename to which the Table
        /// should be saved</param>
        /// <param name="options">can be one of "tsv", "csv", or
        /// "html"</param>
        abstract saveTable: Table: Table * filename: string * ?options: string -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Calculates the absolute value (magnitude) of a
        /// number. Maps to Math.abs(). The absolute value of
        /// a number is always positive.</summary>
        /// <param name="n">number to compute</param>
        abstract abs: n: float -> float
        /// <summary>Calculates the closest int value that is greater
        /// than or equal to the value of the parameter. Maps
        /// to Math.ceil(). For example, ceil(9.03) returns
        /// the value 10.</summary>
        /// <param name="n">number to round up</param>
        abstract ceil: n: float -> float
        /// <summary>Constrains a value between a minimum and maximum
        /// value.</summary>
        /// <param name="n">number to constrain</param>
        /// <param name="low">minimum limit</param>
        /// <param name="high">maximum limit</param>
        abstract constrain: n: float * low: float * high: float -> float
        /// <summary>Calculates the distance between two points.</summary>
        /// <param name="x1">x-coordinate of the first point</param>
        /// <param name="y1">y-coordinate of the first point</param>
        /// <param name="x2">x-coordinate of the second point</param>
        /// <param name="y2">y-coordinate of the second point</param>
        abstract dist: x1: float * y1: float * x2: float * y2: float -> float
        /// <summary>Calculates the distance between two points.</summary>
        /// <param name="x1">x-coordinate of the first point</param>
        /// <param name="y1">y-coordinate of the first point</param>
        /// <param name="z1">z-coordinate of the first point</param>
        /// <param name="x2">x-coordinate of the second point</param>
        /// <param name="y2">y-coordinate of the second point</param>
        /// <param name="z2">z-coordinate of the second point</param>
        abstract dist: x1: float * y1: float * z1: float * x2: float * y2: float * z2: float -> float
        /// <summary>Returns Euler's number e (2.71828...) raised to
        /// the power of the n parameter. Maps to Math.exp().</summary>
        /// <param name="n">exponent to raise</param>
        abstract exp: n: float -> float
        /// <summary>Calculates the closest int value that is less than
        /// or equal to the value of the parameter. Maps to
        /// Math.floor().</summary>
        /// <param name="n">number to round down</param>
        abstract floor: n: float -> float
        /// <summary>Calculates a number between two numbers at a
        /// specific increment. The amt parameter is the
        /// amount to interpolate between the two values where
        /// 0.0 equal to the first point, 0.1 is very near the
        /// first point, 0.5 is half-way in between, etc. The
        /// lerp function is convenient for creating motion
        /// along a straight path and for drawing dotted
        /// lines.</summary>
        /// <param name="start">first value</param>
        /// <param name="stop">second value</param>
        /// <param name="amt">number between 0.0 and 1.0</param>
        abstract lerp: start: float * stop: float * amt: float -> float
        /// <summary>Calculates the natural logarithm (the base-e
        /// logarithm) of a number. This function expects the
        /// n parameter to be a value greater than 0.0. Maps
        /// to Math.log().</summary>
        /// <param name="n">number greater than 0</param>
        abstract log: n: float -> float
        /// <summary>Calculates the magnitude (or length) of a vector.
        /// A vector is a direction in space commonly used in
        /// computer graphics and linear algebra. Because it
        /// has no "start" position, the magnitude of a vector
        /// can be thought of as the distance from the
        /// coordinate 0,0 to its x,y value. Therefore, mag()
        /// is a shortcut for writing dist(0, 0, x, y).</summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        abstract mag: a: float * b: float -> float
        /// <summary>Re-maps a number from one range to another.  In
        /// the first example above, the number 25 is
        /// converted from a value in the range of 0 to 100
        /// into a value that ranges from the left edge of the
        /// window (0) to the right edge (width).</summary>
        /// <param name="value">the incoming value to be converted</param>
        /// <param name="start1">lower bound of the value's current
        /// range</param>
        /// <param name="stop1">upper bound of the value's current
        /// range</param>
        /// <param name="start2">lower bound of the value's target
        /// range</param>
        /// <param name="stop2">upper bound of the value's target
        /// range</param>
        /// <param name="withinBounds">constrain the value to the
        /// newly mapped range</param>
        abstract map: value: float * start1: float * stop1: float * start2: float * stop2: float * ?withinBounds: bool -> float
        /// <summary>Determines the largest value in a sequence of
        /// numbers, and then returns that value. max()
        /// accepts any number of Number parameters, or an
        /// Array of any length.</summary>
        /// <param name="n0">Number to compare</param>
        /// <param name="n1">Number to compare</param>
        abstract max: n0: float * n1: float -> float
        /// <summary>Determines the largest value in a sequence of
        /// numbers, and then returns that value. max()
        /// accepts any number of Number parameters, or an
        /// Array of any length.</summary>
        /// <param name="nums">Numbers to compare</param>
        abstract max: nums: ResizeArray<float> -> float
        /// <summary>Determines the smallest value in a sequence of
        /// numbers, and then returns that value. min()
        /// accepts any number of Number parameters, or an
        /// Array of any length.</summary>
        /// <param name="n0">Number to compare</param>
        /// <param name="n1">Number to compare</param>
        abstract min: n0: float * n1: float -> float
        /// <summary>Determines the smallest value in a sequence of
        /// numbers, and then returns that value. min()
        /// accepts any number of Number parameters, or an
        /// Array of any length.</summary>
        /// <param name="nums">Numbers to compare</param>
        abstract min: nums: ResizeArray<float> -> float
        /// <summary>Normalizes a number from another range into a
        /// value between 0 and 1. Identical to map(value,
        /// low, high, 0, 1). Numbers outside of the range are
        /// not clamped to 0 and 1, because out-of-range
        /// values are often intentional and useful. (See the
        /// second example above.)</summary>
        /// <param name="value">incoming value to be normalized</param>
        /// <param name="start">lower bound of the value's current
        /// range</param>
        /// <param name="stop">upper bound of the value's current
        /// range</param>
        abstract norm: value: float * start: float * stop: float -> float
        /// <summary>Facilitates exponential expressions. The pow()
        /// function is an efficient way of multiplying
        /// numbers by themselves (or their reciprocals) in
        /// large quantities. For example, pow(3, 5) is
        /// equivalent to the expression 33333 and pow(3, -5)
        /// is equivalent to 1 / 33333. Maps to Math.pow().</summary>
        /// <param name="n">base of the exponential expression</param>
        /// <param name="e">power by which to raise the base</param>
        abstract pow: n: float * e: float -> float
        /// <summary>Calculates the integer closest to the n parameter.
        /// For example, round(133.8) returns the value 134.
        /// Maps to Math.round().</summary>
        /// <param name="n">number to round</param>
        abstract round: n: float -> float
        /// <summary>Squares a number (multiplies a number by itself).
        /// The result is always a positive number, as
        /// multiplying two negative numbers always yields a
        /// positive result. For example, -1 * -1 = 1.</summary>
        /// <param name="n">number to square</param>
        abstract sq: n: float -> float
        /// <summary>Calculates the square root of a number. The square
        /// root of a number is always positive, even though
        /// there may be a valid negative root. The square
        /// root s of number a is such that s*s = a. It is the
        /// opposite of squaring. Maps to Math.sqrt().</summary>
        /// <param name="n">non-negative number to square root</param>
        abstract sqrt: n: float -> float
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Creates a new p5.Vector (the datatype for storing
        /// vectors). This provides a two or three dimensional
        /// vector, specifically a Euclidean (also known as
        /// geometric) vector. A vector is an entity that has
        /// both magnitude and direction.</summary>
        /// <param name="x">x component of the vector</param>
        /// <param name="y">y component of the vector</param>
        /// <param name="z">z component of the vector</param>
        abstract createVector: ?x: float * ?y: float * ?z: float -> Vector
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Returns the Perlin noise value at specified
        /// coordinates. Perlin noise is a random sequence
        /// generator producing a more natural ordered,
        /// harmonic succession of numbers compared to the
        /// standard random() function. It was invented by Ken
        /// Perlin in the 1980s and been used since in
        /// graphical applications to produce procedural
        /// textures, natural motion, shapes, terrains etc.
        /// The main difference to the random() function is
        /// that Perlin noise is defined in an infinite
        /// n-dimensional space where each pair of coordinates
        /// corresponds to a fixed semi-random value (fixed
        /// only for the lifespan of the program; see the
        /// noiseSeed() function). p5.js can compute 1D, 2D
        /// and 3D noise, depending on the number of
        /// coordinates given. The resulting value will always
        /// be between 0.0 and 1.0. The noise value can be
        /// animated by moving through the noise space as
        /// demonstrated in the example above. The 2nd and 3rd
        /// dimension can also be interpreted as time.
        /// 
        /// The actual noise is structured similar to an audio
        /// signal, in respect to the function's use of
        /// frequencies. Similar to the concept of harmonics
        /// in physics, perlin noise is computed over several
        /// octaves which are added together for the final
        /// result.
        /// 
        /// Another way to adjust the character of the
        /// resulting sequence is the scale of the input
        /// coordinates. As the function works within an
        /// infinite space the value of the coordinates
        /// doesn't matter as such, only the distance between
        /// successive coordinates does (eg. when using
        /// noise() within a loop). As a general rule the
        /// smaller the difference between coordinates, the
        /// smoother the resulting noise sequence will be.
        /// Steps of 0.005-0.03 work best for most
        /// applications, but this will differ depending on
        /// use.</summary>
        /// <param name="x">x-coordinate in noise space</param>
        /// <param name="y">y-coordinate in noise space</param>
        /// <param name="z">z-coordinate in noise space</param>
        abstract noise: x: float * ?y: float * ?z: float -> float
        /// <summary>Adjusts the character and level of detail produced
        /// by the Perlin noise function. Similar to harmonics
        /// in physics, noise is computed over several
        /// octaves. Lower octaves contribute more to the
        /// output signal and as such define the overall
        /// intensity of the noise, whereas higher octaves
        /// create finer grained details in the noise
        /// sequence.  By default, noise is computed over 4
        /// octaves with each octave contributing exactly half
        /// than its predecessor, starting at 50% strength for
        /// the 1st octave. This falloff amount can be changed
        /// by adding an additional function parameter. Eg. a
        /// falloff factor of 0.75 means each octave will now
        /// have 75% impact (25% less) of the previous lower
        /// octave. Any value between 0.0 and 1.0 is valid,
        /// however note that values greater than 0.5 might
        /// result in greater than 1.0 values returned by
        /// noise().
        /// 
        /// 
        /// By changing these parameters, the signal created
        /// by the noise() function can be adapted to fit very
        /// specific needs and characteristics.</summary>
        /// <param name="lod">number of octaves to be used by the
        /// noise</param>
        /// <param name="falloff">falloff factor for each octave</param>
        abstract noiseDetail: lod: float * falloff: float -> unit
        /// <summary>Sets the seed value for noise(). By default,
        /// noise() produces different results each time the
        /// program is run. Set the value parameter to a
        /// constant to return the same pseudo-random numbers
        /// each time the software is run.</summary>
        /// <param name="seed">the seed value</param>
        abstract noiseSeed: seed: float -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Sets the seed value for random(). By default,
        /// random() produces different results each time the
        /// program is run. Set the seed parameter to a
        /// constant to return the same pseudo-random numbers
        /// each time the software is run.</summary>
        /// <param name="seed">the seed value</param>
        abstract randomSeed: seed: float -> unit
        /// <summary>Return a random floating-point number. Takes
        /// either 0, 1 or 2 arguments.
        /// 
        /// If no argument is given, returns a random number
        /// from 0 up to (but not including) 1.
        /// 
        /// If one argument is given and it is a number,
        /// returns a random number from 0 up to (but not
        /// including) the number.
        /// 
        /// If one argument is given and it is an array,
        /// returns a random element from that array.
        /// 
        /// If two arguments are given, returns a random
        /// number from the first argument up to (but not
        /// including) the second argument.</summary>
        /// <param name="min">the lower bound (inclusive)</param>
        /// <param name="max">the upper bound (exclusive)</param>
        abstract random: ?min: float * ?max: float -> float
        /// <summary>Return a random floating-point number. Takes
        /// either 0, 1 or 2 arguments.
        /// 
        /// If no argument is given, returns a random number
        /// from 0 up to (but not including) 1.
        /// 
        /// If one argument is given and it is a number,
        /// returns a random number from 0 up to (but not
        /// including) the number.
        /// 
        /// If one argument is given and it is an array,
        /// returns a random element from that array.
        /// 
        /// If two arguments are given, returns a random
        /// number from the first argument up to (but not
        /// including) the second argument.</summary>
        /// <param name="choices">the array to choose from</param>
        abstract random: choices: ResizeArray<obj option> -> obj option
        /// <summary>Returns a random number fitting a Gaussian, or
        /// normal, distribution. There is theoretically no
        /// minimum or maximum value that randomGaussian()
        /// might return. Rather, there is just a very low
        /// probability that values far from the mean will be
        /// returned; and a higher probability that numbers
        /// near the mean will be returned.  Takes either 0, 1
        /// or 2 arguments.
        /// 
        /// If no args, returns a mean of 0 and standard
        /// deviation of 1.
        /// 
        /// If one arg, that arg is the mean (standard
        /// deviation is 1).
        /// 
        /// If two args, first is mean, second is standard
        /// deviation.</summary>
        /// <param name="mean">the mean</param>
        /// <param name="sd">the standard deviation</param>
        abstract randomGaussian: mean: float * sd: float -> float
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>The inverse of cos(), returns the arc cosine of a
        /// value. This function expects the values in the
        /// range of -1 to 1 and values are returned in the
        /// range 0 to PI (3.1415927).</summary>
        /// <param name="value">the value whose arc cosine is to be
        /// returned</param>
        abstract acos: value: float -> float
        /// <summary>The inverse of sin(), returns the arc sine of a
        /// value. This function expects the values in the
        /// range of -1 to 1 and values are returned in the
        /// range -PI/2 to PI/2.</summary>
        /// <param name="value">the value whose arc sine is to be
        /// returned</param>
        abstract asin: value: float -> float
        /// <summary>The inverse of tan(), returns the arc tangent of a
        /// value. This function expects the values in the
        /// range of -Infinity to Infinity (exclusive) and
        /// values are returned in the range -PI/2 to PI/2.</summary>
        /// <param name="value">the value whose arc tangent is to be
        /// returned</param>
        abstract atan: value: float -> float
        /// <summary>Calculates the angle (in radians) from a specified
        /// point to the coordinate origin as measured from
        /// the positive x-axis. Values are returned as a
        /// float in the range from PI to -PI. The atan2()
        /// function is most often used for orienting geometry
        /// to the position of the cursor.  Note: The
        /// y-coordinate of the point is the first parameter,
        /// and the x-coordinate is the second parameter, due
        /// the the structure of calculating the tangent.</summary>
        /// <param name="y">y-coordinate of the point</param>
        /// <param name="x">x-coordinate of the point</param>
        abstract atan2: y: float * x: float -> float
        /// <summary>Calculates the cosine of an angle. This function
        /// takes into account the current angleMode. Values
        /// are returned in the range -1 to 1.</summary>
        /// <param name="angle">the angle</param>
        abstract cos: angle: float -> float
        /// <summary>Calculates the sine of an angle. This function
        /// takes into account the current angleMode. Values
        /// are returned in the range -1 to 1.</summary>
        /// <param name="angle">the angle</param>
        abstract sin: angle: float -> float
        /// <summary>Calculates the tangent of an angle. This function
        /// takes into account the current angleMode. Values
        /// are returned in the range -1 to 1.</summary>
        /// <param name="angle">the angle</param>
        abstract tan: angle: float -> float
        /// <summary>Converts a radian measurement to its corresponding
        /// value in degrees. Radians and degrees are two ways
        /// of measuring the same thing. There are 360 degrees
        /// in a circle and 2*PI radians in a circle. For
        /// example, 90° = PI/2 = 1.5707964. This function
        /// does not take into account the current angleMode.</summary>
        /// <param name="radians">the radians value to convert to
        /// degrees</param>
        abstract degrees: radians: float -> float
        /// <summary>Converts a degree measurement to its corresponding
        /// value in radians. Radians and degrees are two ways
        /// of measuring the same thing. There are 360 degrees
        /// in a circle and 2*PI radians in a circle. For
        /// example, 90° = PI/2 = 1.5707964. This function
        /// does not take into account the current angleMode.</summary>
        /// <param name="degrees">the degree value to convert to
        /// radians</param>
        abstract radians: degrees: float -> float
        /// <summary>Sets the current mode of p5 to given mode. Default
        /// mode is RADIANS.</summary>
        /// <param name="mode">either RADIANS or DEGREES</param>
        abstract angleMode: mode: ANGLE_MODE -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Sets the current alignment for drawing text.
        /// Accepts two arguments: horizAlign (LEFT, CENTER,
        /// or RIGHT) and vertAlign (TOP, BOTTOM, CENTER, or
        /// BASELINE). The horizAlign parameter is in
        /// reference to the x value of the text() function,
        /// while the vertAlign parameter is in reference to
        /// the y value.
        /// 
        /// So if you write textAlign(LEFT), you are aligning
        /// the left edge of your text to the x value you give
        /// in text(). If you write textAlign(RIGHT, TOP), you
        /// are aligning the right edge of your text to the x
        /// value and the top of edge of the text to the y
        /// value.</summary>
        /// <param name="horizAlign">horizontal alignment, either
        /// LEFT, CENTER, or RIGHT</param>
        /// <param name="vertAlign">vertical alignment, either TOP,
        /// BOTTOM, CENTER, or BASELINE</param>
        abstract textAlign: horizAlign: HORIZ_ALIGN * ?vertAlign: VERT_ALIGN -> p5
        /// Sets the current alignment for drawing text.
        /// Accepts two arguments: horizAlign (LEFT, CENTER,
        /// or RIGHT) and vertAlign (TOP, BOTTOM, CENTER, or
        /// BASELINE). The horizAlign parameter is in
        /// reference to the x value of the text() function,
        /// while the vertAlign parameter is in reference to
        /// the y value.
        /// 
        /// So if you write textAlign(LEFT), you are aligning
        /// the left edge of your text to the x value you give
        /// in text(). If you write textAlign(RIGHT, TOP), you
        /// are aligning the right edge of your text to the x
        /// value and the top of edge of the text to the y
        /// value.
        abstract textAlign: unit -> obj
        /// <summary>Sets/gets the spacing, in pixels, between lines of
        /// text. This setting will be used in all subsequent
        /// calls to the text() function.</summary>
        /// <param name="leading">the size in pixels for spacing
        /// between lines</param>
        abstract textLeading: leading: float -> p5
        /// Sets/gets the spacing, in pixels, between lines of
        /// text. This setting will be used in all subsequent
        /// calls to the text() function.
        abstract textLeading: unit -> float
        /// <summary>Sets/gets the current font size. This size will be
        /// used in all subsequent calls to the text()
        /// function. Font size is measured in pixels.</summary>
        /// <param name="theSize">the size of the letters in units of
        /// pixels</param>
        abstract textSize: theSize: float -> p5
        /// Sets/gets the current font size. This size will be
        /// used in all subsequent calls to the text()
        /// function. Font size is measured in pixels.
        abstract textSize: unit -> float
        /// <summary>Sets/gets the style of the text for system fonts
        /// to NORMAL, ITALIC, or BOLD. Note: this may be is
        /// overridden by CSS styling. For non-system fonts
        /// (opentype, truetype, etc.) please load styled
        /// fonts instead.</summary>
        /// <param name="theStyle">styling for text, either NORMAL,
        /// ITALIC, or BOLD</param>
        abstract textStyle: theStyle: THE_STYLE -> p5
        /// Sets/gets the style of the text for system fonts
        /// to NORMAL, ITALIC, or BOLD. Note: this may be is
        /// overridden by CSS styling. For non-system fonts
        /// (opentype, truetype, etc.) please load styled
        /// fonts instead.
        abstract textStyle: unit -> string
        /// <summary>Calculates and returns the width of any character
        /// or text string.</summary>
        /// <param name="theText">the String of characters to measure</param>
        abstract textWidth: theText: string -> float
        /// Returns the ascent of the current font at its
        /// current size. The ascent represents the distance,
        /// in pixels, of the tallest character above the
        /// baseline.
        abstract textAscent: unit -> float
        /// Returns the descent of the current font at its
        /// current size. The descent represents the distance,
        /// in pixels, of the character with the longest
        /// descender below the baseline.
        abstract textDescent: unit -> float
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Loads an opentype font file (.otf, .ttf) from a
        /// file or a URL, and returns a PFont Object. This
        /// method is asynchronous, meaning it may not finish
        /// before the next line in your sketch is executed.
        /// The path to the font should be relative to the
        /// HTML file that links in your sketch. Loading an
        /// from a URL or other remote location may be blocked
        /// due to your browser's built-in security.</summary>
        /// <param name="path">name of the file or url to load</param>
        /// <param name="callback">function to be executed after
        /// loadFont() completes</param>
        /// <param name="onError">function to be executed if an
        /// error occurs</param>
        abstract loadFont: path: string * ?callback: (ResizeArray<obj option> -> obj option) * ?onError: (ResizeArray<obj option> -> obj option) -> Font
        /// <summary>Draws text to the screen. Displays the information
        /// specified in the first parameter on the screen in
        /// the position specified by the additional
        /// parameters. A default font will be used unless a
        /// font is set with the textFont() function and a
        /// default size will be used unless a font is set
        /// with textSize(). Change the color of the text with
        /// the fill() function. Change the outline of the
        /// text with the stroke() and strokeWeight()
        /// functions.  The text displays in relation to the
        /// textAlign() function, which gives the option to
        /// draw to the left, right, and center of the
        /// coordinates.
        /// 
        /// 
        /// The x2 and y2 parameters define a rectangular area
        /// to display within and may only be used with string
        /// data. When these parameters are specified, they
        /// are interpreted based on the current rectMode()
        /// setting. Text that does not fit completely within
        /// the rectangle specified will not be drawn to the
        /// screen. If x2 and y2 are not specified, the
        /// baseline alignment is the default, which means
        /// that the text will be drawn upwards from x and y.
        /// 
        /// 
        /// WEBGL: Only opentype/truetype fonts are supported.
        /// You must load a font using the loadFont() method
        /// (see the example above). stroke() currently has no
        /// effect in webgl mode.</summary>
        /// <param name="str">the alphanumeric symbols to be
        /// displayed</param>
        /// <param name="x">x-coordinate of text</param>
        /// <param name="y">y-coordinate of text</param>
        /// <param name="x2">by default, the width of the text box,
        /// see rectMode() for more info</param>
        /// <param name="y2">by default, the height of the text
        /// box, see rectMode() for more info</param>
        abstract text: str: U5<string, obj, ResizeArray<obj option>, float, bool> * x: float * y: float * ?x2: float * ?y2: float -> p5
        /// Sets the current font that will be drawn with the
        /// text() function.  WEBGL: Only fonts loaded via
        /// loadFont() are supported.
        abstract textFont: unit -> obj
        /// <summary>Sets the current font that will be drawn with the
        /// text() function.  WEBGL: Only fonts loaded via
        /// loadFont() are supported.</summary>
        /// <param name="font">a font loaded via loadFont(), or a
        /// String representing a web safe font (a font that
        /// is generally available across all systems)</param>
        /// <param name="size">the font size to use</param>
        abstract textFont: font: U2<obj, string> * ?size: float -> p5
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Adds a value to the end of an array. Extends the
        /// length of the array by one. Maps to Array.push().</summary>
        /// <param name="array">Array to append</param>
        /// <param name="value">to be added to the Array</param>
        abstract append: array: ResizeArray<obj option> * value: obj option -> ResizeArray<obj option>
        /// <summary>Copies an array (or part of an array) to another
        /// array. The src array is copied to the dst array,
        /// beginning at the position specified by srcPosition
        /// and into the position specified by dstPosition.
        /// The number of elements to copy is determined by
        /// length. Note that copying values overwrites
        /// existing values in the destination array. To
        /// append values instead of overwriting them, use
        /// concat().  The simplified version with only two
        /// arguments, arrayCopy(src, dst), copies an entire
        /// array to another of the same size. It is
        /// equivalent to arrayCopy(src, 0, dst, 0,
        /// src.length).
        /// 
        /// 
        /// Using this function is far more efficient for
        /// copying array data than iterating through a for()
        /// loop and copying each element individually.</summary>
        /// <param name="src">the source Array</param>
        /// <param name="srcPosition">starting position in the source
        /// Array</param>
        /// <param name="dst">the destination Array</param>
        /// <param name="dstPosition">starting position in the
        /// destination Array</param>
        /// <param name="length">number of Array elements to be
        /// copied</param>
        abstract arrayCopy: src: ResizeArray<obj option> * srcPosition: float * dst: ResizeArray<obj option> * dstPosition: float * length: float -> unit
        /// <summary>Copies an array (or part of an array) to another
        /// array. The src array is copied to the dst array,
        /// beginning at the position specified by srcPosition
        /// and into the position specified by dstPosition.
        /// The number of elements to copy is determined by
        /// length. Note that copying values overwrites
        /// existing values in the destination array. To
        /// append values instead of overwriting them, use
        /// concat().  The simplified version with only two
        /// arguments, arrayCopy(src, dst), copies an entire
        /// array to another of the same size. It is
        /// equivalent to arrayCopy(src, 0, dst, 0,
        /// src.length).
        /// 
        /// 
        /// Using this function is far more efficient for
        /// copying array data than iterating through a for()
        /// loop and copying each element individually.</summary>
        /// <param name="src">the source Array</param>
        /// <param name="dst">the destination Array</param>
        /// <param name="length">number of Array elements to be
        /// copied</param>
        abstract arrayCopy: src: ResizeArray<obj option> * dst: ResizeArray<obj option> * ?length: float -> unit
        /// <summary>Concatenates two arrays, maps to Array.concat().
        /// Does not modify the input arrays.</summary>
        /// <param name="a">first Array to concatenate</param>
        /// <param name="b">second Array to concatenate</param>
        abstract concat: a: ResizeArray<obj option> * b: ResizeArray<obj option> -> ResizeArray<obj option>
        /// <summary>Reverses the order of an array, maps to
        /// Array.reverse()</summary>
        /// <param name="list">Array to reverse</param>
        abstract reverse: list: ResizeArray<obj option> -> ResizeArray<obj option>
        /// <summary>Decreases an array by one element and returns the
        /// shortened array, maps to Array.pop().</summary>
        /// <param name="list">Array to shorten</param>
        abstract shorten: list: ResizeArray<obj option> -> ResizeArray<obj option>
        /// <summary>Randomizes the order of the elements of an array.
        /// Implements  Fisher-Yates Shuffle Algorithm.</summary>
        /// <param name="array">Array to shuffle</param>
        /// <param name="bool">modify passed array</param>
        abstract shuffle: array: ResizeArray<obj option> * ?bool: bool -> ResizeArray<obj option>
        /// <summary>Sorts an array of numbers from smallest to
        /// largest, or puts an array of words in alphabetical
        /// order. The original array is not modified; a
        /// re-ordered array is returned. The count parameter
        /// states the number of elements to sort. For
        /// example, if there are 12 elements in an array and
        /// count is set to 5, only the first 5 elements in
        /// the array will be sorted.</summary>
        /// <param name="list">Array to sort</param>
        /// <param name="count">number of elements to sort,
        /// starting from 0</param>
        abstract sort: list: ResizeArray<obj option> * ?count: float -> ResizeArray<obj option>
        /// <summary>Inserts a value or an array of values into an
        /// existing array. The first parameter specifies the
        /// initial array to be modified, and the second
        /// parameter defines the data to be inserted. The
        /// third parameter is an index value which specifies
        /// the array position from which to insert data.
        /// (Remember that array index numbering starts at
        /// zero, so the first position is 0, the second
        /// position is 1, and so on.)</summary>
        /// <param name="list">Array to splice into</param>
        /// <param name="value">value to be spliced in</param>
        /// <param name="position">in the array from which to insert
        /// data</param>
        abstract splice: list: ResizeArray<obj option> * value: obj option * position: float -> ResizeArray<obj option>
        /// <summary>Extracts an array of elements from an existing
        /// array. The list parameter defines the array from
        /// which the elements will be copied, and the start
        /// and count parameters specify which elements to
        /// extract. If no count is given, elements will be
        /// extracted from the start to the end of the array.
        /// When specifying the start, remember that the first
        /// array element is 0. This function does not change
        /// the source array.</summary>
        /// <param name="list">Array to extract from</param>
        /// <param name="start">position to begin</param>
        /// <param name="count">number of values to extract</param>
        abstract subset: list: ResizeArray<obj option> * start: float * ?count: float -> ResizeArray<obj option>
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Converts a string to its floating point
        /// representation. The contents of a string must
        /// resemble a number, or NaN (not a number) will be
        /// returned. For example, float("1234.56") evaluates
        /// to 1234.56, but float("giraffe") will return NaN.
        /// When an array of values is passed in, then an
        /// array of floats of the same length is returned.</summary>
        /// <param name="str">float string to parse</param>
        abstract float: str: string -> float
        /// <summary>Converts a boolean, string, or float to its
        /// integer representation. When an array of values is
        /// passed in, then an int array of the same length is
        /// returned.</summary>
        /// <param name="n">value to parse</param>
        /// <param name="radix">the radix to convert to (default:
        /// 10)</param>
        abstract int: n: U3<string, bool, float> * ?radix: float -> float
        /// <summary>Converts a boolean, string, or float to its
        /// integer representation. When an array of values is
        /// passed in, then an int array of the same length is
        /// returned.</summary>
        /// <param name="ns">values to parse</param>
        abstract int: ns: ResizeArray<obj option> -> ResizeArray<float>
        /// <summary>Converts a boolean, string or number to its string
        /// representation. When an array of values is passed
        /// in, then an array of strings of the same length is
        /// returned.</summary>
        /// <param name="n">value to parse</param>
        abstract str: n: U4<string, bool, float, ResizeArray<obj option>> -> string
        /// <summary>Converts a number or string to its boolean
        /// representation. For a number, any non-zero value
        /// (positive or negative) evaluates to true, while
        /// zero evaluates to false. For a string, the value
        /// "true" evaluates to true, while any other value
        /// evaluates to false. When an array of number or
        /// string values is passed in, then a array of
        /// booleans of the same length is returned.</summary>
        /// <param name="n">value to parse</param>
        abstract boolean: n: U4<string, bool, float, ResizeArray<obj option>> -> bool
        /// <summary>Converts a number, string representation of a
        /// number, or boolean to its byte representation. A
        /// byte can be only a whole number between -128 and
        /// 127, so when a value outside of this range is
        /// converted, it wraps around to the corresponding
        /// byte representation. When an array of number,
        /// string or boolean values is passed in, then an
        /// array of bytes the same length is returned.</summary>
        /// <param name="n">value to parse</param>
        abstract byte: n: U3<string, bool, float> -> float
        /// <summary>Converts a number, string representation of a
        /// number, or boolean to its byte representation. A
        /// byte can be only a whole number between -128 and
        /// 127, so when a value outside of this range is
        /// converted, it wraps around to the corresponding
        /// byte representation. When an array of number,
        /// string or boolean values is passed in, then an
        /// array of bytes the same length is returned.</summary>
        /// <param name="ns">values to parse</param>
        abstract byte: ns: ResizeArray<obj option> -> ResizeArray<float>
        /// <summary>Converts a number or string to its corresponding
        /// single-character string representation. If a
        /// string parameter is provided, it is first parsed
        /// as an integer and then translated into a
        /// single-character string. When an array of number
        /// or string values is passed in, then an array of
        /// single-character strings of the same length is
        /// returned.</summary>
        /// <param name="n">value to parse</param>
        abstract char: n: U2<string, float> -> string
        /// <summary>Converts a number or string to its corresponding
        /// single-character string representation. If a
        /// string parameter is provided, it is first parsed
        /// as an integer and then translated into a
        /// single-character string. When an array of number
        /// or string values is passed in, then an array of
        /// single-character strings of the same length is
        /// returned.</summary>
        /// <param name="ns">values to parse</param>
        abstract char: ns: ResizeArray<obj option> -> ResizeArray<string>
        /// <summary>Converts a single-character string to its
        /// corresponding integer representation. When an
        /// array of single-character string values is passed
        /// in, then an array of integers of the same length
        /// is returned.</summary>
        /// <param name="n">value to parse</param>
        abstract unchar: n: string -> float
        /// <summary>Converts a single-character string to its
        /// corresponding integer representation. When an
        /// array of single-character string values is passed
        /// in, then an array of integers of the same length
        /// is returned.</summary>
        /// <param name="ns">values to parse</param>
        abstract unchar: ns: ResizeArray<obj option> -> ResizeArray<float>
        /// <summary>Converts a number to a string in its equivalent
        /// hexadecimal notation. If a second parameter is
        /// passed, it is used to set the number of characters
        /// to generate in the hexadecimal notation. When an
        /// array is passed in, an array of strings in
        /// hexadecimal notation of the same length is
        /// returned.</summary>
        /// <param name="n">value to parse</param>
        abstract hex: n: float * ?digits: float -> string
        /// <summary>Converts a number to a string in its equivalent
        /// hexadecimal notation. If a second parameter is
        /// passed, it is used to set the number of characters
        /// to generate in the hexadecimal notation. When an
        /// array is passed in, an array of strings in
        /// hexadecimal notation of the same length is
        /// returned.</summary>
        /// <param name="ns">array of values to parse</param>
        abstract hex: ns: ResizeArray<float> * ?digits: float -> ResizeArray<string>
        /// <summary>Converts a string representation of a hexadecimal
        /// number to its equivalent integer value. When an
        /// array of strings in hexadecimal notation is passed
        /// in, an array of integers of the same length is
        /// returned.</summary>
        /// <param name="n">value to parse</param>
        abstract unhex: n: string -> float
        /// <summary>Converts a string representation of a hexadecimal
        /// number to its equivalent integer value. When an
        /// array of strings in hexadecimal notation is passed
        /// in, an array of integers of the same length is
        /// returned.</summary>
        /// <param name="ns">values to parse</param>
        abstract unhex: ns: ResizeArray<obj option> -> ResizeArray<float>
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Combines an array of Strings into one String, each
        /// separated by the character(s) used for the
        /// separator parameter. To join arrays of ints or
        /// floats, it's necessary to first convert them to
        /// Strings using nf() or nfs().</summary>
        /// <param name="list">array of Strings to be joined</param>
        /// <param name="separator">String to be placed between each
        /// item</param>
        abstract join: list: ResizeArray<obj option> * separator: string -> string
        /// <summary>This function is used to apply a regular
        /// expression to a piece of text, and return matching
        /// groups (elements found inside parentheses) as a
        /// String array. If there are no matches, a null
        /// value will be returned. If no groups are specified
        /// in the regular expression, but the sequence
        /// matches, an array of length 1 (with the matched
        /// text as the first element of the array) will be
        /// returned.  To use the function, first check to see
        /// if the result is null. If the result is null, then
        /// the sequence did not match at all. If the sequence
        /// did match, an array is returned.
        /// 
        /// 
        /// If there are groups (specified by sets of
        /// parentheses) in the regular expression, then the
        /// contents of each will be returned in the array.
        /// Element [0] of a regular expression match returns
        /// the entire matching string, and the match groups
        /// start at element [1] (the first group is [1], the
        /// second [2], and so on).</summary>
        /// <param name="str">the String to be searched</param>
        /// <param name="regexp">the regexp to be used for matching</param>
        abstract ``match``: str: string * regexp: string -> ResizeArray<string>
        /// <summary>This function is used to apply a regular
        /// expression to a piece of text, and return a list
        /// of matching groups (elements found inside
        /// parentheses) as a two-dimensional String array. If
        /// there are no matches, a null value will be
        /// returned. If no groups are specified in the
        /// regular expression, but the sequence matches, a
        /// two dimensional array is still returned, but the
        /// second dimension is only of length one.  To use
        /// the function, first check to see if the result is
        /// null. If the result is null, then the sequence did
        /// not match at all. If the sequence did match, a 2D
        /// array is returned.
        /// 
        /// 
        /// If there are groups (specified by sets of
        /// parentheses) in the regular expression, then the
        /// contents of each will be returned in the array.
        /// Assuming a loop with counter variable i, element
        /// [i][0] of a regular expression match returns the
        /// entire matching string, and the match groups start
        /// at element [i][1] (the first group is [i][1], the
        /// second [i][2], and so on).</summary>
        /// <param name="str">the String to be searched</param>
        /// <param name="regexp">the regexp to be used for matching</param>
        abstract matchAll: str: string * regexp: string -> ResizeArray<string>
        /// <summary>Utility function for formatting numbers into
        /// strings. There are two versions: one for
        /// formatting floats, and one for formatting ints.
        /// The values for the digits, left, and right
        /// parameters should always be positive integers.</summary>
        /// <param name="num">the Number to format</param>
        /// <param name="left">number of digits to the left of the
        /// decimal point</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nf: num: U2<float, string> * ?left: U2<float, string> * ?right: U2<float, string> -> string
        /// <summary>Utility function for formatting numbers into
        /// strings. There are two versions: one for
        /// formatting floats, and one for formatting ints.
        /// The values for the digits, left, and right
        /// parameters should always be positive integers.</summary>
        /// <param name="nums">the Numbers to format</param>
        /// <param name="left">number of digits to the left of the
        /// decimal point</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nf: nums: ResizeArray<obj option> * ?left: U2<float, string> * ?right: U2<float, string> -> ResizeArray<string>
        /// <summary>Utility function for formatting numbers into
        /// strings and placing appropriate commas to mark
        /// units of 1000. There are two versions: one for
        /// formatting ints, and one for formatting an array
        /// of ints. The value for the right parameter should
        /// always be a positive integer.</summary>
        /// <param name="num">the Number to format</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nfc: num: U2<float, string> * ?right: U2<float, string> -> string
        /// <summary>Utility function for formatting numbers into
        /// strings and placing appropriate commas to mark
        /// units of 1000. There are two versions: one for
        /// formatting ints, and one for formatting an array
        /// of ints. The value for the right parameter should
        /// always be a positive integer.</summary>
        /// <param name="nums">the Numbers to format</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nfc: nums: ResizeArray<obj option> * ?right: U2<float, string> -> ResizeArray<string>
        /// <summary>Utility function for formatting numbers into
        /// strings. Similar to nf() but puts a "+" in front
        /// of positive numbers and a "-" in front of negative
        /// numbers. There are two versions: one for
        /// formatting floats, and one for formatting ints.
        /// The values for left, and right parameters should
        /// always be positive integers.</summary>
        /// <param name="num">the Number to format</param>
        /// <param name="left">number of digits to the left of the
        /// decimal point</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nfp: num: float * ?left: float * ?right: float -> string
        /// <summary>Utility function for formatting numbers into
        /// strings. Similar to nf() but puts a "+" in front
        /// of positive numbers and a "-" in front of negative
        /// numbers. There are two versions: one for
        /// formatting floats, and one for formatting ints.
        /// The values for left, and right parameters should
        /// always be positive integers.</summary>
        /// <param name="nums">the Numbers to format</param>
        /// <param name="left">number of digits to the left of the
        /// decimal point</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nfp: nums: ResizeArray<float> * ?left: float * ?right: float -> ResizeArray<string>
        /// <summary>Utility function for formatting numbers into
        /// strings. Similar to nf() but puts a " " (space) in
        /// front of positive numbers and a "-" in front of
        /// negative numbers. There are two versions: one for
        /// formatting floats, and one for formatting ints.
        /// The values for the digits, left, and right
        /// parameters should always be positive integers.</summary>
        /// <param name="num">the Number to format</param>
        /// <param name="left">number of digits to the left of the
        /// decimal point</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nfs: num: float * ?left: float * ?right: float -> string
        /// <summary>Utility function for formatting numbers into
        /// strings. Similar to nf() but puts a " " (space) in
        /// front of positive numbers and a "-" in front of
        /// negative numbers. There are two versions: one for
        /// formatting floats, and one for formatting ints.
        /// The values for the digits, left, and right
        /// parameters should always be positive integers.</summary>
        /// <param name="nums">the Numbers to format</param>
        /// <param name="left">number of digits to the left of the
        /// decimal point</param>
        /// <param name="right">number of digits to the right of
        /// the decimal point</param>
        abstract nfs: nums: ResizeArray<obj option> * ?left: float * ?right: float -> ResizeArray<string>
        /// <summary>The split() function maps to String.split(), it
        /// breaks a String into pieces using a character or
        /// string as the delimiter. The delim parameter
        /// specifies the character or characters that mark
        /// the boundaries between each piece. A String[]
        /// array is returned that contains each of the
        /// pieces. The splitTokens() function works in a
        /// similar fashion, except that it splits using a
        /// range of characters instead of a specific
        /// character or sequence.</summary>
        /// <param name="value">the String to be split</param>
        /// <param name="delim">the String used to separate the data</param>
        abstract split: value: string * delim: string -> ResizeArray<string>
        /// <summary>The splitTokens() function splits a String at one
        /// or many character delimiters or "tokens." The
        /// delim parameter specifies the character or
        /// characters to be used as a boundary.  If no delim
        /// characters are specified, any whitespace character
        /// is used to split. Whitespace characters include
        /// tab (\t), line feed (\n), carriage return (\r),
        /// form feed (\f), and space.</summary>
        /// <param name="value">the String to be split</param>
        /// <param name="delim">list of individual Strings that
        /// will be used as separators</param>
        abstract splitTokens: value: string * ?delim: string -> ResizeArray<string>
        /// <summary>Removes whitespace characters from the beginning
        /// and end of a String. In addition to standard
        /// whitespace characters such as space, carriage
        /// return, and tab, this function also removes the
        /// Unicode "nbsp" character.</summary>
        /// <param name="str">a String to be trimmed</param>
        abstract trim: str: string -> string
        /// <summary>Removes whitespace characters from the beginning
        /// and end of a String. In addition to standard
        /// whitespace characters such as space, carriage
        /// return, and tab, this function also removes the
        /// Unicode "nbsp" character.</summary>
        /// <param name="strs">an Array of Strings to be trimmed</param>
        abstract trim: strs: ResizeArray<obj option> -> ResizeArray<string>
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// p5.js communicates with the clock on your
        /// computer. The day() function returns the current
        /// day as a value from 1 - 31.
        abstract day: unit -> float
        /// p5.js communicates with the clock on your
        /// computer. The hour() function returns the current
        /// hour as a value from 0 - 23.
        abstract hour: unit -> float
        /// p5.js communicates with the clock on your
        /// computer. The minute() function returns the
        /// current minute as a value from 0 - 59.
        abstract minute: unit -> float
        /// Returns the number of milliseconds (thousandths of
        /// a second) since starting the program. This
        /// information is often used for timing events and
        /// animation sequences.
        abstract millis: unit -> float
        /// p5.js communicates with the clock on your
        /// computer. The month() function returns the current
        /// month as a value from 1 - 12.
        abstract month: unit -> float
        /// p5.js communicates with the clock on your
        /// computer. The second() function returns the
        /// current second as a value from 0 - 59.
        abstract second: unit -> float
        /// p5.js communicates with the clock on your
        /// computer. The year() function returns the current
        /// year as an integer (2014, 2015, 2016, etc).
        abstract year: unit -> float
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Draw a plane with given a width and height</summary>
        /// <param name="width">width of the plane</param>
        /// <param name="height">height of the plane</param>
        /// <param name="detailX">Optional number of triangle
        /// subdivisions in x-dimension</param>
        /// <param name="detailY">Optional number of triangle
        /// subdivisions in y-dimension</param>
        abstract plane: ?width: float * ?height: float * ?detailX: float * ?detailY: float -> p5
        /// <summary>Draw a box with given width, height and depth</summary>
        /// <param name="width">width of the box</param>
        /// <param name="Height">height of the box</param>
        /// <param name="depth">depth of the box</param>
        /// <param name="detailX">Optional number of triangle
        /// subdivisions in x-dimension</param>
        /// <param name="detailY">Optional number of triangle
        /// subdivisions in y-dimension</param>
        abstract box: ?width: float * ?Height: float * ?depth: float * ?detailX: float * ?detailY: float -> p5
        /// <summary>Draw a sphere with given radius</summary>
        /// <param name="radius">radius of circle</param>
        /// <param name="detailX">number of segments, the more
        /// segments the smoother geometry default is 24</param>
        /// <param name="detailY">number of segments, the more
        /// segments the smoother geometry default is 16</param>
        abstract sphere: ?radius: float * ?detailX: float * ?detailY: float -> p5
        /// <summary>Draw a cylinder with given radius and height</summary>
        /// <param name="radius">radius of the surface</param>
        /// <param name="height">height of the cylinder</param>
        /// <param name="detailX">number of segments, the more
        /// segments the smoother geometry default is 24</param>
        /// <param name="detailY">number of segments in
        /// y-dimension, the more segments the smoother
        /// geometry default is 1</param>
        /// <param name="bottomCap">whether to draw the bottom of
        /// the cylinder</param>
        /// <param name="topCap">whether to draw the top of the
        /// cylinder</param>
        abstract cylinder: ?radius: float * ?height: float * ?detailX: float * ?detailY: float * ?bottomCap: bool * ?topCap: bool -> p5
        /// <summary>Draw a cone with given radius and height</summary>
        /// <param name="radius">radius of the bottom surface</param>
        /// <param name="height">height of the cone</param>
        /// <param name="detailX">number of segments, the more
        /// segments the smoother geometry default is 24</param>
        /// <param name="detailY">number of segments, the more
        /// segments the smoother geometry default is 1</param>
        /// <param name="cap">whether to draw the base of the cone</param>
        abstract cone: ?radius: float * ?height: float * ?detailX: float * ?detailY: float * ?cap: bool -> p5
        /// <summary>Draw an ellipsoid with given radius</summary>
        /// <param name="radiusx">xradius of circle</param>
        /// <param name="radiusy">yradius of circle</param>
        /// <param name="radiusz">zradius of circle</param>
        /// <param name="detailX">number of segments, the more
        /// segments the smoother geometry default is 24.
        /// Avoid detail number above 150, it may crash the
        /// browser.</param>
        /// <param name="detailY">number of segments, the more
        /// segments the smoother geometry default is 16.
        /// Avoid detail number above 150, it may crash the
        /// browser.</param>
        abstract ellipsoid: ?radiusx: float * ?radiusy: float * ?radiusz: float * ?detailX: float * ?detailY: float -> p5
        /// <summary>Draw a torus with given radius and tube radius</summary>
        /// <param name="radius">radius of the whole ring</param>
        /// <param name="tubeRadius">radius of the tube</param>
        /// <param name="detailX">number of segments in
        /// x-dimension, the more segments the smoother
        /// geometry default is 24</param>
        /// <param name="detailY">number of segments in
        /// y-dimension, the more segments the smoother
        /// geometry default is 16</param>
        abstract torus: ?radius: float * ?tubeRadius: float * ?detailX: float * ?detailY: float -> p5
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Allows movement around a 3D sketch using a mouse
        /// or trackpad. Left-clicking and dragging will
        /// rotate the camera position about the center of the
        /// sketch, right-clicking and dragging will pan the
        /// camera position without rotation, and using the
        /// mouse wheel (scrolling) will move the camera
        /// closer or further from the center of the sketch.
        /// This function can be called with parameters
        /// dictating sensitivity to mouse movement along the
        /// X and Y axes. Calling this function without
        /// parameters is equivalent to calling
        /// orbitControl(1,1). To reverse direction of
        /// movement in either axis, enter a negative number
        /// for sensitivity.</summary>
        /// <param name="sensitivityX">sensitivity to mouse
        /// movement along X axis</param>
        /// <param name="sensitivityY">sensitivity to mouse
        /// movement along Y axis</param>
        abstract orbitControl: ?sensitivityX: float * ?sensitivityY: float -> p5
        /// debugMode() helps visualize 3D space by adding a
        /// grid to indicate where the ‘ground’ is in a sketch
        /// and an axes icon which indicates the +X, +Y, and
        /// +Z directions. This function can be called without
        /// parameters to create a default grid and axes icon,
        /// or it can be called according to the examples
        /// above to customize the size and position of the
        /// grid and/or axes icon. The grid is drawn using the
        /// most recently set stroke color and weight. To
        /// specify these parameters, add a call to stroke()
        /// and strokeWeight() just before the end of the
        /// draw() loop. By default, the grid will run through
        /// the origin (0,0,0) of the sketch along the XZ
        /// plane and the axes icon will be offset from the
        /// origin. Both the grid and axes icon will be sized
        /// according to the current canvas size. Note that
        /// because the grid runs parallel to the default
        /// camera view, it is often helpful to use debugMode
        /// along with orbitControl to allow full view of the
        /// grid.
        abstract debugMode: unit -> unit
        /// <summary>debugMode() helps visualize 3D space by adding a
        /// grid to indicate where the ‘ground’ is in a sketch
        /// and an axes icon which indicates the +X, +Y, and
        /// +Z directions. This function can be called without
        /// parameters to create a default grid and axes icon,
        /// or it can be called according to the examples
        /// above to customize the size and position of the
        /// grid and/or axes icon. The grid is drawn using the
        /// most recently set stroke color and weight. To
        /// specify these parameters, add a call to stroke()
        /// and strokeWeight() just before the end of the
        /// draw() loop. By default, the grid will run through
        /// the origin (0,0,0) of the sketch along the XZ
        /// plane and the axes icon will be offset from the
        /// origin. Both the grid and axes icon will be sized
        /// according to the current canvas size. Note that
        /// because the grid runs parallel to the default
        /// camera view, it is often helpful to use debugMode
        /// along with orbitControl to allow full view of the
        /// grid.</summary>
        /// <param name="mode">either GRID or AXES</param>
        abstract debugMode: mode: DEBUG_MODE -> unit
        /// <summary>debugMode() helps visualize 3D space by adding a
        /// grid to indicate where the ‘ground’ is in a sketch
        /// and an axes icon which indicates the +X, +Y, and
        /// +Z directions. This function can be called without
        /// parameters to create a default grid and axes icon,
        /// or it can be called according to the examples
        /// above to customize the size and position of the
        /// grid and/or axes icon. The grid is drawn using the
        /// most recently set stroke color and weight. To
        /// specify these parameters, add a call to stroke()
        /// and strokeWeight() just before the end of the
        /// draw() loop. By default, the grid will run through
        /// the origin (0,0,0) of the sketch along the XZ
        /// plane and the axes icon will be offset from the
        /// origin. Both the grid and axes icon will be sized
        /// according to the current canvas size. Note that
        /// because the grid runs parallel to the default
        /// camera view, it is often helpful to use debugMode
        /// along with orbitControl to allow full view of the
        /// grid.</summary>
        /// <param name="mode">either GRID or AXES</param>
        /// <param name="gridSize">size of one side of the grid</param>
        /// <param name="gridDivisions">number of divisions in the
        /// grid</param>
        /// <param name="xOff">X axis offset from origin (0,0,0)</param>
        /// <param name="yOff">Y axis offset from origin (0,0,0)</param>
        /// <param name="zOff">Z axis offset from origin (0,0,0)</param>
        abstract debugMode: mode: UNKNOWN_P5_CONSTANT * ?gridSize: float * ?gridDivisions: float * ?xOff: float * ?yOff: float * ?zOff: float -> unit
        /// <summary>debugMode() helps visualize 3D space by adding a
        /// grid to indicate where the ‘ground’ is in a sketch
        /// and an axes icon which indicates the +X, +Y, and
        /// +Z directions. This function can be called without
        /// parameters to create a default grid and axes icon,
        /// or it can be called according to the examples
        /// above to customize the size and position of the
        /// grid and/or axes icon. The grid is drawn using the
        /// most recently set stroke color and weight. To
        /// specify these parameters, add a call to stroke()
        /// and strokeWeight() just before the end of the
        /// draw() loop. By default, the grid will run through
        /// the origin (0,0,0) of the sketch along the XZ
        /// plane and the axes icon will be offset from the
        /// origin. Both the grid and axes icon will be sized
        /// according to the current canvas size. Note that
        /// because the grid runs parallel to the default
        /// camera view, it is often helpful to use debugMode
        /// along with orbitControl to allow full view of the
        /// grid.</summary>
        /// <param name="mode">either GRID or AXES</param>
        /// <param name="axesSize">size of axes icon</param>
        /// <param name="xOff">X axis offset from origin (0,0,0)</param>
        /// <param name="yOff">Y axis offset from origin (0,0,0)</param>
        /// <param name="zOff">Z axis offset from origin (0,0,0)</param>
        abstract debugMode: mode: UNKNOWN_P5_CONSTANT * ?axesSize: float * ?xOff: float * ?yOff: float * ?zOff: float -> unit
        /// <summary>debugMode() helps visualize 3D space by adding a
        /// grid to indicate where the ‘ground’ is in a sketch
        /// and an axes icon which indicates the +X, +Y, and
        /// +Z directions. This function can be called without
        /// parameters to create a default grid and axes icon,
        /// or it can be called according to the examples
        /// above to customize the size and position of the
        /// grid and/or axes icon. The grid is drawn using the
        /// most recently set stroke color and weight. To
        /// specify these parameters, add a call to stroke()
        /// and strokeWeight() just before the end of the
        /// draw() loop. By default, the grid will run through
        /// the origin (0,0,0) of the sketch along the XZ
        /// plane and the axes icon will be offset from the
        /// origin. Both the grid and axes icon will be sized
        /// according to the current canvas size. Note that
        /// because the grid runs parallel to the default
        /// camera view, it is often helpful to use debugMode
        /// along with orbitControl to allow full view of the
        /// grid.</summary>
        /// <param name="gridSize">size of one side of the grid</param>
        /// <param name="gridDivisions">number of divisions in the
        /// grid</param>
        /// <param name="axesSize">size of axes icon</param>
        abstract debugMode: ?gridSize: float * ?gridDivisions: float * ?gridXOff: float * ?gridYOff: float * ?gridZOff: float * ?axesSize: float * ?axesXOff: float * ?axesYOff: float * ?axesZOff: float -> unit
        /// Turns off debugMode() in a 3D sketch.
        abstract noDebugMode: unit -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Creates an ambient light with a color</summary>
        /// <param name="v1">red or hue value relative to the current
        /// color range</param>
        /// <param name="v2">green or saturation value relative to
        /// the current color range</param>
        /// <param name="v3">blue or brightness value relative to the
        /// current color range</param>
        /// <param name="alpha">the alpha value</param>
        abstract ambientLight: v1: float * v2: float * v3: float * ?alpha: float -> p5
        /// <summary>Creates an ambient light with a color</summary>
        /// <param name="value">a color string</param>
        abstract ambientLight: value: string -> p5
        /// <summary>Creates an ambient light with a color</summary>
        /// <param name="gray">a gray value</param>
        /// <param name="alpha">the alpha value</param>
        abstract ambientLight: gray: float * ?alpha: float -> p5
        /// <summary>Creates an ambient light with a color</summary>
        /// <param name="values">an array containing the
        /// red,green,blue & and alpha components of the color</param>
        abstract ambientLight: values: ResizeArray<float> -> p5
        /// <summary>Creates an ambient light with a color</summary>
        /// <param name="color">the ambient light color</param>
        abstract ambientLight: color: Color -> p5
        /// <summary>Creates a directional light with a color and a
        /// direction</summary>
        /// <param name="v1">red or hue value (depending on the
        /// current color mode),</param>
        /// <param name="v2">green or saturation value</param>
        /// <param name="v3">blue or brightness value</param>
        /// <param name="position">the direction of the light</param>
        abstract directionalLight: v1: float * v2: float * v3: float * position: Vector -> p5
        /// <summary>Creates a directional light with a color and a
        /// direction</summary>
        /// <param name="color">color Array, CSS color string, or
        /// p5.Color value</param>
        /// <param name="x">x axis direction</param>
        /// <param name="y">y axis direction</param>
        /// <param name="z">z axis direction</param>
        abstract directionalLight: color: U3<ResizeArray<float>, string, Color> * x: float * y: float * z: float -> p5
        /// <summary>Creates a directional light with a color and a
        /// direction</summary>
        /// <param name="color">color Array, CSS color string, or
        /// p5.Color value</param>
        /// <param name="position">the direction of the light</param>
        abstract directionalLight: color: U3<ResizeArray<float>, string, Color> * position: Vector -> p5
        /// <summary>Creates a directional light with a color and a
        /// direction</summary>
        /// <param name="v1">red or hue value (depending on the
        /// current color mode),</param>
        /// <param name="v2">green or saturation value</param>
        /// <param name="v3">blue or brightness value</param>
        /// <param name="x">x axis direction</param>
        /// <param name="y">y axis direction</param>
        /// <param name="z">z axis direction</param>
        abstract directionalLight: v1: float * v2: float * v3: float * x: float * y: float * z: float -> p5
        /// <summary>Creates a point light with a color and a light
        /// position</summary>
        /// <param name="v1">red or hue value (depending on the
        /// current color mode),</param>
        /// <param name="v2">green or saturation value</param>
        /// <param name="v3">blue or brightness value</param>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="z">z axis position</param>
        abstract pointLight: v1: float * v2: float * v3: float * x: float * y: float * z: float -> p5
        /// <summary>Creates a point light with a color and a light
        /// position</summary>
        /// <param name="v1">red or hue value (depending on the
        /// current color mode),</param>
        /// <param name="v2">green or saturation value</param>
        /// <param name="v3">blue or brightness value</param>
        /// <param name="position">the position of the light</param>
        abstract pointLight: v1: float * v2: float * v3: float * position: Vector -> p5
        /// <summary>Creates a point light with a color and a light
        /// position</summary>
        /// <param name="color">color Array, CSS color string, or
        /// p5.Color value</param>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="z">z axis position</param>
        abstract pointLight: color: U3<ResizeArray<float>, string, Color> * x: float * y: float * z: float -> p5
        /// <summary>Creates a point light with a color and a light
        /// position</summary>
        /// <param name="color">color Array, CSS color string, or
        /// p5.Color value</param>
        /// <param name="position">the position of the light</param>
        abstract pointLight: color: U3<ResizeArray<float>, string, Color> * position: Vector -> p5
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Load a 3d model from an OBJ file.  One of the
        /// limitations of the OBJ format is that it doesn't
        /// have a built-in sense of scale. This means that
        /// models exported from different programs might be
        /// very different sizes. If your model isn't
        /// displaying, try calling loadModel() with the
        /// normalized parameter set to true. This will resize
        /// the model to a scale appropriate for p5. You can
        /// also make additional changes to the final size of
        /// your model with the scale() function.</summary>
        /// <param name="path">Path of the model to be loaded</param>
        /// <param name="normalize">If true, scale the model to a
        /// standardized size when loading</param>
        /// <param name="successCallback">Function to be called
        /// once the model is loaded. Will be passed the 3D
        /// model object.</param>
        /// <param name="failureCallback">called with event error
        /// if the image fails to load.</param>
        abstract loadModel: path: string * normalize: bool * ?successCallback: (Geometry -> obj option) * ?failureCallback: (Event -> obj option) -> Geometry
        /// <summary>Load a 3d model from an OBJ file.  One of the
        /// limitations of the OBJ format is that it doesn't
        /// have a built-in sense of scale. This means that
        /// models exported from different programs might be
        /// very different sizes. If your model isn't
        /// displaying, try calling loadModel() with the
        /// normalized parameter set to true. This will resize
        /// the model to a scale appropriate for p5. You can
        /// also make additional changes to the final size of
        /// your model with the scale() function.</summary>
        /// <param name="path">Path of the model to be loaded</param>
        /// <param name="successCallback">Function to be called
        /// once the model is loaded. Will be passed the 3D
        /// model object.</param>
        /// <param name="failureCallback">called with event error
        /// if the image fails to load.</param>
        abstract loadModel: path: string * ?successCallback: (Geometry -> obj option) * ?failureCallback: (Event -> obj option) -> Geometry
        /// <summary>Render a 3d model to the screen.</summary>
        /// <param name="model">Loaded 3d model to be rendered</param>
        abstract model: model: Geometry -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Loads a custom shader from the provided vertex and
        /// fragment shader paths. The shader files are loaded
        /// asynchronously in the background, so this method
        /// should be used in preload(). For now, there are
        /// three main types of shaders. p5 will automatically
        /// supply appropriate vertices, normals, colors, and
        /// lighting attributes if the parameters defined in
        /// the shader match the names.</summary>
        /// <param name="vertFilename">path to file containing
        /// vertex shader source code</param>
        /// <param name="fragFilename">path to file containing
        /// fragment shader source code</param>
        abstract loadShader: ?vertFilename: string * ?fragFilename: string -> Shader
        abstract createShader: vertSrc: string * fragSrc: string -> Shader
        /// <summary>The shader() function lets the user provide a
        /// custom shader to fill in shapes in WEBGL mode.
        /// Users can create their own shaders by loading
        /// vertex and fragment shaders with loadShader().</summary>
        /// <param name="s">the desired p5.Shader to use for
        /// rendering shapes.</param>
        abstract shader: ?s: Shader -> p5
        /// Normal material for geometry. You can view all
        /// possible materials in this example.
        abstract normalMaterial: unit -> p5
        /// <summary>Texture for geometry. You can view other possible
        /// materials in this example.</summary>
        /// <param name="tex">2-dimensional graphics to render as
        /// texture</param>
        abstract texture: tex: U3<Image, MediaElement, Graphics> -> p5
        /// <summary>Ambient material for geometry with a given color.
        /// You can view all possible materials in this
        /// example.</summary>
        /// <param name="v1">gray value, red or hue value (depending
        /// on the current color mode),</param>
        /// <param name="v2">green or saturation value</param>
        /// <param name="v3">blue or brightness value</param>
        /// <param name="a">opacity</param>
        abstract ambientMaterial: v1: float * ?v2: float * ?v3: float * ?a: float -> p5
        /// <summary>Ambient material for geometry with a given color.
        /// You can view all possible materials in this
        /// example.</summary>
        /// <param name="color">color, color Array, or CSS color
        /// string</param>
        abstract ambientMaterial: color: U3<ResizeArray<float>, string, Color> -> p5
        /// <summary>Specular material for geometry with a given color.
        /// You can view all possible materials in this
        /// example.</summary>
        /// <param name="v1">gray value, red or hue value (depending
        /// on the current color mode),</param>
        /// <param name="v2">green or saturation value</param>
        /// <param name="v3">blue or brightness value</param>
        /// <param name="a">opacity</param>
        abstract specularMaterial: v1: float * ?v2: float * ?v3: float * ?a: float -> p5
        /// <summary>Specular material for geometry with a given color.
        /// You can view all possible materials in this
        /// example.</summary>
        /// <param name="color">color Array, or CSS color string</param>
        abstract specularMaterial: color: U3<ResizeArray<float>, string, Color> -> p5
module P5 = ______index
let [<Import("*","p5/src/webgl/p5.Camera")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Camera: CameraStatic

    type [<AllowNullLiteral>] Camera =
        /// Sets a perspective projection for a p5.Camera
        /// object and sets parameters for that projection
        /// according to perspective() syntax.
        abstract perspective: unit -> unit
        /// Sets an orthographic projection for a p5.Camera
        /// object and sets parameters for that projection
        /// according to ortho() syntax.
        abstract ortho: unit -> unit
        /// <summary>Panning rotates the camera view to the left and
        /// right.</summary>
        /// <param name="angle">amount to rotate camera in current
        /// angleMode units. Greater than 0 values rotate
        /// counterclockwise (to the left).</param>
        abstract pan: angle: float -> unit
        /// <summary>Tilting rotates the camera view up and down.</summary>
        /// <param name="angle">amount to rotate camera in current
        /// angleMode units. Greater than 0 values rotate
        /// counterclockwise (to the left).</param>
        abstract tilt: angle: float -> unit
        /// <summary>Reorients the camera to look at a position in
        /// world space.</summary>
        /// <param name="x">x position of a point in world space</param>
        /// <param name="y">y position of a point in world space</param>
        /// <param name="z">z position of a point in world space</param>
        abstract lookAt: x: float * y: float * z: float -> unit
        /// Sets a camera's position and orientation. This is
        /// equivalent to calling camera() on a p5.Camera
        /// object.
        abstract camera: unit -> unit
        /// <summary>Move camera along its local axes while maintaining
        /// current camera orientation.</summary>
        /// <param name="x">amount to move along camera's left-right
        /// axis</param>
        /// <param name="y">amount to move along camera's up-down
        /// axis</param>
        /// <param name="z">amount to move along camera's
        /// forward-backward axis</param>
        abstract move: x: float * y: float * z: float -> unit
        /// <summary>Set camera position in world-space while
        /// maintaining current camera orientation.</summary>
        /// <param name="x">x position of a point in world space</param>
        /// <param name="y">y position of a point in world space</param>
        /// <param name="z">z position of a point in world space</param>
        abstract setPosition: x: float * y: float * z: float -> unit

    type [<AllowNullLiteral>] CameraStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Camera

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Sets the camera position for a 3D sketch.
        /// Parameters for this function define the position
        /// for the camera, the center of the sketch (where
        /// the camera is pointing), and an up direction (the
        /// orientation of the camera). When called with no
        /// arguments, this function creates a default camera
        /// equivalent to camera(0, 0, (height/2.0) /
        /// tan(PI*30.0 / 180.0), 0, 0, 0, 0, 1, 0);</summary>
        /// <param name="x">camera position value on x axis</param>
        /// <param name="y">camera position value on y axis</param>
        /// <param name="z">camera position value on z axis</param>
        /// <param name="centerX">x coordinate representing center
        /// of the sketch</param>
        /// <param name="centerY">y coordinate representing center
        /// of the sketch</param>
        /// <param name="centerZ">z coordinate representing center
        /// of the sketch</param>
        /// <param name="upX">x component of direction 'up' from
        /// camera</param>
        /// <param name="upY">y component of direction 'up' from
        /// camera</param>
        /// <param name="upZ">z component of direction 'up' from
        /// camera</param>
        abstract camera: ?x: float * ?y: float * ?z: float * ?centerX: float * ?centerY: float * ?centerZ: float * ?upX: float * ?upY: float * ?upZ: float -> p5
        /// <summary>Sets a perspective projection for the camera in a
        /// 3D sketch. This projection represents depth
        /// through foreshortening: objects that are close to
        /// the camera appear their actual size while those
        /// that are further away from the camera appear
        /// smaller. The parameters to this function define
        /// the viewing frustum (the truncated pyramid within
        /// which objects are seen by the camera) through
        /// vertical field of view, aspect ratio (usually
        /// width/height), and near and far clipping planes.
        /// When called with no arguments, the defaults
        /// provided are equivalent to perspective(PI/3.0,
        /// width/height, eyeZ/10.0, eyeZ10.0), where eyeZ is
        /// equal to ((height/2.0) / tan(PI60.0/360.0));</summary>
        /// <param name="fovy">camera frustum vertical field of
        /// view, from bottom to top of view, in angleMode
        /// units</param>
        /// <param name="aspect">camera frustum aspect ratio</param>
        /// <param name="near">frustum near plane length</param>
        /// <param name="far">frustum far plane length</param>
        abstract perspective: ?fovy: float * ?aspect: float * ?near: float * ?far: float -> p5
        /// <summary>Sets an orthographic projection for the camera in
        /// a 3D sketch and defines a box-shaped viewing
        /// frustum within which objects are seen. In this
        /// projection, all objects with the same dimension
        /// appear the same size, regardless of whether they
        /// are near or far from the camera. The parameters to
        /// this function specify the viewing frustum where
        /// left and right are the minimum and maximum x
        /// values, top and bottom are the minimum and maximum
        /// y values, and near and far are the minimum and
        /// maximum z values. If no parameters are given, the
        /// default is used: ortho(-width/2, width/2,
        /// -height/2, height/2).</summary>
        /// <param name="left">camera frustum left plane</param>
        /// <param name="right">camera frustum right plane</param>
        /// <param name="bottom">camera frustum bottom plane</param>
        /// <param name="top">camera frustum top plane</param>
        /// <param name="near">camera frustum near plane</param>
        /// <param name="far">camera frustum far plane</param>
        abstract ortho: ?left: float * ?right: float * ?bottom: float * ?top: float * ?near: float * ?far: float -> p5
        /// Creates a new p5.Camera object and tells the
        /// renderer to use that camera. Returns the p5.Camera
        /// object.
        abstract createCamera: unit -> Camera
        /// <summary>Sets rendererGL's current camera to a p5.Camera
        /// object. Allows switching between multiple cameras.</summary>
        /// <param name="cam">p5.Camera object</param>
        abstract setCamera: cam: Camera -> unit
module P5 = ______index

module ______index =

    type [<AllowNullLiteral>] p5InstanceExtensions =
        /// <summary>Set attributes for the WebGL Drawing context. This
        /// is a way of adjusting ways that the WebGL renderer
        /// works to fine-tune the display and performance.
        /// This should be put in setup(). The available
        /// attributes are:  alpha - indicates if the canvas
        /// contains an alpha buffer default is true
        /// 
        /// 
        /// depth - indicates whether the drawing buffer has a
        /// depth buffer of at least 16 bits - default is true
        /// 
        /// 
        /// stencil - indicates whether the drawing buffer has
        /// a stencil buffer of at least 8 bits
        /// 
        /// 
        /// antialias - indicates whether or not to perform
        /// anti-aliasing default is false
        /// 
        /// 
        /// premultipliedAlpha - indicates that the page
        /// compositor will assume the drawing buffer contains
        /// colors with pre-multiplied alpha default is false
        /// 
        /// 
        /// preserveDrawingBuffer - if true the buffers will
        /// not be cleared and and will preserve their values
        /// until cleared or overwritten by author (note that
        /// p5 clears automatically on draw loop) default is
        /// true
        /// 
        /// 
        /// perPixelLighting - if true, per-pixel lighting
        /// will be used in the lighting shader. default is
        /// false</summary>
        /// <param name="key">Name of attribute</param>
        /// <param name="value">New value of named attribute</param>
        abstract setAttributes: key: string * value: bool -> unit
        /// <summary>Set attributes for the WebGL Drawing context. This
        /// is a way of adjusting ways that the WebGL renderer
        /// works to fine-tune the display and performance.
        /// This should be put in setup(). The available
        /// attributes are:  alpha - indicates if the canvas
        /// contains an alpha buffer default is true
        /// 
        /// 
        /// depth - indicates whether the drawing buffer has a
        /// depth buffer of at least 16 bits - default is true
        /// 
        /// 
        /// stencil - indicates whether the drawing buffer has
        /// a stencil buffer of at least 8 bits
        /// 
        /// 
        /// antialias - indicates whether or not to perform
        /// anti-aliasing default is false
        /// 
        /// 
        /// premultipliedAlpha - indicates that the page
        /// compositor will assume the drawing buffer contains
        /// colors with pre-multiplied alpha default is false
        /// 
        /// 
        /// preserveDrawingBuffer - if true the buffers will
        /// not be cleared and and will preserve their values
        /// until cleared or overwritten by author (note that
        /// p5 clears automatically on draw loop) default is
        /// true
        /// 
        /// 
        /// perPixelLighting - if true, per-pixel lighting
        /// will be used in the lighting shader. default is
        /// false</summary>
        /// <param name="obj">object with key-value pairs</param>
        abstract setAttributes: obj: obj -> unit
module P5 = ______index
let [<Import("*","p5/src/color/p5.Color")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Color: ColorStatic

    type [<AllowNullLiteral>] Color =
        /// <summary>This function returns the color formatted as a
        /// string. This can be useful for debugging, or for
        /// using p5.js with other libraries.</summary>
        /// <param name="format">How the color string will be
        /// formatted. Leaving this empty formats the string
        /// as rgba(r, g, b, a). '#rgb' '#rgba' '#rrggbb' and
        /// '#rrggbbaa' format as hexadecimal color codes.
        /// 'rgb' 'hsb' and 'hsl' return the color formatted
        /// in the specified color mode. 'rgba' 'hsba' and
        /// 'hsla' are the same as above but with alpha
        /// channels. 'rgb%' 'hsb%' 'hsl%' 'rgba%' 'hsba%' and
        /// 'hsla%' format as percentages.</param>
        abstract toString: ?format: string -> string
        abstract setRed: red: float -> unit
        abstract setGreen: green: float -> unit
        abstract setBlue: blue: float -> unit
        abstract setAlpha: alpha: float -> unit

    type [<AllowNullLiteral>] ColorStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Color
module P5 = ______index
let [<Import("*","p5/src/core/p5.Element")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Element: ElementStatic

    type [<AllowNullLiteral>] Element =
        /// <summary>Attaches the element to the parent specified. A
        /// way of setting the container for the element.
        /// Accepts either a string ID, DOM node, or
        /// p5.Element. If no arguments given, parent node is
        /// returned. For more ways to position the canvas,
        /// see the  positioning the canvas wiki page.</summary>
        /// <param name="parent">the ID, DOM node, or p5.Element of
        /// desired parent element</param>
        abstract parent: parent: U3<string, Element, obj> -> Element
        /// Attaches the element to the parent specified. A
        /// way of setting the container for the element.
        /// Accepts either a string ID, DOM node, or
        /// p5.Element. If no arguments given, parent node is
        /// returned. For more ways to position the canvas,
        /// see the  positioning the canvas wiki page.
        abstract parent: unit -> Element
        /// <summary>Sets the ID of the element. If no ID argument is
        /// passed in, it instead returns the current ID of
        /// the element.</summary>
        /// <param name="id">ID of the element</param>
        abstract id: id: string -> Element
        /// Sets the ID of the element. If no ID argument is
        /// passed in, it instead returns the current ID of
        /// the element.
        abstract id: unit -> string
        /// Adds given class to the element. If no class
        /// argument is passed in, it instead returns a string
        /// containing the current class(es) of the element.
        abstract ``class``: theClass: string -> Element
        /// Adds given class to the element. If no class
        /// argument is passed in, it instead returns a string
        /// containing the current class(es) of the element.
        abstract ``class``: unit -> string
        /// <summary>The .mousePressed() function is called once after
        /// every time a mouse button is pressed over the
        /// element. Some mobile browsers may also trigger
        /// this event on a touch screen, if the user performs
        /// a quick tap. This can be used to attach element
        /// specific event listeners.</summary>
        /// <param name="fxn">function to be fired when mouse is
        /// pressed over the element. if false is passed
        /// instead, the previously firing function will no
        /// longer fire.</param>
        abstract mousePressed: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .doubleClicked() function is called once after
        /// every time a mouse button is pressed twice over
        /// the element. This can be used to attach element
        /// and action specific event listeners.</summary>
        /// <param name="fxn">function to be fired when mouse is
        /// double clicked over the element. if false is
        /// passed instead, the previously firing function
        /// will no longer fire.</param>
        abstract doubleClicked: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .mouseWheel() function is called once after
        /// every time a mouse wheel is scrolled over the
        /// element. This can be used to attach element
        /// specific event listeners.  The function accepts a
        /// callback function as argument which will be
        /// executed when the wheel event is triggered on the
        /// element, the callback function is passed one
        /// argument event. The event.deltaY property returns
        /// negative values if the mouse wheel is rotated up
        /// or away from the user and positive in the other
        /// direction. The event.deltaX does the same as
        /// event.deltaY except it reads the horizontal wheel
        /// scroll of the mouse wheel.
        /// 
        /// 
        /// On OS X with "natural" scrolling enabled, the
        /// event.deltaY values are reversed.</summary>
        /// <param name="fxn">function to be fired when mouse is
        /// scrolled over the element. if false is passed
        /// instead, the previously firing function will no
        /// longer fire.</param>
        abstract mouseWheel: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .mouseReleased() function is called once after
        /// every time a mouse button is released over the
        /// element. Some mobile browsers may also trigger
        /// this event on a touch screen, if the user performs
        /// a quick tap. This can be used to attach element
        /// specific event listeners.</summary>
        /// <param name="fxn">function to be fired when mouse is
        /// released over the element. if false is passed
        /// instead, the previously firing function will no
        /// longer fire.</param>
        abstract mouseReleased: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .mouseClicked() function is called once after
        /// a mouse button is pressed and released over the
        /// element. Some mobile browsers may also trigger
        /// this event on a touch screen, if the user performs
        /// a quick tap. This can be used to attach element
        /// specific event listeners.</summary>
        /// <param name="fxn">function to be fired when mouse is
        /// clicked over the element. if false is passed
        /// instead, the previously firing function will no
        /// longer fire.</param>
        abstract mouseClicked: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .mouseMoved() function is called once every
        /// time a mouse moves over the element. This can be
        /// used to attach an element specific event listener.</summary>
        /// <param name="fxn">function to be fired when a mouse moves
        /// over the element. if false is passed instead, the
        /// previously firing function will no longer fire.</param>
        abstract mouseMoved: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .mouseOver() function is called once after
        /// every time a mouse moves onto the element. This
        /// can be used to attach an element specific event
        /// listener.</summary>
        /// <param name="fxn">function to be fired when a mouse moves
        /// onto the element. if false is passed instead, the
        /// previously firing function will no longer fire.</param>
        abstract mouseOver: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .changed() function is called when the value
        /// of an element changes. This can be used to attach
        /// an element specific event listener.</summary>
        /// <param name="fxn">function to be fired when the value of
        /// an element changes. if false is passed instead,
        /// the previously firing function will no longer
        /// fire.</param>
        abstract changed: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .input() function is called when any user
        /// input is detected with an element. The input event
        /// is often used to detect keystrokes in a input
        /// element, or changes on a slider element. This can
        /// be used to attach an element specific event
        /// listener.</summary>
        /// <param name="fxn">function to be fired when any user
        /// input is detected within the element. if false is
        /// passed instead, the previously firing function
        /// will no longer fire.</param>
        abstract input: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .mouseOut() function is called once after
        /// every time a mouse moves off the element. This can
        /// be used to attach an element specific event
        /// listener.</summary>
        /// <param name="fxn">function to be fired when a mouse moves
        /// off of an element. if false is passed instead, the
        /// previously firing function will no longer fire.</param>
        abstract mouseOut: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .touchStarted() function is called once after
        /// every time a touch is registered. This can be used
        /// to attach element specific event listeners.</summary>
        /// <param name="fxn">function to be fired when a touch
        /// starts over the element. if false is passed
        /// instead, the previously firing function will no
        /// longer fire.</param>
        abstract touchStarted: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .touchMoved() function is called once after
        /// every time a touch move is registered. This can be
        /// used to attach element specific event listeners.</summary>
        /// <param name="fxn">function to be fired when a touch moves
        /// over the element. if false is passed instead, the
        /// previously firing function will no longer fire.</param>
        abstract touchMoved: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .touchEnded() function is called once after
        /// every time a touch is registered. This can be used
        /// to attach element specific event listeners.</summary>
        /// <param name="fxn">function to be fired when a touch ends
        /// over the element. if false is passed instead, the
        /// previously firing function will no longer fire.</param>
        abstract touchEnded: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .dragOver() function is called once after
        /// every time a file is dragged over the element.
        /// This can be used to attach an element specific
        /// event listener.</summary>
        /// <param name="fxn">function to be fired when a file is
        /// dragged over the element. if false is passed
        /// instead, the previously firing function will no
        /// longer fire.</param>
        abstract dragOver: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>The .dragLeave() function is called once after
        /// every time a dragged file leaves the element area.
        /// This can be used to attach an element specific
        /// event listener.</summary>
        /// <param name="fxn">function to be fired when a file is
        /// dragged off the element. if false is passed
        /// instead, the previously firing function will no
        /// longer fire.</param>
        abstract dragLeave: fxn: U2<(ResizeArray<obj option> -> obj option), bool> -> Element
        /// <summary>Registers a callback that gets called every time a
        /// file that is dropped on the element has been
        /// loaded. p5 will load every dropped file into
        /// memory and pass it as a p5.File object to the
        /// callback. Multiple files dropped at the same time
        /// will result in multiple calls to the callback. You
        /// can optionally pass a second callback which will
        /// be registered to the raw drop event. The callback
        /// will thus be provided the original DragEvent.
        /// Dropping multiple files at the same time will
        /// trigger the second callback once per drop, whereas
        /// the first callback will trigger for each loaded
        /// file.</summary>
        /// <param name="callback">callback to receive loaded file.</param>
        /// <param name="fxn">callback triggered when files are
        /// dropped.</param>
        abstract drop: callback: (ResizeArray<obj option> -> obj option) * ?fxn: (ResizeArray<obj option> -> obj option) -> Element
        /// Underlying HTML element. All normal HTML methods
        /// can be called on this.
        abstract elt: obj option with get, set

    type [<AllowNullLiteral>] ElementStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Element
module P5 = ______index
let [<Import("*","p5/src/core/p5.Graphics")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Graphics: GraphicsStatic

    type [<AllowNullLiteral>] Graphics =
        inherit Element
        /// Removes a Graphics object from the page and frees
        /// any resources associated with it.
        abstract remove: unit -> unit

    type [<AllowNullLiteral>] GraphicsStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Graphics
module P5 = ______index
let [<Import("*","p5/src/image/p5.Image")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Image: ImageStatic

    type [<AllowNullLiteral>] Image =
        /// Loads the pixels data for this image into the
        /// [pixels] attribute.
        abstract loadPixels: unit -> unit
        /// <summary>Updates the backing canvas for this image with the
        /// contents of the [pixels] array.</summary>
        /// <param name="x">x-offset of the target update area for
        /// the underlying canvas</param>
        /// <param name="y">y-offset of the target update area for
        /// the underlying canvas</param>
        /// <param name="w">height of the target update area for the
        /// underlying canvas</param>
        /// <param name="h">height of the target update area for the
        /// underlying canvas</param>
        abstract updatePixels: x: float * y: float * w: float * h: float -> unit
        /// Updates the backing canvas for this image with the
        /// contents of the [pixels] array.
        abstract updatePixels: unit -> unit
        /// <summary>Get a region of pixels from an image. If no params
        /// are passed, those whole image is returned, if x
        /// and y are the only params passed a single pixel is
        /// extracted if all params are passed a rectangle
        /// region is extracted and a p5.Image is returned.
        /// 
        /// Returns undefined if the region is outside the
        /// bounds of the image</summary>
        /// <param name="x">x-coordinate of the pixel</param>
        /// <param name="y">y-coordinate of the pixel</param>
        /// <param name="w">width</param>
        /// <param name="h">height</param>
        abstract get: ?x: float * ?y: float * ?w: float * ?h: float -> U3<ResizeArray<float>, Color, Image>
        /// <summary>Set the color of a single pixel or write an image
        /// into this p5.Image. Note that for a large number
        /// of pixels this will be slower than directly
        /// manipulating the pixels array and then calling
        /// updatePixels().</summary>
        /// <param name="x">x-coordinate of the pixel</param>
        /// <param name="y">y-coordinate of the pixel</param>
        /// <param name="a">grayscale value | pixel array | a
        /// p5.Color | image to copy</param>
        abstract set: x: float * y: float * a: U3<float, ResizeArray<float>, obj> -> unit
        /// <summary>Resize the image to a new width and height. To
        /// make the image scale proportionally, use 0 as the
        /// value for the wide or high parameter. For
        /// instance, to make the width of an image 150
        /// pixels, and change the height using the same
        /// proportion, use resize(150, 0).</summary>
        /// <param name="width">the resized image width</param>
        /// <param name="height">the resized image height</param>
        abstract resize: width: float * height: float -> unit
        /// <summary>Copies a region of pixels from one image to
        /// another. If no srcImage is specified this is used
        /// as the source. If the source and destination
        /// regions aren't the same size, it will
        /// automatically resize source pixels to fit the
        /// specified target region.</summary>
        /// <param name="srcImage">source image</param>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        abstract copy: srcImage: U2<Image, Element> * sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float -> unit
        /// <summary>Copies a region of pixels from one image to
        /// another. If no srcImage is specified this is used
        /// as the source. If the source and destination
        /// regions aren't the same size, it will
        /// automatically resize source pixels to fit the
        /// specified target region.</summary>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        abstract copy: sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float -> unit
        /// <summary>Masks part of an image from displaying by loading
        /// another image and using it's alpha channel as an
        /// alpha channel for this image.</summary>
        /// <param name="srcImage">source image</param>
        abstract mask: srcImage: Image -> unit
        /// <summary>Applies an image filter to a p5.Image</summary>
        /// <param name="filterType">either THRESHOLD, GRAY, OPAQUE,
        /// INVERT, POSTERIZE, BLUR, ERODE, DILATE or BLUR.
        /// See Filters.js for docs on each available filter</param>
        /// <param name="filterParam">an optional parameter unique
        /// to each filter, see above</param>
        abstract filter: filterType: FILTER_TYPE * ?filterParam: float -> unit
        /// <summary>Copies a region of pixels from one image to
        /// another, using a specified blend mode to do the
        /// operation.</summary>
        /// <param name="srcImage">source image</param>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        /// <param name="blendMode">the blend mode. either BLEND,
        /// DARKEST, LIGHTEST, DIFFERENCE, MULTIPLY,
        /// EXCLUSION, SCREEN, REPLACE, OVERLAY, HARD_LIGHT,
        /// SOFT_LIGHT, DODGE, BURN, ADD or NORMAL.
        /// 
        /// Available blend modes are: normal | multiply |
        /// screen | overlay | darken | lighten | color-dodge
        /// | color-burn | hard-light | soft-light |
        /// difference | exclusion | hue | saturation | color
        /// | luminosity
        /// 
        /// http://blogs.adobe.com/webplatform/2013/01/28/blending-features-in-canvas/</param>
        abstract blend: srcImage: Image * sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float * blendMode: BLEND_MODE -> unit
        /// <summary>Copies a region of pixels from one image to
        /// another, using a specified blend mode to do the
        /// operation.</summary>
        /// <param name="sx">X coordinate of the source's upper left
        /// corner</param>
        /// <param name="sy">Y coordinate of the source's upper left
        /// corner</param>
        /// <param name="sw">source image width</param>
        /// <param name="sh">source image height</param>
        /// <param name="dx">X coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dy">Y coordinate of the destination's upper
        /// left corner</param>
        /// <param name="dw">destination image width</param>
        /// <param name="dh">destination image height</param>
        /// <param name="blendMode">the blend mode. either BLEND,
        /// DARKEST, LIGHTEST, DIFFERENCE, MULTIPLY,
        /// EXCLUSION, SCREEN, REPLACE, OVERLAY, HARD_LIGHT,
        /// SOFT_LIGHT, DODGE, BURN, ADD or NORMAL.
        /// 
        /// Available blend modes are: normal | multiply |
        /// screen | overlay | darken | lighten | color-dodge
        /// | color-burn | hard-light | soft-light |
        /// difference | exclusion | hue | saturation | color
        /// | luminosity
        /// 
        /// http://blogs.adobe.com/webplatform/2013/01/28/blending-features-in-canvas/</param>
        abstract blend: sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float * blendMode: UNKNOWN_P5_CONSTANT -> unit
        /// <summary>Saves the image to a file and force the browser to
        /// download it. Accepts two strings for filename and
        /// file extension Supports png (default) and jpg.</summary>
        /// <param name="filename">give your file a name</param>
        /// <param name="extension">'png' or 'jpg'</param>
        abstract save: filename: string * extension: string -> unit
        /// Image width.
        abstract width: float with get, set
        /// Image height.
        abstract height: float with get, set
        /// Array containing the values for all the pixels in
        /// the display window. These values are numbers. This
        /// array is the size (include an appropriate factor
        /// for pixelDensity) of the display window x4,
        /// representing the R, G, B, A values in order for
        /// each pixel, moving from left to right across each
        /// row, then down each column. Retina and other high
        /// denisty displays may have more pixels (by a factor
        /// of pixelDensity^2). For example, if the image is
        /// 100x100 pixels, there will be 40,000. With
        /// pixelDensity = 2, there will be 160,000. The first
        /// four values (indices 0-3) in the array will be the
        /// R, G, B, A values of the pixel at (0, 0). The
        /// second four values (indices 4-7) will contain the
        /// R, G, B, A values of the pixel at (1, 0). More
        /// generally, to set values for a pixel at (x, y):
        /// var d = pixelDensity(); for (var i = 0; i < d;
        /// i++) { for (var j = 0; j < d; j++) { // loop over
        /// idx = 4 * ((y * d + j) * width * d + (x * d + i));
        /// pixels[idx] = r; pixels[idx+1] = g; pixels[idx+2]
        /// = b; pixels[idx+3] = a; } }
        /// 
        /// 
        /// 
        /// 
        /// Before accessing this array, the data must loaded
        /// with the loadPixels() function. After the array
        /// data has been modified, the updatePixels()
        /// function must be run to update the changes.
        abstract pixels: ResizeArray<float> with get, set

    type [<AllowNullLiteral>] ImageStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Image
module P5 = ______index
let [<Import("*","p5/src/io/p5.Table")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Table: TableStatic

    type [<AllowNullLiteral>] Table =
        /// <summary>Use addRow() to add a new row of data to a
        /// p5.Table object. By default, an empty row is
        /// created. Typically, you would store a reference to
        /// the new row in a TableRow object (see newRow in
        /// the example above), and then set individual values
        /// using set(). If a p5.TableRow object is included
        /// as a parameter, then that row is duplicated and
        /// added to the table.</summary>
        /// <param name="row">row to be added to the table</param>
        abstract addRow: ?row: TableRow -> TableRow
        /// <summary>Removes a row from the table object.</summary>
        /// <param name="id">ID number of the row to remove</param>
        abstract removeRow: id: float -> unit
        /// <summary>Returns a reference to the specified p5.TableRow.
        /// The reference can then be used to get and set
        /// values of the selected row.</summary>
        /// <param name="rowID">ID number of the row to get</param>
        abstract getRow: rowID: float -> TableRow
        /// Gets all rows from the table. Returns an array of
        /// p5.TableRows.
        abstract getRows: unit -> ResizeArray<TableRow>
        /// <summary>Finds the first row in the Table that contains the
        /// value provided, and returns a reference to that
        /// row. Even if multiple rows are possible matches,
        /// only the first matching row is returned. The
        /// column to search may be specified by either its ID
        /// or title.</summary>
        /// <param name="value">The value to match</param>
        /// <param name="column">ID number or title of the column to
        /// search</param>
        abstract findRow: value: string * column: U2<float, string> -> TableRow
        /// <summary>Finds the rows in the Table that contain the value
        /// provided, and returns references to those rows.
        /// Returns an Array, so for must be used to iterate
        /// through all the rows, as shown in the example
        /// above. The column to search may be specified by
        /// either its ID or title.</summary>
        /// <param name="value">The value to match</param>
        /// <param name="column">ID number or title of the column to
        /// search</param>
        abstract findRows: value: string * column: U2<float, string> -> ResizeArray<TableRow>
        /// <summary>Finds the first row in the Table that matches the
        /// regular expression provided, and returns a
        /// reference to that row. Even if multiple rows are
        /// possible matches, only the first matching row is
        /// returned. The column to search may be specified by
        /// either its ID or title.</summary>
        /// <param name="regexp">The regular expression to match</param>
        /// <param name="column">The column ID (number) or title
        /// (string)</param>
        abstract matchRow: regexp: U2<string, RegExp> * column: U2<string, float> -> TableRow
        /// <summary>Finds the rows in the Table that match the regular
        /// expression provided, and returns references to
        /// those rows. Returns an array, so for must be used
        /// to iterate through all the rows, as shown in the
        /// example. The column to search may be specified by
        /// either its ID or title.</summary>
        /// <param name="regexp">The regular expression to match</param>
        /// <param name="column">The column ID (number) or title
        /// (string)</param>
        abstract matchRows: regexp: string * ?column: U2<string, float> -> ResizeArray<TableRow>
        /// <summary>Retrieves all values in the specified column, and
        /// returns them as an array. The column may be
        /// specified by either its ID or title.</summary>
        /// <param name="column">String or Number of the column to
        /// return</param>
        abstract getColumn: column: U2<string, float> -> ResizeArray<obj option>
        /// Removes all rows from a Table. While all rows are
        /// removed, columns and column titles are maintained.
        abstract clearRows: unit -> unit
        /// <summary>Use addColumn() to add a new column to a Table
        /// object. Typically, you will want to specify a
        /// title, so the column may be easily referenced
        /// later by name. (If no title is specified, the new
        /// column's title will be null.)</summary>
        /// <param name="title">title of the given column</param>
        abstract addColumn: ?title: string -> unit
        /// Returns the total number of columns in a Table.
        abstract getColumnCount: unit -> float
        /// Returns the total number of rows in a Table.
        abstract getRowCount: unit -> float
        /// <summary>Removes any of the specified characters (or
        /// "tokens"). If no column is specified, then the
        /// values in all columns and rows are processed. A
        /// specific column may be referenced by either its ID
        /// or title.</summary>
        /// <param name="chars">String listing characters to be
        /// removed</param>
        /// <param name="column">Column ID (number) or name
        /// (string)</param>
        abstract removeTokens: chars: string * ?column: U2<string, float> -> unit
        /// <summary>Trims leading and trailing whitespace, such as
        /// spaces and tabs, from String table values. If no
        /// column is specified, then the values in all
        /// columns and rows are trimmed. A specific column
        /// may be referenced by either its ID or title.</summary>
        /// <param name="column">Column ID (number) or name
        /// (string)</param>
        abstract trim: ?column: U2<string, float> -> unit
        /// <summary>Use removeColumn() to remove an existing column
        /// from a Table object. The column to be removed may
        /// be identified by either its title (a String) or
        /// its index value (an int). removeColumn(0) would
        /// remove the first column, removeColumn(1) would
        /// remove the second column, and so on.</summary>
        /// <param name="column">columnName (string) or ID (number)</param>
        abstract removeColumn: column: U2<string, float> -> unit
        /// <summary>Stores a value in the Table's specified row and
        /// column. The row is specified by its ID, while the
        /// column may be specified by either its ID or title.</summary>
        /// <param name="row">row ID</param>
        /// <param name="column">column ID (Number) or title (String)</param>
        /// <param name="value">value to assign</param>
        abstract set: row: float * column: U2<string, float> * value: U2<string, float> -> unit
        /// <summary>Stores a Float value in the Table's specified row
        /// and column. The row is specified by its ID, while
        /// the column may be specified by either its ID or
        /// title.</summary>
        /// <param name="row">row ID</param>
        /// <param name="column">column ID (Number) or title (String)</param>
        /// <param name="value">value to assign</param>
        abstract setNum: row: float * column: U2<string, float> * value: float -> unit
        /// <summary>Stores a String value in the Table's specified row
        /// and column. The row is specified by its ID, while
        /// the column may be specified by either its ID or
        /// title.</summary>
        /// <param name="row">row ID</param>
        /// <param name="column">column ID (Number) or title (String)</param>
        /// <param name="value">value to assign</param>
        abstract setString: row: float * column: U2<string, float> * value: string -> unit
        /// <summary>Retrieves a value from the Table's specified row
        /// and column. The row is specified by its ID, while
        /// the column may be specified by either its ID or
        /// title.</summary>
        /// <param name="row">row ID</param>
        /// <param name="column">columnName (string) or ID (number)</param>
        abstract get: row: float * column: U2<string, float> -> U2<string, float>
        /// <summary>Retrieves a Float value from the Table's specified
        /// row and column. The row is specified by its ID,
        /// while the column may be specified by either its ID
        /// or title.</summary>
        /// <param name="row">row ID</param>
        /// <param name="column">columnName (string) or ID (number)</param>
        abstract getNum: row: float * column: U2<string, float> -> float
        /// <summary>Retrieves a String value from the Table's
        /// specified row and column. The row is specified by
        /// its ID, while the column may be specified by
        /// either its ID or title.</summary>
        /// <param name="row">row ID</param>
        /// <param name="column">columnName (string) or ID (number)</param>
        abstract getString: row: float * column: U2<string, float> -> string
        /// <summary>Retrieves all table data and returns as an object.
        /// If a column name is passed in, each row object
        /// will be stored with that attribute as its title.</summary>
        /// <param name="headerColumn">Name of the column which
        /// should be used to title each row object (optional)</param>
        abstract getObject: ?headerColumn: string -> obj
        /// Retrieves all table data and returns it as a
        /// multidimensional array.
        abstract getArray: unit -> ResizeArray<obj option>
        abstract columns: ResizeArray<string> with get, set
        abstract rows: ResizeArray<TableRow> with get, set

    type [<AllowNullLiteral>] TableStatic =
        /// <summary>Table objects store data with multiple rows and
        /// columns, much like in a traditional spreadsheet.
        /// Tables can be generated from scratch, dynamically,
        /// or using data from an existing file.</summary>
        /// <param name="rows">An array of p5.TableRow objects</param>
        [<Emit "new $0($1...)">] abstract Create: ?rows: ResizeArray<TableRow> -> Table
module P5 = ______index
let [<Import("*","p5/src/io/p5.TableRow")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract TableRow: TableRowStatic

    type [<AllowNullLiteral>] TableRow =
        /// <summary>Stores a value in the TableRow's specified column.
        /// The column may be specified by either its ID or
        /// title.</summary>
        /// <param name="column">Column ID (Number) or Title (String)</param>
        /// <param name="value">The value to be stored</param>
        abstract set: column: U2<string, float> * value: U2<string, float> -> unit
        /// <summary>Stores a Float value in the TableRow's specified
        /// column. The column may be specified by either its
        /// ID or title.</summary>
        /// <param name="column">Column ID (Number) or Title (String)</param>
        /// <param name="value">The value to be stored as a Float</param>
        abstract setNum: column: U2<string, float> * value: U2<float, string> -> unit
        /// <summary>Stores a String value in the TableRow's specified
        /// column. The column may be specified by either its
        /// ID or title.</summary>
        /// <param name="column">Column ID (Number) or Title (String)</param>
        /// <param name="value">The value to be stored as a String</param>
        abstract setString: column: U2<string, float> * value: U4<string, float, bool, obj> -> unit
        /// <summary>Retrieves a value from the TableRow's specified
        /// column. The column may be specified by either its
        /// ID or title.</summary>
        /// <param name="column">columnName (string) or ID (number)</param>
        abstract get: column: U2<string, float> -> U2<string, float>
        /// <summary>Retrieves a Float value from the TableRow's
        /// specified column. The column may be specified by
        /// either its ID or title.</summary>
        /// <param name="column">columnName (string) or ID (number)</param>
        abstract getNum: column: U2<string, float> -> float
        /// <summary>Retrieves an String value from the TableRow's
        /// specified column. The column may be specified by
        /// either its ID or title.</summary>
        /// <param name="column">columnName (string) or ID (number)</param>
        abstract getString: column: U2<string, float> -> string

    type [<AllowNullLiteral>] TableRowStatic =
        /// <summary>A TableRow object represents a single row of data
        /// values, stored in columns, from a table. A Table
        /// Row contains both an ordered array, and an
        /// unordered JSON object.</summary>
        /// <param name="str">optional: populate the row with a
        /// string of values, separated by the separator</param>
        /// <param name="separator">comma separated values (csv) by
        /// default</param>
        [<Emit "new $0($1...)">] abstract Create: ?str: string * ?separator: string -> TableRow
module P5 = ______index
let [<Import("*","p5/src/io/p5.XML")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract XML: XMLStatic

    type [<AllowNullLiteral>] XML =
        /// Gets a copy of the element's parent. Returns the
        /// parent as another p5.XML object.
        abstract getParent: unit -> XML
        /// Gets the element's full name, which is returned as
        /// a String.
        abstract getName: unit -> string
        /// <summary>Sets the element's name, which is specified as a
        /// String.</summary>
        /// <param name="the">new name of the node</param>
        abstract setName: the: string -> unit
        /// Checks whether or not the element has any
        /// children, and returns the result as a boolean.
        abstract hasChildren: unit -> bool
        /// Get the names of all of the element's children,
        /// and returns the names as an array of Strings. This
        /// is the same as looping through and calling
        /// getName() on each child element individually.
        abstract listChildren: unit -> ResizeArray<string>
        /// <summary>Returns all of the element's children as an array
        /// of p5.XML objects. When the name parameter is
        /// specified, then it will return all children that
        /// match that name.</summary>
        /// <param name="name">element name</param>
        abstract getChildren: ?name: string -> ResizeArray<XML>
        /// <summary>Returns the first of the element's children that
        /// matches the name parameter or the child of the
        /// given index.It returns undefined if no matching
        /// child is found.</summary>
        /// <param name="name">element name or index</param>
        abstract getChild: name: U2<string, float> -> XML
        /// <summary>Appends a new child to the element. The child can
        /// be specified with either a String, which will be
        /// used as the new tag's name, or as a reference to
        /// an existing p5.XML object. A reference to the
        /// newly created child is returned as an p5.XML
        /// object.</summary>
        /// <param name="node">a p5.XML Object which will be the
        /// child to be added</param>
        abstract addChild: node: XML -> unit
        /// <summary>Removes the element specified by name or index.</summary>
        /// <param name="name">element name or index</param>
        abstract removeChild: name: U2<string, float> -> unit
        /// Counts the specified element's number of
        /// attributes, returned as an Number.
        abstract getAttributeCount: unit -> float
        /// Gets all of the specified element's attributes,
        /// and returns them as an array of Strings.
        abstract listAttributes: unit -> ResizeArray<string>
        /// <summary>Checks whether or not an element has the specified
        /// attribute.</summary>
        /// <param name="the">attribute to be checked</param>
        abstract hasAttribute: the: string -> bool
        /// <summary>Returns an attribute value of the element as an
        /// Number. If the defaultValue parameter is specified
        /// and the attribute doesn't exist, then defaultValue
        /// is returned. If no defaultValue is specified and
        /// the attribute doesn't exist, the value 0 is
        /// returned.</summary>
        /// <param name="name">the non-null full name of the
        /// attribute</param>
        /// <param name="defaultValue">the default value of the
        /// attribute</param>
        abstract getNum: name: string * ?defaultValue: float -> float
        /// <summary>Returns an attribute value of the element as an
        /// String. If the defaultValue parameter is specified
        /// and the attribute doesn't exist, then defaultValue
        /// is returned. If no defaultValue is specified and
        /// the attribute doesn't exist, null is returned.</summary>
        /// <param name="name">the non-null full name of the
        /// attribute</param>
        /// <param name="defaultValue">the default value of the
        /// attribute</param>
        abstract getString: name: string * ?defaultValue: float -> string
        /// <summary>Sets the content of an element's attribute. The
        /// first parameter specifies the attribute name,
        /// while the second specifies the new content.</summary>
        /// <param name="name">the full name of the attribute</param>
        /// <param name="value">the value of the attribute</param>
        abstract setAttribute: name: string * value: U3<float, string, bool> -> unit
        /// <summary>Returns the content of an element. If there is no
        /// such content, defaultValue is returned if
        /// specified, otherwise null is returned.</summary>
        /// <param name="defaultValue">value returned if no content
        /// is found</param>
        abstract getContent: ?defaultValue: string -> string
        /// <summary>Sets the element's content.</summary>
        /// <param name="text">the new content</param>
        abstract setContent: text: string -> unit

    type [<AllowNullLiteral>] XMLStatic =
        /// XML is a representation of an XML object, able to
        /// parse XML code. Use loadXML() to load external XML
        /// files and create XML objects.
        [<Emit "new $0($1...)">] abstract Create: unit -> XML
module P5 = ______index
let [<Import("*","p5/src/math/p5.Vector")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Vector: VectorStatic

    type [<AllowNullLiteral>] Vector =
        /// Returns a string representation of a vector v by
        /// calling String(v) or v.toString(). This method is
        /// useful for logging vectors in the console.
        abstract toString: unit -> string
        /// <summary>Sets the x, y, and z component of the vector using
        /// two or three separate variables, the data from a
        /// p5.Vector, or the values from a float array.</summary>
        /// <param name="x">the x component of the vector</param>
        /// <param name="y">the y component of the vector</param>
        /// <param name="z">the z component of the vector</param>
        abstract set: ?x: float * ?y: float * ?z: float -> Vector
        /// <summary>Sets the x, y, and z component of the vector using
        /// two or three separate variables, the data from a
        /// p5.Vector, or the values from a float array.</summary>
        /// <param name="value">the vector to set</param>
        abstract set: value: U2<Vector, ResizeArray<float>> -> Vector
        /// Gets a copy of the vector, returns a p5.Vector
        /// object.
        abstract copy: unit -> Vector
        /// <summary>Adds x, y, and z components to a vector, adds one
        /// vector to another, or adds two independent vectors
        /// together. The version of the method that adds two
        /// vectors together is a static method and returns a
        /// p5.Vector, the others acts directly on the vector.
        /// See the examples for more context.</summary>
        /// <param name="x">the x component of the vector to be added</param>
        /// <param name="y">the y component of the vector to be
        /// added</param>
        /// <param name="z">the z component of the vector to be
        /// added</param>
        abstract add: x: float * ?y: float * ?z: float -> Vector
        /// <summary>Adds x, y, and z components to a vector, adds one
        /// vector to another, or adds two independent vectors
        /// together. The version of the method that adds two
        /// vectors together is a static method and returns a
        /// p5.Vector, the others acts directly on the vector.
        /// See the examples for more context.</summary>
        /// <param name="value">the vector to add</param>
        abstract add: value: U2<Vector, ResizeArray<float>> -> Vector
        /// <summary>Subtracts x, y, and z components from a vector,
        /// subtracts one vector from another, or subtracts
        /// two independent vectors. The version of the method
        /// that subtracts two vectors is a static method and
        /// returns a p5.Vector, the other acts directly on
        /// the vector. See the examples for more context.</summary>
        /// <param name="x">the x component of the vector to subtract</param>
        /// <param name="y">the y component of the vector to
        /// subtract</param>
        /// <param name="z">the z component of the vector to
        /// subtract</param>
        abstract sub: x: float * ?y: float * ?z: float -> Vector
        /// <summary>Subtracts x, y, and z components from a vector,
        /// subtracts one vector from another, or subtracts
        /// two independent vectors. The version of the method
        /// that subtracts two vectors is a static method and
        /// returns a p5.Vector, the other acts directly on
        /// the vector. See the examples for more context.</summary>
        /// <param name="value">the vector to subtract</param>
        abstract sub: value: U2<Vector, ResizeArray<float>> -> Vector
        /// <summary>Multiply the vector by a scalar. The static
        /// version of this method creates a new p5.Vector
        /// while the non static version acts on the vector
        /// directly. See the examples for more context.</summary>
        /// <param name="n">the number to multiply with the vector</param>
        abstract mult: n: float -> Vector
        /// <summary>Divide the vector by a scalar. The static version
        /// of this method creates a new p5.Vector while the
        /// non static version acts on the vector directly.
        /// See the examples for more context.</summary>
        /// <param name="n">the number to divide the vector by</param>
        abstract div: n: float -> Vector
        /// Calculates the magnitude (length) of the vector
        /// and returns the result as a float (this is simply
        /// the equation sqrt(xx + yy + z*z).)
        abstract mag: unit -> float
        /// Calculates the squared magnitude of the vector and
        /// returns the result as a float (this is simply the
        /// equation (xx + yy + z*z).) Faster if the real
        /// length is not required in the case of comparing
        /// vectors, etc.
        abstract magSq: unit -> float
        /// <summary>Calculates the dot product of two vectors. The
        /// version of the method that computes the dot
        /// product of two independent vectors is a static
        /// method. See the examples for more context.</summary>
        /// <param name="x">x component of the vector</param>
        /// <param name="y">y component of the vector</param>
        /// <param name="z">z component of the vector</param>
        abstract dot: x: float * ?y: float * ?z: float -> float
        /// <summary>Calculates the dot product of two vectors. The
        /// version of the method that computes the dot
        /// product of two independent vectors is a static
        /// method. See the examples for more context.</summary>
        /// <param name="value">value component of the vector or a
        /// p5.Vector</param>
        abstract dot: value: Vector -> float
        /// <summary>Calculates and returns a vector composed of the
        /// cross product between two vectors. Both the static
        /// and non static methods return a new p5.Vector. See
        /// the examples for more context.</summary>
        /// <param name="v">p5.Vector to be crossed</param>
        abstract cross: v: Vector -> Vector
        /// <summary>Calculates the Euclidean distance between two
        /// points (considering a point as a vector object).</summary>
        /// <param name="v">the x, y, and z coordinates of a
        /// p5.Vector</param>
        abstract dist: v: Vector -> float
        /// Normalize the vector to length 1 (make it a unit
        /// vector).
        abstract normalize: unit -> Vector
        /// <summary>Limit the magnitude of this vector to the value
        /// used for the max parameter.</summary>
        /// <param name="max">the maximum magnitude for the vector</param>
        abstract limit: max: float -> Vector
        /// <summary>Set the magnitude of this vector to the value used
        /// for the len parameter.</summary>
        /// <param name="len">the new length for this vector</param>
        abstract setMag: len: float -> Vector
        /// Calculate the angle of rotation for this vector
        /// (only 2D vectors)
        abstract heading: unit -> float
        /// <summary>Rotate the vector by an angle (only 2D vectors),
        /// magnitude remains the same</summary>
        /// <param name="angle">the angle of rotation</param>
        abstract rotate: angle: float -> Vector
        /// <summary>Calculates and returns the angle (in radians)
        /// between two vectors.</summary>
        /// <param name="the">x, y, and z components of a p5.Vector</param>
        abstract angleBetween: the: Vector -> float
        /// <summary>Linear interpolate the vector to another vector</summary>
        /// <param name="x">the x component</param>
        /// <param name="y">the y component</param>
        /// <param name="z">the z component</param>
        /// <param name="amt">the amount of interpolation; some value
        /// between 0.0 (old vector) and 1.0 (new vector). 0.9
        /// is very near the new vector. 0.5 is halfway in
        /// between.</param>
        abstract lerp: x: float * y: float * z: float * amt: float -> Vector
        /// <summary>Linear interpolate the vector to another vector</summary>
        /// <param name="v">the p5.Vector to lerp to</param>
        /// <param name="amt">the amount of interpolation; some value
        /// between 0.0 (old vector) and 1.0 (new vector). 0.9
        /// is very near the new vector. 0.5 is halfway in
        /// between.</param>
        abstract lerp: v: Vector * amt: float -> Vector
        /// Return a representation of this vector as a float
        /// array. This is only for temporary use. If used in
        /// any other fashion, the contents should be copied
        /// by using the p5.Vector.copy() method to copy into
        /// your own array.
        abstract array: unit -> ResizeArray<float>
        /// <summary>Equality check against a p5.Vector</summary>
        /// <param name="x">the x component of the vector</param>
        /// <param name="y">the y component of the vector</param>
        /// <param name="z">the z component of the vector</param>
        abstract equals: ?x: float * ?y: float * ?z: float -> bool
        /// <summary>Equality check against a p5.Vector</summary>
        /// <param name="value">the vector to compare</param>
        abstract equals: value: U2<Vector, ResizeArray<obj option>> -> bool
        /// The x component of the vector
        abstract x: float with get, set
        /// The y component of the vector
        abstract y: float with get, set
        /// The z component of the vector
        abstract z: float with get, set

    type [<AllowNullLiteral>] VectorStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Vector
        /// <summary>Adds x, y, and z components to a vector, adds one
        /// vector to another, or adds two independent vectors
        /// together. The version of the method that adds two
        /// vectors together is a static method and returns a
        /// p5.Vector, the others acts directly on the vector.
        /// See the examples for more context.</summary>
        /// <param name="v1">a p5.Vector to add</param>
        /// <param name="v2">a p5.Vector to add</param>
        /// <param name="target">the vector to receive the result</param>
        abstract add: v1: Vector * v2: Vector * target: Vector -> unit
        /// <summary>Adds x, y, and z components to a vector, adds one
        /// vector to another, or adds two independent vectors
        /// together. The version of the method that adds two
        /// vectors together is a static method and returns a
        /// p5.Vector, the others acts directly on the vector.
        /// See the examples for more context.</summary>
        /// <param name="v1">a p5.Vector to add</param>
        /// <param name="v2">a p5.Vector to add</param>
        abstract add: v1: Vector * v2: Vector -> Vector
        /// <summary>Subtracts x, y, and z components from a vector,
        /// subtracts one vector from another, or subtracts
        /// two independent vectors. The version of the method
        /// that subtracts two vectors is a static method and
        /// returns a p5.Vector, the other acts directly on
        /// the vector. See the examples for more context.</summary>
        /// <param name="v1">a p5.Vector to subtract from</param>
        /// <param name="v2">a p5.Vector to subtract</param>
        /// <param name="target">if undefined a new vector will be
        /// created</param>
        abstract sub: v1: Vector * v2: Vector * target: Vector -> unit
        /// <summary>Subtracts x, y, and z components from a vector,
        /// subtracts one vector from another, or subtracts
        /// two independent vectors. The version of the method
        /// that subtracts two vectors is a static method and
        /// returns a p5.Vector, the other acts directly on
        /// the vector. See the examples for more context.</summary>
        /// <param name="v1">a p5.Vector to subtract from</param>
        /// <param name="v2">a p5.Vector to subtract</param>
        abstract sub: v1: Vector * v2: Vector -> Vector
        /// <summary>Multiply the vector by a scalar. The static
        /// version of this method creates a new p5.Vector
        /// while the non static version acts on the vector
        /// directly. See the examples for more context.</summary>
        /// <param name="v">the vector to multiply</param>
        /// <param name="n">the number to multiply with the vector</param>
        /// <param name="target">if undefined a new vector will be
        /// created</param>
        abstract mult: v: Vector * n: float * target: Vector -> unit
        /// <summary>Multiply the vector by a scalar. The static
        /// version of this method creates a new p5.Vector
        /// while the non static version acts on the vector
        /// directly. See the examples for more context.</summary>
        /// <param name="v">the vector to multiply</param>
        /// <param name="n">the number to multiply with the vector</param>
        abstract mult: v: Vector * n: float -> Vector
        /// <summary>Divide the vector by a scalar. The static version
        /// of this method creates a new p5.Vector while the
        /// non static version acts on the vector directly.
        /// See the examples for more context.</summary>
        /// <param name="v">the vector to divide</param>
        /// <param name="n">the number to divide the vector by</param>
        /// <param name="target">if undefined a new vector will be
        /// created</param>
        abstract div: v: Vector * n: float * target: Vector -> unit
        /// <summary>Divide the vector by a scalar. The static version
        /// of this method creates a new p5.Vector while the
        /// non static version acts on the vector directly.
        /// See the examples for more context.</summary>
        /// <param name="v">the vector to divide</param>
        /// <param name="n">the number to divide the vector by</param>
        abstract div: v: Vector * n: float -> Vector
        /// <summary>Calculates the magnitude (length) of the vector
        /// and returns the result as a float (this is simply
        /// the equation sqrt(xx + yy + z*z).)</summary>
        /// <param name="vecT">the vector to return the magnitude of</param>
        abstract mag: vecT: Vector -> float
        /// <summary>Calculates the dot product of two vectors. The
        /// version of the method that computes the dot
        /// product of two independent vectors is a static
        /// method. See the examples for more context.</summary>
        /// <param name="v1">the first p5.Vector</param>
        /// <param name="v2">the second p5.Vector</param>
        abstract dot: v1: Vector * v2: Vector -> float
        /// <summary>Calculates and returns a vector composed of the
        /// cross product between two vectors. Both the static
        /// and non static methods return a new p5.Vector. See
        /// the examples for more context.</summary>
        /// <param name="v1">the first p5.Vector</param>
        /// <param name="v2">the second p5.Vector</param>
        abstract cross: v1: Vector * v2: Vector -> float
        /// <summary>Calculates the Euclidean distance between two
        /// points (considering a point as a vector object).</summary>
        /// <param name="v1">the first p5.Vector</param>
        /// <param name="v2">the second p5.Vector</param>
        abstract dist: v1: Vector * v2: Vector -> float
        /// <summary>Linear interpolate the vector to another vector</summary>
        /// <param name="amt">the amount of interpolation; some value
        /// between 0.0 (old vector) and 1.0 (new vector). 0.9
        /// is very near the new vector. 0.5 is halfway in
        /// between.</param>
        /// <param name="target">if undefined a new vector will be
        /// created</param>
        abstract lerp: v1: Vector * v2: Vector * amt: float * target: Vector -> unit
        /// <summary>Linear interpolate the vector to another vector</summary>
        /// <param name="amt">the amount of interpolation; some value
        /// between 0.0 (old vector) and 1.0 (new vector). 0.9
        /// is very near the new vector. 0.5 is halfway in
        /// between.</param>
        abstract lerp: v1: Vector * v2: Vector * amt: float -> float
        /// <summary>Make a new 2D vector from an angle</summary>
        /// <param name="angle">the desired angle, in radians</param>
        /// <param name="length">the length of the new vector
        /// (defaults to 1)</param>
        abstract fromAngle: angle: float * ?length: float -> Vector
        /// <summary>Make a new 3D vector from a pair of ISO spherical
        /// angles</summary>
        /// <param name="theta">the polar angle, in radians (zero is
        /// up)</param>
        /// <param name="phi">the azimuthal angle, in radians (zero
        /// is out of the screen)</param>
        /// <param name="length">the length of the new vector
        /// (defaults to 1)</param>
        abstract fromAngles: theta: float * phi: float * ?length: float -> Vector
        /// Make a new 2D unit vector from a random angle
        abstract random2D: unit -> Vector
        /// Make a new random 3D unit vector.
        abstract random3D: unit -> Vector
module P5 = ______index
let [<Import("*","p5/src/typography/p5.Font")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Font: FontStatic

    type [<AllowNullLiteral>] Font =
        /// <summary>Returns a tight bounding box for the given text
        /// string using this font (currently only supports
        /// single lines)</summary>
        /// <param name="line">a line of text</param>
        /// <param name="x">x-position</param>
        /// <param name="y">y-position</param>
        /// <param name="fontSize">font size to use (optional)</param>
        /// <param name="options">opentype options (optional)</param>
        abstract textBounds: line: string * x: float * y: float * ?fontSize: float * ?options: obj -> obj
        /// <summary>Computes an array of points following the path for
        /// specified text</summary>
        /// <param name="txt">a line of text</param>
        /// <param name="x">x-position</param>
        /// <param name="y">y-position</param>
        /// <param name="fontSize">font size to use (optional)</param>
        /// <param name="options">an (optional) object that can
        /// contain:
        /// 
        /// 
        /// sampleFactor - the ratio of path-length to number
        /// of samples (default=.25); higher values yield more
        /// points and are therefore more precise
        /// 
        /// 
        /// simplifyThreshold - if set to a non-zero value,
        /// collinear points will be be removed from the
        /// polygon; the value represents the threshold angle
        /// to use when determining whether two edges are
        /// collinear</param>
        abstract textToPoints: txt: string * x: float * y: float * fontSize: float * ?options: obj -> ResizeArray<obj option>
        /// Underlying opentype font implementation
        abstract font: obj option with get, set

    type [<AllowNullLiteral>] FontStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Font
module P5 = ______index
let [<Import("*","p5/src/webgl/p5.Geometry")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Geometry: GeometryStatic

    type [<AllowNullLiteral>] Geometry =
        abstract computeFaces: unit -> Geometry
        /// computes smooth normals per vertex as an average
        /// of each face.
        abstract computeNormals: unit -> Geometry
        /// Averages the vertex normals. Used in curved
        /// surfaces
        abstract averageNormals: unit -> Geometry
        /// Averages pole normals. Used in spherical
        /// primitives
        abstract averagePoleNormals: unit -> Geometry
        /// Modifies all vertices to be centered within the
        /// range -100 to 100.
        abstract normalize: unit -> Geometry

    type [<AllowNullLiteral>] GeometryStatic =
        /// <summary>p5 Geometry class</summary>
        /// <param name="detailX">number of vertices on horizontal
        /// surface</param>
        /// <param name="detailY">number of vertices on horizontal
        /// surface</param>
        /// <param name="callback">function to call upon object
        /// instantiation.</param>
        [<Emit "new $0($1...)">] abstract Create: ?detailX: float * ?detailY: float * ?callback: (ResizeArray<obj option> -> obj option) -> Geometry
module P5 = ______index
let [<Import("*","p5/src/webgl/p5.Shader")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Shader: ShaderStatic

    type [<AllowNullLiteral>] Shader =
        /// <summary>Wrapper around gl.uniform functions. As we store
        /// uniform info in the shader we can use that to do
        /// type checking on the supplied data and call the
        /// appropriate function.</summary>
        /// <param name="uniformName">the name of the uniform in the
        /// shader program</param>
        /// <param name="data">the data to be associated with that
        /// uniform; type varies (could be a single numerical
        /// value, array, matrix, or texture / sampler
        /// reference)</param>
        abstract setUniform: uniformName: string * data: U4<obj, float, bool, ResizeArray<float>> -> Shader

    type [<AllowNullLiteral>] ShaderStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Shader
module P5 = ______index
let [<Import("*","p5/src/core/p5.Renderer")>] ``../../index``: ______index.IExports = jsNative

module ______index =

    type [<AllowNullLiteral>] IExports =
        abstract Renderer: RendererStatic

    type [<AllowNullLiteral>] Renderer =
        inherit Element

    type [<AllowNullLiteral>] RendererStatic =
        /// <summary>Main graphics and rendering context, as well as
        /// the base API implementation for p5.js "core". To
        /// be used as the superclass for Renderer2D and
        /// Renderer3D classes, respecitvely.</summary>
        /// <param name="elt">DOM node that is wrapped</param>
        /// <param name="pInst">pointer to p5 instance</param>
        /// <param name="isMainCanvas">whether we're using it as
        /// main canvas</param>
        [<Emit "new $0($1...)">] abstract Create: elt: string * ?pInst: p5 * ?isMainCanvas: bool -> Renderer
module P5 = __index

module __index =

    type ADD =
        string

    type ARROW =
        string

    type AUDIO =
        string

    type AUTO =
        string

    type AXES =
        string

    type BASELINE =
        string

    type BEVEL =
        string

    type BLEND =
        string

    type BLUR =
        string

    type BOLD =
        string

    type BOTTOM =
        string

    type BURN =
        string

    type CENTER =
        string

    type CHORD =
        string

    type CLOSE =
        string

    type CORNER =
        string

    type CORNERS =
        string

    type CROSS =
        string

    type DARKEST =
        string

    type DEGREES =
        string

    type DIFFERENCE =
        string

    type DILATE =
        string

    type DODGE =
        string

    type ERODE =
        string

    type EXCLUSION =
        string

    type GRAY =
        string

    type GRID =
        string

    type HAND =
        string

    type HARD_LIGHT =
        string

    type HSB =
        string

    type HSL =
        string

    type INVERT =
        string

    type ITALIC =
        string

    type LANDSCAPE =
        string

    type LEFT =
        string

    type LIGHTEST =
        string

    type LINE_LOOP =
        obj

    type LINE_STRIP =
        obj

    type LINES =
        obj

    type MITER =
        string

    type MOVE =
        string

    type MULTIPLY =
        string

    type NORMAL =
        string

    type OPAQUE =
        string

    type OPEN =
        string

    type OVERLAY =
        string

    type P2D =
        string

    type PIE =
        string

    type POINTS =
        obj

    type PORTRAIT =
        string

    type POSTERIZE =
        string

    type PROJECT =
        string

    type QUAD_STRIP =
        string

    type QUADS =
        string

    type RADIANS =
        string

    type RADIUS =
        string

    type REPLACE =
        string

    type RGB =
        string

    type RIGHT =
        string

    type ROUND =
        string

    type SCREEN =
        string

    type SOFT_LIGHT =
        string

    type SQUARE =
        string

    type TEXT =
        string

    type THRESHOLD =
        string

    type TOP =
        string

    type TRIANGLE_FAN =
        obj

    type TRIANGLE_STRIP =
        obj

    type TRIANGLES =
        obj

    type VIDEO =
        string

    type WAIT =
        string

    type WEBGL =
        string
module P5 = __index

module __index =

    type ANGLE_MODE =
        U2<RADIANS, DEGREES>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module ANGLE_MODE =
        let ofRADIANS v: ANGLE_MODE = v |> U2.Case1
        let isRADIANS (v: ANGLE_MODE) = match v with U2.Case1 _ -> true | _ -> false
        let asRADIANS (v: ANGLE_MODE) = match v with U2.Case1 o -> Some o | _ -> None
        let ofDEGREES v: ANGLE_MODE = v |> U2.Case2
        let isDEGREES (v: ANGLE_MODE) = match v with U2.Case2 _ -> true | _ -> false
        let asDEGREES (v: ANGLE_MODE) = match v with U2.Case2 o -> Some o | _ -> None

    type ARC_MODE =
        U3<CHORD, PIE, OPEN>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module ARC_MODE =
        let ofCHORD v: ARC_MODE = v |> U3.Case1
        let isCHORD (v: ARC_MODE) = match v with U3.Case1 _ -> true | _ -> false
        let asCHORD (v: ARC_MODE) = match v with U3.Case1 o -> Some o | _ -> None
        let ofPIE v: ARC_MODE = v |> U3.Case2
        let isPIE (v: ARC_MODE) = match v with U3.Case2 _ -> true | _ -> false
        let asPIE (v: ARC_MODE) = match v with U3.Case2 o -> Some o | _ -> None
        let ofOPEN v: ARC_MODE = v |> U3.Case3
        let isOPEN (v: ARC_MODE) = match v with U3.Case3 _ -> true | _ -> false
        let asOPEN (v: ARC_MODE) = match v with U3.Case3 o -> Some o | _ -> None

    type BEGIN_KIND =
        U7<POINTS, LINES, TRIANGLES, TRIANGLE_FAN, TRIANGLE_STRIP, QUADS, QUAD_STRIP>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module BEGIN_KIND =
        let ofPOINTS v: BEGIN_KIND = v |> U7.Case1
        let isPOINTS (v: BEGIN_KIND) = match v with U7.Case1 _ -> true | _ -> false
        let asPOINTS (v: BEGIN_KIND) = match v with U7.Case1 o -> Some o | _ -> None
        let ofLINES v: BEGIN_KIND = v |> U7.Case2
        let isLINES (v: BEGIN_KIND) = match v with U7.Case2 _ -> true | _ -> false
        let asLINES (v: BEGIN_KIND) = match v with U7.Case2 o -> Some o | _ -> None
        let ofTRIANGLES v: BEGIN_KIND = v |> U7.Case3
        let isTRIANGLES (v: BEGIN_KIND) = match v with U7.Case3 _ -> true | _ -> false
        let asTRIANGLES (v: BEGIN_KIND) = match v with U7.Case3 o -> Some o | _ -> None
        let ofTRIANGLE_FAN v: BEGIN_KIND = v |> U7.Case4
        let isTRIANGLE_FAN (v: BEGIN_KIND) = match v with U7.Case4 _ -> true | _ -> false
        let asTRIANGLE_FAN (v: BEGIN_KIND) = match v with U7.Case4 o -> Some o | _ -> None
        let ofTRIANGLE_STRIP v: BEGIN_KIND = v |> U7.Case5
        let isTRIANGLE_STRIP (v: BEGIN_KIND) = match v with U7.Case5 _ -> true | _ -> false
        let asTRIANGLE_STRIP (v: BEGIN_KIND) = match v with U7.Case5 o -> Some o | _ -> None
        let ofQUADS v: BEGIN_KIND = v |> U7.Case6
        let isQUADS (v: BEGIN_KIND) = match v with U7.Case6 _ -> true | _ -> false
        let asQUADS (v: BEGIN_KIND) = match v with U7.Case6 o -> Some o | _ -> None
        let ofQUAD_STRIP v: BEGIN_KIND = v |> U7.Case7
        let isQUAD_STRIP (v: BEGIN_KIND) = match v with U7.Case7 _ -> true | _ -> false
        let asQUAD_STRIP (v: BEGIN_KIND) = match v with U7.Case7 o -> Some o | _ -> None

    type BLEND_MODE =
        obj

    type COLOR_MODE =
        U3<RGB, HSB, HSL>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module COLOR_MODE =
        let ofRGB v: COLOR_MODE = v |> U3.Case1
        let isRGB (v: COLOR_MODE) = match v with U3.Case1 _ -> true | _ -> false
        let asRGB (v: COLOR_MODE) = match v with U3.Case1 o -> Some o | _ -> None
        let ofHSB v: COLOR_MODE = v |> U3.Case2
        let isHSB (v: COLOR_MODE) = match v with U3.Case2 _ -> true | _ -> false
        let asHSB (v: COLOR_MODE) = match v with U3.Case2 o -> Some o | _ -> None
        let ofHSL v: COLOR_MODE = v |> U3.Case3
        let isHSL (v: COLOR_MODE) = match v with U3.Case3 _ -> true | _ -> false
        let asHSL (v: COLOR_MODE) = match v with U3.Case3 o -> Some o | _ -> None

    type CURSOR_TYPE =
        U6<ARROW, CROSS, HAND, MOVE, TEXT, WAIT>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module CURSOR_TYPE =
        let ofARROW v: CURSOR_TYPE = v |> U6.Case1
        let isARROW (v: CURSOR_TYPE) = match v with U6.Case1 _ -> true | _ -> false
        let asARROW (v: CURSOR_TYPE) = match v with U6.Case1 o -> Some o | _ -> None
        let ofCROSS v: CURSOR_TYPE = v |> U6.Case2
        let isCROSS (v: CURSOR_TYPE) = match v with U6.Case2 _ -> true | _ -> false
        let asCROSS (v: CURSOR_TYPE) = match v with U6.Case2 o -> Some o | _ -> None
        let ofHAND v: CURSOR_TYPE = v |> U6.Case3
        let isHAND (v: CURSOR_TYPE) = match v with U6.Case3 _ -> true | _ -> false
        let asHAND (v: CURSOR_TYPE) = match v with U6.Case3 o -> Some o | _ -> None
        let ofMOVE v: CURSOR_TYPE = v |> U6.Case4
        let isMOVE (v: CURSOR_TYPE) = match v with U6.Case4 _ -> true | _ -> false
        let asMOVE (v: CURSOR_TYPE) = match v with U6.Case4 o -> Some o | _ -> None
        let ofTEXT v: CURSOR_TYPE = v |> U6.Case5
        let isTEXT (v: CURSOR_TYPE) = match v with U6.Case5 _ -> true | _ -> false
        let asTEXT (v: CURSOR_TYPE) = match v with U6.Case5 o -> Some o | _ -> None
        let ofWAIT v: CURSOR_TYPE = v |> U6.Case6
        let isWAIT (v: CURSOR_TYPE) = match v with U6.Case6 _ -> true | _ -> false
        let asWAIT (v: CURSOR_TYPE) = match v with U6.Case6 o -> Some o | _ -> None

    type DEBUG_MODE =
        U2<GRID, AXES>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module DEBUG_MODE =
        let ofGRID v: DEBUG_MODE = v |> U2.Case1
        let isGRID (v: DEBUG_MODE) = match v with U2.Case1 _ -> true | _ -> false
        let asGRID (v: DEBUG_MODE) = match v with U2.Case1 o -> Some o | _ -> None
        let ofAXES v: DEBUG_MODE = v |> U2.Case2
        let isAXES (v: DEBUG_MODE) = match v with U2.Case2 _ -> true | _ -> false
        let asAXES (v: DEBUG_MODE) = match v with U2.Case2 o -> Some o | _ -> None

    type ELLIPSE_MODE =
        U4<CENTER, RADIUS, CORNER, CORNERS>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module ELLIPSE_MODE =
        let ofCENTER v: ELLIPSE_MODE = v |> U4.Case1
        let isCENTER (v: ELLIPSE_MODE) = match v with U4.Case1 _ -> true | _ -> false
        let asCENTER (v: ELLIPSE_MODE) = match v with U4.Case1 o -> Some o | _ -> None
        let ofRADIUS v: ELLIPSE_MODE = v |> U4.Case2
        let isRADIUS (v: ELLIPSE_MODE) = match v with U4.Case2 _ -> true | _ -> false
        let asRADIUS (v: ELLIPSE_MODE) = match v with U4.Case2 o -> Some o | _ -> None
        let ofCORNER v: ELLIPSE_MODE = v |> U4.Case3
        let isCORNER (v: ELLIPSE_MODE) = match v with U4.Case3 _ -> true | _ -> false
        let asCORNER (v: ELLIPSE_MODE) = match v with U4.Case3 o -> Some o | _ -> None
        let ofCORNERS v: ELLIPSE_MODE = v |> U4.Case4
        let isCORNERS (v: ELLIPSE_MODE) = match v with U4.Case4 _ -> true | _ -> false
        let asCORNERS (v: ELLIPSE_MODE) = match v with U4.Case4 o -> Some o | _ -> None

    type END_MODE =
        CLOSE

    type FILTER_TYPE =
        U8<THRESHOLD, GRAY, OPAQUE, INVERT, POSTERIZE, BLUR, ERODE, DILATE>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module FILTER_TYPE =
        let ofTHRESHOLD v: FILTER_TYPE = v |> U8.Case1
        let isTHRESHOLD (v: FILTER_TYPE) = match v with U8.Case1 _ -> true | _ -> false
        let asTHRESHOLD (v: FILTER_TYPE) = match v with U8.Case1 o -> Some o | _ -> None
        let ofGRAY v: FILTER_TYPE = v |> U8.Case2
        let isGRAY (v: FILTER_TYPE) = match v with U8.Case2 _ -> true | _ -> false
        let asGRAY (v: FILTER_TYPE) = match v with U8.Case2 o -> Some o | _ -> None
        let ofOPAQUE v: FILTER_TYPE = v |> U8.Case3
        let isOPAQUE (v: FILTER_TYPE) = match v with U8.Case3 _ -> true | _ -> false
        let asOPAQUE (v: FILTER_TYPE) = match v with U8.Case3 o -> Some o | _ -> None
        let ofINVERT v: FILTER_TYPE = v |> U8.Case4
        let isINVERT (v: FILTER_TYPE) = match v with U8.Case4 _ -> true | _ -> false
        let asINVERT (v: FILTER_TYPE) = match v with U8.Case4 o -> Some o | _ -> None
        let ofPOSTERIZE v: FILTER_TYPE = v |> U8.Case5
        let isPOSTERIZE (v: FILTER_TYPE) = match v with U8.Case5 _ -> true | _ -> false
        let asPOSTERIZE (v: FILTER_TYPE) = match v with U8.Case5 o -> Some o | _ -> None
        let ofBLUR v: FILTER_TYPE = v |> U8.Case6
        let isBLUR (v: FILTER_TYPE) = match v with U8.Case6 _ -> true | _ -> false
        let asBLUR (v: FILTER_TYPE) = match v with U8.Case6 o -> Some o | _ -> None
        let ofERODE v: FILTER_TYPE = v |> U8.Case7
        let isERODE (v: FILTER_TYPE) = match v with U8.Case7 _ -> true | _ -> false
        let asERODE (v: FILTER_TYPE) = match v with U8.Case7 o -> Some o | _ -> None
        let ofDILATE v: FILTER_TYPE = v |> U8.Case8
        let isDILATE (v: FILTER_TYPE) = match v with U8.Case8 _ -> true | _ -> false
        let asDILATE (v: FILTER_TYPE) = match v with U8.Case8 o -> Some o | _ -> None

    type GRAPHICS_RENDERER =
        U2<P2D, WEBGL>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module GRAPHICS_RENDERER =
        let ofP2D v: GRAPHICS_RENDERER = v |> U2.Case1
        let isP2D (v: GRAPHICS_RENDERER) = match v with U2.Case1 _ -> true | _ -> false
        let asP2D (v: GRAPHICS_RENDERER) = match v with U2.Case1 o -> Some o | _ -> None
        let ofWEBGL v: GRAPHICS_RENDERER = v |> U2.Case2
        let isWEBGL (v: GRAPHICS_RENDERER) = match v with U2.Case2 _ -> true | _ -> false
        let asWEBGL (v: GRAPHICS_RENDERER) = match v with U2.Case2 o -> Some o | _ -> None

    type HORIZ_ALIGN =
        U3<LEFT, CENTER, RIGHT>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module HORIZ_ALIGN =
        let ofLEFT v: HORIZ_ALIGN = v |> U3.Case1
        let isLEFT (v: HORIZ_ALIGN) = match v with U3.Case1 _ -> true | _ -> false
        let asLEFT (v: HORIZ_ALIGN) = match v with U3.Case1 o -> Some o | _ -> None
        let ofCENTER v: HORIZ_ALIGN = v |> U3.Case2
        let isCENTER (v: HORIZ_ALIGN) = match v with U3.Case2 _ -> true | _ -> false
        let asCENTER (v: HORIZ_ALIGN) = match v with U3.Case2 o -> Some o | _ -> None
        let ofRIGHT v: HORIZ_ALIGN = v |> U3.Case3
        let isRIGHT (v: HORIZ_ALIGN) = match v with U3.Case3 _ -> true | _ -> false
        let asRIGHT (v: HORIZ_ALIGN) = match v with U3.Case3 o -> Some o | _ -> None

    type IMAGE_MODE =
        U3<CORNER, CORNERS, CENTER>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module IMAGE_MODE =
        let ofCORNER v: IMAGE_MODE = v |> U3.Case1
        let isCORNER (v: IMAGE_MODE) = match v with U3.Case1 _ -> true | _ -> false
        let asCORNER (v: IMAGE_MODE) = match v with U3.Case1 o -> Some o | _ -> None
        let ofCORNERS v: IMAGE_MODE = v |> U3.Case2
        let isCORNERS (v: IMAGE_MODE) = match v with U3.Case2 _ -> true | _ -> false
        let asCORNERS (v: IMAGE_MODE) = match v with U3.Case2 o -> Some o | _ -> None
        let ofCENTER v: IMAGE_MODE = v |> U3.Case3
        let isCENTER (v: IMAGE_MODE) = match v with U3.Case3 _ -> true | _ -> false
        let asCENTER (v: IMAGE_MODE) = match v with U3.Case3 o -> Some o | _ -> None

    type RECT_MODE =
        U4<CORNER, CORNERS, CENTER, RADIUS>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module RECT_MODE =
        let ofCORNER v: RECT_MODE = v |> U4.Case1
        let isCORNER (v: RECT_MODE) = match v with U4.Case1 _ -> true | _ -> false
        let asCORNER (v: RECT_MODE) = match v with U4.Case1 o -> Some o | _ -> None
        let ofCORNERS v: RECT_MODE = v |> U4.Case2
        let isCORNERS (v: RECT_MODE) = match v with U4.Case2 _ -> true | _ -> false
        let asCORNERS (v: RECT_MODE) = match v with U4.Case2 o -> Some o | _ -> None
        let ofCENTER v: RECT_MODE = v |> U4.Case3
        let isCENTER (v: RECT_MODE) = match v with U4.Case3 _ -> true | _ -> false
        let asCENTER (v: RECT_MODE) = match v with U4.Case3 o -> Some o | _ -> None
        let ofRADIUS v: RECT_MODE = v |> U4.Case4
        let isRADIUS (v: RECT_MODE) = match v with U4.Case4 _ -> true | _ -> false
        let asRADIUS (v: RECT_MODE) = match v with U4.Case4 o -> Some o | _ -> None

    type RENDERER =
        U2<P2D, WEBGL>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module RENDERER =
        let ofP2D v: RENDERER = v |> U2.Case1
        let isP2D (v: RENDERER) = match v with U2.Case1 _ -> true | _ -> false
        let asP2D (v: RENDERER) = match v with U2.Case1 o -> Some o | _ -> None
        let ofWEBGL v: RENDERER = v |> U2.Case2
        let isWEBGL (v: RENDERER) = match v with U2.Case2 _ -> true | _ -> false
        let asWEBGL (v: RENDERER) = match v with U2.Case2 o -> Some o | _ -> None

    type SIZE_H =
        AUTO

    type SIZE_W =
        AUTO

    type STROKE_CAP =
        U3<SQUARE, PROJECT, ROUND>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module STROKE_CAP =
        let ofSQUARE v: STROKE_CAP = v |> U3.Case1
        let isSQUARE (v: STROKE_CAP) = match v with U3.Case1 _ -> true | _ -> false
        let asSQUARE (v: STROKE_CAP) = match v with U3.Case1 o -> Some o | _ -> None
        let ofPROJECT v: STROKE_CAP = v |> U3.Case2
        let isPROJECT (v: STROKE_CAP) = match v with U3.Case2 _ -> true | _ -> false
        let asPROJECT (v: STROKE_CAP) = match v with U3.Case2 o -> Some o | _ -> None
        let ofROUND v: STROKE_CAP = v |> U3.Case3
        let isROUND (v: STROKE_CAP) = match v with U3.Case3 _ -> true | _ -> false
        let asROUND (v: STROKE_CAP) = match v with U3.Case3 o -> Some o | _ -> None

    type STROKE_JOIN =
        U3<MITER, BEVEL, ROUND>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module STROKE_JOIN =
        let ofMITER v: STROKE_JOIN = v |> U3.Case1
        let isMITER (v: STROKE_JOIN) = match v with U3.Case1 _ -> true | _ -> false
        let asMITER (v: STROKE_JOIN) = match v with U3.Case1 o -> Some o | _ -> None
        let ofBEVEL v: STROKE_JOIN = v |> U3.Case2
        let isBEVEL (v: STROKE_JOIN) = match v with U3.Case2 _ -> true | _ -> false
        let asBEVEL (v: STROKE_JOIN) = match v with U3.Case2 o -> Some o | _ -> None
        let ofROUND v: STROKE_JOIN = v |> U3.Case3
        let isROUND (v: STROKE_JOIN) = match v with U3.Case3 _ -> true | _ -> false
        let asROUND (v: STROKE_JOIN) = match v with U3.Case3 o -> Some o | _ -> None

    type THE_STYLE =
        U3<NORMAL, ITALIC, BOLD>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module THE_STYLE =
        let ofNORMAL v: THE_STYLE = v |> U3.Case1
        let isNORMAL (v: THE_STYLE) = match v with U3.Case1 _ -> true | _ -> false
        let asNORMAL (v: THE_STYLE) = match v with U3.Case1 o -> Some o | _ -> None
        let ofITALIC v: THE_STYLE = v |> U3.Case2
        let isITALIC (v: THE_STYLE) = match v with U3.Case2 _ -> true | _ -> false
        let asITALIC (v: THE_STYLE) = match v with U3.Case2 o -> Some o | _ -> None
        let ofBOLD v: THE_STYLE = v |> U3.Case3
        let isBOLD (v: THE_STYLE) = match v with U3.Case3 _ -> true | _ -> false
        let asBOLD (v: THE_STYLE) = match v with U3.Case3 o -> Some o | _ -> None

    type TYPE =
        U2<VIDEO, AUDIO>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module TYPE =
        let ofVIDEO v: TYPE = v |> U2.Case1
        let isVIDEO (v: TYPE) = match v with U2.Case1 _ -> true | _ -> false
        let asVIDEO (v: TYPE) = match v with U2.Case1 o -> Some o | _ -> None
        let ofAUDIO v: TYPE = v |> U2.Case2
        let isAUDIO (v: TYPE) = match v with U2.Case2 _ -> true | _ -> false
        let asAUDIO (v: TYPE) = match v with U2.Case2 o -> Some o | _ -> None

    type VERT_ALIGN =
        U4<TOP, BOTTOM, CENTER, BASELINE>

    [<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    module VERT_ALIGN =
        let ofTOP v: VERT_ALIGN = v |> U4.Case1
        let isTOP (v: VERT_ALIGN) = match v with U4.Case1 _ -> true | _ -> false
        let asTOP (v: VERT_ALIGN) = match v with U4.Case1 o -> Some o | _ -> None
        let ofBOTTOM v: VERT_ALIGN = v |> U4.Case2
        let isBOTTOM (v: VERT_ALIGN) = match v with U4.Case2 _ -> true | _ -> false
        let asBOTTOM (v: VERT_ALIGN) = match v with U4.Case2 o -> Some o | _ -> None
        let ofCENTER v: VERT_ALIGN = v |> U4.Case3
        let isCENTER (v: VERT_ALIGN) = match v with U4.Case3 _ -> true | _ -> false
        let asCENTER (v: VERT_ALIGN) = match v with U4.Case3 o -> Some o | _ -> None
        let ofBASELINE v: VERT_ALIGN = v |> U4.Case4
        let isBASELINE (v: VERT_ALIGN) = match v with U4.Case4 _ -> true | _ -> false
        let asBASELINE (v: VERT_ALIGN) = match v with U4.Case4 o -> Some o | _ -> None
let [<Import("*","p5")>] p5: P5.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract p5: p5Static

type [<AllowNullLiteral>] p5 =
    inherit P5.P5InstanceExtensions
    /// Called directly before setup(), the preload()
    /// function is used to handle asynchronous loading of
    /// external files in a blocking way. If a preload
    /// function is defined, setup() will wait until any
    /// load calls within have finished. Nothing besides
    /// load calls (loadImage, loadJSON, loadFont,
    /// loadStrings, etc.) should be inside the preload
    /// function. If asynchronous loading is preferred,
    /// the load methods can instead be called in setup()
    /// or anywhere else with the use of a callback
    /// parameter.  By default the text "loading..." will
    /// be displayed. To make your own loading page,
    /// include an HTML element with id "p5_loading" in
    /// your page. More information here.
    abstract preload: unit -> unit
    /// The setup() function is called once when the
    /// program starts. It's used to define initial
    /// environment properties such as screen size and
    /// background color and to load media such as images
    /// and fonts as the program starts. There can only be
    /// one setup() function for each program and it
    /// shouldn't be called again after its initial
    /// execution.  Note: Variables declared within
    /// setup() are not accessible within other functions,
    /// including draw().
    abstract setup: unit -> unit
    /// Called directly after setup(), the draw() function
    /// continuously executes the lines of code contained
    /// inside its block until the program is stopped or
    /// noLoop() is called. Note if noLoop() is called in
    /// setup(), draw() will still be executed once before
    /// stopping. draw() is called automatically and
    /// should never be called explicitly.  It should
    /// always be controlled with noLoop(), redraw() and
    /// loop(). After noLoop() stops the code in draw()
    /// from executing, redraw() causes the code inside
    /// draw() to execute once, and loop() will cause the
    /// code inside draw() to resume executing
    /// continuously.
    /// 
    /// 
    /// The number of times draw() executes in each second
    /// may be controlled with the frameRate() function.
    /// 
    /// 
    /// There can only be one draw() function for each
    /// sketch, and draw() must exist if you want the code
    /// to run continuously, or to process events such as
    /// mousePressed(). Sometimes, you might have an empty
    /// call to draw() in your program, as shown in the
    /// above example.
    /// 
    /// 
    /// It is important to note that the drawing
    /// coordinate system will be reset at the beginning
    /// of each draw() call. If any transformations are
    /// performed within draw() (ex: scale, rotate,
    /// translate), their effects will be undone at the
    /// beginning of draw(), so transformations will not
    /// accumulate over time. On the other hand, styling
    /// applied (ex: fill, stroke, etc) will remain in
    /// effect.
    abstract draw: unit -> unit
    /// Removes the entire p5 sketch. This will remove the
    /// canvas and any elements created by p5.js. It will
    /// also stop the draw loop and unbind any properties
    /// or methods from the window global scope. It will
    /// leave a variable p5 in case you wanted to create a
    /// new p5 sketch. If you like, you can set p5 = null
    /// to erase it. While all functions and variables and
    /// objects created by the p5 library will be removed,
    /// any other global variables created by your code
    /// will remain.
    abstract remove: unit -> unit

type [<AllowNullLiteral>] p5Static =
    /// <summary>This is the p5 instance constructor. A p5 instance
    /// holds all the properties and methods related to a
    /// p5 sketch. It expects an incoming sketch closure
    /// and it can also take an optional node parameter
    /// for attaching the generated p5 canvas to a node.
    /// The sketch closure takes the newly created p5
    /// instance as its sole argument and may optionally
    /// set preload(), setup(), and/or draw() properties
    /// on it for running a sketch.
    /// 
    /// A p5 sketch can run in "global" or "instance"
    /// mode: "global" - all properties and methods are
    /// attached to the window "instance" - all properties
    /// and methods are bound to this p5 object</summary>
    /// <param name="sketch">a closure that can set optional
    /// preload(), setup(), and/or draw() properties on
    /// the given p5 instance</param>
    /// <param name="node">element to attach canvas to, if a
    /// boolean is passed in use it as sync</param>
    /// <param name="sync">start synchronously (optional)</param>
    [<Emit "new $0($1...)">] abstract Create: sketch: (ResizeArray<obj option> -> obj option) * ?node: U2<HTMLElement, bool> * ?sync: bool -> p5

module P5 =

    type UNKNOWN_P5_CONSTANT =
        obj option

    type [<AllowNullLiteral>] p5InstanceExtensions =
        interface end
