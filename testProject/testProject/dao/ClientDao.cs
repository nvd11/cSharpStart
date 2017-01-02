using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.model;

namespace com.dao
{
    class ClientDao
    {
        public List<Client> getClientList()
        {
            List<Client> list = new List<Client>();
            list.Add(new Client("code1", "name1"));
            list.Add(new Client("code2", "name2"));
            return list;
        }

    }
}
