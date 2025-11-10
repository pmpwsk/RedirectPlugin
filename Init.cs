namespace uwap.WebFramework.Plugins;

public partial class RedirectPlugin
{
    public RedirectPlugin()
    {
        RedirectDirectory = Directory.CreateDirectory("../Redirects").FullName;
        Redirects = [];
    }
}