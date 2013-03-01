using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGeolocation.Helpers;

namespace MvcGeolocation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Places()
        {
            var googleApiKey = GlobalHelper.GetConfigVal(GlobalHelper.GoogleApiKey);
            ViewBag.GoogleApiKey = googleApiKey;
            return View();
        }
    }
}
