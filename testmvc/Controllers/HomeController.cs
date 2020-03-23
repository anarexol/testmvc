using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testmvc.Models;

namespace testmvc.Controllers {
    public class HomeController : Controller {

        public ViewResult Index() {

            return View("Splash");
        }

        [HttpGet]
 
        [HttpPost]
        public ActionResult Zskrechner(ZSKbag zsk) {

            

            ViewBag.Ziegen = zsk.Ziegen * 300;
            ViewBag.Schafe = zsk.Schafe * 200;
            ViewBag.Kuehe = zsk.Kuehe * 800;
            ViewBag.EUR = ViewBag.Ziegen + ViewBag.Schafe + ViewBag.Kuehe;
            if (ViewBag.EUR != 0 && ViewBag.EUR != null)
            {
                ViewBag.Ausgabe = "Sie erhalten EUR: ";
                
            }
            return View("zskrechner");

        }

    }
}
