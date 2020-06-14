
using AtosFramework.Models;
using ModelAtosFramework;
using Newtonsoft.Json;
using ServicesAtosFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Security;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace AtosFramework.Controllers
{

    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Ident(LoginModel loginModel)
        {
            // Je verifie si le model est valid
            if (ModelState.IsValid)
            {
                //// je rempli l'objet de ma DAL
                UserModel userModel = new UserModel();
                Console.WriteLine(loginModel.LoginUtilisateur);
                userModel.nomDeCompte = loginModel.LoginUtilisateur;
                userModel.motDePasse = loginModel.LoginMotDePasse;
                //userModel.Role = DBModel.Roles.Client;
                // J'instencie le service
                IUserServices userService = new UserServices();

                if (userService.UserExist(userModel))
                {
                    // je vais chercher en db les infos de cet utilisateur

                    var userInfos = userService.GetUser(userModel);
                    userModel.id_ROLE = userInfos.id_ROLE;
                    // Je crée un coockie d'authent du nom .ASPXAUTH
                    //System.Web.Security.FormsAuthentication.SetAuthCookie(loginModel.LoginEmail, true);

                    var objectJson = JsonConvert.SerializeObject(userModel);
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, Constantes.Authent, DateTime.Now,
                                                            DateTime.Now.AddMinutes(30),
                                                            true, objectJson, FormsAuthentication.FormsCookiePath);

                    Response.Cookies.Add
                                            (
                                                new HttpCookie
                                                (
                                                    FormsAuthentication.FormsCookieName,
                                                    FormsAuthentication.Encrypt(ticket)
                                                )
                                            );

                    //Session["User"] = loginModel.LoginEmail;
                    //Session["test"] = "Cou";
                    // Manually add the authCookie to the Cookies collection
                    //response
                    return new JsonResult { Data = true, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }
                return new JsonResult { Data = false, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            }
            else
                return new JsonResult { Data = false, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

    }
}