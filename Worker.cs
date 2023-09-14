namespace uwap.WebFramework.Plugins;

public partial class RedirectPlugin : Plugin
{
    public override Task Work()
    {
        Dictionary<string, string> newRedirects = new();
        foreach (string file in Directory.GetFiles(RedirectDirectory, "*.txt", SearchOption.AllDirectories))
        {
            string relPath = file.Remove(0, RedirectDirectory.Length);
            relPath = relPath.Replace('\\', '/');
            relPath = relPath.Substring(0, relPath.Length - 4);
            newRedirects.Add(relPath, File.ReadAllText(file));
        }
        Redirects = newRedirects;
        return Task.CompletedTask;
    }
}