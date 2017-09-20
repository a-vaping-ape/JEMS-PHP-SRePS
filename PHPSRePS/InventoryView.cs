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
                Product product = new Product();

                // populate with database info
                product.Id = Int32.Parse(reader["ProductID"].ToString());
                product.Name = reader["ProductName"].ToString();
                product.Category = reader["CategoryID"].ToString();
                product.Price = Int32.Parse(reader["UnitPrice"].ToString());
                product.Stock = Int32.Parse(reader["UnitsInStock"].ToString());
                product.Discontinued = reader["Discontinued"].ToString() == "1";

                productList.Add(product);
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
            int productId = 1;
            //  int productId = Convert.ToInt32(listView1.FocusedItem.Text);
            new AddEditProductView(productId).ShowDialog();
        }
    }
}
