using System;
using MySql.Data.MySqlClient;

namespace c_Programming {
    public class TestSingleInstanceClass{

        public TestSingleInstanceClass() {

            try{
                DatabaseConnectivity databaseCon = DatabaseConnectivity.Instance();
                databaseCon.OpenConnection();
                databaseCon.CloseConnection();
                DatabaseConnectivity databaseCon2 = DatabaseConnectivity.Instance();
                // DatabaseConnectivity databaseCon4 = DatabaseConnectivity.Instance();

                Console.WriteLine("Print server name [databaseCon]: "+databaseCon.getServerName());
                Console.WriteLine("Print server name [databaseCon2]: "+databaseCon2.getServerName());
                // databaseCon2.getServerName();

            } catch (Exception e)
            {
                Console.WriteLine("\nError Message: " + e);
            }
        }
    }
}