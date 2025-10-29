using System.Configuration;
using System.Data.SqlClient;

namespace HumanResourcesManager_Project.DAL
{
    internal class ConnectionDB
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["HighTechDBConnectionString"].ConnectionString;
        private static SqlConnection connection = null;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
