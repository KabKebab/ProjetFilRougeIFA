using BDDAtosFramework;
using ModelAtosFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServicesAtosFramework
{
    public class ClientServices : IClientServices
    {
        public List<ClientModel> GetClientList()
        {

            using (var context = new Context())
            {
                return context.CLIENT.Select(a => new ClientModel { id = a.id, intitule = a.intitule, adresseSiege = a.adresseSiege, Actif = true}).ToList();
            }


        }
    }
}
