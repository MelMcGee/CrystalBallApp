using CrystalBallApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrystalBallApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ShakeBall()
        {
            RandomStrings rndStr = new RandomStrings();

            return Json( rndStr.grabRandomString(), JsonRequestBehavior.AllowGet);
        }

     }
}