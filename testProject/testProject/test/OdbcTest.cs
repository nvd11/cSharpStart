using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.testProject.test
{
    class OdbcTest
    {
        public Boolean connectODBC()
        {
            string conString = "DSN=odbcCompass";
            string sql = "select count(*) from tClient";
            OdbcConnection con = new OdbcConnection(conString);

            con.Open();
            OdbcCommand com = new OdbcCommand(sql, con);
            int i = Convert.ToInt32(com.ExecuteScalar());
            Console.WriteLine(i);
            return true;
        }

    }
}
