using ModelAtosFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesAtosFramework
{
    public interface IClientServices
    {

        List<ClientModel> GetClientList();
    }
}
