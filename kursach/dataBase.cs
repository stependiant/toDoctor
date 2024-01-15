using MySql.Data.MySqlClient;
using System;

namespace kursach
{
    internal class dataBase : IDisposable
    {
        private MySqlConnection connection;

        public dataBase()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=stepbase";

            connection = new MySqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            closeConnection();
            connection.Dispose();
        }
    }
}