using PicArch.Library.Models;

namespace PicArch.ConsoleApp.Flows;

public interface IInitConfigFlow
{
    InitConfig GetOrCreateInitConfig();
}