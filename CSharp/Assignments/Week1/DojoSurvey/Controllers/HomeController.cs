using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{

    static Ninja data;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }



    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("ninja/create")]
    public IActionResult Create(Ninja newNinja)
    {
        if(ModelState.IsValid)
        {
            data = newNinja;
            return RedirectToAction("Result");
        } 
        else
        {
            return View("Index");
        }
    }

    [HttpGet("ninja/result")]
    public IActionResult Result()
    {
        return View("Results", data);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
