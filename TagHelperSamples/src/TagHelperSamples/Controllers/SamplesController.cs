﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TagHelperSamples.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TagHelperSamples.Controllers
{
    public class SamplesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AlertTagHelper()
        {
            return View();
        }

        public IActionResult ProgressBarTagHelper()
        {
            Random random = new Random();
            
            var model = new TestModel
            {
                CurrentProgress = random.Next(0, 100)
            };
            return View(model);
        }
    }
}