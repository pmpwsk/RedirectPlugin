namespace uwap.WebFramework.Plugins;

public partial class RedirectPlugin : Plugin
{
    public override Task Handle(AppRequest req, string path, string pathPrefix)
    {
        if (Redirects.TryGetValue(path, out string? value) && !value.Contains("/api/"))
            req.Redirect(value);
        else req.Status = 404;
        return Task.CompletedTask;
    }
}