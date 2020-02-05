using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tutorial._01Cookies.Models;
using Tutorial._01Cookies.Repository;

namespace Tutorial._01Cookies.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryService repoService = null;

        public HomeController(IRepositoryService repositoryService)
        {
            repoService = repositoryService;
        }

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
            if (ModelState.IsValid)
            {
                repoService.AddResponse(guestResponse);
                //return RedirectToAction(nameof(Index));
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            var exp = repoService.Responses.Where(r => r.WillAttend == true);
            return View(exp);
        }
    }
}