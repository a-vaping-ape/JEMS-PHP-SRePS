using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PHPSRePS
{
    public partial class InventoryView : Form
    {
        // all products
        List<Product> productList = new List<Product>();

        // database
        Database database = new Database("", "", "", "");

        // main constructor
        public InventoryView()
        {
            InitializeComponent();
            LoadProducts();
        }

        // load data from database
        private void LoadProducts()
        {
            database.OpenConnection();
            string query = database.generateQuery("All Products");
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // populate with database info
                int id = Int32.Parse(reader["ProductID"].ToString());
                string name = reader["ProductName"].ToString();
                string category = reader["CategoryID"].ToString();
                float price = Int32.Parse(reader["UnitPrice"].ToString());
                int stock = Int32.Parse(reader["UnitsInStock"].ToString());
                bool discontinued = reader["Discontinued"].ToString() == "1";

                productList.Add(new Product(id, name, category, price, stock, discontinued));
            }
        }

        // display products to the UI
        private void DisplayAllProducts()
        {
            foreach (Product product in productList)
            {
                // do something
            }
        }

        // go to AddEditProductView to add a product
        private void AddProduct(object sender, EventArgs e)
        {
            int productId = 0;
            new AddEditProductView(productId).ShowDialog();
        }

        // go to AddEditProductView to edit a product
        private void EditProduct()
        {
            int productId = 1;  // get currently selected productId
            //  int productId = Convert.ToInt32(listView1.FocusedItem.Text);
            new AddEditProductView(productId).ShowDialog();
        }
    }
}
