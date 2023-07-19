using Contracts;

namespace PluginManager.Interfaces;

public interface IPluginStore
{
    public List<IPlugin> Plugins { get; }
}