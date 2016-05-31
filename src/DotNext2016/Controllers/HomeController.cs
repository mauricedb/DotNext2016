using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.PlatformAbstractions;

namespace DotNext2016.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var runtime = PlatformServices.Default.Runtime;

            ViewData["Message"] = "Your application is running on:";
            ViewData["OperatingSystem"] = runtime.OperatingSystem;
            ViewData["OperatingSystemVersion"] = runtime.OperatingSystemVersion;
            ViewData["RuntimeType"] = runtime.RuntimeType;
            ViewData["RuntimeArchitecture"] = runtime.RuntimeArchitecture;
            ViewData["RuntimeVersion"] = runtime.RuntimeVersion;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
