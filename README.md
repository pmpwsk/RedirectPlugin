# RedirectPlugin
Plugin for [WebFramework](https://github.com/pmpwsk/WebFramework) that adds simple static redirects.

Website: https://uwap.org/projects/redirect-plugin

## Main features
- Creating static redirects as files

## Installation
You can install this library to your WF project by downloading a .dll file or the source code and referencing it in your project file. In the future, there will be a NuGet package.

If you're using the source code, you will need to update the project reference to WebFramework according to where you have it. The reference will soon be replaced with a NuGet dependency so the library becomes smaller and you don't need to reference WF manually.

Once installed, add the following things to your program start code:
- Add <code>using uwap.WebFramework.Plugins;</code> to the top, otherwise you have to prepend it to <code>RedirectPlugin</code>
- Create a new object of the plugin: <code>RedirectPlugin redirectPlugin = new();</code>
- Map the plugin to a path of your choosing (like any/r): <code>PluginManager.Map("any/r", redirectPlugin);</code>

You can do all that with a single line of code before starting the WF server:<br/><code>PluginManager.Map("any/r", new uwap.WebFramework.Plugins.RedirectPlugin());</code>

## Plans for the future
- Different redirect folders for different instances of the plugin in case there are multiple

## Usage
To create a redirect from <code>[mapped path]/[redirect path]</code> to <code>[target]</code>, create a new file <code>../Redirects/[redirect path].txt</code> (you can also create subfolders) and enter <code>[target]</code> as the content.

Currently, all instances of the project use the same folder for their redirects.
The redirects are stored in memory during runtime and updated by the worker.

Example: After mapping the plugin to <code>uwap.org/r</code> and creating a file <code>../Redirects/test.txt</code> containing <code>https://github.com/pmpwsk</code>, visitors will be redirected from <code>https://uwap.org/r/github</code> to <code>https://github.com/pmpwsk</code>.
