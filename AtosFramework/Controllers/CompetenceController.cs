using ServicesAtosFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtosFramework.Controllers
{
    public class CompetenceController : Controller
    {
        // GET: Competence
        public ActionResult Index()
        {

            ICompetenceService listCompetences = new CompetenceService();
            var vm = listCompetences.GetCompetenceList();
            return View(vm);
        }
        public ActionResult TableauCompetences()
        {
            
            ICompetenceService listCompetences = new CompetenceService();
           var vm = listCompetences.GetCompetenceList();
            return View(vm);
        }
    }
}