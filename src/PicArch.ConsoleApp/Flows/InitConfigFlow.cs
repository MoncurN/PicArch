using PicArch.ConsoleApp.Screens;
using PicArch.Library.Models;
using PicArch.Library.Services;

namespace PicArch.ConsoleApp.Flows;

public class InitConfigFlow : IInitConfigFlow
{
    private readonly IInitConfigService _initConfigService;
    private readonly InitConfigScreens _initConfigScreens;

    public InitConfigFlow(IInitConfigService initConfigService, InitConfigScreens initConfigScreen) 
    {
        _initConfigService = initConfigService;
        _initConfigScreens = initConfigScreen;
    }

    public InitConfig GetOrCreateInitConfig() 
    {
        var initConfig = _initConfigService.GetInitConfig();
        if (initConfig == null || string.IsNullOrWhiteSpace(initConfig?.ExcelPath)) 
        {
            var excelPath = _initConfigScreens.AskUserForExcelPath();
            initConfig = new InitConfig 
            {
                ExcelPath = excelPath,
            };
        }
        return initConfig;
    }
}