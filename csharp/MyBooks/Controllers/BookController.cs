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
    public class BookController : Controller
    {
        private MyContext _context;

        public BookController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("books/create")]
        public IActionResult BookForm()
        {
            return View();
        }

        [HttpPost("books/create/process")]
        public IActionResult CreateBook(Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return Redirect("/home");
        }

        [HttpGet("books/{id}")]
        public IActionResult BookDetail(int id)
        {
            Book selectedBook = _context.Books.Include(b => b.Owners).ThenInclude(bs => bs.Reader).FirstOrDefault(b => b.BookId == id);
            return View("BookDetail", selectedBook);
        }

        [HttpGet("books/add/{id}")]
        public IActionResult AddToShelf(int id)
        {
            string loggedin = HttpContext.Session.GetString("LoggedIn");
            User loggedInUser = _context.Users.FirstOrDefault(u => u.Email == loggedin);
            Bookshelf newCollection = new Bookshelf();
            newCollection.UserId = loggedInUser.UserId;
            newCollection.BookId = id;
            _context.BookCollections.Add(newCollection);
            _context.SaveChanges();
            return RedirectToAction("BookDetail");
        }

    }
}