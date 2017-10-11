using System;
using System.Windows.Forms;

namespace PHPSRePS
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidebar = new System.Windows.Forms.Panel();
            this.forecastTab = new System.Windows.Forms.Button();
            this.homeTab = new System.Windows.Forms.Button();
            this.reportsTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventTab = new System.Windows.Forms.Button();
            this.salesTab = new System.Windows.Forms.Button();
            this.tabView = new System.Windows.Forms.TabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.powerButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.salesPage = new System.Windows.Forms.TabPage();
            this.salesTranList = new System.Windows.Forms.DataGridView();
            this.salesAddBtn = new System.Windows.Forms.Button();
            this.salesPayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.salesTotalNum = new System.Windows.Forms.Label();
            this.salesTotal = new System.Windows.Forms.Label();
            this.salesLine = new System.Windows.Forms.Label();
            this.salesTransList = new System.Windows.Forms.ListView();
            this.salesTransLabel = new System.Windows.Forms.Label();
            this.searchZBtn = new System.Windows.Forms.Button();
            this.searchYBtn = new System.Windows.Forms.Button();
            this.searchXBtn = new System.Windows.Forms.Button();
            this.searchWBtn = new System.Windows.Forms.Button();
            this.searchVBtn = new System.Windows.Forms.Button();
            this.searchUBtn = new System.Windows.Forms.Button();
            this.searchTBtn = new System.Windows.Forms.Button();
            this.searchSBtn = new System.Windows.Forms.Button();
            this.searchRBtn = new System.Windows.Forms.Button();
            this.searchQBtn = new System.Windows.Forms.Button();
            this.searchPBtn = new System.Windows.Forms.Button();
            this.searchOBtn = new System.Windows.Forms.Button();
            this.searchNBtn = new System.Windows.Forms.Button();
            this.searchMBtn = new System.Windows.Forms.Button();
            this.searchLBtn = new System.Windows.Forms.Button();
            this.searchKBtn = new System.Windows.Forms.Button();
            this.searchJBtn = new System.Windows.Forms.Button();
            this.searchIBtn = new System.Windows.Forms.Button();
            this.searchHBtn = new System.Windows.Forms.Button();
            this.searchGBtn = new System.Windows.Forms.Button();
            this.searchFBtn = new System.Windows.Forms.Button();
            this.searchEBtn = new System.Windows.Forms.Button();
            this.searchDBtn = new System.Windows.Forms.Button();
            this.searchCBtn = new System.Windows.Forms.Button();
            this.searchBBtn = new System.Windows.Forms.Button();
            this.searchABtn = new System.Windows.Forms.Button();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.salesDataList = new System.Windows.Forms.DataGridView();
            this.salesSearchBox = new System.Windows.Forms.TextBox();
            this.salesSearchButton = new System.Windows.Forms.Button();
            this.inventPage = new System.Windows.Forms.TabPage();
            this.inventAddForm = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inventPriceLabel = new System.Windows.Forms.Label();
            this.inventPriceTxtbox = new System.Windows.Forms.TextBox();
            this.inventQtyLabel = new System.Windows.Forms.Label();
            this.inventQtyTxtbox = new System.Windows.Forms.TextBox();
            this.inventCateLabel = new System.Windows.Forms.Label();
            this.inventNameLabel = new System.Windows.Forms.Label();
            this.inventFormLabel = new System.Windows.Forms.Label();
            this.inventNameTxtbox = new System.Windows.Forms.TextBox();
            this.inventCancelBtn = new System.Windows.Forms.Button();
            this.inventEditBtn = new System.Windows.Forms.Button();
            this.inventDescriptList = new System.Windows.Forms.DataGridView();
            this.descriptText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventAddNew = new System.Windows.Forms.Button();
            this.InventDescription = new System.Windows.Forms.Label();
            this.inventDataList = new System.Windows.Forms.DataGridView();
            this.inventSearchBar = new System.Windows.Forms.TextBox();
            this.inventSearchBtn = new System.Windows.Forms.Button();
            this.reportsPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.reportEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.reportStartDate = new System.Windows.Forms.DateTimePicker();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reportCategories = new System.Windows.Forms.Button();
            this.reportsProducts = new System.Windows.Forms.Button();
            this.reportEmployee = new System.Windows.Forms.Button();
            this.userPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.userPassField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userUsrField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userLoginBtn = new System.Windows.Forms.Button();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profileHireDate = new System.Windows.Forms.Label();
            this.profileID = new System.Windows.Forms.Label();
            this.profileName = new System.Windows.Forms.Label();
            this.profileLogout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.forecastPage = new System.Windows.Forms.TabPage();
            this.forecastProductBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.forecastCategoriesBtn = new System.Windows.Forms.Button();
            this.forecastDropDown = new System.Windows.Forms.ComboBox();
            this.forecastDropdownTitle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.forecastEndDate = new System.Windows.Forms.Label();
            this.forecastEndDate2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.forecastStartDate = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sidebar.SuspendLayout();
            this.tabView.SuspendLayout();
            this.homePage.SuspendLayout();
            this.salesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTranList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataList)).BeginInit();
            this.inventPage.SuspendLayout();
            this.inventAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescriptList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDataList)).BeginInit();
            this.reportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.userPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.profilePage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.forecastPage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebar.Controls.Add(this.forecastTab);
            this.sidebar.Controls.Add(this.homeTab);
            this.sidebar.Controls.Add(this.reportsTab);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.inventTab);
            this.sidebar.Controls.Add(this.salesTab);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(115, 1080);
            this.sidebar.TabIndex = 0;
            // 
            // forecastTab
            // 
            this.forecastTab.BackColor = System.Drawing.Color.SteelBlue;
            this.forecastTab.BackgroundImage = global::PHPSRePS.Properties.Resources.Forecast;
            this.forecastTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forecastTab.FlatAppearance.BorderSize = 0;
            this.forecastTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forecastTab.ForeColor = System.Drawing.Color.Transparent;
            this.forecastTab.Location = new System.Drawing.Point(-3, 345);
            this.forecastTab.Margin = new System.Windows.Forms.Padding(0);
            this.forecastTab.Name = "forecastTab";
            this.forecastTab.Size = new System.Drawing.Size(115, 115);
            this.forecastTab.TabIndex = 4;
            this.forecastTab.UseVisualStyleBackColor = false;
            this.forecastTab.Click += new System.EventHandler(this.forecastTab_Click);
            // 
            // homeTab
            // 
            this.homeTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeTab.BackgroundImage")));
            this.homeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeTab.FlatAppearance.BorderSize = 0;
            this.homeTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeTab.ForeColor = System.Drawing.Color.Transparent;
            this.homeTab.Location = new System.Drawing.Point(0, 965);
            this.homeTab.Margin = new System.Windows.Forms.Padding(0);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(115, 115);
            this.homeTab.TabIndex = 3;
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // reportsTab
            // 
            this.reportsTab.BackColor = System.Drawing.Color.SteelBlue;
            this.reportsTab.BackgroundImage = global::PHPSRePS.Properties.Resources.Reports1;
            this.reportsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportsTab.FlatAppearance.BorderSize = 0;
            this.reportsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsTab.ForeColor = System.Drawing.Color.Transparent;
            this.reportsTab.Location = new System.Drawing.Point(0, 230);
            this.reportsTab.Margin = new System.Windows.Forms.Padding(0);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Size = new System.Drawing.Size(115, 115);
            this.reportsTab.TabIndex = 2;
            this.reportsTab.UseVisualStyleBackColor = false;
            this.reportsTab.Click += new System.EventHandler(this.reportsTab_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(115, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1805, 1080);
            this.panel1.TabIndex = 1;
            // 
            // inventTab
            // 
            this.inventTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventTab.BackgroundImage")));
            this.inventTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventTab.FlatAppearance.BorderSize = 0;
            this.inventTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventTab.ForeColor = System.Drawing.Color.Transparent;
            this.inventTab.Location = new System.Drawing.Point(0, 115);
            this.inventTab.Margin = new System.Windows.Forms.Padding(0);
            this.inventTab.Name = "inventTab";
            this.inventTab.Size = new System.Drawing.Size(115, 115);
            this.inventTab.TabIndex = 1;
            this.inventTab.UseVisualStyleBackColor = true;
            // 
            // salesTab
            // 
            this.salesTab.BackColor = System.Drawing.Color.SteelBlue;
            this.salesTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesTab.BackgroundImage")));
            this.salesTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesTab.FlatAppearance.BorderSize = 0;
            this.salesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesTab.ForeColor = System.Drawing.Color.Transparent;
            this.salesTab.Location = new System.Drawing.Point(0, 0);
            this.salesTab.Margin = new System.Windows.Forms.Padding(0);
            this.salesTab.Name = "salesTab";
            this.salesTab.Size = new System.Drawing.Size(115, 115);
            this.salesTab.TabIndex = 0;
            this.salesTab.UseVisualStyleBackColor = false;
            this.salesTab.Click += new System.EventHandler(this.salesTab_Click);
            // 
            // tabView
            // 
            this.tabView.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabView.Controls.Add(this.homePage);
            this.tabView.Controls.Add(this.salesPage);
            this.tabView.Controls.Add(this.inventPage);
            this.tabView.Controls.Add(this.reportsPage);
            this.tabView.Controls.Add(this.userPage);
            this.tabView.Controls.Add(this.profilePage);
            this.tabView.Controls.Add(this.forecastPage);
            this.tabView.ItemSize = new System.Drawing.Size(0, 1);
            this.tabView.Location = new System.Drawing.Point(115, 1);
            this.tabView.Margin = new System.Windows.Forms.Padding(0);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(1805, 1079);
            this.tabView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabView.TabIndex = 1;
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.powerButton);
            this.homePage.Controls.Add(this.userButton);
            this.homePage.Location = new System.Drawing.Point(4, 5);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(1797, 1070);
            this.homePage.TabIndex = 3;
            this.homePage.Text = "Home";
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.Transparent;
            this.powerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("powerButton.BackgroundImage")));
            this.powerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.powerButton.FlatAppearance.BorderSize = 0;
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.ForeColor = System.Drawing.Color.Black;
            this.powerButton.Location = new System.Drawing.Point(1752, 0);
            this.powerButton.Margin = new System.Windows.Forms.Padding(0);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(40, 40);
            this.powerButton.TabIndex = 5;
            this.powerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.powerButton.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.Transparent;
            this.userButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.Color.Black;
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.Location = new System.Drawing.Point(1677, 950);
            this.userButton.Margin = new System.Windows.Forms.Padding(0);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(115, 115);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "Username";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // salesPage
            // 
            this.salesPage.Controls.Add(this.salesTranList);
            this.salesPage.Controls.Add(this.salesAddBtn);
            this.salesPage.Controls.Add(this.salesPayButton);
            this.salesPage.Controls.Add(this.cancelButton);
            this.salesPage.Controls.Add(this.salesTotalNum);
            this.salesPage.Controls.Add(this.salesTotal);
            this.salesPage.Controls.Add(this.salesLine);
            this.salesPage.Controls.Add(this.salesTransList);
            this.salesPage.Controls.Add(this.salesTransLabel);
            this.salesPage.Controls.Add(this.searchZBtn);
            this.salesPage.Controls.Add(this.searchYBtn);
            this.salesPage.Controls.Add(this.searchXBtn);
            this.salesPage.Controls.Add(this.searchWBtn);
            this.salesPage.Controls.Add(this.searchVBtn);
            this.salesPage.Controls.Add(this.searchUBtn);
            this.salesPage.Controls.Add(this.searchTBtn);
            this.salesPage.Controls.Add(this.searchSBtn);
            this.salesPage.Controls.Add(this.searchRBtn);
            this.salesPage.Controls.Add(this.searchQBtn);
            this.salesPage.Controls.Add(this.searchPBtn);
            this.salesPage.Controls.Add(this.searchOBtn);
            this.salesPage.Controls.Add(this.searchNBtn);
            this.salesPage.Controls.Add(this.searchMBtn);
            this.salesPage.Controls.Add(this.searchLBtn);
            this.salesPage.Controls.Add(this.searchKBtn);
            this.salesPage.Controls.Add(this.searchJBtn);
            this.salesPage.Controls.Add(this.searchIBtn);
            this.salesPage.Controls.Add(this.searchHBtn);
            this.salesPage.Controls.Add(this.searchGBtn);
            this.salesPage.Controls.Add(this.searchFBtn);
            this.salesPage.Controls.Add(this.searchEBtn);
            this.salesPage.Controls.Add(this.searchDBtn);
            this.salesPage.Controls.Add(this.searchCBtn);
            this.salesPage.Controls.Add(this.searchBBtn);
            this.salesPage.Controls.Add(this.searchABtn);
            this.salesPage.Controls.Add(this.horizontalLine);
            this.salesPage.Controls.Add(this.salesDataList);
            this.salesPage.Controls.Add(this.salesSearchBox);
            this.salesPage.Controls.Add(this.salesSearchButton);
            this.salesPage.Location = new System.Drawing.Point(4, 5);
            this.salesPage.Margin = new System.Windows.Forms.Padding(0);
            this.salesPage.Name = "salesPage";
            this.salesPage.Size = new System.Drawing.Size(1797, 1070);
            this.salesPage.TabIndex = 0;
            this.salesPage.Text = "tabPage1";
            this.salesPage.UseVisualStyleBackColor = true;
            // 
            // salesTranList
            // 
            this.salesTranList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesTranList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesTranList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesTranList.Location = new System.Drawing.Point(1149, 88);
            this.salesTranList.Name = "salesTranList";
            this.salesTranList.ReadOnly = true;
            this.salesTranList.Size = new System.Drawing.Size(566, 649);
            this.salesTranList.TabIndex = 39;
            // 
            // salesAddBtn
            // 
            this.salesAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salesAddBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.salesAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesAddBtn.FlatAppearance.BorderSize = 0;
            this.salesAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesAddBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesAddBtn.ForeColor = System.Drawing.Color.Transparent;
            this.salesAddBtn.Location = new System.Drawing.Point(963, 765);
            this.salesAddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.salesAddBtn.Name = "salesAddBtn";
            this.salesAddBtn.Size = new System.Drawing.Size(112, 70);
            this.salesAddBtn.TabIndex = 38;
            this.salesAddBtn.Text = "Add item to Transaction";
            this.salesAddBtn.UseCompatibleTextRendering = true;
            this.salesAddBtn.UseVisualStyleBackColor = false;
            this.salesAddBtn.Click += new System.EventHandler(this.salesAddBtn_Click);
            // 
            // salesPayButton
            // 
            this.salesPayButton.BackColor = System.Drawing.Color.LimeGreen;
            this.salesPayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesPayButton.FlatAppearance.BorderSize = 0;
            this.salesPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesPayButton.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPayButton.ForeColor = System.Drawing.Color.Black;
            this.salesPayButton.Location = new System.Drawing.Point(1629, 979);
            this.salesPayButton.Margin = new System.Windows.Forms.Padding(0);
            this.salesPayButton.Name = "salesPayButton";
            this.salesPayButton.Size = new System.Drawing.Size(133, 55);
            this.salesPayButton.TabIndex = 37;
            this.salesPayButton.Text = "Pay";
            this.salesPayButton.UseCompatibleTextRendering = true;
            this.salesPayButton.UseVisualStyleBackColor = false;
            this.salesPayButton.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(1158, 981);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 55);
            this.cancelButton.TabIndex = 36;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseCompatibleTextRendering = true;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // salesTotalNum
            // 
            this.salesTotalNum.AutoSize = true;
            this.salesTotalNum.BackColor = System.Drawing.Color.Transparent;
            this.salesTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotalNum.ForeColor = System.Drawing.Color.Black;
            this.salesTotalNum.Location = new System.Drawing.Point(1628, 774);
            this.salesTotalNum.Name = "salesTotalNum";
            this.salesTotalNum.Size = new System.Drawing.Size(134, 37);
            this.salesTotalNum.TabIndex = 35;
            this.salesTotalNum.Text = "$000.00";
            // 
            // salesTotal
            // 
            this.salesTotal.AutoSize = true;
            this.salesTotal.BackColor = System.Drawing.Color.Transparent;
            this.salesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotal.ForeColor = System.Drawing.Color.Black;
            this.salesTotal.Location = new System.Drawing.Point(1151, 774);
            this.salesTotal.Name = "salesTotal";
            this.salesTotal.Size = new System.Drawing.Size(276, 37);
            this.salesTotal.TabIndex = 34;
            this.salesTotal.Text = "Transaction Total:";
            // 
            // salesLine
            // 
            this.salesLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesLine.Location = new System.Drawing.Point(1113, 21);
            this.salesLine.Name = "salesLine";
            this.salesLine.Size = new System.Drawing.Size(2, 1032);
            this.salesLine.TabIndex = 33;
            // 
            // salesTransList
            // 
            this.salesTransList.Location = new System.Drawing.Point(1149, 89);
            this.salesTransList.Name = "salesTransList";
            this.salesTransList.Size = new System.Drawing.Size(613, 649);
            this.salesTransList.TabIndex = 32;
            this.salesTransList.UseCompatibleStateImageBehavior = false;
            // 
            // salesTransLabel
            // 
            this.salesTransLabel.AutoSize = true;
            this.salesTransLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesTransLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTransLabel.ForeColor = System.Drawing.Color.Black;
            this.salesTransLabel.Location = new System.Drawing.Point(1151, 21);
            this.salesTransLabel.Name = "salesTransLabel";
            this.salesTransLabel.Size = new System.Drawing.Size(298, 42);
            this.salesTransLabel.TabIndex = 31;
            this.salesTransLabel.Text = "Transaction List";
            // 
            // searchZBtn
            // 
            this.searchZBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchZBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchZBtn.FlatAppearance.BorderSize = 0;
            this.searchZBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchZBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchZBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchZBtn.Location = new System.Drawing.Point(728, 957);
            this.searchZBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchZBtn.Name = "searchZBtn";
            this.searchZBtn.Size = new System.Drawing.Size(70, 70);
            this.searchZBtn.TabIndex = 29;
            this.searchZBtn.Text = "Z";
            this.searchZBtn.UseCompatibleTextRendering = true;
            this.searchZBtn.UseVisualStyleBackColor = false;
            this.searchZBtn.Click += new System.EventHandler(this.searchZBtn_Click);
            // 
            // searchYBtn
            // 
            this.searchYBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchYBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchYBtn.FlatAppearance.BorderSize = 0;
            this.searchYBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchYBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchYBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchYBtn.Location = new System.Drawing.Point(630, 957);
            this.searchYBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchYBtn.Name = "searchYBtn";
            this.searchYBtn.Size = new System.Drawing.Size(70, 70);
            this.searchYBtn.TabIndex = 28;
            this.searchYBtn.Text = "Y";
            this.searchYBtn.UseCompatibleTextRendering = true;
            this.searchYBtn.UseVisualStyleBackColor = false;
            this.searchYBtn.Click += new System.EventHandler(this.searchYBtn_Click);
            // 
            // searchXBtn
            // 
            this.searchXBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchXBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchXBtn.FlatAppearance.BorderSize = 0;
            this.searchXBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchXBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchXBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchXBtn.Location = new System.Drawing.Point(531, 957);
            this.searchXBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchXBtn.Name = "searchXBtn";
            this.searchXBtn.Size = new System.Drawing.Size(70, 70);
            this.searchXBtn.TabIndex = 27;
            this.searchXBtn.Text = "X";
            this.searchXBtn.UseCompatibleTextRendering = true;
            this.searchXBtn.UseVisualStyleBackColor = false;
            this.searchXBtn.Click += new System.EventHandler(this.searchXBtn_Click);
            // 
            // searchWBtn
            // 
            this.searchWBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchWBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchWBtn.FlatAppearance.BorderSize = 0;
            this.searchWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchWBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchWBtn.Location = new System.Drawing.Point(432, 957);
            this.searchWBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchWBtn.Name = "searchWBtn";
            this.searchWBtn.Size = new System.Drawing.Size(70, 70);
            this.searchWBtn.TabIndex = 26;
            this.searchWBtn.Text = "W";
            this.searchWBtn.UseCompatibleTextRendering = true;
            this.searchWBtn.UseVisualStyleBackColor = false;
            this.searchWBtn.Click += new System.EventHandler(this.searchWBtn_Click);
            // 
            // searchVBtn
            // 
            this.searchVBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchVBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchVBtn.FlatAppearance.BorderSize = 0;
            this.searchVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchVBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchVBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchVBtn.Location = new System.Drawing.Point(335, 957);
            this.searchVBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchVBtn.Name = "searchVBtn";
            this.searchVBtn.Size = new System.Drawing.Size(70, 70);
            this.searchVBtn.TabIndex = 25;
            this.searchVBtn.Text = "V";
            this.searchVBtn.UseCompatibleTextRendering = true;
            this.searchVBtn.UseVisualStyleBackColor = false;
            this.searchVBtn.Click += new System.EventHandler(this.searchVBtn_Click);
            // 
            // searchUBtn
            // 
            this.searchUBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchUBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchUBtn.FlatAppearance.BorderSize = 0;
            this.searchUBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchUBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchUBtn.Location = new System.Drawing.Point(237, 957);
            this.searchUBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchUBtn.Name = "searchUBtn";
            this.searchUBtn.Size = new System.Drawing.Size(70, 70);
            this.searchUBtn.TabIndex = 24;
            this.searchUBtn.Text = "U";
            this.searchUBtn.UseCompatibleTextRendering = true;
            this.searchUBtn.UseVisualStyleBackColor = false;
            this.searchUBtn.Click += new System.EventHandler(this.searchUBtn_Click);
            // 
            // searchTBtn
            // 
            this.searchTBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchTBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchTBtn.FlatAppearance.BorderSize = 0;
            this.searchTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchTBtn.Location = new System.Drawing.Point(138, 957);
            this.searchTBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchTBtn.Name = "searchTBtn";
            this.searchTBtn.Size = new System.Drawing.Size(70, 70);
            this.searchTBtn.TabIndex = 23;
            this.searchTBtn.Text = "T";
            this.searchTBtn.UseCompatibleTextRendering = true;
            this.searchTBtn.UseVisualStyleBackColor = false;
            this.searchTBtn.Click += new System.EventHandler(this.searchTBtn_Click);
            // 
            // searchSBtn
            // 
            this.searchSBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchSBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchSBtn.FlatAppearance.BorderSize = 0;
            this.searchSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchSBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchSBtn.Location = new System.Drawing.Point(37, 957);
            this.searchSBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchSBtn.Name = "searchSBtn";
            this.searchSBtn.Size = new System.Drawing.Size(70, 70);
            this.searchSBtn.TabIndex = 22;
            this.searchSBtn.Text = "S";
            this.searchSBtn.UseCompatibleTextRendering = true;
            this.searchSBtn.UseVisualStyleBackColor = false;
            this.searchSBtn.Click += new System.EventHandler(this.searchSBtn_Click);
            // 
            // searchRBtn
            // 
            this.searchRBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchRBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchRBtn.FlatAppearance.BorderSize = 0;
            this.searchRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchRBtn.Location = new System.Drawing.Point(827, 861);
            this.searchRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchRBtn.Name = "searchRBtn";
            this.searchRBtn.Size = new System.Drawing.Size(70, 70);
            this.searchRBtn.TabIndex = 21;
            this.searchRBtn.Text = "R";
            this.searchRBtn.UseCompatibleTextRendering = true;
            this.searchRBtn.UseVisualStyleBackColor = false;
            this.searchRBtn.Click += new System.EventHandler(this.searchRBtn_Click);
            // 
            // searchQBtn
            // 
            this.searchQBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchQBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchQBtn.FlatAppearance.BorderSize = 0;
            this.searchQBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchQBtn.Location = new System.Drawing.Point(728, 861);
            this.searchQBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchQBtn.Name = "searchQBtn";
            this.searchQBtn.Size = new System.Drawing.Size(70, 70);
            this.searchQBtn.TabIndex = 20;
            this.searchQBtn.Text = "Q";
            this.searchQBtn.UseCompatibleTextRendering = true;
            this.searchQBtn.UseVisualStyleBackColor = false;
            this.searchQBtn.Click += new System.EventHandler(this.searchQBtn_Click);
            // 
            // searchPBtn
            // 
            this.searchPBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchPBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchPBtn.FlatAppearance.BorderSize = 0;
            this.searchPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchPBtn.Location = new System.Drawing.Point(630, 861);
            this.searchPBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchPBtn.Name = "searchPBtn";
            this.searchPBtn.Size = new System.Drawing.Size(70, 70);
            this.searchPBtn.TabIndex = 19;
            this.searchPBtn.Text = "P";
            this.searchPBtn.UseCompatibleTextRendering = true;
            this.searchPBtn.UseVisualStyleBackColor = false;
            this.searchPBtn.Click += new System.EventHandler(this.searchPBtn_Click);
            // 
            // searchOBtn
            // 
            this.searchOBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchOBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchOBtn.FlatAppearance.BorderSize = 0;
            this.searchOBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchOBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchOBtn.Location = new System.Drawing.Point(531, 861);
            this.searchOBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchOBtn.Name = "searchOBtn";
            this.searchOBtn.Size = new System.Drawing.Size(70, 70);
            this.searchOBtn.TabIndex = 18;
            this.searchOBtn.Text = "O";
            this.searchOBtn.UseCompatibleTextRendering = true;
            this.searchOBtn.UseVisualStyleBackColor = false;
            this.searchOBtn.Click += new System.EventHandler(this.searchOBtn_Click);
            // 
            // searchNBtn
            // 
            this.searchNBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchNBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchNBtn.FlatAppearance.BorderSize = 0;
            this.searchNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchNBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchNBtn.Location = new System.Drawing.Point(432, 861);
            this.searchNBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchNBtn.Name = "searchNBtn";
            this.searchNBtn.Size = new System.Drawing.Size(70, 70);
            this.searchNBtn.TabIndex = 17;
            this.searchNBtn.Text = "N";
            this.searchNBtn.UseCompatibleTextRendering = true;
            this.searchNBtn.UseVisualStyleBackColor = false;
            this.searchNBtn.Click += new System.EventHandler(this.searchNBtn_Click);
            // 
            // searchMBtn
            // 
            this.searchMBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchMBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchMBtn.FlatAppearance.BorderSize = 0;
            this.searchMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchMBtn.Location = new System.Drawing.Point(335, 861);
            this.searchMBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchMBtn.Name = "searchMBtn";
            this.searchMBtn.Size = new System.Drawing.Size(70, 70);
            this.searchMBtn.TabIndex = 16;
            this.searchMBtn.Text = "M";
            this.searchMBtn.UseCompatibleTextRendering = true;
            this.searchMBtn.UseVisualStyleBackColor = false;
            this.searchMBtn.Click += new System.EventHandler(this.searchMBtn_Click);
            // 
            // searchLBtn
            // 
            this.searchLBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchLBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchLBtn.FlatAppearance.BorderSize = 0;
            this.searchLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchLBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchLBtn.Location = new System.Drawing.Point(237, 861);
            this.searchLBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchLBtn.Name = "searchLBtn";
            this.searchLBtn.Size = new System.Drawing.Size(70, 70);
            this.searchLBtn.TabIndex = 15;
            this.searchLBtn.Text = "L";
            this.searchLBtn.UseCompatibleTextRendering = true;
            this.searchLBtn.UseVisualStyleBackColor = false;
            this.searchLBtn.Click += new System.EventHandler(this.searchLBtn_Click);
            // 
            // searchKBtn
            // 
            this.searchKBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchKBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchKBtn.FlatAppearance.BorderSize = 0;
            this.searchKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchKBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchKBtn.Location = new System.Drawing.Point(138, 861);
            this.searchKBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchKBtn.Name = "searchKBtn";
            this.searchKBtn.Size = new System.Drawing.Size(70, 70);
            this.searchKBtn.TabIndex = 14;
            this.searchKBtn.Text = "K";
            this.searchKBtn.UseCompatibleTextRendering = true;
            this.searchKBtn.UseVisualStyleBackColor = false;
            this.searchKBtn.Click += new System.EventHandler(this.searchKBtn_Click);
            // 
            // searchJBtn
            // 
            this.searchJBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchJBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchJBtn.FlatAppearance.BorderSize = 0;
            this.searchJBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchJBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchJBtn.Location = new System.Drawing.Point(37, 861);
            this.searchJBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchJBtn.Name = "searchJBtn";
            this.searchJBtn.Size = new System.Drawing.Size(70, 70);
            this.searchJBtn.TabIndex = 13;
            this.searchJBtn.Text = "J";
            this.searchJBtn.UseCompatibleTextRendering = true;
            this.searchJBtn.UseVisualStyleBackColor = false;
            this.searchJBtn.Click += new System.EventHandler(this.searchJBtn_Click);
            // 
            // searchIBtn
            // 
            this.searchIBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchIBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchIBtn.FlatAppearance.BorderSize = 0;
            this.searchIBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchIBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchIBtn.Location = new System.Drawing.Point(827, 765);
            this.searchIBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchIBtn.Name = "searchIBtn";
            this.searchIBtn.Size = new System.Drawing.Size(70, 70);
            this.searchIBtn.TabIndex = 12;
            this.searchIBtn.Text = "I";
            this.searchIBtn.UseCompatibleTextRendering = true;
            this.searchIBtn.UseVisualStyleBackColor = false;
            this.searchIBtn.Click += new System.EventHandler(this.searchIBtn_Click);
            // 
            // searchHBtn
            // 
            this.searchHBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchHBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchHBtn.FlatAppearance.BorderSize = 0;
            this.searchHBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchHBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchHBtn.Location = new System.Drawing.Point(728, 765);
            this.searchHBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchHBtn.Name = "searchHBtn";
            this.searchHBtn.Size = new System.Drawing.Size(70, 70);
            this.searchHBtn.TabIndex = 11;
            this.searchHBtn.Text = "H";
            this.searchHBtn.UseCompatibleTextRendering = true;
            this.searchHBtn.UseVisualStyleBackColor = false;
            this.searchHBtn.Click += new System.EventHandler(this.searchHBtn_Click);
            // 
            // searchGBtn
            // 
            this.searchGBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchGBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchGBtn.FlatAppearance.BorderSize = 0;
            this.searchGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchGBtn.Location = new System.Drawing.Point(630, 765);
            this.searchGBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchGBtn.Name = "searchGBtn";
            this.searchGBtn.Size = new System.Drawing.Size(70, 70);
            this.searchGBtn.TabIndex = 10;
            this.searchGBtn.Text = "G";
            this.searchGBtn.UseCompatibleTextRendering = true;
            this.searchGBtn.UseVisualStyleBackColor = false;
            this.searchGBtn.Click += new System.EventHandler(this.searchGBtn_Click);
            // 
            // searchFBtn
            // 
            this.searchFBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchFBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchFBtn.FlatAppearance.BorderSize = 0;
            this.searchFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchFBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchFBtn.Location = new System.Drawing.Point(531, 765);
            this.searchFBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchFBtn.Name = "searchFBtn";
            this.searchFBtn.Size = new System.Drawing.Size(70, 70);
            this.searchFBtn.TabIndex = 9;
            this.searchFBtn.Text = "F";
            this.searchFBtn.UseCompatibleTextRendering = true;
            this.searchFBtn.UseVisualStyleBackColor = false;
            this.searchFBtn.Click += new System.EventHandler(this.searchFBtn_Click);
            // 
            // searchEBtn
            // 
            this.searchEBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchEBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchEBtn.FlatAppearance.BorderSize = 0;
            this.searchEBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchEBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchEBtn.Location = new System.Drawing.Point(432, 765);
            this.searchEBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchEBtn.Name = "searchEBtn";
            this.searchEBtn.Size = new System.Drawing.Size(70, 70);
            this.searchEBtn.TabIndex = 8;
            this.searchEBtn.Text = "E";
            this.searchEBtn.UseCompatibleTextRendering = true;
            this.searchEBtn.UseVisualStyleBackColor = false;
            this.searchEBtn.Click += new System.EventHandler(this.searchEBtn_Click);
            // 
            // searchDBtn
            // 
            this.searchDBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchDBtn.FlatAppearance.BorderSize = 0;
            this.searchDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchDBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchDBtn.Location = new System.Drawing.Point(335, 765);
            this.searchDBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchDBtn.Name = "searchDBtn";
            this.searchDBtn.Size = new System.Drawing.Size(70, 70);
            this.searchDBtn.TabIndex = 7;
            this.searchDBtn.Text = "D";
            this.searchDBtn.UseCompatibleTextRendering = true;
            this.searchDBtn.UseVisualStyleBackColor = false;
            this.searchDBtn.Click += new System.EventHandler(this.searchDBtn_Click);
            // 
            // searchCBtn
            // 
            this.searchCBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchCBtn.FlatAppearance.BorderSize = 0;
            this.searchCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchCBtn.Location = new System.Drawing.Point(237, 765);
            this.searchCBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchCBtn.Name = "searchCBtn";
            this.searchCBtn.Size = new System.Drawing.Size(70, 70);
            this.searchCBtn.TabIndex = 6;
            this.searchCBtn.Text = "C";
            this.searchCBtn.UseCompatibleTextRendering = true;
            this.searchCBtn.UseVisualStyleBackColor = false;
            this.searchCBtn.Click += new System.EventHandler(this.searchCBtn_Click);
            // 
            // searchBBtn
            // 
            this.searchBBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBBtn.FlatAppearance.BorderSize = 0;
            this.searchBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchBBtn.Location = new System.Drawing.Point(138, 765);
            this.searchBBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBBtn.Name = "searchBBtn";
            this.searchBBtn.Size = new System.Drawing.Size(70, 70);
            this.searchBBtn.TabIndex = 5;
            this.searchBBtn.Text = "B";
            this.searchBBtn.UseCompatibleTextRendering = true;
            this.searchBBtn.UseVisualStyleBackColor = false;
            this.searchBBtn.Click += new System.EventHandler(this.searchBBtn_Click);
            // 
            // searchABtn
            // 
            this.searchABtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchABtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchABtn.FlatAppearance.BorderSize = 0;
            this.searchABtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchABtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchABtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchABtn.Location = new System.Drawing.Point(37, 765);
            this.searchABtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchABtn.Name = "searchABtn";
            this.searchABtn.Size = new System.Drawing.Size(70, 70);
            this.searchABtn.TabIndex = 4;
            this.searchABtn.Text = "A";
            this.searchABtn.UseCompatibleTextRendering = true;
            this.searchABtn.UseVisualStyleBackColor = false;
            this.searchABtn.Click += new System.EventHandler(this.searchABtn_Click);
            // 
            // horizontalLine
            // 
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine.Location = new System.Drawing.Point(18, 72);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(1069, 2);
            this.horizontalLine.TabIndex = 2;
            // 
            // salesDataList
            // 
            this.salesDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesDataList.Location = new System.Drawing.Point(37, 89);
            this.salesDataList.Name = "salesDataList";
            this.salesDataList.ReadOnly = true;
            this.salesDataList.Size = new System.Drawing.Size(1038, 649);
            this.salesDataList.TabIndex = 1;
            this.salesDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataList_CellClick);
            this.salesDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataList_CellContentClick);
            // 
            // salesSearchBox
            // 
            this.salesSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesSearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.salesSearchBox.Location = new System.Drawing.Point(120, 27);
            this.salesSearchBox.Name = "salesSearchBox";
            this.salesSearchBox.Size = new System.Drawing.Size(840, 38);
            this.salesSearchBox.TabIndex = 0;
            this.salesSearchBox.Text = "Search product name here";
            this.salesSearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.salesSearchBox_MouseClick);
            this.salesSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salesSearchBox_KeyPress);
            // 
            // salesSearchButton
            // 
            this.salesSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesSearchButton.BackgroundImage")));
            this.salesSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesSearchButton.FlatAppearance.BorderSize = 0;
            this.salesSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesSearchButton.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesSearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.salesSearchButton.Location = new System.Drawing.Point(963, 24);
            this.salesSearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.salesSearchButton.Name = "salesSearchButton";
            this.salesSearchButton.Size = new System.Drawing.Size(38, 38);
            this.salesSearchButton.TabIndex = 30;
            this.salesSearchButton.UseCompatibleTextRendering = true;
            this.salesSearchButton.UseVisualStyleBackColor = false;
            // 
            // inventPage
            // 
            this.inventPage.Controls.Add(this.inventAddForm);
            this.inventPage.Controls.Add(this.inventCancelBtn);
            this.inventPage.Controls.Add(this.inventEditBtn);
            this.inventPage.Controls.Add(this.inventDescriptList);
            this.inventPage.Controls.Add(this.inventAddNew);
            this.inventPage.Controls.Add(this.InventDescription);
            this.inventPage.Controls.Add(this.inventDataList);
            this.inventPage.Controls.Add(this.inventSearchBar);
            this.inventPage.Controls.Add(this.inventSearchBtn);
            this.inventPage.Location = new System.Drawing.Point(4, 5);
            this.inventPage.Name = "inventPage";
            this.inventPage.Padding = new System.Windows.Forms.Padding(3);
            this.inventPage.Size = new System.Drawing.Size(1797, 1070);
            this.inventPage.TabIndex = 1;
            this.inventPage.Text = "Inventory";
            this.inventPage.UseVisualStyleBackColor = true;
            // 
            // inventAddForm
            // 
            this.inventAddForm.BackColor = System.Drawing.Color.HotPink;
            this.inventAddForm.Controls.Add(this.comboBox1);
            this.inventAddForm.Controls.Add(this.inventPriceLabel);
            this.inventAddForm.Controls.Add(this.inventPriceTxtbox);
            this.inventAddForm.Controls.Add(this.inventQtyLabel);
            this.inventAddForm.Controls.Add(this.inventQtyTxtbox);
            this.inventAddForm.Controls.Add(this.inventCateLabel);
            this.inventAddForm.Controls.Add(this.inventNameLabel);
            this.inventAddForm.Controls.Add(this.inventFormLabel);
            this.inventAddForm.Controls.Add(this.inventNameTxtbox);
            this.inventAddForm.Enabled = false;
            this.inventAddForm.Location = new System.Drawing.Point(33, 69);
            this.inventAddForm.Name = "inventAddForm";
            this.inventAddForm.Size = new System.Drawing.Size(1183, 966);
            this.inventAddForm.TabIndex = 40;
            this.inventAddForm.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AntiSeptics",
            "Supplements",
            "Laxatives",
            "Painkillers",
            "Entheogen",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(287, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(602, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // inventPriceLabel
            // 
            this.inventPriceLabel.AutoSize = true;
            this.inventPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.inventPriceLabel.Location = new System.Drawing.Point(60, 289);
            this.inventPriceLabel.Name = "inventPriceLabel";
            this.inventPriceLabel.Size = new System.Drawing.Size(257, 29);
            this.inventPriceLabel.TabIndex = 8;
            this.inventPriceLabel.Text = "Sales Price per Item:";
            // 
            // inventPriceTxtbox
            // 
            this.inventPriceTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventPriceTxtbox.Location = new System.Drawing.Point(323, 292);
            this.inventPriceTxtbox.Name = "inventPriceTxtbox";
            this.inventPriceTxtbox.Size = new System.Drawing.Size(609, 26);
            this.inventPriceTxtbox.TabIndex = 7;
            // 
            // inventQtyLabel
            // 
            this.inventQtyLabel.AutoSize = true;
            this.inventQtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventQtyLabel.ForeColor = System.Drawing.Color.Black;
            this.inventQtyLabel.Location = new System.Drawing.Point(60, 240);
            this.inventQtyLabel.Name = "inventQtyLabel";
            this.inventQtyLabel.Size = new System.Drawing.Size(215, 29);
            this.inventQtyLabel.TabIndex = 6;
            this.inventQtyLabel.Text = "Quantity In Stock:";
            // 
            // inventQtyTxtbox
            // 
            this.inventQtyTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventQtyTxtbox.Location = new System.Drawing.Point(281, 243);
            this.inventQtyTxtbox.Name = "inventQtyTxtbox";
            this.inventQtyTxtbox.Size = new System.Drawing.Size(609, 26);
            this.inventQtyTxtbox.TabIndex = 5;
            // 
            // inventCateLabel
            // 
            this.inventCateLabel.AutoSize = true;
            this.inventCateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventCateLabel.ForeColor = System.Drawing.Color.Black;
            this.inventCateLabel.Location = new System.Drawing.Point(60, 194);
            this.inventCateLabel.Name = "inventCateLabel";
            this.inventCateLabel.Size = new System.Drawing.Size(222, 29);
            this.inventCateLabel.TabIndex = 4;
            this.inventCateLabel.Text = "Product Category:";
            // 
            // inventNameLabel
            // 
            this.inventNameLabel.AutoSize = true;
            this.inventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventNameLabel.ForeColor = System.Drawing.Color.Black;
            this.inventNameLabel.Location = new System.Drawing.Point(60, 151);
            this.inventNameLabel.Name = "inventNameLabel";
            this.inventNameLabel.Size = new System.Drawing.Size(186, 29);
            this.inventNameLabel.TabIndex = 2;
            this.inventNameLabel.Text = "Product Name:";
            // 
            // inventFormLabel
            // 
            this.inventFormLabel.AutoSize = true;
            this.inventFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventFormLabel.ForeColor = System.Drawing.Color.Black;
            this.inventFormLabel.Location = new System.Drawing.Point(46, 40);
            this.inventFormLabel.Name = "inventFormLabel";
            this.inventFormLabel.Size = new System.Drawing.Size(302, 37);
            this.inventFormLabel.TabIndex = 1;
            this.inventFormLabel.Text = "New Product Form";
            // 
            // inventNameTxtbox
            // 
            this.inventNameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventNameTxtbox.Location = new System.Drawing.Point(281, 154);
            this.inventNameTxtbox.Name = "inventNameTxtbox";
            this.inventNameTxtbox.Size = new System.Drawing.Size(609, 26);
            this.inventNameTxtbox.TabIndex = 0;
            // 
            // inventCancelBtn
            // 
            this.inventCancelBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.inventCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventCancelBtn.Enabled = false;
            this.inventCancelBtn.FlatAppearance.BorderSize = 0;
            this.inventCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventCancelBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventCancelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.inventCancelBtn.Location = new System.Drawing.Point(1260, 959);
            this.inventCancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventCancelBtn.Name = "inventCancelBtn";
            this.inventCancelBtn.Size = new System.Drawing.Size(120, 93);
            this.inventCancelBtn.TabIndex = 39;
            this.inventCancelBtn.Text = "Cancel Changes";
            this.inventCancelBtn.UseCompatibleTextRendering = true;
            this.inventCancelBtn.UseVisualStyleBackColor = false;
            this.inventCancelBtn.Visible = false;
            this.inventCancelBtn.Click += new System.EventHandler(this.inventCancelBtn_Click);
            // 
            // inventEditBtn
            // 
            this.inventEditBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.inventEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventEditBtn.FlatAppearance.BorderSize = 0;
            this.inventEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventEditBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.inventEditBtn.Location = new System.Drawing.Point(1440, 959);
            this.inventEditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventEditBtn.Name = "inventEditBtn";
            this.inventEditBtn.Size = new System.Drawing.Size(120, 93);
            this.inventEditBtn.TabIndex = 38;
            this.inventEditBtn.Text = "Edit Item";
            this.inventEditBtn.UseCompatibleTextRendering = true;
            this.inventEditBtn.UseVisualStyleBackColor = false;
            this.inventEditBtn.Click += new System.EventHandler(this.inventEditBtn_Click);
            // 
            // inventDescriptList
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.inventDescriptList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.inventDescriptList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventDescriptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventDescriptList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptText});
            this.inventDescriptList.Location = new System.Drawing.Point(1260, 69);
            this.inventDescriptList.Margin = new System.Windows.Forms.Padding(2);
            this.inventDescriptList.Name = "inventDescriptList";
            this.inventDescriptList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventDescriptList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.inventDescriptList.RowHeadersWidth = 200;
            this.inventDescriptList.Size = new System.Drawing.Size(489, 864);
            this.inventDescriptList.TabIndex = 36;
            // 
            // descriptText
            // 
            this.descriptText.HeaderText = "";
            this.descriptText.Name = "descriptText";
            this.descriptText.ReadOnly = true;
            // 
            // inventAddNew
            // 
            this.inventAddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventAddNew.FlatAppearance.BorderSize = 0;
            this.inventAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventAddNew.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddNew.ForeColor = System.Drawing.Color.Transparent;
            this.inventAddNew.Location = new System.Drawing.Point(33, 959);
            this.inventAddNew.Margin = new System.Windows.Forms.Padding(0);
            this.inventAddNew.Name = "inventAddNew";
            this.inventAddNew.Size = new System.Drawing.Size(120, 93);
            this.inventAddNew.TabIndex = 34;
            this.inventAddNew.Text = "Add new product";
            this.inventAddNew.UseCompatibleTextRendering = true;
            this.inventAddNew.UseVisualStyleBackColor = false;
            this.inventAddNew.Click += new System.EventHandler(this.inventAddNew_Click);
            // 
            // InventDescription
            // 
            this.InventDescription.AutoSize = true;
            this.InventDescription.BackColor = System.Drawing.Color.Transparent;
            this.InventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventDescription.ForeColor = System.Drawing.Color.Black;
            this.InventDescription.Location = new System.Drawing.Point(1253, 13);
            this.InventDescription.Name = "InventDescription";
            this.InventDescription.Size = new System.Drawing.Size(216, 42);
            this.InventDescription.TabIndex = 32;
            this.InventDescription.Text = "Description";
            // 
            // inventDataList
            // 
            this.inventDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventDataList.Location = new System.Drawing.Point(33, 69);
            this.inventDataList.Name = "inventDataList";
            this.inventDataList.ReadOnly = true;
            this.inventDataList.Size = new System.Drawing.Size(1183, 864);
            this.inventDataList.TabIndex = 2;
            this.inventDataList.SelectionChanged += new System.EventHandler(this.inventDataList_SelectionChanged);
            // 
            // inventSearchBar
            // 
            this.inventSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventSearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inventSearchBar.Location = new System.Drawing.Point(223, 17);
            this.inventSearchBar.Name = "inventSearchBar";
            this.inventSearchBar.Size = new System.Drawing.Size(763, 38);
            this.inventSearchBar.TabIndex = 1;
            this.inventSearchBar.Text = "Search product name here";
            this.inventSearchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventSearchBar_Click);
            this.inventSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inventSearchBar_KeyPress);
            // 
            // inventSearchBtn
            // 
            this.inventSearchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventSearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventSearchBtn.BackgroundImage")));
            this.inventSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventSearchBtn.FlatAppearance.BorderSize = 0;
            this.inventSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventSearchBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.inventSearchBtn.Location = new System.Drawing.Point(989, 17);
            this.inventSearchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventSearchBtn.Name = "inventSearchBtn";
            this.inventSearchBtn.Size = new System.Drawing.Size(39, 38);
            this.inventSearchBtn.TabIndex = 37;
            this.inventSearchBtn.UseCompatibleTextRendering = true;
            this.inventSearchBtn.UseVisualStyleBackColor = false;
            this.inventSearchBtn.Click += new System.EventHandler(this.inventSearchBtn_Click);
            // 
            // reportsPage
            // 
            this.reportsPage.Controls.Add(this.label5);
            this.reportsPage.Controls.Add(this.reportEndDate);
            this.reportsPage.Controls.Add(this.label4);
            this.reportsPage.Controls.Add(this.reportStartDate);
            this.reportsPage.Controls.Add(this.reportChart);
            this.reportsPage.Controls.Add(this.reportsGrid);
            this.reportsPage.Controls.Add(this.panel4);
            this.reportsPage.Location = new System.Drawing.Point(4, 5);
            this.reportsPage.Name = "reportsPage";
            this.reportsPage.Size = new System.Drawing.Size(1797, 1070);
            this.reportsPage.TabIndex = 2;
            this.reportsPage.Text = "Reports";
            this.reportsPage.UseVisualStyleBackColor = true;
            this.reportsPage.Click += new System.EventHandler(this.reportsPage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(972, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "End Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // reportEndDate
            // 
            this.reportEndDate.Location = new System.Drawing.Point(926, 173);
            this.reportEndDate.Name = "reportEndDate";
            this.reportEndDate.Size = new System.Drawing.Size(191, 20);
            this.reportEndDate.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(559, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Start Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // reportStartDate
            // 
            this.reportStartDate.Location = new System.Drawing.Point(528, 173);
            this.reportStartDate.Name = "reportStartDate";
            this.reportStartDate.Size = new System.Drawing.Size(191, 20);
            this.reportStartDate.TabIndex = 20;
            // 
            // reportChart
            // 
            chartArea4.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.reportChart.Legends.Add(legend4);
            this.reportChart.Location = new System.Drawing.Point(306, 212);
            this.reportChart.Name = "reportChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.reportChart.Series.Add(series4);
            this.reportChart.Size = new System.Drawing.Size(1073, 400);
            this.reportChart.TabIndex = 19;
            this.reportChart.Text = "chart1";
            // 
            // reportsGrid
            // 
            this.reportsGrid.AllowUserToAddRows = false;
            this.reportsGrid.AllowUserToDeleteRows = false;
            this.reportsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Location = new System.Drawing.Point(306, 644);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.ReadOnly = true;
            this.reportsGrid.Size = new System.Drawing.Size(1073, 418);
            this.reportsGrid.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.reportCategories);
            this.panel4.Controls.Add(this.reportsProducts);
            this.panel4.Controls.Add(this.reportEmployee);
            this.panel4.Location = new System.Drawing.Point(306, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1073, 118);
            this.panel4.TabIndex = 17;
            // 
            // reportCategories
            // 
            this.reportCategories.BackColor = System.Drawing.Color.SteelBlue;
            this.reportCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportCategories.FlatAppearance.BorderSize = 0;
            this.reportCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportCategories.ForeColor = System.Drawing.Color.Transparent;
            this.reportCategories.Location = new System.Drawing.Point(778, 20);
            this.reportCategories.Margin = new System.Windows.Forms.Padding(0);
            this.reportCategories.Name = "reportCategories";
            this.reportCategories.Size = new System.Drawing.Size(208, 73);
            this.reportCategories.TabIndex = 6;
            this.reportCategories.Text = "Categories";
            this.reportCategories.UseVisualStyleBackColor = false;
            this.reportCategories.Click += new System.EventHandler(this.reportCategories_Click);
            // 
            // reportsProducts
            // 
            this.reportsProducts.BackColor = System.Drawing.Color.SteelBlue;
            this.reportsProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportsProducts.FlatAppearance.BorderSize = 0;
            this.reportsProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsProducts.ForeColor = System.Drawing.Color.Transparent;
            this.reportsProducts.Location = new System.Drawing.Point(69, 20);
            this.reportsProducts.Margin = new System.Windows.Forms.Padding(0);
            this.reportsProducts.Name = "reportsProducts";
            this.reportsProducts.Size = new System.Drawing.Size(208, 73);
            this.reportsProducts.TabIndex = 4;
            this.reportsProducts.Text = "Products";
            this.reportsProducts.UseVisualStyleBackColor = false;
            this.reportsProducts.Click += new System.EventHandler(this.reportsProducts_Click);
            // 
            // reportEmployee
            // 
            this.reportEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.reportEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportEmployee.FlatAppearance.BorderSize = 0;
            this.reportEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.reportEmployee.Location = new System.Drawing.Point(401, 20);
            this.reportEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.reportEmployee.Name = "reportEmployee";
            this.reportEmployee.Size = new System.Drawing.Size(208, 73);
            this.reportEmployee.TabIndex = 5;
            this.reportEmployee.Text = "Employees";
            this.reportEmployee.UseVisualStyleBackColor = false;
            this.reportEmployee.Click += new System.EventHandler(this.reportEmployee_Click);
            // 
            // userPage
            // 
            this.userPage.Controls.Add(this.label3);
            this.userPage.Controls.Add(this.userPassField);
            this.userPage.Controls.Add(this.label2);
            this.userPage.Controls.Add(this.label1);
            this.userPage.Controls.Add(this.userUsrField);
            this.userPage.Controls.Add(this.panel2);
            this.userPage.Location = new System.Drawing.Point(4, 5);
            this.userPage.Name = "userPage";
            this.userPage.Padding = new System.Windows.Forms.Padding(3);
            this.userPage.Size = new System.Drawing.Size(1797, 1070);
            this.userPage.TabIndex = 4;
            this.userPage.Text = "userPage";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(620, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // userPassField
            // 
            this.userPassField.Location = new System.Drawing.Point(626, 419);
            this.userPassField.Name = "userPassField";
            this.userPassField.Size = new System.Drawing.Size(327, 20);
            this.userPassField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(620, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(451, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Login Details";
            // 
            // userUsrField
            // 
            this.userUsrField.Location = new System.Drawing.Point(626, 320);
            this.userUsrField.Name = "userUsrField";
            this.userUsrField.Size = new System.Drawing.Size(327, 20);
            this.userUsrField.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.userLoginBtn);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(440, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 630);
            this.panel2.TabIndex = 6;
            // 
            // userLoginBtn
            // 
            this.userLoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userLoginBtn.Location = new System.Drawing.Point(211, 393);
            this.userLoginBtn.Name = "userLoginBtn";
            this.userLoginBtn.Size = new System.Drawing.Size(253, 44);
            this.userLoginBtn.TabIndex = 5;
            this.userLoginBtn.Text = "Login";
            this.userLoginBtn.UseVisualStyleBackColor = false;
            this.userLoginBtn.Click += new System.EventHandler(this.userLoginBtn_Click);
            // 
            // profilePage
            // 
            this.profilePage.Controls.Add(this.panel3);
            this.profilePage.Location = new System.Drawing.Point(4, 5);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(1797, 1070);
            this.profilePage.TabIndex = 5;
            this.profilePage.Text = "profileName";
            this.profilePage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.profileHireDate);
            this.panel3.Controls.Add(this.profileID);
            this.panel3.Controls.Add(this.profileName);
            this.panel3.Controls.Add(this.profileLogout);
            this.panel3.Controls.Add(this.label6);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(556, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 630);
            this.panel3.TabIndex = 12;
            // 
            // profileHireDate
            // 
            this.profileHireDate.AutoSize = true;
            this.profileHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileHireDate.ForeColor = System.Drawing.Color.Black;
            this.profileHireDate.Location = new System.Drawing.Point(205, 238);
            this.profileHireDate.Name = "profileHireDate";
            this.profileHireDate.Size = new System.Drawing.Size(86, 31);
            this.profileHireDate.TabIndex = 12;
            this.profileHireDate.Text = "label7";
            // 
            // profileID
            // 
            this.profileID.AutoSize = true;
            this.profileID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileID.Location = new System.Drawing.Point(205, 116);
            this.profileID.Name = "profileID";
            this.profileID.Size = new System.Drawing.Size(0, 31);
            this.profileID.TabIndex = 11;
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.ForeColor = System.Drawing.Color.Black;
            this.profileName.Location = new System.Drawing.Point(205, 178);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(86, 31);
            this.profileName.TabIndex = 9;
            this.profileName.Text = "label7";
            // 
            // profileLogout
            // 
            this.profileLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.profileLogout.Location = new System.Drawing.Point(211, 393);
            this.profileLogout.Name = "profileLogout";
            this.profileLogout.Size = new System.Drawing.Size(253, 44);
            this.profileLogout.TabIndex = 5;
            this.profileLogout.Text = "Log Out";
            this.profileLogout.UseVisualStyleBackColor = false;
            this.profileLogout.Click += new System.EventHandler(this.profileLogout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(200, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 63);
            this.label6.TabIndex = 8;
            this.label6.Text = "User Profile";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // forecastPage
            // 
            this.forecastPage.Controls.Add(this.chart1);
            this.forecastPage.Controls.Add(this.forecastDropDown);
            this.forecastPage.Controls.Add(this.panel5);
            this.forecastPage.Controls.Add(this.panel6);
            this.forecastPage.Location = new System.Drawing.Point(4, 5);
            this.forecastPage.Name = "forecastPage";
            this.forecastPage.Size = new System.Drawing.Size(1797, 1070);
            this.forecastPage.TabIndex = 6;
            this.forecastPage.Text = "forecastPage";
            this.forecastPage.UseVisualStyleBackColor = true;
            // 
            // forecastProductBtn
            // 
            this.forecastProductBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.forecastProductBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forecastProductBtn.FlatAppearance.BorderSize = 0;
            this.forecastProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forecastProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastProductBtn.ForeColor = System.Drawing.Color.Transparent;
            this.forecastProductBtn.Location = new System.Drawing.Point(124, 20);
            this.forecastProductBtn.Margin = new System.Windows.Forms.Padding(0);
            this.forecastProductBtn.Name = "forecastProductBtn";
            this.forecastProductBtn.Size = new System.Drawing.Size(208, 73);
            this.forecastProductBtn.TabIndex = 4;
            this.forecastProductBtn.Text = "Products";
            this.forecastProductBtn.UseVisualStyleBackColor = false;
            this.forecastProductBtn.Click += new System.EventHandler(this.forecastProductBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.forecastCategoriesBtn);
            this.panel5.Controls.Add(this.forecastProductBtn);
            this.panel5.Location = new System.Drawing.Point(392, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(897, 118);
            this.panel5.TabIndex = 18;
            // 
            // forecastCategoriesBtn
            // 
            this.forecastCategoriesBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.forecastCategoriesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forecastCategoriesBtn.FlatAppearance.BorderSize = 0;
            this.forecastCategoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forecastCategoriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastCategoriesBtn.ForeColor = System.Drawing.Color.Transparent;
            this.forecastCategoriesBtn.Location = new System.Drawing.Point(556, 20);
            this.forecastCategoriesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.forecastCategoriesBtn.Name = "forecastCategoriesBtn";
            this.forecastCategoriesBtn.Size = new System.Drawing.Size(208, 73);
            this.forecastCategoriesBtn.TabIndex = 6;
            this.forecastCategoriesBtn.Text = "Categories";
            this.forecastCategoriesBtn.UseVisualStyleBackColor = false;
            this.forecastCategoriesBtn.Click += new System.EventHandler(this.forecastCategoriesBtn_Click);
            // 
            // forecastDropDown
            // 
            this.forecastDropDown.FormattingEnabled = true;
            this.forecastDropDown.Location = new System.Drawing.Point(604, 203);
            this.forecastDropDown.Name = "forecastDropDown";
            this.forecastDropDown.Size = new System.Drawing.Size(434, 21);
            this.forecastDropDown.TabIndex = 19;
            // 
            // forecastDropdownTitle
            // 
            this.forecastDropdownTitle.AutoSize = true;
            this.forecastDropdownTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastDropdownTitle.ForeColor = System.Drawing.Color.Black;
            this.forecastDropdownTitle.Location = new System.Drawing.Point(206, 50);
            this.forecastDropdownTitle.Name = "forecastDropdownTitle";
            this.forecastDropdownTitle.Size = new System.Drawing.Size(216, 31);
            this.forecastDropdownTitle.TabIndex = 20;
            this.forecastDropdownTitle.Text = "Select A Product";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.forecastEndDate);
            this.panel6.Controls.Add(this.forecastDropdownTitle);
            this.panel6.Controls.Add(this.forecastEndDate2);
            this.panel6.Controls.Add(this.forecastStartDate);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(392, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(897, 253);
            this.panel6.TabIndex = 19;
            // 
            // forecastEndDate
            // 
            this.forecastEndDate.AutoSize = true;
            this.forecastEndDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forecastEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastEndDate.ForeColor = System.Drawing.Color.Black;
            this.forecastEndDate.Location = new System.Drawing.Point(450, 152);
            this.forecastEndDate.Name = "forecastEndDate";
            this.forecastEndDate.Size = new System.Drawing.Size(101, 25);
            this.forecastEndDate.TabIndex = 28;
            this.forecastEndDate.Text = "End Date";
            // 
            // forecastEndDate2
            // 
            this.forecastEndDate2.Location = new System.Drawing.Point(455, 180);
            this.forecastEndDate2.Name = "forecastEndDate2";
            this.forecastEndDate2.Size = new System.Drawing.Size(191, 20);
            this.forecastEndDate2.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(207, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Start Date";
            // 
            // forecastStartDate
            // 
            this.forecastStartDate.Location = new System.Drawing.Point(212, 180);
            this.forecastStartDate.Name = "forecastStartDate";
            this.forecastStartDate.Size = new System.Drawing.Size(191, 20);
            this.forecastStartDate.TabIndex = 25;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(392, 436);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(897, 400);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tabView);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidebar.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.salesPage.ResumeLayout(false);
            this.salesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTranList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataList)).EndInit();
            this.inventPage.ResumeLayout(false);
            this.inventPage.PerformLayout();
            this.inventAddForm.ResumeLayout(false);
            this.inventAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescriptList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDataList)).EndInit();
            this.reportsPage.ResumeLayout(false);
            this.reportsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.userPage.ResumeLayout(false);
            this.userPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.profilePage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.forecastPage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inventTab;
        private System.Windows.Forms.Button salesTab;
        private System.Windows.Forms.Button homeTab;
        private System.Windows.Forms.Button reportsTab;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage salesPage;
        private System.Windows.Forms.TabPage inventPage;
        private System.Windows.Forms.TabPage reportsPage;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.TextBox salesSearchBox;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.DataGridView salesDataList;
        private System.Windows.Forms.Button searchABtn;
        private System.Windows.Forms.Button searchBBtn;
        private System.Windows.Forms.Button searchZBtn;
        private System.Windows.Forms.Button searchYBtn;
        private System.Windows.Forms.Button searchXBtn;
        private System.Windows.Forms.Button searchWBtn;
        private System.Windows.Forms.Button searchVBtn;
        private System.Windows.Forms.Button searchUBtn;
        private System.Windows.Forms.Button searchTBtn;
        private System.Windows.Forms.Button searchSBtn;
        private System.Windows.Forms.Button searchRBtn;
        private System.Windows.Forms.Button searchQBtn;
        private System.Windows.Forms.Button searchPBtn;
        private System.Windows.Forms.Button searchOBtn;
        private System.Windows.Forms.Button searchNBtn;
        private System.Windows.Forms.Button searchMBtn;
        private System.Windows.Forms.Button searchLBtn;
        private System.Windows.Forms.Button searchKBtn;
        private System.Windows.Forms.Button searchJBtn;
        private System.Windows.Forms.Button searchIBtn;
        private System.Windows.Forms.Button searchHBtn;
        private System.Windows.Forms.Button searchGBtn;
        private System.Windows.Forms.Button searchFBtn;
        private System.Windows.Forms.Button searchEBtn;
        private System.Windows.Forms.Button searchDBtn;
        private System.Windows.Forms.Button searchCBtn;
        private System.Windows.Forms.Button salesSearchButton;
        private System.Windows.Forms.Label salesTransLabel;
        private System.Windows.Forms.Label salesLine;
        private System.Windows.Forms.Label salesTotal;
        private System.Windows.Forms.Label salesTotalNum;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button salesPayButton;
        private System.Windows.Forms.TextBox inventSearchBar;
        private System.Windows.Forms.DataGridView inventDataList;
        private System.Windows.Forms.Label InventDescription;
        private System.Windows.Forms.Button inventAddNew;
        private System.Windows.Forms.Button salesAddBtn;

        private System.Windows.Forms.DataGridView salesTranList;
        private System.Windows.Forms.ListView salesTransList;

        private System.Windows.Forms.DataGridView inventDescriptList;
        private Button inventSearchBtn;
        private Button inventEditBtn;
        private DataGridViewTextBoxColumn descriptText;
        private TabPage userPage;
        private Label label1;
        private TextBox userUsrField;
        private Label label2;
        private Label label3;
        private TextBox userPassField;
        private Button userLoginBtn;
        private Panel panel2;
        private TabPage profilePage;
        private Label label6;
        private Panel panel3;
        private Button profileLogout;
        private Label profileHireDate;
        private Label profileID;
        private Label profileName;
        private Button inventCancelBtn;
        private Panel inventAddForm;
        private Label inventFormLabel;
        private TextBox inventNameTxtbox;
        private Label inventNameLabel;
        private Label inventPriceLabel;
        private TextBox inventPriceTxtbox;
        private Label inventQtyLabel;
        private TextBox inventQtyTxtbox;
        private Label inventCateLabel;
        private ComboBox comboBox1;
        private Button reportsProducts;
        private Button reportCategories;
        private Button reportEmployee;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private DataGridView reportsGrid;
        private Label label4;
        private DateTimePicker reportStartDate;
        private Label label5;
        private DateTimePicker reportEndDate;
        private Button forecastTab;
        private TabPage forecastPage;
        private Label forecastDropdownTitle;
        private ComboBox forecastDropDown;
        private Panel panel5;
        private Button forecastCategoriesBtn;
        private Button forecastProductBtn;
        private Panel panel6;
        private Label forecastEndDate;
        private DateTimePicker forecastEndDate2;
        private DateTimePicker forecastStartDate;
        private Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

