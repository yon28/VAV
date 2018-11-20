using System.Configuration;
using System.Data.SqlClient;

namespace Department.DAL
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            string databaseName = ConfigurationManager.AppSettings["EmployeesAndRewards"];
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = databaseName;

            return builder.ToString();
        }
    }
}
