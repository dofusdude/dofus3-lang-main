using System.IO;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;

namespace DDC.Extractor;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Extractor : BasePlugin
{
    public static ManualLogSource Logger { get; private set; }
    public static string OutputDirectory { get; private set; }

    public override void Load()
    {
        Logger = Log;
        InitializeOutputDirectory();
        AddComponent<ExtractorBehaviour>();
    }

    void InitializeOutputDirectory()
    {
        string outdir = Config.Bind("General", "OutputDirectory", "./", "Directory where outputs should be written to.").Value;
        OutputDirectory = Path.GetFullPath(outdir);

        if (!Directory.Exists(OutputDirectory))
        {
            Directory.CreateDirectory(OutputDirectory);
        }

        Log.LogInfo($"Output directory set to {OutputDirectory}.");
    }
}
