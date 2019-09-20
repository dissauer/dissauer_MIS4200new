using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dissauer_MIS4800.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our History Starts With One Man";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nearest Location";

            return View();
        }
    }
}