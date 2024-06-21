namespace uwap.WebFramework.Plugins;

public partial class RedirectPlugin : Plugin
{
    public override Task Handle(Request req)
    {
        if (req.Method != "GET")
            throw new BadMethodSignal();

        if (Redirects.TryGetValue(req.Path, out string? value))
            req.Redirect(value);
        else throw new NotFoundSignal();

        return Task.CompletedTask;
    }
}