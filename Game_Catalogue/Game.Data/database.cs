using System.Data.SqlClient;

namespace Data
{

    /// <summary>
    /// Microsoft SQL Server Database Connection Class
    /// </summary>
    public static class DataBase
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GAMECATALOGUE;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}
