using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace PHPSRePS {
    public partial class MainView : Form {
        // TODO sprint2: implement authorisation + levels of security

        // database
        Database database = new Database();

        // all products
        private List<Product> productList = new List<Product>();
        private List<Sale> saleList = new List<Sale>();

        // clear all data
        private void ClearData()
        {
            productList.Clear();
            saleList.Clear();
        }

        public MainView() {
            InitializeComponent();
            salesTab.FlatAppearance.BorderSize = 0;
            inventTab.FlatAppearance.BorderSize = 0;
            reportsTab.FlatAppearance.BorderSize = 0;
            homeTab.FlatAppearance.BorderSize = 0;
            updateTabButtons();
            

            salesTab.Click += new EventHandler(this.OpenSales);
            inventTab.Click += new EventHandler(this.OpenInventory);
            reportsTab.Click += new EventHandler(this.OpenReports);
            homeTab.Click += new EventHandler(this.OpenHome);
            powerButton.Click += new EventHandler(this.CloseApp);
        }



        #region button click methods
        // MAIN PANEL
        // navigate to the main view
        private void OpenMain(object sender, EventArgs e)
        {
            // add code here to hide current panel, show main panel

            ClearData();
        }

        // MAIN PANEL
        // navigate to the inventory view

        private void OpenInventory(object sender, EventArgs e) {
            tabView.SelectTab("inventPage");
            updateTabButtons();

            ClearData();
            //LoadProducts();
            //DisplayProducts();
        }

        // MAIN PANEL
        // navigate to the sales view
        private void OpenSales(object sender, EventArgs e) {
                tabView.SelectTab("salesPage");
                updateTabButtons();

                ClearData();
                //LoadSales();
                //DisplaySales();
            }

        // MAIN PANEL
        // navigate to the create sales report view
        private void OpenReports(object sender, EventArgs e) {
            tabView.SelectTab("reportsPage");
            updateTabButtons();

            ClearData();
        }

        private void OpenHome(object sender, EventArgs e)
        {
            tabView.SelectTab("homePage");
            updateTabButtons();
        }
        private void OpenCreateSalesReport(object sender, EventArgs e)
        {
            // add code here to hide current panel, show report panel

            ClearData();
        }

        // close the application
        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateTabButtons()
        {
            string tabName = tabView.SelectedTab.Name;
            if(tabName == salesPage.Name)
            {
                salesTab.BackColor = Color.CornflowerBlue;
                inventTab.BackColor = Color.SteelBlue;
                reportsTab.BackColor = Color.SteelBlue;
                homeTab.BackColor = Color.SteelBlue;
            }
            if (tabName == inventPage.Name)
            {
                salesTab.BackColor = Color.SteelBlue;
                inventTab.BackColor = Color.CornflowerBlue;
                reportsTab.BackColor = Color.SteelBlue;
                homeTab.BackColor = Color.SteelBlue;
            }
            if (tabName == reportsPage.Name)
            {
                salesTab.BackColor = Color.SteelBlue;
                inventTab.BackColor = Color.SteelBlue;
                reportsTab.BackColor = Color.CornflowerBlue;
                homeTab.BackColor = Color.SteelBlue;
            }
            if (tabName == homePage.Name)
            {
                salesTab.BackColor = Color.SteelBlue;
                inventTab.BackColor = Color.SteelBlue;
                reportsTab.BackColor = Color.SteelBlue;
                homeTab.BackColor = Color.CornflowerBlue;
            }
        }

        private void salesSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchABtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBBtn_Click(object sender, EventArgs e) {
        }
        // INVENTORY PANEL
        // go to AddEditProductView to add a product
        private void AddProduct(object sender, EventArgs e)
        {
            int productId = 0;
            new AddEditProductView(productId).ShowDialog();
        }

        // INVENTORY PANEL
        // go to AddEditProductView to edit a product
        private void EditProduct(object sender, EventArgs e)
        {
            int productId = 1;  // get currently selected productId
            //  int productId = Convert.ToInt32(listView1.FocusedItem.Text);
            new AddEditProductView(productId).ShowDialog();
        }

        // SALES PANEL
        // go to AddEditProductView to add a product
        private void AddSale(object sender, EventArgs e)
        {
            int saleId = 0;
            new AddEditSaleView(saleId).ShowDialog();
        }

        // SALES PANEL
        // go to AddEditProductView to edit a product
        private void EditSale(object sender, EventArgs e)
        {
            int saleId = 1;  // get currently selected saleId
            new AddEditSaleView(saleId).ShowDialog();
        }

        // SALES REPORTS PANEL
        private void DisplaySalesReport(object sender, EventArgs e)
        {

        }

        private void searchCBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //productList.Clear();
            //saleList.Clear();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {

        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {

        }

        private void addExistingProduct_Click(object sender, EventArgs e)
        {

        }

        private void inventDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // SALES FORECAST PANEL
        private void DisplaySalesForecast(object sender, EventArgs e)
        {

        }
        #endregion



        #region inventory screen methods
        // display products to the UI
        private void DisplayProducts()
        {
            foreach (Product product in productList)
            {
                // do something
            }
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

            database.CloseConnection();
        }
        #endregion



        #region sales screen methods
        // display items in productList to the UI
        private void DisplaySales()
        {
            foreach (Sale sales in saleList)
            {
                // do something
            }
        }

        // load data from database into saleList
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

            database.CloseConnection();
        }
        #endregion



        #region reports screen methods
        private void LoadSalesReport(DateTime startDate, DateTime endDate)
        {
            string query = "";
            database.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {

            }

            database.CloseConnection();
        }

        private void ExportSalesReport(string format)
        {

            string query = "";
            database.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            switch (format)
            {
                case ("csv"):
                    StringBuilder csvContent = new StringBuilder();
                    String csvPath = "C:\\salesreport.csv";



                    File.AppendAllText(csvPath, csvContent.ToString());
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
