using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellDeer.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DisplayBrand()
        {
            
            ViewBag.Message = "Your Brand page.";
            string[] s = { "ahmed", "mahmood", "ali","asdas" };
            List<string> newlist = new List<string>();
            newlist.AddRange(s);
            var d = s.ToList();           
            ViewResult g = new ViewResult();
            g.ViewBag.ad = newlist;
            ViewBag.ad = newlist;
            ViewData["vie"] = newlist;
            var viewli = ViewData["vie"];
            
            
            return View();
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}