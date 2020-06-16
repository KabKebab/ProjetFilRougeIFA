
using AtosFramework.Models;
using BDDAtosFramework;
using ModelAtosFramework;
using ServicesAtosFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtosFramework.Controllers
{
    public class UtilisateurController : Controller
    {

        List<UTILISATEUR> UtilisateurSearch { get; set; }

        [AuthorizeCustom (Roles = "1")]
        // GET: Utilisateur
        public ActionResult Index()
        {
            IUserServices Utilisateur = new UserServices();
            var vm = Utilisateur.GetUserList();
            return View(vm);



        }

        public ActionResult RechercheFiltre(string nomRecherche, string prenomRecherche, string nomDeCompteRecherche, string id_ROLERecherche)
        {


            Console.WriteLine(nomRecherche);

            using (var c = new Context())
            {
                var listUTILISATEUR = c.UTILISATEUR.Select(u => new UserModel() { id = u.id, nomDeCompte = u.nomDeCompte, prenom = u.prenom, nom = u.nom, id_ROLE = u.id_ROLE, motDePasse = u.motDePasse }).AsQueryable();

                if (!string.IsNullOrEmpty(nomRecherche))
                {
                    // 5 personnes
                    listUTILISATEUR = listUTILISATEUR.Where(u => u.nom.Contains(nomRecherche)).AsQueryable();
                }

                if (!string.IsNullOrEmpty(prenomRecherche))
                {
                    // 5 personnes


                    listUTILISATEUR = listUTILISATEUR.Where(u => u.prenom.Contains(prenomRecherche)).AsQueryable();
                }
                if (!string.IsNullOrEmpty(nomDeCompteRecherche))
                {
                    // 5 personnes
                   listUTILISATEUR = listUTILISATEUR.Where(u => u.nomDeCompte.Contains(nomDeCompteRecherche)).AsQueryable();
                }
                if (id_ROLERecherche != "")
               {
                    // 5 personnes
                   listUTILISATEUR = listUTILISATEUR.Where(u => u.id_ROLE.ToString().Contains(id_ROLERecherche)).AsQueryable();
                }



                var resultat = listUTILISATEUR.ToList();

                return PartialView("RechercheFiltre", resultat);
            }

            





        }
        public ActionResult ajouter(string nom, string prenom, string email, string role, string motDePasse)
        {
            return View();
        }
        public ActionResult InsertionUtilisateur(UpdateUser UpdateUser)
        {




            UTILISATEUR Utilisateur = new UTILISATEUR();
            Utilisateur.nom = UpdateUser.nom;
            Utilisateur.prenom = UpdateUser.prenom;
            Utilisateur.nomDeCompte = UpdateUser.nomDeCompte;
            Utilisateur.id_ROLE = UpdateUser.id_ROLE;
            Utilisateur.motDePasse = UpdateUser.motDePasse;
            using (Context c = new Context())
            {
                Utilisateur.id = c.UTILISATEUR.Max(u => u.id) + 1;
                c.UTILISATEUR.Add(Utilisateur);
                c.SaveChanges();
            }


            return View();


        }

       
        public ActionResult EnregistreEdit(EditUser UpdateUser)
        {




           

            using (Context c = new Context())
            {

                int essai = Convert.ToInt32(UpdateUser.ididentification);
                var Utilisateur = c.UTILISATEUR.First(a => a.id == essai);
                Utilisateur.id = Convert.ToInt32(UpdateUser.ididentification);
                Utilisateur.nom = UpdateUser.nom;
                Utilisateur.prenom = UpdateUser.prenom;
                Utilisateur.nomDeCompte = UpdateUser.nomDeCompte;
                Utilisateur.id_ROLE = Convert.ToInt32(UpdateUser.id_ROLE);
                Utilisateur.motDePasse = UpdateUser.motDePasse;


                IUserServices userService = new UserServices();
                userService.UpdateUser2(Utilisateur);


                //c.SaveChanges();
            }


            return View();



        }

        public ActionResult edit(int editeur)
        {
            UTILISATEUR listUTILISATEUR = new UTILISATEUR();
            using (var dada = new Context())
            {
                listUTILISATEUR = dada.UTILISATEUR.Where((client) => client.id == editeur).First();
            }

            return PartialView("EditModal", listUTILISATEUR);
            //return View(listUTILISATEUR);
        }

        public ActionResult suprimer(int suprimer)
        {
            UTILISATEUR listUTILISATEUR = new UTILISATEUR();
            using (var dada = new Context())
            {
                listUTILISATEUR = dada.UTILISATEUR.Where((a) => a.id == suprimer).First();

                dada.UTILISATEUR.Remove(listUTILISATEUR);
                dada.SaveChanges();
            }

            return RedirectToAction("Index", "Utilisateur"); ;
        }

        public ActionResult test(int id, string nom, string prenom, string email, int id_ROLE, string motDePasse)
        {
            UTILISATEUR listUTILISATEUR = new UTILISATEUR();
            using (var dada = new Context())
            {
                //Hash MotDepasseHash = new Hash();
                //string PhraseCles = "ATOSPROJECT" + motDePasse + "DOTNET";
                listUTILISATEUR = dada.UTILISATEUR.Where((client) => client.id == id).First();
                listUTILISATEUR.nom = nom;
                listUTILISATEUR.prenom = prenom;
                listUTILISATEUR.nomDeCompte = email;
                listUTILISATEUR.id_ROLE = id_ROLE;
                listUTILISATEUR.motDePasse = motDePasse;
                dada.SaveChanges();
            }

            List<UTILISATEUR> newUser = new List<UTILISATEUR>();
            using (var dada = new Context())
            {
                newUser = dada.UTILISATEUR.ToList();


            }

            // PartialView("TableauUtilisateur", newUser);

            return PartialView("TableauUtilisateur", newUser);

            //return RedirectToAction("Index", newUser); ;
        }

        public ActionResult TableauUtilisateur()
        {
            IUserServices Utilisateur = new UserServices();
            var vm = Utilisateur.GetUserList();
            



            return PartialView("TableauUtilisateur", vm);
        }

        public ActionResult test()
        {
           

            IUserServices newUser = new UserServices();
            var vm = newUser.GetUserList();
            // PartialView("TableauUtilisateur", newUser);

            return PartialView("TableauUtilisateur", vm);

            //return RedirectToAction("Index", newUser); ;
        }

        public ActionResult essaisModal()
        {

            return View();
        }

        public ActionResult Recherche(UpdateUser UpdateUser)
        {




          
            
            using (Context c = new Context())
            {
                var ListRecherche = c.UTILISATEUR.Where(u => u.nom == UpdateUser.nom).ToList() ;
                UtilisateurSearch = new List<UTILISATEUR>(ListRecherche);
            }


            return View();


        }
    }
}