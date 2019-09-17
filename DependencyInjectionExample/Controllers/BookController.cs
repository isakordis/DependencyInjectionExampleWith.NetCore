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
        public IActionResult Create(Book book)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(book);

        }
    }
}