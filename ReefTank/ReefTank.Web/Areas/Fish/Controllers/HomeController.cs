using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReefTank.Models.Inhabitants;

namespace ReefTank.Web.Areas.Fish.Controllers
{
    public class HomeController : Controller
    {
        // GET: Fish/Home
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create()
        //{
        //    return RedirectToAction("Index");
        //}

        public ActionResult Edit(Guid id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit()
        {
            return RedirectToAction("Index");
        }
    }
}