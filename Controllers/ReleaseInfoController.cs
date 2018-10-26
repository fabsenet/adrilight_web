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
        public IActionResult Index(string version, string lang)
        {
            string view = null;
            switch (version)
            {
                case "2.0.7":
                    if (lang.StartsWith("de", StringComparison.OrdinalIgnoreCase))
                    {
                        view = "v2.0.7_de";
                    }
                    else
                    {
                        //en is default
                        view = "v2.0.7_en";
                    }
                    break;
            }
            if (view != null)
            {
                ViewBag.Version = version;
                return View(view);
            }

            return this.NotFound("This version does not exist (yet).");
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
