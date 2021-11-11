using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minimarket_Raphi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nosotros somos el minimarket Raphi.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Puedes contactarnos desde el siguiente formulario.";

            return View();
        }
    }
}