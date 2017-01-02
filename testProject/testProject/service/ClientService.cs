using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.model;
using com.dao;

namespace com.service
{
    class ClientService
    {
        public List<Client> getClients()
        {
            return new ClientDao().getClientList();
        }
    }
}
