﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VROnRamp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Setup()
        {
            return View();
        }
        public IActionResult Links()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Helping developers create compelling Mixed Reality Applications.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact us for information, seminars and customized training and development.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
