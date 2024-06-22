using PicArch.Library.Models;
using System.Text.Json;

namespace PicArch.Library.Services;

public class InitConfigService : IInitConfigService
{
    private readonly string _initConfigFilePath = "InitConfig.json";

    public InitConfig? GetInitConfig()
    {
        InitConfig? initConfig = null;

        var exists = File.Exists(_initConfigFilePath);
        if (exists)
        {
            var json = File.ReadAllText(_initConfigFilePath);
            initConfig = JsonSerializer.Deserialize<InitConfig>(json);
        }

        return initConfig;
    }
}
