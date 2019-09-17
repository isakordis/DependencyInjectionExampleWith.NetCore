﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionExample.Models;

namespace DependencyInjectionExample.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "isa");
            HttpContext.Session.SetInt32("age", 23);


            return RedirectToAction("Get");
        }


        public IActionResult Get()
        {

            User newUser = new User()
            {
                Name = HttpContext.Session.GetString("Name").ToString(),
                age = HttpContext.Session.GetInt32("age").Value
            };

            return View(newUser);
        }
        
        public IActionResult GetQueryString(string name, int age)
        {
            User newUser = new User()
            {
                Name = name,
                age = age
            };
            return View(newUser);
        }

        [HttpPost]
        public IActionResult HiddenData(IFormCollection keyValues)
        {
            var id = keyValues["Id"];
            return View();
        }
    }
}