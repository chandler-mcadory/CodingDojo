using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers;

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
    { // redirects to /dashboard if the user is already logged in
        if (HttpContext.Session.GetInt32("UserId") != null)
        {
            return RedirectToAction("Dashboard");
        }
        return View();
    }

    [HttpPost("users/create")]
    public IActionResult CreateUser(User newUser)
    {
        if(ModelState.IsValid)
        {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("FirstName", newUser.FirstName);
            HttpContext.Session.SetString("LastName", newUser.LastName);
            return RedirectToAction("Dashboard");
        }
        else
        {
            return View("Index");
        }
    }


    [HttpPost("users/login")]
    public IActionResult LoginUser(LogUser loginUser)
    {
        if(ModelState.IsValid)
        {
            User? userInDb = _context.Users.FirstOrDefault(u => u.Email == loginUser.LEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("LEmail", "Invalid Credentials");
                return View("Index");
            }

            PasswordHasher<LogUser> hasher= new PasswordHasher<LogUser>();
            var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LPassword);
            if(result == 0)
            {
                ModelState.AddModelError("LEmail", "Invalid Credentials");
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                HttpContext.Session.SetString("FirstName", userInDb.FirstName);
                HttpContext.Session.SetString("LastName", userInDb.LastName);
                return RedirectToAction("Dashboard");
            }
        }
        else
        {
            return View("Index");
        }
    }


    [HttpGet("users/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }


    [HttpGet("weddings/new")]
    public IActionResult Create()
    {
        return View("Create");
    }

    [HttpPost("wedding/create")]
    public IActionResult CreateWedding(Wedding newWedding)
    {
        _context.Add(newWedding);
        _context.SaveChanges();
        HttpContext.Session.SetInt32("WeddingId", newWedding.WeddingId);
        return RedirectToAction("Dashboard");
    }


    [HttpGet("weddings/{weddingId}/destroy")]
    public IActionResult Delete(int weddingId)
    {
        var w = _context.Weddings;

        var result = w.First(x => x.WeddingId == weddingId);

        w.Remove(result);
        _context.SaveChanges();
        return RedirectToAction("Dashboard");
    }


    [SessionCheck]
    [HttpGet("dashboard")]
    public IActionResult Dashboard()
    {
        var weddings = GetList();
        return View(weddings);
    }


    [HttpGet("weddings/{id}")]
    public IActionResult Show(int id)
    {
        var thisWedding = GetOne(id);
        return View(thisWedding);
    }


    [HttpGet("/guest/{weddingId}/remove/{userId}")]
    public IActionResult RemoveGuest(int weddingId, int userId)
    {
        var events = _context.Events;
        
        var result = events.Where(e => e.UserId == userId && e.WeddingId == weddingId).Single();

        events.Remove(result);
        var numChanged = _context.SaveChanges();

        return RedirectToAction("Dashboard");
    }


    [HttpGet("/guest/{weddingId}/add/{userId}")]
    public IActionResult AddGuest(int weddingId, int userId)
    {   
        var events = _context.Events;
        events.Add(new Event {
            UserId = userId,
            WeddingId = weddingId
        });
        _context.SaveChanges();

        return RedirectToAction("Dashboard");
    }


    private Dto? GetOne(int eventId)
    {
        var events = GetList();
        var result = events.Where(d => d.WeddingId == eventId).Single();
        return result;
    }


    private List<Dto> GetList()
    {
        var weddings = _context.Weddings.Include(w => w.EventsCreated).ToList();
        var users = _context.Users.ToList();

        var results = weddings.Select(w => new Dto {
            DisplayName = w.Wedder1 + " & " + w.Wedder2,
            WeddingDate = w.Date,
            CreatorId = w.UserId,
            WeddingId = w.WeddingId,
            // Address = w.Address,
            GuestList = users.Join(
                w.EventsCreated,
                u => u.UserId,
                e => e.UserId,
                (u, e) => u
            ).Select(u => u.FirstName + " " + u.LastName).ToList()
        });

        return results.ToList();
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


    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            int? userId = context.HttpContext.Session.GetInt32("UserId");
            if(userId == null)
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}


