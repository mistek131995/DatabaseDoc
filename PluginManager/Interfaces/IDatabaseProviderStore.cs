using Contracts;

namespace PluginManager.Interfaces;

public interface IDatabaseProviderStore
{
    public IEnumerable<IDatabaseProvider> DatabaseProviders { get; }
}