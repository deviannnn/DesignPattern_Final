using System;
using System.Collections.Generic;
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
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=YAMEv1;Integrated Security=True");
        }
    }
}
