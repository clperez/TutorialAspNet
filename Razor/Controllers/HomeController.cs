using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Current2.Models;
using Current2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Current2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository pr)
        {
            productRepository = pr;
        }


        public ViewResult Index() => View(productRepository.Entities.Where(p => p?.Price < 50));

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            productRepository.AddProduct(p);
            return RedirectToAction("Index");
        }
    }
}