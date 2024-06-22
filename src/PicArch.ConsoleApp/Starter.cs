using PicArch.ConsoleApp.Screens;
using PicArch.Library.Services;

namespace PicArch.ConsoleApp;

public class Starter
{
    private readonly IInitService _initService;
    private readonly ExcelPathScreen _excelPathScreen;

    public Starter (IInitService initService, ExcelPathScreen excelPathScreen)
    {
        _initService = initService; 
        _excelPathScreen = excelPathScreen;
    }

    public void Start()
    {
        var initConfig = _initService.GetInitConfig();
        if (string.IsNullOrWhiteSpace(initConfig?.ExcelPath) || !File.Exists(initConfig?.ExcelPath))
        {
            var excelPath = _excelPathScreen.AskUserForExcelPath();
            Console.WriteLine($"The user answered: {excelPath}");
        }
    }
}
