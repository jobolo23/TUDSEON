using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tudseon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            //ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Minecraft()
        {
            return View();
        }

        public IActionResult Overwatch()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
