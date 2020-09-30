using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTest.Controllers
{
    public class ComponentController : Controller
    {
        // GET: Component
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alerts()
        {
            return View();
        }
        public ActionResult Forms()
        {
            return View();
        }
    }
}