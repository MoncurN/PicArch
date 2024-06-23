using PicArch.ConsoleApp.Screens;

namespace PicArch.ConsoleApp.Flows;

public class MainFlow : IMainFlow
{
    private readonly MainScreens _mainScreens;
    private readonly IInitConfigFlow _initConfigFlow;

    public MainFlow(MainScreens mainScreens, IInitConfigFlow initConfigFlow) 
    {
        _mainScreens = mainScreens;
        _initConfigFlow = initConfigFlow;
    }
    
    public void Run() 
    {
        _mainScreens.Welcome();
        var initConfig = _initConfigFlow.GetOrCreateInitConfig();
    }
}