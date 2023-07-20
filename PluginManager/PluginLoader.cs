using System.Reflection;
using Contracts;

namespace PluginManager;

public static class PluginLoader<T> where T : class
{
    /// <summary>
    /// Загружает файлы плагинов
    /// </summary>
    /// <param name="folderName">Папка с плагинами</param>
    /// <returns></returns>
    private static IEnumerable<Assembly> LoadPlugin(string folderName = "plugins")
    {
        var pluginsPath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
        var pluginFolders = Directory.GetDirectories(pluginsPath);

        foreach (var folder in pluginFolders)
        {
            var file = Directory.GetFiles(folder).FirstOrDefault(x => x.EndsWith(".dll"));

            var context = new PluginLoadContext(file);
            yield return context.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(file)));
        }
    }

    /// <summary>
    /// Создает экзепляры плагинов
    /// </summary>
    /// <param name="assembly">Имя сборки</param>
    /// <returns></returns>
    private static T CreatePluginInstanse(Assembly assembly)
    {
        foreach (Type type in assembly.GetTypes())
        {
            if (typeof(T).IsAssignableFrom(type))
            {
                T result = Activator.CreateInstance(type) as T;
                
                if (result != null)
                {
                    return result;
                }
            }
        }

        return null;
    }
    
    /// <summary>
    /// Инициализация списка плагинов
    /// </summary>
    public static IEnumerable<T> InitializePlugins()
    {
        var plugins = LoadPlugin();

        foreach (var plugin in plugins)
        {
            yield return PluginLoader<T>.CreatePluginInstanse(plugin);
        }
    }
}