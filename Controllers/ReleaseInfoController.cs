using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using adrilight_web.Models;

namespace adrilight_web.Controllers
{
    public class ReleaseInfoController : Controller
    {
        public IActionResult Index(string version, string lang = null)
        {
            //we support "de" and "en" for now...
            lang = (lang ?? "en").StartsWith("de", StringComparison.OrdinalIgnoreCase) ? "de" : "en";


            switch (version)
            {
                //supported versions only have to have a case here
                case "2.0.7":
                //case "2.0.8": this version was never released
                case "2.0.9":
                    ViewBag.Version = version;
                    return View($"v{version}_{lang}");

                case "private_build":
                    return View($"{version}_{lang}");

                default:
                    version = "unknown";
                    return View($"{version}_{lang}");
            }

        }
    }
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.Content("nothing here for now");
        }
    }
}
