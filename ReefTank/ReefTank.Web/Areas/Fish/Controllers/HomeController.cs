using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReefTank.Web.Areas.Fish.Controllers
{
    public class HomeController : Controller
    {
        // GET: Fish/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}