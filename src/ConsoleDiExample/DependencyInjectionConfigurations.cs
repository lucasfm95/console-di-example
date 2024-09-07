using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDiExample;

public static class DependencyInjectionConfigurations
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services
            .AddSingleton<IFileReader, FileReader>()
            .AddSingleton<IFileWriter, FileWriter>()
            .AddSingleton<FileManager>();
    }
    
    public static IServiceProvider GetServiceProvider(this IServiceCollection services)
    {
        return services.BuildServiceProvider();
    }
}