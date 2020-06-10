using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtosFramework
{
    public class EditUser
    {

        public int ididentification { get; set; }


        public string nom { get; set; }


        public string prenom { get; set; }


        public string nomDeCompte { get; set; }

        public string motDePasse { get; set; }

        public int id_ROLE { get; set; }
    }
}