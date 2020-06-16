using ServicesAtosFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtosFramework.Models;
using BDDAtosFramework;
using ModelAtosFramework;



using System.ComponentModel.DataAnnotations.Schema;


namespace AtosFramework.Controllers
{
    public class CompetenceController : Controller
    {
        [AuthorizeCustom]
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
            return PartialView("TableauCompetences", vm);
        }

        public ActionResult ModifierCompetence(EditCompetence ediCompetence)
        {

            using (Context c = new Context())
            {

                
                var competence = c.COMPETENCE.First(a => a.id == ediCompetence.id);
                competence.id = ediCompetence.id;
                competence.intitule = ediCompetence.intitule;
                competence.id_TYPE_COMPETENCE = ediCompetence.id_TYPE_COMPETENCE;

                ICompetenceService userService = new CompetenceService();
                userService.ModifierCompetence(competence);


            }
            return View();
        }

        public ActionResult supprimer(int supprimer)
        {
            COMPETENCE listCOMPETENCE = new COMPETENCE();
            try { 
                using (var c = new Context())
                {
                    listCOMPETENCE = c.COMPETENCE.Where((a) => a.id == supprimer).First();

                    c.COMPETENCE.Remove(listCOMPETENCE);
                    c.SaveChanges();
                }
            }
            catch(Exception)
            {

                RedirectToAction("Index", "Competence");



            }
            return RedirectToAction("Index", "Competence"); ;
        }

    }
}