# RedirectPlugin
Plugin for [WebFramework](https://github.com/pmpwsk/WebFramework) that adds simple static redirects.

Website: https://uwap.org/projects/redirect-plugin

Changelog: https://uwap.org/changes/redirect-plugin

## Main features
- Creating static redirects as files

## Installation
You can add this plugin to your WF project by installing the NuGet package: [uwap.RedirectPlugin](https://www.nuget.org/packages/uwap.RedirectPlugin/)

You can also download the source code and reference it in your project file.

Once installed, add the following things to your program start code:
- Add <code>using uwap.WebFramework.Plugins;</code> to the top, otherwise you have to prepend it to <code>RedirectPlugin</code>
- Create a new object of the plugin: <code>RedirectPlugin redirectPlugin = new();</code>
- Map the plugin to a path of your choosing (like any/r): <code>PluginManager.Map("any/r", redirectPlugin);</code>

You can do all that with a single line of code before starting the WF server:<br/><code>PluginManager.Map("any/r", new uwap.WebFramework.Plugins.RedirectPlugin());</code>

## Plans for the future
- Different redirect folders for different instances of the plugin in case there are multiple
- Web interface to manage (create and delete) redirects with an API, either to manage the files or replacing the files altogether

## Usage
To create a redirect from <code>[mapped path]/[redirect path]</code> to <code>[target]</code>, create a new file <code>../Redirects/[redirect path].txt</code> (you can also create subfolders) and enter <code>[target]</code> as the content.

Currently, all instances of the project use the same folder for their redirects.
The redirects are stored in memory during runtime and updated by the worker.

Example: After mapping the plugin to <code>uwap.org/r</code> and creating a file <code>../Redirects/test.txt</code> containing <code>https://github.com/pmpwsk</code>, visitors will be redirected from <code>https://uwap.org/r/github</code> to <code>https://github.com/pmpwsk</code>.
