using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers;

[ApiController]
[Route("[Controller]/[Action]")]
public class HomeController : Controller
{
    public HomeController()
    {
    }
    
    [HttpGet]
    public JsonResult Index()
    {
        return Json(new {});
    }
}