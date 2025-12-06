using uwap.WebFramework.Responses;

namespace uwap.WebFramework.Plugins;

public partial class RedirectPlugin : Plugin
{
    public override Task<IResponse> HandleAsync(Request req)
    {
        req.ForceGET();

        if (Redirects.TryGetValue(req.Path, out string? value))
            return Task.FromResult<IResponse>(new RedirectResponse(value));
        return Task.FromResult<IResponse>(StatusResponse.NotFound);
    }
}