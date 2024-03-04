using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.Controllers
{
    public class BooksController : Controller
    {
        // Примерная реализация, предполагающая наличие списка книг
        private static List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "Book 1", Author = "Author 1" },
            new Book { Id = 2, Title = "Book 2", Author = "Author 2" }
        };

        // GET: /Books/
        public IActionResult Index()
        {
            return View(books);
        }

        // GET: /Books/Details/5
        public IActionResult Details(int id)
        {
            var book = books.Find(b => b.Id == id);
            return book == null ? NotFound() : View(book);
        }

        // GET: /Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                books.Add(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
    }
}
