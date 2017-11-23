using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReefTank.Models.Base;

namespace ReefTank.Web.Areas.Migrations.Controllers
{
    public class MigrateController : Controller
    {
        // GET: Migrations/Migrate
        public ActionResult Index()
        {
            var category = new Category();
            category.Name = "";
            var categories = new[]
            {
                new Category() {Name = "Bivalves"},
                new Category() {Name = "Crustaceans"},
                new Category() {Name = "Echinoderms"},
                new Category() {Name = "Fish"},
                new Category() {Name = "Molluscs"},
                new Category() {Name = ""},
                new Category() {Name = ""},
                new Category() {Name = ""},
                new Category() {Name = ""},
            };
            return Content("Done");
        }
    }
}