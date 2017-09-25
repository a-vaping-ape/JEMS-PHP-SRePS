using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PHPSRePS
{
    public partial class SalesView : Form
    {
        // all sales
        private List<Sale> saleList = new List<Sale>();

        // database
        Database database = new Database("", "", "", "");

        // main constructor
        public SalesView()
        {
            InitializeComponent();
            LoadSales();
        }

        #region form methods
        // display items in productList to the UI
        private void formDisplaySales()
        {
            foreach (Sale sales in saleList)
            {
                // do something
            }
        }

        // go to AddEditProductView to add a product
        private void formAddSale(object sender, EventArgs e)
        {
            int saleId = 0;
            new AddEditSaleView(saleId).ShowDialog();
        }

        // go to AddEditProductView to edit a product
        private void formEditSale()
        {
            int saleId = 1;  // get currently selected saleId
            new AddEditSaleView(saleId).ShowDialog();
        }
        #endregion

        /* load data from database into saleList */
        private void LoadSales()
        {
            string query = database.generateQuery("All Sales");
            database.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // populate with database info
                int id = Int32.Parse(reader["SalesID"].ToString());
                string date = reader["SalesDate"].ToString();
                string employee = reader["EmployeeID"].ToString();

                saleList.Add(new Sale(id, date, employee));
            }
        }
    }
}
