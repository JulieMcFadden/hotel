using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Documentation";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Full Stack .NET Developer";

            return View();
        }
    }
}