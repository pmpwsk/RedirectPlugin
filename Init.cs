namespace uwap.WebFramework.Plugins;

public partial class RedirectPlugin : Plugin
{
    public RedirectPlugin()
    {
        RedirectDirectory = Directory.CreateDirectory("../Redirects").FullName;
        Redirects = new();
    }
}