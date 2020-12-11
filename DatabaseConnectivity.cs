using System;

using MySql.Data.MySqlClient;

namespace c_Programming{
    public class DatabaseConnectivity
    {
        private MySqlConnection connection;
        private static DatabaseConnectivity instance;
        private string MySQLServer = "localhost";
        private string Port = "9999";
        private string DBName = "books";
        private string UserId = "root";
        private string Password = "yourpassword";

        private DatabaseConnectivity()
        {

        }

        //Singleton
        public static DatabaseConnectivity Instance()
        {

            if (instance == null)
            {
                instance = new DatabaseConnectivity();
                return instance;
            }
            return null;

        }

        public bool OpenConnection()
        {
            if (this.connection != null)
            {
                this.connection.Open();
                return true;
            }
            return false;
        }

        public bool CloseConnection()
        {
            if (this.connection != null)
            {
                MakeInstanceNull();
                this.connection.Close();
                return true;
            }
            return false;
        }

        private void MakeInstanceNull()
        {
            instance = null;
        }

        public string getServerName()
        {
            return this.MySQLServer;
        }

        public MySqlConnection MakeMySQLConnection()
        {
            string connectionString =
             $@"server={this.MySQLServer}; port={this.Port}; database={this.DBName}; userid={this.UserId}; password={this.Password}";

            if (this.connection == null) {
                try {
                    this.connection = new MySqlConnection(connectionString);
                    Console.WriteLine("\nDatabase Connection Has Been Made. But connection is closed.");
                    return this.connection;

                }
                catch (Exception e) {
                    Console.WriteLine("\nPrint Error Message: " + e);
                }
            }
            return null;
        }
    }
}