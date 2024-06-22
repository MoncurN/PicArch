using Microsoft.Extensions.DependencyInjection;
using PicArch.ConsoleApp;
using PicArch.ConsoleApp.Screens;
using PicArch.Library.Services;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<Starter>();
serviceCollection.AddSingleton<IInitService, InitService>();

serviceCollection.AddSingleton<ExcelPathScreen>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var starter = serviceProvider.GetRequiredService<Starter>();

starter.Start();