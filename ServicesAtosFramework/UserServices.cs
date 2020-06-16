using BDDAtosFramework;
using ModelAtosFramework;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

namespace ServicesAtosFramework
{
    public class UserServices : IUserServices
    {

        public UserModel GetUser()
        {

            using (var context = new Context())
            {
                return context.UTILISATEUR.Select(a => new UserModel { id = a.id, nom = a.nom, prenom = a.prenom, nomDeCompte = a.nomDeCompte, id_ROLE = a.id_ROLE, motDePasse = a.motDePasse}).First();
            }


        }
        public List<UserModel> GetUserList()
        {

            using (Context c = new Context())
            {
                return c.UTILISATEUR.Select(a => new UserModel { id = a.id, nom = a.nom, prenom = a.prenom, nomDeCompte = a.nomDeCompte, id_ROLE = a.id_ROLE, motDePasse = a.motDePasse }).ToList();
            }


        }

        public void AddUser(string nom, string prenom, string email, int role, string motDePasse)
        {
           

            using (Context c = new Context())
            {
                UTILISATEUR UdateUtilisateur = new UTILISATEUR();
            //Hash MotDepasseHash = new Hash();
            UdateUtilisateur.nom = nom;
            UdateUtilisateur.prenom = prenom;
            UdateUtilisateur.nomDeCompte = email;
            UdateUtilisateur.id_ROLE = role;
            UdateUtilisateur.motDePasse = motDePasse;


                int Idmax =  c.UTILISATEUR.Max(u=>u.id) + 1;
                Console.WriteLine("mon max" + Idmax);
            UdateUtilisateur.id = Idmax;
                c.UTILISATEUR.Add(UdateUtilisateur);
                c.SaveChanges();
            }

        }
        public void UpdateUser2(UTILISATEUR Utilisateur)
        {

            

           
             UTILISATEUR UtilisateurUpdate = new UTILISATEUR();

                using (Context c = new Context())
            {
                UtilisateurUpdate = c.UTILISATEUR.First(a => a.id == Utilisateur.id);
                UtilisateurUpdate.id = Utilisateur.id;
                UtilisateurUpdate.nom = Utilisateur.nom;
                UtilisateurUpdate.prenom = Utilisateur.prenom;
                UtilisateurUpdate.nomDeCompte = Utilisateur.nomDeCompte;
                UtilisateurUpdate.id_ROLE = Utilisateur.id_ROLE;
                UtilisateurUpdate.motDePasse =Utilisateur.motDePasse ;

               c.SaveChanges();
            }

        }



        public List<UserModel> SearchMultiple(UserModel ObjetDrefenrenceDeLaRecherche)
        {
            using (var RechercheParFiltre = new Context())
            {
                var listUTILISATEUR = RechercheParFiltre.UTILISATEUR.Select(u => new UserModel() { id = u.id, nomDeCompte = u.nomDeCompte, prenom = u.prenom, nom = u.nom, id_ROLE = u.id_ROLE, motDePasse = u.motDePasse }).AsQueryable();

                if (!string.IsNullOrEmpty(ObjetDrefenrenceDeLaRecherche.nom))
                {
                    // 5 personnes
                    listUTILISATEUR = listUTILISATEUR.Where(u => u.nom.Contains(ObjetDrefenrenceDeLaRecherche.nom)).AsQueryable();
                }
                if (!string.IsNullOrEmpty(ObjetDrefenrenceDeLaRecherche.prenom))
                {
                    // 5 personnes
                    listUTILISATEUR = listUTILISATEUR.Where(u => u.prenom.Contains(ObjetDrefenrenceDeLaRecherche.prenom)).AsQueryable();
                }
                if (!string.IsNullOrEmpty(ObjetDrefenrenceDeLaRecherche.nomDeCompte))
                {
                    // 5 personnes
                    listUTILISATEUR = listUTILISATEUR.Where(u => u.nomDeCompte.Contains(ObjetDrefenrenceDeLaRecherche.nomDeCompte)).AsQueryable();
                }
                if (ObjetDrefenrenceDeLaRecherche.id_ROLE != 0)
                {
                    // 5 personnes
                    listUTILISATEUR = listUTILISATEUR.Where(u => u.id_ROLE == ObjetDrefenrenceDeLaRecherche.id_ROLE).AsQueryable();
                }

                return listUTILISATEUR.ToList();

            }
        }

        public bool UserExist(UserModel utilisateur)
        {
            using (Context c = new Context())
            {
                var test = c.UTILISATEUR.Any(u => u.nomDeCompte == utilisateur.nomDeCompte && u.motDePasse == utilisateur.motDePasse);
                return test;
            }



        }

        public UserModel GetUser(UserModel user)
        {
            if (user.id != 0)
            {

                using (Context c = new Context())
                {
                    var getuser = c.UTILISATEUR.Where(u => u.id == user.id).Select(p => new UserModel { id = p.id, nom = p.nom, prenom = p.prenom }).FirstOrDefault();
                    return getuser;

                }
            }
            if (!string.IsNullOrEmpty(user.nom))
            {
                using (Context c = new Context())
                {
                    var getuser = c.UTILISATEUR.Where(u => u.nom == user.nom).Select(p => new UserModel { id = p.id, nom = p.nom, prenom = p.prenom, id_ROLE = p.id_ROLE }).FirstOrDefault();
                    return getuser;

                }
            }
            else
                using (Context c = new Context())
                {
                    var getuser = c.UTILISATEUR.Select(p => new UserModel { id = p.id, nom = p.nom, prenom = p.prenom, id_ROLE = p.id_ROLE }).FirstOrDefault();
                    return getuser;

                }
        }
    }
}
