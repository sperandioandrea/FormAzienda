using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public static class Db
    {
        private static MySqlConnection connection;

        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                string connectionString = "Server=localhost;Database=dbaziendale;UID=root;Password=;";
                connection = new MySqlConnection(connectionString);
            }
            return connection;
        }
    }
}
