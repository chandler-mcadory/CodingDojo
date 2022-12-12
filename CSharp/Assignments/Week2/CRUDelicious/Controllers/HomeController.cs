using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var dishes = _context.Dishes.ToList();
        return View(dishes);
    }

    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(newDish.DishId == 0)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        else
        {
            var theDish = _context.Dishes.FirstOrDefault(x => x.DishId == newDish.DishId);
            if(theDish is not null)
            {
            _context.Entry(theDish).CurrentValues.SetValues(newDish);
            _context.SaveChanges();
            }
            return Redirect($"/dishes/{newDish.DishId}");
        }
    }

    public IActionResult Create()
    {
        return View(new Dish());
    }

    [HttpGet("dishes/{id}")]
    public IActionResult Show(int id)
    {
        var ThisDish = _context.Dishes.FirstOrDefault(x => x.DishId == id);
        return View(ThisDish);
    }

    [HttpPost("dishes/{id}/destroy")]
    public IActionResult DestroyDish(int id)
    {
        Dish? DeleteDish = _context.Dishes.FirstOrDefault(x => x.DishId == id);
        if(DeleteDish is not null)
        {
            _context.Dishes.Remove(DeleteDish);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    [HttpPost("dishes/{id}/edit")]
    public IActionResult EditDish(int id)
    {
        Dish? EditDish = _context.Dishes.FirstOrDefault(x => x.DishId == id);
        return View("Create", EditDish);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
