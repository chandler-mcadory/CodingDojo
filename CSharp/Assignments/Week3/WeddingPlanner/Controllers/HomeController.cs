using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;

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
    {
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
            return RedirectToAction("Dashboard");
        }
        else
        {
            return View("Index");
        }
    }

    // [HttpGet("success")]
    // public IActionResult Success()
    // {
    //     if(HttpContext.Session.GetInt32("UserId") == null)
    //     {
    //         return RedirectToAction("Index");
    //     }
    //     return View();
    // }

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

    [HttpPost("users/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return View("Index");
    }

    [SessionCheck]
    [HttpGet("dashboard")]
    public IActionResult Dashboard()
    {
        var weddings = GetList();
        return View(weddings);
    }


    // ========================= JOINS =========================
    // [HttpGet(WeddingId)]
    // public 
    // {

    // }


    private List<Dto> GetList()
    {
        var weddings = _context.Weddings.ToList();
        var events = _context.Events.ToList();
        var users = _context.Users.ToList();

        var results = 
        from w in weddings 
        join e in events on w.WeddingId equals e.WeddingId
        join u in users on e.UserId equals u.UserId into JoinedUsers
        select new Dto
        {
            DisplayName = w.Wedder1 + " & " + w.Wedder2,
            WeddingDate = w.Date,
            CreatorId = w.UserId,
            WeddingId = w.WeddingId,
            GuestList = JoinedUsers.Select(x => x.FirstName + " " + x.LastName).ToList()
        };

        HttpContext.Session.SetString("debug", results.First().GuestList[0]);

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


