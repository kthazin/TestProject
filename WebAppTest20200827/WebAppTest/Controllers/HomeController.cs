using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AreaChart()
        {
            return View();
        }

        public ActionResult HeatMap()
        {
            return View();
        }
        public ActionResult TimeLine()
        {
            return View();
        }
        public ActionResult RadialBarChart()
        {
            return View();
        }
        public ActionResult MonochroneChart()
        {
            return View();
        }
        public ActionResult BasicLine()
        {
            return View();
        }
        public ActionResult InterpolationModeChart()
        {
            return View();
        }
        public ActionResult LineStyleChart()
        {
            return View();
        }
        public ActionResult PointSizesChart()
        {
            return View();
        }
        public ActionResult PointStylesChart()
        {
            return View();
        }
        public ActionResult SkipPointChart()
        {
            return View();
        }
        public ActionResult HorizontalChart()
        {
            return View();
        }
        public ActionResult StackedBarChart()
        {
            return View();
        }
        public ActionResult VerticalChart()
        {
            return View();
        }
        public ActionResult MultiAxisChart()
        {
            return View();
        }
        public ActionResult StackedBarChartGroup()
        {
            return View();
        }
        public ActionResult LineBoundariesChart()
        {
            return View();
        }
        public ActionResult LineDatasetsChart()
        {
            return View();
        }
        public ActionResult LineStackedChart()
        {
            return View();
        }
        public ActionResult RadarChart()
        {
            return View();
        }
    }
}