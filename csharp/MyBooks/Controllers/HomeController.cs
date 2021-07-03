using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBooks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MyBooks.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LoginAndRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Register");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("register/process")]
        public IActionResult Register(User newUser)
        {

            

            Console.WriteLine(newUser.FirstName);

            if (ModelState.IsValid)
            {
                Console.WriteLine("form is valid");
                if (_context.Users.Any(u => u.Email == newUser.Email))
                {
                    Console.WriteLine("Email in use");
                    ModelState.AddModelError("Email", "Email is already in use");
                    return View("Index");
                }
                else 
                {
                    Console.WriteLine("Good to go");
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password );

                    _context.Users.Add(newUser);
                    _context.SaveChanges();
                    Console.WriteLine(newUser.UserId);
                    HttpContext.Session.SetString("LoggedIn", newUser.Email);
                    return RedirectToAction("Home");
                }

            }
            else
            {
                Console.WriteLine("Model not valid", newUser.FirstName);
                return View("Register");
            }

        }

        [HttpPost("login/process")]
        public IActionResult LoginProcess(LoginUser login)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.FirstOrDefault(u => u.Email == login.Email);

                if (user == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }

                var hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(login, user.Password, login.Password);

                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("Login");
                }
                
                HttpContext.Session.SetString("LoggedIn", login.Email);
                return RedirectToAction("Home");
            }
            else 
            {
                return View("Login");
            }
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            string loggedin = HttpContext.Session.GetString("LoggedIn");

            if (loggedin == null){
                return RedirectToAction("Login");
            }

            User logged = _context.Users.FirstOrDefault(u => u.Email == loggedin);
            
            ViewBag.AllBooks = _context.Books.ToList();
            
            // Console.WriteLine(logged);
            return View("Home" );
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}