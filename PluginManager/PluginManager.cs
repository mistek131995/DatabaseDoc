using Microsoft.Extensions.DependencyInjection;
using PluginManager.Implementations;
using PluginManager.Interfaces;

namespace PluginManager;

public static class PluginManager
{
    public static IServiceCollection LoadPluginSystem(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IDatabaseProviderStore, DatabaseProviderStore>();
        serviceCollection.AddSingleton<IPluginStore, PluginStore>();
        
        return serviceCollection;
    }
}