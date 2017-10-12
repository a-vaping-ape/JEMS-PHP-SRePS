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
using System.Windows.Forms.DataVisualization.Charting;

namespace PHPSRePS {

    public struct RevenueFormat
    {
        public string Title;
        public float Cost;
    };

    public partial class MainView : Form {

  

        // TODO sprint2: implement authorisation + levels of security

        // database
        private Database database = new Database();
        private Employee currentEmployee = null;
        private ForecastReport forecast;
        private SalesReport report;

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
            #region inventory description lsit rows

            #endregion
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
            salesTotalNum.Text = "$0.00";
            productList.Clear();
        }

        //creates a new items sales record on the DB
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (productList.Count < 1)
            {
                MessageBox.Show("Please add an item to the transatiom");
            }
            else if ((currentEmployee != null))
            {
                database.CreateSaleItems(productList, currentEmployee.EmployeeID);
                salesTranList.DataSource = null;
                salesTranList.Rows.Clear();
                salesTranList.Refresh();
                MessageBox.Show("Your Transation Has Been Saved");
                salesTotalNum.Text = "$0.00";
                productList.Clear();
            }
            else
            {
                MessageBox.Show("Please Login To Process A Order");
            }

            getAllProducts(salesSearchBox.Text.ToString());
        }

       

        private void addExistingProduct_Click(object sender, EventArgs e)
        {

        }

        // SALES FORECAST PANEL
        private void DisplaySalesForecast(object sender, EventArgs e)
        {

        }


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

        #region Inventory Screen Functions
        private void inventGetAllProducts(string input)
        {
            BindingSource source = database.getProducts(input);

            if (source != null)
            {
                inventDataList.DataSource = source;
                inventDataList.ForeColor = Color.Black;
            }

            inventUpdateDropboxes();
        }

        private void inventGetAllProducts()
        {
            inventGetAllProducts(inventSearchBar.Text.ToString());
        }

        #region SearchBar Methods
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

        private void inventSearchBar_Click(object sender, MouseEventArgs e)
        {
            inventSearchBar.Text = "";
        }
        #endregion

        private void inventDataList_SelectionChanged(object sender, EventArgs e)
        {
            inventDescriptionUpdater();
        }

        private void inventEditBtn_Click(object sender, EventArgs e)
        {
            if (!inventDescPanel.Enabled)
            {
                inventDescPanel.Enabled = true;
                inventEditBtn.BackColor = Color.MediumSpringGreen;
                inventPage.BackColor = Color.Coral;
                inventEditBtn.Text = "SAVE CHANGES";
                InventDescription.Text = "EDITING MODE";
                inventCancelBtn.Enabled = true;
                inventCancelBtn.Visible = true;
                inventEditBtn.Location = new Point(1629, 959);
            }
            else
            {
                Product updatedProduct = new Product();
                updatedProduct.ID = (int)inventDescIDTxtbox.Value;
                updatedProduct.Name = inventDescNameTxtbox.Text;
                updatedProduct.Category = inventDescCateBox.Text;
                updatedProduct.Price = (float)inventDescPriceTextbox.Value;
                updatedProduct.Stock = (int)inventDescQTYTxtbox.Value;
                updatedProduct.IsDiscontinued = inventDescCheckbox.Checked;
                database.RunVoidQuery(updatedProduct.GetUPDATE());

                inventEditBtn.Enabled = false;
                inventCancelBtn.Enabled = false;
                sidebar.Enabled = false;
                inventAddNew.Enabled = false;
                inventSearchBtn.Enabled = false;
                inventSearchBar.Enabled = false;
                inventDescConfirmPanel.Enabled = true;
                inventDescConfirmPanel.Visible = true;
            }
        }

        private void inventCancelBtn_Click(object sender, EventArgs e)
        {
            inventDescriptionUpdater();
            inventReturnToReadOnly();
        }

        private void inventReturnToReadOnly()
        {
            inventDescPanel.Enabled = false;
            inventEditBtn.BackColor = Color.DarkOrange;
            inventEditBtn.Text = "Edit Values";
            inventEditBtn.Location = new Point(1440, 959);
            inventPage.BackColor = Color.White;
            InventDescription.Text = "Description";
            inventCancelBtn.Enabled = false;
            inventCancelBtn.Visible = false;
            inventAddContinPanel.Visible = false;
            inventAddContinPanel.Enabled = true;
            inventAddForm.Visible = false;
            inventAddForm.Enabled = false;
            inventDataList.Enabled = true;
            inventEditBtn.Enabled = true;
            inventDescConfirmPanel.Visible = false;
            inventDescConfirmPanel.Enabled = false;
            inventSearchBar.Enabled = true;
            inventSearchBtn.Enabled = true;
            sidebar.Enabled = true;
            inventGetAllProducts();
        }

        private void inventDescriptionUpdater()
        {
            int selectedRow = 0;
            try
            {
                Int32.TryParse(inventDataList.SelectedCells[0].RowIndex.ToString(), out selectedRow);
            }
            catch (Exception e)
            {

            }
            try
            {

                inventDescIDTxtbox.Value = (int)inventDataList.Rows[selectedRow].Cells[0].Value;
                inventDescNameTxtbox.Text = (string)inventDataList.Rows[selectedRow].Cells[1].Value;
                inventDescCateBox.Text = (string)inventDataList.Rows[selectedRow].Cells[2].Value;
                inventDescPriceTextbox.Text = inventDataList.Rows[selectedRow].Cells[3].Value.ToString();
                inventDescQTYTxtbox.Value = (int)inventDataList.Rows[selectedRow].Cells[4].Value;
                inventDescCheckbox.Checked = (bool)inventDataList.Rows[selectedRow].Cells[5].Value;

            }
            catch (Exception e)
            {

            }



        }

        private void inventUpdateDropboxes()
        {
            foreach (string str in database.GetCategoires())
            {
                if (!inventAddCateBox.Items.Contains(str))
                {
                    inventAddCateBox.Items.Add(str);
                }
                if (!inventDescCateBox.Items.Contains(str))
                {
                    inventDescCateBox.Items.Add(str);
                }
            }
        }

        private void inventAddNew_Click(object sender, EventArgs e)
        {
            //Disables all buttons in the background
            sidebar.Enabled = false;
            inventDataList.Enabled = false;
            inventDescPriceTextbox.Enabled = false;
            inventAddForm.Visible = true;
            inventAddForm.Enabled = true;
        }

        private void inventAddAddBtn_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Name = inventNameTxtbox.Text;
            newProduct.Category = inventAddCateBox.Text;
            newProduct.Stock = (int)inventQtyTxtbox.Value;
            newProduct.Price = (float)inventPriceTxtbox.Value;
            newProduct.IsDiscontinued = false;

            database.RunVoidQuery(newProduct.GetINSERT());
            inventAddAddBtn.Enabled = false;
           // inventAddCancelBtn.Enabled = false;
            inventAddContinPanel.Enabled = true;
            inventAddContinPanel.Visible = true;
        }

        private void inventAddContinBtn_Click(object sender, EventArgs e)
        {
            inventGetAllProducts();
            inventReturnToReadOnly();
            inventAddAddBtn.Enabled = true;
            //inventAddCancelBtn.Enabled = true;
        }
        private void inventAddCancelBtn_Click(object sender, EventArgs e)
        {
            inventResetTextboxes();
            inventReturnToReadOnly();
        }

        private void inventResetTextboxes()
        {
            inventNameTxtbox.Text = "";
            inventAddCateBox.Text = "";
            inventPriceTxtbox.Value = 0;
            inventQtyTxtbox.Value = 0;
        }

        private void inventDescConfirmBtn_Click(object sender, EventArgs e)
        {
            inventReturnToReadOnly();
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
            if (( currentEmployee == null) || (!currentEmployee.IsManager))
            {
                salesOldOrder.Visible = false;
            }
            else
            {
                salesOldOrder.Visible = true;
            }
        }

        private void salesAddBtn_Click(object sender, EventArgs e)
        {
            Product addedProduct = new Product();
            float total = 0;

            if (currentEmployee != null) {
                //a select coutn is greater then 0 fetch the first one
                if (salesDataList.SelectedCells.Count > 0)
                {
                    //the selected row
                    int rowCount = 0;
                    Int32.TryParse(salesDataList.SelectedCells[0].RowIndex.ToString(), out rowCount);

                    //checks is translist has been added to before
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
                    
                    if (salesDataList.Rows[rowCount].Cells[4].Value == null)
                    {
                       
                    }
                    else if ((int)salesDataList.Rows[rowCount].Cells[4].Value < 1)
                    {
                        MessageBox.Show("There is not stock left on this product. Got to the inventory to order more stocks");
                    }

                    else
                    {
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
                        total = 0;
                        foreach (Product product in productList)
                            total += product.Price;

                        if (total.ToString().Contains('.'))
                            salesTotalNum.Text = "$" + total.ToString();
                        else
                            salesTotalNum.Text = "$" + total.ToString() + ".00";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Login To Be Able To Checkout Items");
            }
        }

        

        private void userButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee == null)
            {
                tabView.SelectTab("userPage");
            }
            else
            {
                tabView.SelectTab("profilePage");

                profileName.Text = currentEmployee.FirstName + " " + currentEmployee.LastName;
                profileHireDate.Text = currentEmployee.HireDate;

            }
        }

        //attempts to loging 
        private void userLoginBtn_Click(object sender, EventArgs e)
        {
            string userName = userUsrField.Text;
            string password = userPassField.Text;

            currentEmployee = database.attemptUserLogin(userName, password);

            if (currentEmployee != null)
            {
                MessageBox.Show("Welcome "+userName);
                tabView.SelectTab("homePage");
                userUsrField.Text = "";
                userPassField.Text = "";
                updateTabButtons();

                if (currentEmployee.IsManager)
                {
                    reportsTab.Visible = true;
                    forecastTab.Visible = true;
                }
                else
                {
                    reportsTab.Visible = false;
                    forecastTab.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Login Failed Please Try Again");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //log out button
        private void profileLogout_Click(object sender, EventArgs e)
        {
            reportsTab.Visible = false;
            forecastTab.Visible = false;

            currentEmployee = null;
            tabView.SelectTab("homePage");

            profileName.Text = "";
            profileHireDate.Text = "";
            updateTabButtons();
            MessageBox.Show("You Have Been Signed Out");
        }

   

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

            private void GeneratePieChart(string groupBy)
        {
            reportChart.Series.Clear();
            reportChart.Titles.Clear();
            List<RevenueFormat> data = null;
            string Title = "";

            reportChart.Name = "PieChartArea";

            if (groupBy == "products")  {
                Title = "Products";
                
                data = report.GetRevenues("products");
            }
            else if (groupBy == "employee") 
            {
                Title = "Employees";
                
                data = report.GetRevenues("employee");
            }
            else if (groupBy == "category")
            {
                Title = "Categories";
               
                data = report.GetRevenues("category");
            }


            Series series = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Pie
            };

            reportChart.Titles.Add(new Title(
               Title + " Report",
               Docking.Top,
               new Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold),
               Color.Black)
            );


            int i = 0;
            foreach (RevenueFormat item in data)
            {
                series.Points.Add(item.Cost);
                var temp = series.Points[i];
                temp.AxisLabel = item.Cost.ToString();
                temp.LegendText = item.Title.ToString();
                i++;
            }
            
            reportChart.Series.Add(series);
        }

        private void PopulateReportTable(string input)
        {
            DateTime startDate = reportStartDate.Value.Date;
            DateTime endDate = reportEndDate.Value.Date;

            report = new SalesReport(startDate, endDate);

            report.LoadReport(startDate, endDate);

            reportsGrid.DataSource = report.GetSource(input);
            reportsGrid.ForeColor = Color.Black;
        }

        private void reportsProducts_Click(object sender, EventArgs e)
        {
            PopulateReportTable("products");
            GeneratePieChart("products");
           
        }

        private void reportsPage_Click(object sender, EventArgs e)
        {
            PopulateReportTable("products");
        }

        private void reportEmployee_Click(object sender, EventArgs e)
        {
            PopulateReportTable("employee");
            GeneratePieChart("employee");
        }

        private void reportCategories_Click(object sender, EventArgs e)
        {
            PopulateReportTable("category");
            GeneratePieChart("category");
        }

        private void reportsTab_Click(object sender, EventArgs e)
        {

        }

        private void GenerateLineChart()
        {
            forecastChart.Series.Clear();
            forecastChart.Titles.Clear();
            List<SalesForecast> data = null;
            
            data = forecast.SalesForecastReport;

            Series series = new Series
            {
                Name = "series",
                IsVisibleInLegend = false,
                Color = System.Drawing.Color.DarkBlue,
                ChartType = SeriesChartType.Spline
            };

            int i = 0;
            foreach (SalesForecast item in data)
            {
                series.Points.AddXY(item.date, item.quantity);
                i++;
            }


            Font titleFont = new Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            Font axisFont = new Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);

            forecastChart.Titles.Add(new Title(
                "Sales Forecast",
                Docking.Top,
                new Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold),
                Color.Black)
             );


            forecastChart.ChartAreas[0].AxisX.Title = "Time In Days";
            forecastChart.ChartAreas[0].AxisX.LabelStyle.Font = axisFont;
            forecastChart.ChartAreas[0].AxisX.TitleFont = titleFont;

            forecastChart.ChartAreas[0].AxisY.Title = "Quantity";
            forecastChart.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Rotated90;
            forecastChart.ChartAreas[0].AxisY.LabelStyle.Font = axisFont;
            forecastChart.ChartAreas[0].AxisY.TitleFont = titleFont;

            forecastChart.Series.Add(series);
            forecastChart.ChartAreas[0].AxisX.IsReversed = true;

            forecastChart.Series[0].XValueType = ChartValueType.DateTime;

        }

        private void forecastTab_Click(object sender, EventArgs e)
        {
            tabView.SelectTab("forecastPage");
            LoadForcast("products");

            
        }

        private void LoadForcast(string groupBy)
        {
            DateTime startDate = forecastStartDate.Value.Date;
            DateTime endDate = forecastEndDate2.Value.Date;

            forecast = new ForecastReport(startDate, endDate);

            string itemName = "";
            string group = "";

            //report.LoadReport(startDate, endDate);

            if (groupBy == "products")
            {
                if (forecastDropdownTitle.Text != "Please Choose A Product")
                    forecastDropDown.DataSource = database.GetProducts();
                else if (forecastDropDown.SelectedValue == null)
                    forecastDropDown.DataSource = database.GetProducts();

                forecastDropdownTitle.Text = "Please Choose A Product";
                group = "product";
            }
            else if (groupBy == "categories")
            {
                if (forecastDropdownTitle.Text != "Please Choose A Category")
                    forecastDropDown.DataSource = database.GetCategoires();
                else if (forecastDropDown.SelectedValue == null)
                    forecastDropDown.DataSource = database.GetCategoires();


                forecastDropdownTitle.Text = "Please Choose A Category";
                group = "categories";
            }

            itemName = forecastDropDown.SelectedValue.ToString();

            if ((group != "" ) && (itemName != ""))
                forecast.LoadReport(itemName, group);
                GenerateLineChart();

        }

        private void homePage_Click(object sender, EventArgs e)
        {

        }

        private void forecastProductBtn_Click(object sender, EventArgs e)
        {
            LoadForcast("products");
        }

        private void forecastCategoriesBtn_Click(object sender, EventArgs e)
        {
            LoadForcast("categories");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salesOldPay_Click(object sender, EventArgs e)
        {
            if (productList.Count < 1)
            {
                MessageBox.Show("Please add an item to the transatiom");
            }
            else if ( (currentEmployee != null) && productList.Count > 0)
            {
                DateTime date = salesTimePicker.Value;
                database.CreateSaleItems(productList, currentEmployee.EmployeeID, date);
                salesTranList.DataSource = null;
                salesTranList.Rows.Clear();
                salesTranList.Refresh();
                MessageBox.Show("Your Transation Has Been Saved");
                salesTotalNum.Text = "$0.00";
            }
            else
            {
                MessageBox.Show("Please Login To Process A Order");
            }

           // getAllProducts(salesSearchBox.Text.ToString());
            salesOldOrderPanel.Visible = false;
  
        }

        private void salesOldOrder_Click(object sender, EventArgs e)
        {
            salesOldOrderPanel.Visible = true;
        }

        private void salesCancel_Click(object sender, EventArgs e)
        {
            salesOldOrderPanel.Visible = false;
        }

        private void reportCSVBtn_Click(object sender, EventArgs e)
        {
            if (report != null)
                report.ExportToCSV();
            MessageBox.Show("Export Done");
        }

        private void forecastCSVBtn_Click(object sender, EventArgs e)
        {
            if (forecast != null)
                forecast.ExportToCSV();
            MessageBox.Show("Export Done");
        }

        private void forcastEmailSCV_Click(object sender, EventArgs e)
        {

        }
    }
}