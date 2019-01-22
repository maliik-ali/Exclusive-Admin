using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devdap_admin.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult ChartJs()
        {
            return View();
        }
        public ActionResult FlotChart()
        {
            return View();
        }
        public ActionResult InlineGraph()
        {
            return View();
        }
        public ActionResult Chartist()
        {
            return View();
        }
        public ActionResult C3Chart()
        {
            return View();
        }
    }
}