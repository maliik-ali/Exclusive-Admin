using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devdap_admin.Controllers
{
    public class FormsController : Controller
    {
        // GET: Forms
        public ActionResult FormElement()
        {
            return View();
        }
        public ActionResult FormExtended()
        {
            return View();
        }
        public ActionResult TextEditor()
        {
            return View();
        }
        public ActionResult Validation()
        {
            return View();
        }
        public ActionResult Wizard()
        {
            return View();
        }
    }
}