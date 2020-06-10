using ServicesAtosFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtosFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            IUserServices Utilisateur = new UserServices();
            var vm = Utilisateur.GetUser();
            //return View(vm);
            return RedirectToAction("Index", "Utilisateur");
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
    }
}