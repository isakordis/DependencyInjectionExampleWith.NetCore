using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionExample.Models;

namespace DependencyInjectionExample.Controllers
{
    public class BookController : Controller
    {
        private readonly DependencyInjectionExampleContext _context;

        public BookController(DependencyInjectionExampleContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Details()
        {
            Book book = new Book()
            {
                id = 1,
                Title = "First Book",
                Genre = "Programming",
                PublishDate = System.DateTime.Now,
                Price=323

            };

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("id,Title,Genre,Price,PublishDate")] Book book)
        {

            if (ModelState.IsValid)
            {
                _context.Add(book);
                 _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);

        }
    }
}