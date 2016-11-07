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
            ViewBag.Message = "Tech specs and docs generated during challenge";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Full Stack .NET Developer";
            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Data must be administrated as well as coded";
            return View();
        }

        public ActionResult Reservation()
        {
            ViewBag.Message = "Reserve a room or rooms now";
            return View();
        }
    }
}