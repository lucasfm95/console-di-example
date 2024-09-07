using ConsoleDiExample;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("App started");

var serviceProvider = new ServiceCollection()
    .AddServices()
    .GetServiceProvider();

var fileManager = serviceProvider.GetRequiredService<FileManager>();

fileManager.WriteFile("Hello, World!");
fileManager.ReadFile();

Console.WriteLine("App finished");