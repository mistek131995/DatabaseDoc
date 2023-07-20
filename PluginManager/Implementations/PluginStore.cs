using Contracts;
using PluginManager.Interfaces;

namespace PluginManager.Implementations;

public class PluginStore : IPluginStore
{
    public PluginStore()
    {
        Plugins = PluginLoader<IPlugin>.InitializePlugins().ToList();
    }
    public List<IPlugin> Plugins { get; private set; }
    
}