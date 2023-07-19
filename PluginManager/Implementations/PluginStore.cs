using Contracts;
using PluginManager.Interfaces;

namespace PluginManager.Implementations;

public class PluginStore : IPluginStore
{
    public PluginStore()
    {
        Plugins = InitializePlugins().ToList();
    }
    public List<IPlugin> Plugins { get; private set; }

    /// <summary>
    /// Инициализация списка плагинов
    /// </summary>
    private static IEnumerable<IPlugin> InitializePlugins()
    {
        var plugins = PluginLoader<IDatabaseProvider>.LoadPlugin();

        foreach (var plugin in plugins)
        {
            yield return PluginLoader<IPlugin>.CreatePluginInstanse(plugin);
        }
    }
}