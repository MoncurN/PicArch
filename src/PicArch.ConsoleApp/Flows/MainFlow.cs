namespace PicArch.ConsoleApp.Flows;

public class MainFlow : IMainFlow 
{
    private readonly IInitConfigFlow _initConfigFlow;

    public MainFlow(IInitConfigFlow initConfigFlow) 
    {
        _initConfigFlow = initConfigFlow;
    }
    
    public void Run() 
    {
        var initConfig = _initConfigFlow.GetOrCreateInitConfig();
    }
}