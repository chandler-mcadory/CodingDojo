using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("login")]
    public IActionResult Login(string NewName, int MyNumber)
    {
        HttpContext.Session.SetString("Username", NewName);
        HttpContext.Session.SetInt32("MyNumber", 0);
        return RedirectToAction("Privacy");
    }

    public IActionResult Privacy()
    {
        string? Username = HttpContext.Session.GetString("Username");
        if (Username == null)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpPost("adjust/{Operation}")]
    public IActionResult Adjust(string Operation)
    {
        int IntVariable = HttpContext.Session.GetInt32("MyNumber") ?? 0;

        // DO STUFF ----- SWITCH IS SIMPLIFYING IF STATEMENTS
        IntVariable = Operation switch
        {
            "plus1" => IntVariable + 1,
            "mins1" => IntVariable - 1,
            "mult2" => IntVariable * 2,
            "plusR" => IntVariable + new Random().Next(11),
            // WAY BETTER RANDOM NUMBERS (ABOVE)
            _ => IntVariable
        };

        HttpContext.Session.SetInt32("MyNumber", IntVariable);
        return RedirectToAction("Privacy");
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
