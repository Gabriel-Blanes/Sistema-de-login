using MySql.Data.MySqlClient;

namespace ExemploLogin.Database
{
    public class Connection
    {
        private const string connectionString = "Server=localhost;port=3306;User Id=root;database=dbblanes; Password=;";

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
