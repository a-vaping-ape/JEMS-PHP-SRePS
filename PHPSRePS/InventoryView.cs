using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS
{
    public partial class InventoryView : Form
    {
        // all products
        private List<Product> productList = new List<Product>();

        // database
        Database database = new Database("", "", "", "");

        // main constructor
        public InventoryView()
        {
            InitializeComponent();
            LoadProducts();
        }

        #region form methods
        // display products to the UI
        private void formDisplayProducts()
        {
            foreach (Product product in productList)
            {
                // do something
            }
        }

        // go to AddEditProductView to add a product
        private void formAddProduct(object sender, EventArgs e)
        {
            int productId = 0;
            new AddEditProductView(productId).ShowDialog();
        }

        // go to AddEditProductView to edit a product
        private void formEditProduct()
        {
            int productId = 1;  // get currently selected productId
            //  int productId = Convert.ToInt32(listView1.FocusedItem.Text);
            new AddEditProductView(productId).ShowDialog();
        }
        #endregion

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
    }
}
