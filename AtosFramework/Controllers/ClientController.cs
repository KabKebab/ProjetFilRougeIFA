using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServicesAtosFramework;

namespace AtosFramework.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            IClientServices Client = new ClientServices();
            var vm = Client.GetClientList();
            return View(vm);
        }

        public ActionResult ContactClient()
        {
            return View();
        }

        public ActionResult TableauClient()
        {
            IClientServices Client = new ClientServices();
            var vm = Client.GetClientList();
            return PartialView("TableauClient", vm);
        }
        public ActionResult Recherche()
        {

            return View();
        }

        public ActionResult FormulaireContact()
        {

            return View();
        }
    }
}