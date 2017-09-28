using System;
using System.Windows.Forms;
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
        MySqlConnection connection;
        
        public Database()
        {
        }

        public MySqlConnection Connection { get => connection; set => connection = value; }

        //add this to anymehtods working with the database
        public void OpenConnection()
        {
            string server = "sql12.freemysqlhosting.net";
            string databaseName = "sql12196182";    
            string username = "sql12196182";
            string password = "nZdkdnzrck";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", server, username, password, databaseName);
            connection = new MySqlConnection(dbConnectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public BindingSource getProducts(string input)
        {
            OpenConnection();
            //SELECT* FROM Product WHERE ProductName LIKE"+input+";"
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string queiry;

            if (input != "")
                queiry = "SELECT * FROM Product WHERE ProductName LIKE '" + input + "%';";
            else
                queiry = "SELECT * FROM Product";

            BindingSource bSource = null;

            try
            {
                MyDA.SelectCommand = new MySqlCommand(queiry, connection);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                bSource = new BindingSource();
                bSource.DataSource = table;
            }
            catch
            {
                Console.WriteLine("Smoething ducked up");
            }
            finally
            {
                CloseConnection();
            }
            return bSource;
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

        public string TestConnection()
        {
            string key = "SELECT * FROM Categories";
            OpenConnection();

            MySqlCommand cmd = new MySqlCommand(key, connection);
            var reader = cmd.ExecuteReader();

            //waiting for the GUI implementation
            while (reader.Read())
            {
                return reader["CategoryID"].ToString();
            }
            connection.Close();
            return "Error in connection";
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
