using System.Configuration;
using System.Data.SqlClient;

namespace EczaneYonetimSistemi.DataAccess
{
    public class DbHelper
    {
        // App.config içindeki connection string’i alır
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["EczaneDb"].ConnectionString;

        // SqlConnection döndüren metot
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
