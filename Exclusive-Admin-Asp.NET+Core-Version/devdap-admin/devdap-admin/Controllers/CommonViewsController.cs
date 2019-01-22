using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devdap_admin.Controllers
{
    public class CommonViewsController : Controller
    {
        // GET: CommonViews
        public ActionResult ErrorOne()
        {
            return View();
        }
        public ActionResult ErrorTwo()
        {
            return View();
        }
        public ActionResult LockScreen()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult PasswordRecovery()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}