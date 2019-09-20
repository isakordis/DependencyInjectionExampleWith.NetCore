using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionExample.Models;

namespace DependencyInjectionExample.Controllers
{
    public class DIExController : Controller
    {
        private readonly IBookDI<Book> _book;


        public DIExController(IBookDI<Book> book)
        {
            _book = book;                
        }
        public IActionResult Index([FromServices] IBookDI<Book> _book)
        {
            IEnumerable<Book> getBooks = _book.GetAll();
            return View(getBooks);
        }
    }
}