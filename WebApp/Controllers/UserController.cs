using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        static List<user> users = new List<user>
        {
            new user(){UserId = 1,UserName ="Sam",UserPassword="Sam@1256",UserEmail="same5@gamil.com"},
            new user(){UserId = 2,UserName ="wan",UserPassword="wan@1256",UserEmail="wan@gamil.com"},
            new user(){UserId = 3,UserName ="lan",UserPassword="lan@1256",UserEmail="lan@gamil.com"},
            new user(){UserId = 4,UserName ="man",UserPassword="man@1256",UserEmail="man@gamil.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new user());
        }

        [HttpPost]
        public IActionResult Create(user model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
