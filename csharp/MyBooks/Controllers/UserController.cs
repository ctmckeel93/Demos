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

namespace MyBooks.Controllers
{
    public class UserController : Controller
    {
        public MyContext _context;

        public UserController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("users/collection")]
        public IActionResult MyCollection()
        {
            string loggedEmail = HttpContext.Session.GetString("LoggedIn");
            User loggedin = _context.Users.Include(u => u.OwnedBooks).ThenInclude(bs => bs.UserBook).FirstOrDefault(u => u.Email == loggedEmail);

            return View("MyCollection", loggedin);
        }

        [HttpGet("users/collection/remove/{id}")]
        public IActionResult RemoveFromCollection(int id)
        {
            string loggedEmail = HttpContext.Session.GetString("LoggedIn");
            User loggedin = _context.Users.Include(u => u.OwnedBooks).ThenInclude(bs => bs.UserBook).FirstOrDefault(u => u.Email == loggedEmail);

            Bookshelf target = _context.BookCollections.FirstOrDefault(bs => bs.UserId == loggedin.UserId && bs.BookId == id);
            _context.BookCollections.Remove(target);
            _context.SaveChanges();
            return RedirectToAction("MyCollection");
        }
    }
}