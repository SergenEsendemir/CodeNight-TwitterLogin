using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage

        public ActionResult MainPage()
        {
            return View();
        }
        public ActionResult UserPage()
        {
            return View();
        }
        public ActionResult Notifications()
        {
            return View();
        }
        public ActionResult DirectMessage()
        {
            return View();
        }
    }
}