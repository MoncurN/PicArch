using Microsoft.Extensions.DependencyInjection;
using PicArch.ConsoleApp;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<Starter>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var starter = serviceProvider.GetRequiredService<Starter>();

starter.Start();