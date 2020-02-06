using System;
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
            Product[] array = {
                new Product {Name = "Kayak", Price = 275M, Stock=2},
                new Product {Name = "Lifejacket", Price = 48.95M, Stock=4},
                new Product {Name = "Soccer ball", Price = 19.50M, Stock=4},
                new Product {Name = "Corner flag", Price = 34.95M, Stock=1}
                };
            return View(array);
        }
    }
}