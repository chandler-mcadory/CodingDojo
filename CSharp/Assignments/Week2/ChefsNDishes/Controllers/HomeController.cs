using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;


namespace ChefsNDishes.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var chefs = _context.Chefs.Include(x => x.AllDishes).ToList();
        return View(chefs);
    }

    [HttpGet]
    public IActionResult Dishes()
    {
        var dishes = _context.Dishes.Include(x => x.Chef).ToList();
        return View(dishes);
    }

    [HttpGet]
    public IActionResult AddChef()
    {
        return View("ChefCreate");
    }

    [HttpGet]
    public IActionResult AddDish()
    {
        return View("DishCreate");
    }

    [HttpPost("chef/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } else
        {
            return View("Index");
        }
    }

    [HttpPost("dish/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("dishes");
        } else
        {
            return View("Dishes");
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
