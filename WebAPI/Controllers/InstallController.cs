using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PluginManager.Interfaces;

namespace Web_API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class InstallController : Controller
{
    public InstallController(IDatabaseProviderStore databaseProviderStore) =>
        this.databaseProviderStore = databaseProviderStore;

    private readonly IDatabaseProviderStore databaseProviderStore;
    
    [HttpGet]
    public JsonResult Index()
    {
        var databaseProviders = databaseProviderStore.DatabaseProviders
            .Select(x => new
            {
                Value = x.Key,
                Label = x.Name
            }).ToList();
        
        return Json(new { 
            Options = databaseProviders
        });
    }
}