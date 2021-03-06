﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArtUzmykai.Models;

namespace ArtUzmykai.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //index code added here
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            //About code added here
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
    }
}
