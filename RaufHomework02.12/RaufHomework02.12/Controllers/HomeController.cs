﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RaufHomework02._12.DATA;
using RaufHomework02._12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RaufHomework02._12.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            List<About> about = this._context.Abouts.ToList();
            return View(about);
        }

      

      
    }
}
