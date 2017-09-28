using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PHPSRePS
{

   public class Database
    {
        //CONSTS
        private string server = "110.22.43.149";
        private string databaseName = "hawthornpharmacy";

        //changes depending on user
        private string username = "admin";
        private string password = "dp22017";

        MySqlConnection connection;

        //use this in solution
        public Database(string svr, string usr, string pwd, string db )
        {
            server = svr;
            username = usr;
            password = pwd;
            databaseName = db;
        }

        //overloading for debugging purposes
        public Database()
        {

        }

        public MySqlConnection Connection { get => connection; set => connection = value; }

        public void OpenConnection()
        {
            /*string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", server, username, password, databaseName);
            connection = new MySqlConnection(dbConnectionString);
            connection.Open();*/
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        //used for reading from the database
        //waiting for GUI implementation to be finished
        public void ReadDatabase(string key)
        {
            OpenConnection();

            MySqlCommand cmd = new MySqlCommand(generateQuery(key), connection);
            var reader = cmd.ExecuteReader();

            //waiting for the GUI implementation
            while (reader.Read())
            {
                var someValue = reader[1];
                var someValue2 = reader["CategoryID"];
                Console.Write(someValue + "-" + someValue2 + "\n");
            }
            connection.Close();
        }

        //GUI will generate query fron form
        public void Insert(string query)
        {
            OpenConnection();

            string query2 = "INSERT INTO categories(CategoryID, CategoryName)VALUES('6', 'test2')";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query2, connection);
                var reader = cmd.ExecuteReader();
            }
            catch
            {
                Console.WriteLine("ERROR: ");
            }
            

            //waiting for the GUI implementation
            //while (reader.Read()) { }

            connection.Close();
        }

        //the key is predefined SQL statements 
        //if a key contains '#' at the start
        //then the query is defined by the key
        //eg key = #SELECT * FROM table
        //returns SELECT * FROM table
        public String generateQuery(String key)
        {
     
            if (key.Contains('#'))
                return key.TrimStart('#');

            //predefined SQL statements
            switch(key)
            {
                case "All Categories":
                    return "SELECT * FROM categories";

                case "All Employee":
                    return "SELECT * FROM employee";

                case "All Item Sales":
                    return "SELECT * FROM item sales";

                case "All Products":
                    return "SELECT * FROM product";

                case "All Sales":
                    return "SELECT * FROM sales";

                default:
                    return "";
            }
        }

        public String generateSalesReportQuery(String key)
        {
            if (key.Contains('#'))
                return key.TrimStart('#');

            //predefined SQL statements
            switch (key)
            {
                case "GROUPBY_PRODUCT":
                    return "SELECT ";
                default:
                    return "";
            }
        }
    }
}
