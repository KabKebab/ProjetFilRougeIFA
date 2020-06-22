using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAtosFramework
{
    public class ClientModel
    {

        public int id { get; set; }

        public string intitule { get; set; }

        public string adresseSiege { get; set; }


        public bool Actif { get; set; }

        public  ICollection<ContactClientModel> CONTACT_CLIENT { get; set; }  
    }
}
