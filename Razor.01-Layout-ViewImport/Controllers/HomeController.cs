﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Current2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Current2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };
            return View(myProduct);
        }
    }
}