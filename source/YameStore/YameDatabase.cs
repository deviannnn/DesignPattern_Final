using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore
{
    internal class YameDatabase
    {
        public YameDatabase()
        {

        }

        public SqlConnection getConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            return new SqlConnection(conStr);
        }
    }
}
