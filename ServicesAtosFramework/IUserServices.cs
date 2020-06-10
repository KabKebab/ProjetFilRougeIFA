using BDDAtosFramework;
using ModelAtosFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesAtosFramework
{
   public interface IUserServices
    {

        UserModel GetUser();

        List<UserModel> GetUserList();

        void AddUser(string nom, string prenom, string email, int role, string motDePasse);

        void UpdateUser2(UTILISATEUR Utilisateur);
    }
}
