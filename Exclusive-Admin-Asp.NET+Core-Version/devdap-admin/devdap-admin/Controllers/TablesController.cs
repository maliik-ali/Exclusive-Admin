using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devdap_admin.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public ActionResult DataTables()
        {
            return View();
        }
        public ActionResult FooTable()
        {
            return View();
        }
        public ActionResult TableDesign()
        {
            return View();
        }
    }
}