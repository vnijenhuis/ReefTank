using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReefTank.Models.Corals;

namespace ReefTank.Web.Areas.Corals.Controllers
{
    public class HomeController : Controller
    {
        // GET: Corals/Coral
        public ActionResult Index()
        {
            return View();
        }
    }
}