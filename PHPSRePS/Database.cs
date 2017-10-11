using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
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
          //  string server = "sql12.freemysqlhosting.net";
            //string databaseName = "sql12196182";    
            //string username = "sql12196182";
            //string password = "nZdkdnzrck";

            string server = "localhost";
            string databaseName = "php_hawthorn";
            string username = "root";
            string password = "";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", server, username, password, databaseName);
            connection = new MySqlConnection(dbConnectionString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Connecting To The Database");
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        
        //used to runqueires that do not return tables
        public bool RunVoidQuery(string query)
        {
            bool result = true;
            OpenConnection();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read()){}
            connection.Close();

            return result;
        }

        public List<String> GetProducts()
        {
            List<String> result = new List<String>();

            OpenConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT ProductName FROM product", connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add((string)reader["ProductName"]);
            }
            connection.Close();

            return result;
        }

        public int  GetCategoires(string name)
        {
            int result = 0;

            OpenConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT CategoryID FROM categories WHERE CategoryName = '"+name+"'", connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // result.Add((string)reader["CategoryID"]);
                result = (int)reader["CategoryID"];
            }
            connection.Close();

            return result;
        }

        public List<String> GetCategoires()
        {
            List<String> result = new List<String>();

            OpenConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT CategoryName FROM categories", connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add((string)reader["CategoryName"]);        
            }
            connection.Close();

            return result;
        }

        public Employee attemptUserLogin(string usr, string pwd)
        {
            string userName = "";
            string password = "";


            Employee foundEmp = null;

            OpenConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `employee` WHERE Username = '" + usr +"' AND Password = '" + pwd + "'", connection);

            var reader = cmd.ExecuteReader();

            //waiting for the GUI implementation
            while (reader.Read())
            {
                userName = (string)reader["Username"];
                password = (string)reader["Password"];

                if ((userName == usr) && (password == pwd))
                {
                    DateTime date = (DateTime)reader["HireDate"];

                    foundEmp = new Employee((int)reader["EmployeeID"], (string)reader["FirstName"], (string)reader["LastName"],
                        (bool)reader["IsManager"], date.ToString(), (bool)reader["Employed"]);
                }

            }
            connection.Close();

            return foundEmp;
        }

        public void CreateSaleItems(List<Product> productList, int EmpID, DateTime date)
        {
            List<Product> checkedProducts = new List<Product>();
            List<ItemSale> Items = new List<ItemSale>();
            Sale sale = new Sale();

            sale.Date = date.ToString("yyyy-MM-dd HH:mm:ss");

            sale.EmployeeID = EmpID;

            bool duplicate;

            //add sales and get the latest ID number
            RunVoidQuery(sale.GetINSERT());
            int ID = ReadOneValue(sale.SelectThisObject(), "SalesID");
            sale.ID = ID;
            sale.EmployeeID = EmpID;

            //works out the quantity for each product

            foreach (Product tempPro in productList)
            {
                duplicate = false;

                foreach (Product p in checkedProducts)
                {
                    if (tempPro.ID == p.ID)
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (duplicate)
                    continue;

                //Product tempPro = productList[i];
                int qty = 0;

                foreach (Product pro in productList)
                {
                    if (tempPro.ID == pro.ID)
                        qty++;
                }

                int remainingStock = tempPro.Stock - qty;

                RunVoidQuery(tempPro.GetUPDATE("product", "UnitsInStock", remainingStock.ToString(), "ProductID", tempPro.ID.ToString()));

                ItemSale Item = new ItemSale(sale.ID, tempPro.ID, qty);
                Items.Add(Item);

                checkedProducts.Add(tempPro);
            }

            //Insert all item sales
            foreach (ItemSale i in Items)
                RunVoidQuery(i.GetINSERT());

        }


        public void CreateSaleItems(List<Product> productList, int EmpID)
        {
            List<Product> checkedProducts = new List<Product>();
            List<ItemSale> Items = new List<ItemSale>();
            Sale sale = new Sale();

            sale.EmployeeID = EmpID;

            bool duplicate;

            //add sales and get the latest ID number
            RunVoidQuery(sale.GetINSERT());
            int ID = ReadOneValue(sale.SelectThisObject(), "SalesID");
            sale.ID = ID;
            sale.EmployeeID = EmpID;

            //works out the quantity for each product

            foreach (Product tempPro in productList)
            {
                duplicate = false;

                foreach (Product p in checkedProducts)
                {
                    if (tempPro.ID == p.ID)
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (duplicate)
                    continue;

                //Product tempPro = productList[i];
                int qty = 0;

                foreach (Product pro in productList)
                {
                    if (tempPro.ID == pro.ID)
                        qty++;
                }

                int remainingStock = tempPro.Stock - qty;

                RunVoidQuery(tempPro.GetUPDATE("product", "UnitsInStock",remainingStock.ToString(), "ProductID", tempPro.ID.ToString()));

                ItemSale Item = new ItemSale(sale.ID, tempPro.ID,qty);
                Items.Add(Item);

                checkedProducts.Add(tempPro);
            }
      
            //Insert all item sales
            foreach (ItemSale i in Items)
                RunVoidQuery(i.GetINSERT());
        }

        //gets a data source for the grid used on the sales page
        public BindingSource getProducts(string input)
        {
            OpenConnection();
            //SELECT* FROM Product WHERE ProductName LIKE"+input+";"
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string queiry;

            if ( (input != "") && (input != "Search product name here"))
                queiry = "SELECT ProductID, ProductName, categories.CategoryName, UnitPrice, UnitsInStock, Discontinued " +
                    "FROM product " +
                    "INNER JOIN categories ON product.CategoryID = categories.CategoryID " +
                    "WHERE ProductName LIKE '" + input + "%';"; 
            else
                queiry = "SELECT ProductID, ProductName, categories.CategoryName, UnitPrice, UnitsInStock, Discontinued " +
                    "FROM product " +
                    "INNER JOIN categories ON product.CategoryID = categories.CategoryID;";

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

        public string generateSalesReportQuery(string groupBy, DateTime startDate, DateTime endDate)
        {
            string startDateString = startDate.Year + "-" + startDate.Month + "-" + startDate.Day + " " + startDate.Hour + ":" + startDate.Minute + ":" + startDate.Second;
            string endDateString = endDate.Year + "-" + endDate.Month + "-" + endDate.Day + " " + 23+ ":" + 59 + ":" + 59;
            string quadrupleJoin =
                "sales INNER JOIN itemsales ON sales.SalesID = itemsales.SalesID "
                + "INNER JOIN employee ON sales.EmployeeID = employee.EmployeeID "
                + "INNER JOIN product ON product.ProductID = itemsales.ProductID "
                + "INNER JOIN categories ON product.CategoryID = categories.CategoryID ";

            string timeFrameLimit = String.Format("WHERE sales.SalesDate >= '{0}' AND sales.SalesDate <= '{1}'", startDateString, endDateString);

            switch (groupBy)
            {
                case "product":
                    return
                        "SELECT product.ProductName AS 'Product', categories.CategoryName AS 'Category', product.UnitPrice AS 'Unit Price', COUNT(sales.SalesID) AS 'Quantity Sold', COUNT(sales.SalesID)*Product.UnitPrice AS 'Total Revenue' FROM "
                        + quadrupleJoin
                        + timeFrameLimit
                        + " GROUP BY ProductName ORDER BY COUNT(sales.salesID)*product.UnitPrice DESC; ";
                case "employee":
                    return
                        "SELECT Employee.FirstName AS employee, COUNT(sales.SalesID) AS 'No. of Sales', COUNT(sales.SalesID)*product.UnitPrice AS 'Total Revenue' FROM "
                        + quadrupleJoin
                        + timeFrameLimit
                        + " GROUP BY employee.FirstName ORDER BY COUNT(sales.SalesID)*product.UnitPrice DESC;";
                case "category":
                    return
                        "SELECT categories.CategoryName as 'Category', COUNT(sales.SalesID) AS 'No. of Sales', COUNT(sales.SalesID)*product.UnitPrice AS 'Total Revenue' FROM "
                        + quadrupleJoin
                        + timeFrameLimit
                        + " GROUP BY categories.CategoryName ORDER BY COUNT(sales.SalesID)*product.UnitPrice DESC;";
                default:
                    return "";
            }
        }

        public string generateSalesHistoryQuery(string itemName, string groupBy)
        {
            string condition;
            //  = (groupBy == "product")

            if (groupBy == "product")
                condition = " WHERE product.ProductName='" + itemName + "' ";
            else
                condition = " WHERE categories.CategoryName='" + itemName + "' ";
               // ? " WHERE Product.ProductName='" + itemName + "' "
                //: " WHERE Categories.CategoryName='" + itemName + "' ";

            return
                "SELECT sales.SalesDate AS Date,SUM(itemsales.Quantity) AS Quantity FROM sales"
                + " INNER JOIN itemsales ON sales.SalesID = itemsales.SalesID"
                + " INNER JOIN product ON product.ProductID = itemsales.ProductID"
                + " INNER JOIN categories ON product.CategoryID = categories.CategoryID"
                + condition
                + " GROUP BY DAY(sales.SalesDate)"
                + " ORDER BY sales.SalesDate ASC";
        }

        //used for reading from the database
        //waiting for GUI implementation to be finished
        public int ReadOneValue(string query, string Value)
        {
            int someValue = -1;
            OpenConnection();

            MySqlCommand cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();

            //waiting for the GUI implementation
            while (reader.Read())
            {
                someValue = (int)reader[Value];

            }
            connection.Close();

            return someValue;
        }

        public string TestConnection()
        {
            string key = "SELECT * FROM categories";
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

                case "All Item sales":
                    return "SELECT * FROM item sales";

                case "All Products":
                    return "SELECT * FROM product";

                case "All sales":
                    return "SELECT * FROM sales";

                case "":
                    return "SELECT * FROM sales";


                default:
                    return "";
            }
        }
    }
}
