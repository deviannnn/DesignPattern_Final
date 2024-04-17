using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameDatabase;

namespace YameStore
{
    public sealed class DBFactoryManager
    {
        private static readonly DBFactoryManager instance = new DBFactoryManager();

        private DatabaseFactory currentFactory;

        private DBFactoryManager()
        {
            // Khởi tạo factory mặc định: SQLFactory
            var dbType = ConfigurationManager.AppSettings["DBType"];
            var cnStr = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            switch (dbType)
            {
                case "mssql":
                    currentFactory = new SQLFactory(cnStr);
                    break;
                case "ole":
                    currentFactory = new AccessFactory(cnStr);
                    break;
                default:
                    currentFactory = new SQLFactory(cnStr);
                    break;
            }
        }

        public static DBFactoryManager Instance => instance;

        public void SetFactory(DatabaseFactory factory)
        {
            currentFactory = factory;
        }

        public DatabaseFactory GetFactory()
        {
            return currentFactory;
        }
    }
}
