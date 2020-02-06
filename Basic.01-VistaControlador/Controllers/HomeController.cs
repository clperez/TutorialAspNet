using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tutorial._01Cookies.Models;

namespace Tutorial._01Cookies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}