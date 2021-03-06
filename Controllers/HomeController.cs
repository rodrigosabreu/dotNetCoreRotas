﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using mvc.Models;

namespace mvc.Controllers
{

    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
       

        public string text()
        {
            return "Rafaela meu amorzinho";
        }


        public IActionResult Index()
        {
           

            return View();
        }

        public IActionResult About()
        {
            
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult People()
        {
            var people = new People();
            people.Name = "Rodrigo";
            people.Age = 34;
            
            return View(people);
        }
    }
}
