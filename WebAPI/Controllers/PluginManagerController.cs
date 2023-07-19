using Microsoft.AspNetCore.Mvc;
using PluginManager.Interfaces;

namespace Web_API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PluginManagerController : Controller
{
    public PluginManagerController(IDatabaseProviderStore databaseProviderStore, IPluginStore pluginStore)
    {
        this.databaseProviderStore = databaseProviderStore;
        this.pluginStore = pluginStore;
    }
    private readonly IDatabaseProviderStore databaseProviderStore;
    private readonly IPluginStore pluginStore;
    
    [HttpGet]
    public async Task<JsonResult> GetDatabaseProviders()
    {
        return Json(new {
        });
    }

    [HttpGet]
    public JsonResult GetPlugins()
    {
        var pluginNames = databaseProviderStore.DatabaseProviders.Select(x => x.Name).ToList();
        
        return Json(pluginNames);
    }
}