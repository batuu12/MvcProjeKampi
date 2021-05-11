using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statics
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Statistics()
        {
            Context c = new Context();

            var sumCategories = c.Categories.Count();
            ViewBag.d1 = sumCategories;

            var yazılımCategories = c.Categories.Where(x => x.CategoryName == "Yazılım").Count();
            ViewBag.d2 = yazılımCategories;

            var deger3 = c.Writers.Where(x => x.WriterName.Contains("a")).Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Categories.Max(x=>x.CategoryName);
            ViewBag.d4 = deger4;

            var deger5 = c.Categories.Where(x => x.CategoryStatus == true).Count();
            var deger6 = c.Categories.Where(x => x.CategoryStatus == false).Count();
            var deger7 = deger5 - deger6;
            ViewBag.d5 = deger7;
            return View();
        }
    }
}