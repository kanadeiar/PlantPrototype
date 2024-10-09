using Microsoft.AspNetCore.Mvc;

namespace PlantPrototype.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}