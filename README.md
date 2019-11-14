# fable-p5-gibber-kinectronclient
Use [kinectron](https://github.com/kinectron/kinectron) skeletal tracking data or mouse input to drive music synthesis in the browser using [Fable](http://fable.io/), [P5](https://p5js.org/), and [Gibber](http://charlie-roberts.com/gibber/p5-gibber/).

For more information on the development and how to use [see this post](https://olney.ai/category/2018/12/02/fabletekno.html).

Basic start up process:

- Start Kinectron server (see shortcut link)
- Select `Skeleton (Tracked Bodies)`. You should see your skeleton tracking in Kinectron preview.
- Open project folder in VsCode
- `npm start` to start localhost dev server
- Go to Chromium (see shortcut link; must be older version for Kinectron, e.g. 69)
- Open `localhost:8080`
- Press `Connect` (default is localhost Kinectron)

Troubleshooting:

- If you see your skeleton but don't hear anything, you may need to resume audio (but not for Chromium 69; modern Chrome requires user input to start audio)
- If you have any Kinectron issues (firewall, etc) see the documentation for Kinectron
- If the mouse version of the current project works, your issues are likely with Kinectron


------------------------------

## Development requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 2.1 or higher
* [node.js](https://nodejs.org) with [npm](https://www.npmjs.com/)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/).

## Building and running the app

* Install JS dependencies: `npm install`
* Install .NET dependencies: `mono .paket/paket.exe install`
* Start Webpack dev server: `npx webpack-dev-server` or `npm start`
* After the first compilation is finished, in your browser open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.

## Project structure

### npm/yarn

JS dependencies are declared in `package.json`, while `package-lock.json` is a lock file automatically generated.

### paket

[Paket](https://fsprojects.github.io/Paket/) 

> Paket is a dependency manager for .NET and mono projects, which is designed to work well with NuGet packages and also enables referencing files directly from Git repositories or any HTTP resource. It enables precise and predictable control over what packages the projects within your application reference.

.NET dependencies are declared in `paket.dependencies`. The `src/paket.references` lists the libraries actually used in the project. Since you can have several F# projects, we could have different custom `.paket` files for each project.

Last but not least, in the `.fsproj` file you can find a new node: `	<Import Project="..\.paket\Paket.Restore.targets" />` which just tells the compiler to look for the referenced libraries information from the `.paket/Paket.Restore.targets` file.

### Webpack

[Webpack](https://webpack.js.org) is a JS bundler with extensions, like a static dev server that enables hot reloading on code changes. Fable interacts with Webpack through the `fable-loader`. Configuration for Webpack is defined in the `webpack.config.js` file. Note this sample only includes basic Webpack configuration for development mode, if you want to see a more comprehensive configuration check the [Fable webpack-config-template](https://github.com/fable-compiler/webpack-config-template/blob/master/webpack.config.js). Deployment uses Webpack to populate the `deploy` directory and then pushes that directory to `gh-pages`.

### Web assets

The `index.html` file is in `src` but other assets like an icon can be found in the `public` folder.