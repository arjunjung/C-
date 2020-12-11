using System;
using MySql.Data.MySqlClient;

namespace c_Programming{
    public class PlayingWithMySQL  {
        public PlayingWithMySQL() {

        }

        public void Play() {
            DatabaseConnectivity databaseConnectivity = DatabaseConnectivity.Instance();
            MySqlConnection conn= databaseConnectivity.MakeMySQLConnection();

            if(databaseConnectivity.OpenConnection() == true) {
                Console.WriteLine("\nConnection is open now.\n");
            }

            // //MYSql Select Operation
            // string SelectQuery = "SELECT *  FROM authors";
            // MySqlCommand MSCommand = new MySqlCommand(SelectQuery, conn);

            // MySqlDataReader MSDreader = MSCommand.ExecuteReader();


            // Console.WriteLine("ID    Author_Name    Author_Interest");

            // //Reading each row one at a time, unitl Read() method sends false flag(which mean the all the data has been finished iterating)
            // while(MSDreader.Read()) {
            //     Console.WriteLine("| {0}  |  {1}   {2} |", MSDreader.GetInt32(0), MSDreader.GetString(1), MSDreader.GetString(2));
            // }

            // //MYSql Insert Operation

            // string InsertQuery = "INSERT INTO authors(name, genre) VALUES('Subin Bhattari', 'Love Story') ";
            // MySqlCommand MSCommandInsert = new MySqlCommand(InsertQuery, conn);

            // try
            // {
            //     MSCommandInsert.ExecuteNonQuery();
            //     Console.WriteLine("Data inserted successfully.");
            // } catch (Exception e) {
            //     Console.WriteLine($"\n {e} \n");
            // }

            // //Creating Table with Foreign key constraint
            // string CreateTableQuery = "CREATE TABLE kitabs(id INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT, authorId INT UNIQUE, FOREIGN KEY (authorId) REFERENCES authors(id))";
            // MySqlCommand MySqlCreateTableCmd = new MySqlCommand(CreateTableQuery, conn);

            // try {
            //     MySqlCreateTableCmd.ExecuteNonQuery();
            //     Console.WriteLine("Table created successfully.");
            // } catch (Exception e) {
            //     Console.WriteLine($"\n {e} \n");
            // }

            // //Inserting 3 data into Table with foreign key constraint [Maxinum number of data entry using single query is 1000]
            // string Insert3DataQuery = "INSERT INTO kitabs(name, authorId) VALUES('Harry Potter', 1), ('Revolution 2020', 2), ('Summer Love', 3)";
            // MySqlCommand MySqlCommandI3Q = new MySqlCommand(Insert3DataQuery, conn);

            // try {
            //     MySqlCommandI3Q.ExecuteNonQuery();
            //     Console.WriteLine("\n3 data has been inserted successfully into kitabs table.\n");

            // } catch(Exception e) {
            //     Console.WriteLine($"\n {e} \n");
            // }

            //Note: I am not doing DELETE and UPDATE query 

            //Doing MYSQL prepared statements: Which will increase security and performance
            //Basically it is used in  INSERT OPERATIONS    

            // string PreparedInsertQuery = "INSERT INTO authors(name, genre) VALUES(@name, @genre)";
            // MySqlCommand MSpiq = new MySqlCommand(PreparedInsertQuery, conn);

            // MSpiq.Parameters.AddWithValue("@name", "Vishen Lakhyani");

            // MSpiq.Parameters.AddWithValue("@genre", "Personal Dpmnt");
            // MSpiq.Prepare();

            // try
            // {
            //     MSpiq.ExecuteNonQuery();
            //     Console.WriteLine("Data inserted successfully using Prepare statement.");
            // } catch (Exception e) {
            //     Console.WriteLine($"\n {e} \n");
            // }

            //Delete Query 
            string DeleteQuery = "DELETE FROM authors WHERE id=5";
            MySqlCommand MSDeleteCmd = new MySqlCommand(DeleteQuery, conn);

            try {
                MSDeleteCmd.ExecuteNonQuery();
                Console.WriteLine("\nId:5 Data is deleted successfully.\n");
            } catch(Exception e) {
                Console.WriteLine($"\n {e} \n");
            }

            if(databaseConnectivity.CloseConnection()) {
                Console.WriteLine("\nYou lost Database connection.\n ");
            }
        }
    }

}