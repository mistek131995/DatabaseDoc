using Contracts;
using PluginManager.Interfaces;

namespace PluginManager.Implementations;

public class DatabaseProviderStore : IDatabaseProviderStore
{
    public DatabaseProviderStore()
    {
        DatabaseProviders = PluginLoader<IDatabaseProvider>.InitializePlugins();
    }
    
    public IEnumerable<IDatabaseProvider> DatabaseProviders { get; private set; }
}