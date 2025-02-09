using Dip.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace Dip.Factory
{
    class DbProductFactory
    {
        public static IDbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }
    }
}
