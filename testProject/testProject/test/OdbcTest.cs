using System;
using System.Collections.Generic;
using System.Data;
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
            int j = Convert.ToInt32(com.ExecuteScalar());
            Console.WriteLine(j);


            OdbcCommand sc = new OdbcCommand("select clntcode, clntname from tClient", con);
            //OdbcCommand sc = new OdbcCommand("SELECT title, price FROM titles WHERE title LIKE 'Hi%'", cn);
            OdbcDataAdapter da = new OdbcDataAdapter(sc);
            DataSet ds = new DataSet("TitlesDS");
            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                //遍历列
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    Console.WriteLine(dr[i].ToString());
                }
            }
            Console.WriteLine("done");
            return true;
        }

    }
}
