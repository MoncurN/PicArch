using Microsoft.Extensions.DependencyInjection;
using PicArch.ConsoleApp;
using PicArch.ConsoleApp.Flows;
using PicArch.ConsoleApp.Screens;
using PicArch.Library.Services;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IMainFlow, MainFlow>();

serviceCollection.AddSingleton<IInitConfigFlow, InitConfigFlow>();
serviceCollection.AddSingleton<InitConfigScreens>();
serviceCollection.AddSingleton<IInitConfigService, InitConfigService>();


var serviceProvider = serviceCollection.BuildServiceProvider();

var mainFlows = serviceProvider.GetRequiredService<IMainFlow>();

mainFlows.Run();