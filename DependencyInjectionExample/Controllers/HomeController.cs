using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionExample.Models;
using Microsoft.AspNetCore.Http;

namespace DependencyInjectionExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string username = Request.Cookies["UserName"];
            return View("Index",username);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string username = form["UserName"].ToString();
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("UserName", username, cookieOptions);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult RemoveCookie()
        {
            Response.Cookies.Delete("UserName");
            return View("Index");
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
    }
}
