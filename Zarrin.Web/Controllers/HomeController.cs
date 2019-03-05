using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zarrin.Web.Models;

namespace Zarrin.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public HomeController(ILogger<HomeController> log)
        {
            _log = log;
        }

        readonly ILogger<HomeController> _log;
        public string log()
        {
            _log.LogCritical("Mohammad, LogCritical!");
            return "View()";
        }

        public IActionResult Dashboard2()
        {
            return View();
        }

        public IActionResult TopNavbar()
        {
            return View();
        }

        public IActionResult Boxed()
        {
            return View();
        }


        public IActionResult Fixed()
        {
            return View();
        }

       public IActionResult Table()
        {
            return View();
        }
        public IActionResult Collapsed()
        {
            return View();
        }

        public IActionResult Widgets()
        {
            return View();
        }

        public IActionResult UIGeneral()
        {
            return View();
        }

        public IActionResult UIIcons()
        {
            return View();
        }

        public IActionResult UIButtons()
        {
            return View();
        }

        public IActionResult UISlider()
        {
            return View();
        }

        public IActionResult UITimeLine()
        {
            return View();
        }
        public IActionResult UIModal()
        {
            return View();
        }

        public IActionResult UIForms()
        {
            return View();
        }
        public IActionResult UIAdvanceForms()
        {
            return View();
        }

        public IActionResult UIEditor()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
