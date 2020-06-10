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
    }
}
