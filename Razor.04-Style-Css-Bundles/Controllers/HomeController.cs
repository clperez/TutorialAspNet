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


        public ViewResult Index()
        {
            return View(productRepository.Entities);
        }
    }
}