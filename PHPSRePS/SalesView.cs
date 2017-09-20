using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PHPSRePS
{
    public partial class SalesView : Form
    {
        // all sales
        List<Sale> saleList = new List<Sale>();

        // database
        Database database = new Database("", "", "", "");

        public SalesView()
        {
            InitializeComponent();
            LoadSales();
        }

        /* load data from database into saleList */
        private void LoadSales()
        {
            string query = database.generateQuery("All Sales");
            database.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Sale sale = new Sale();

                // populate with database info
                sale.Id = Int32.Parse(reader["SalesID"].ToString());
                sale.Date = reader["SalesDate"].ToString();
                sale.Employee = reader["EmployeeID"].ToString();

                saleList.Add(sale);
            }
        }

        // display items in productList to the UI
        private void DisplayAllSales()
        {
            foreach (Sale sales in saleList)
            {
                // do something
            }
        }

        // go to AddEditProductView to add a product
        private void AddSale(object sender, EventArgs e)
        {
            int saleId = 0;
            new AddEditSaleView(saleId).ShowDialog();
        }

        // go to AddEditProductView to edit a product
        private void EditSale()
        {
            int saleId = 1;
            new AddEditSaleView(saleId).ShowDialog();
        }
    }
}
