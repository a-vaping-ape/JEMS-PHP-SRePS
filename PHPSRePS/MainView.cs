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


        // Tab Buttons
        private void OpenMain(object sender, EventArgs e)
        {
            // add code here to hide current panel, show main panel

            ClearData();
        }
        private void OpenInventory(object sender, EventArgs e) {
            inventGetAllProducts("");
            tabView.SelectTab("inventPage");
            updateTabButtons();
            ClearData();
            
            //LoadProducts();
            //DisplayProducts();
        }
        private void OpenSales(object sender, EventArgs e) {
            getAllProducts("");
            tabView.SelectTab("salesPage");
            updateTabButtons();
                
            ClearData();
            //LoadSales();
            //DisplaySales();
                
        }
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
        
        //Updates the tab colours
        private void updateTabButtons()
        {
            string tabName = tabView.SelectedTab.Name;
            if (tabName == salesPage.Name)
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
        
        // INVENTORY PANEL
        // go to AddEditProductView to add a product
        private void AddProduct(object sender, EventArgs e)
        {
            int productId = 0;
            new AddEditProductView(productId).ShowDialog();
        }
        private void EditProduct(object sender, EventArgs e)
        {
            int productId = 1;  // get currently selected productId
            //  int productId = Convert.ToInt32(listView1.FocusedItem.Text);
            new AddEditProductView(productId).ShowDialog();
        }
        
        //Sales Panel
        private void AddSale(object sender, EventArgs e)
        {
            int saleId = 0;
            new AddEditSaleView(saleId).ShowDialog();
        }
        private void EditSale(object sender, EventArgs e)
        {
            int saleId = 1;  // get currently selected saleId
            new AddEditSaleView(saleId).ShowDialog();
        }

        // SALES REPORTS PANEL
        private void DisplaySalesReport(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            salesTranList.DataSource = null;
            salesTranList.Rows.Clear();
            salesTranList.Refresh();
        }

        //creates a new items sales record on the DB
        private void payBtn_Click(object sender, EventArgs e)
        {
            database.CreateSaleItems(productList);
            salesTranList.DataSource = null;
            salesTranList.Rows.Clear();
            salesTranList.Refresh();
            MessageBox.Show("Your Transation Has Been Saved");

            getAllProducts(salesSearchBox.Text.ToString());
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

        private void inventGetAllProducts(string input)
        {
            BindingSource source = database.getProducts(input);

            if (source != null)
            {
                inventDataList.DataSource = source;
                inventDataList.ForeColor = Color.Black;
            }
        }

        private void inventGetAllProducts()
        {
            inventGetAllProducts(inventSearchBar.Text.ToString());
        }

        private void inventSearchBar_Click(object sender, EventArgs e)
        {
            inventSearchBar.Text = "";
        }

        private void inventSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                inventGetAllProducts();
            }
        }

        private void inventSearchBtn_Click(object sender, EventArgs e)
        {
            inventGetAllProducts();
        }

        #endregion

       

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

        private void salesDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salesSearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            salesSearchBox.Text = "";
        }

        private void salesSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                getAllProducts();
            }
        }

        private void getAllProducts(string input)
        {
            BindingSource source = database.getProducts(input);

            if (source != null)
            {

                salesDataList.DataSource = source;
                salesDataList.ForeColor = Color.Black;
            }
        }

        private void getAllProducts()
        {
            getAllProducts(salesSearchBox.Text.ToString());
        }

        //search
        private void salesSearchButton_Click(object sender, EventArgs e)
        {
            getAllProducts();

        }

     

       


       #region Button event handlers
        //On screen keyboard events
        private void searchABtn_Click(object sender, EventArgs e)
        {
            getAllProducts("A");
        }

        private void searchBBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("B");
        }

        private void searchCBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("C");
        }


        private void searchDBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("D");
        }

        private void searchEBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("E");
        }

        private void searchFBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("F");
        }

        private void searchGBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("G");
        }

        private void searchHBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("H");
        }

        private void searchIBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("I");
        }

        private void searchJBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("J");
        }

        private void searchKBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("K");
        }

        private void searchLBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("L");
        }

        private void searchMBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("M");
        }

        private void searchNBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("N");
        }

        private void searchOBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("O");
        }

        private void searchPBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("P");
        }

        private void searchQBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("Q");
        }

        private void searchRBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("R");
        }

        private void searchSBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("S");
        }

        private void searchTBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("T");
        }

        private void searchUBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("U");
        }

        private void searchVBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("V");
        }

        private void searchWBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("W");
        }

        private void searchXBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("X");
        }

        private void searchYBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("Y");
        }

        private void searchZBtn_Click(object sender, EventArgs e)
        {
            getAllProducts("Z");
        }


#endregion

        //add entry on sales page
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void salesDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         

        

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

        private void salesTab_Click(object sender, EventArgs e)
        {

        }

        private void salesAddBtn_Click(object sender, EventArgs e)
        {
            Product addedProduct = new Product();
            if (salesDataList.SelectedCells.Count > 0)
            {
                int rowCount = 0;
                Int32.TryParse(salesDataList.SelectedCells[0].RowIndex.ToString(), out rowCount);
                int i = salesTranList.Columns.Count;

                //creates the appropriate columns in the reciept tables
                if (salesTranList.Columns.Count < 1)
                {
                    foreach (DataGridViewColumn c in salesDataList.Columns)
                    {
                        salesTranList.Columns.Add(c.Clone() as DataGridViewColumn);  
                    }

                    salesTranList.ForeColor = Color.Black;
                }

                //create a product to be added to a sales 
                addedProduct.ID = (int)salesDataList.Rows[rowCount].Cells[0].Value;
                addedProduct.Name = (string)salesDataList.Rows[rowCount].Cells[1].Value;
                addedProduct.Category = (string)salesDataList.Rows[rowCount].Cells[2].Value;
                addedProduct.Price = (float)salesDataList.Rows[rowCount].Cells[3].Value;
                addedProduct.Stock = (int)salesDataList.Rows[rowCount].Cells[4].Value;
                addedProduct.IsDiscontinued = (bool)salesDataList.Rows[rowCount].Cells[5].Value;

                productList.Add(addedProduct);
                salesTranList.Rows.Add(addedProduct.GetDataGridRow(salesTranList));

                //update total cost field
                float total = 0;
                foreach (Product product in productList)
                    total += product.Price;

                if (total.ToString().Contains('.'))
                    salesTotalNum.Text = "$" + total.ToString();
                else
                    salesTotalNum.Text = "$" + total.ToString() + ".00";


            }
        }
    }
}
