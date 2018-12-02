using System.Configuration;
using System.Data.SqlClient;

namespace Department.DAL
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
