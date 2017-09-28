using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS {
    public partial class AddEditSaleView : Form {
        // the sale to be added or edited
        Sale currentSale = new Sale();
        private List<Product> productList = new List<Product>();

        // database
        Database database = new Database();

        // main constructor
        public AddEditSaleView(int saleID) {
            InitializeComponent();

            currentSale.ID = saleID;

            if (currentSale.ID != 0) {
                PopulateFields();
            }
        }

        public enum Action
        {
            Add,
            Edit
        };

        #region form methods
        private void DisplayProducts()
        {
            String searchQuery = "";  // get from user input
            LoadProducts(searchQuery);
        }

        private void DisplayCart()
        {
            foreach (ItemSale itemSale in currentSale.ItemSaleList)
            {
                // display to UI
            }
        }

        private void AddToCart()
        {
            Product selectedProduct = new Product();  // get from user input
            int quantity = 0;  // get from user input

            ItemSale itemSale = new ItemSale(currentSale.ID, selectedProduct.ID, quantity);
            currentSale.ItemSaleList.Add(itemSale);
        }

        private void Save()
        {
            formStoreInformation(Action.Add);
        }

        private void Edit()
        {
            formStoreInformation(Action.Edit);
        }

        private void formClearFields()
        {
            // set each field in the UI to blank
        }
        #endregion

        // pre-populate the fields using data from the database associated with the selected saleID
        private void PopulateFields() {
            database.OpenConnection();
            string query = "SELECT * FROM sales WHERE salesID = " + currentSale.ID;
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);

            // search database table for product with the supplied productId and populate object fields with the product's data


            // add code here to fill textfields in the UI with loaded data inside currentProduct (update entry with the ID of currentProduct.Id)

        }

        private void LoadProducts(string searchQuery)
        {
            database.OpenConnection();
            string query = "SELECT * FROM products WHERE CustomerName LIKE '%" + searchQuery + "%'";
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // populate with database info
                int id = Int32.Parse(reader["ProductID"].ToString());
                String name = reader["ProductName"].ToString();
                String category = reader["CategoryID"].ToString();
                float price = Int32.Parse(reader["UnitPrice"].ToString());
                int stock = Int32.Parse(reader["UnitsInStock"].ToString());
                bool discontinued = reader["Discontinued"].ToString() == "1";

                productList.Add(new Product(id, name, category, price, stock, discontinued));
            }
        }

        // store information in local object and save to db
        private void formStoreInformation(Action action)
        {
            MySqlCommand cmd;

            database.OpenConnection();

            //currentSale.Date = DateTime.Today;
            currentSale.Employee = "";

            // save to db
            switch (action)
            {
                case Action.Add: // save the info provided by the user in the fields into the database as a new entry
                    String querySale = currentSale.GetINSERT();
                    cmd = new MySqlCommand(querySale, database.Connection);

                    foreach (ItemSale itemSale in currentSale.ItemSaleList)
                    {
                        String queryItemSale = itemSale.GetINSERT();
                        cmd = new MySqlCommand(queryItemSale, database.Connection);
                    }

                    break;
                case Action.Edit: // update the info provided by the user in the fields into the database
                    String query = currentSale.GetUPDATE();

                    cmd = new MySqlCommand(query, database.Connection);
                    break;
            }
        }
    }
}
