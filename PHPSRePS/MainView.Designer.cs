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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidebar = new System.Windows.Forms.Panel();
            this.forecastTab = new System.Windows.Forms.Button();
            this.homeTab = new System.Windows.Forms.Button();
            this.reportsTab = new System.Windows.Forms.Button();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.inventTab = new System.Windows.Forms.Button();
            this.salesTab = new System.Windows.Forms.Button();
            this.tabView = new System.Windows.Forms.TabControl();
            this.userPage = new System.Windows.Forms.TabPage();
            this.loginPasswordTitle = new System.Windows.Forms.Label();
            this.userPassField = new System.Windows.Forms.TextBox();
            this.loginUserTitle = new System.Windows.Forms.Label();
            this.userUsrField = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userLoginBtn = new System.Windows.Forms.Button();
            this.loginTitle = new System.Windows.Forms.Label();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.profileHireDate = new System.Windows.Forms.Label();
            this.profileID = new System.Windows.Forms.Label();
            this.profileName = new System.Windows.Forms.Label();
            this.profileLogout = new System.Windows.Forms.Button();
            this.profileTitle = new System.Windows.Forms.Label();
            this.salesPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.searchAllBtn = new System.Windows.Forms.Button();
            this.salesQTYLabel = new System.Windows.Forms.Label();
            this.inventButtonLabel = new System.Windows.Forms.Label();
            this.salesOldOrderPanel = new System.Windows.Forms.Panel();
            this.salesOldPay = new System.Windows.Forms.Button();
            this.salesCancel = new System.Windows.Forms.Button();
            this.salesOldOrderTitle = new System.Windows.Forms.Label();
            this.salesTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salesOldOrder = new System.Windows.Forms.Button();
            this.salesTranList = new System.Windows.Forms.DataGridView();
            this.salesAddBtn = new System.Windows.Forms.Button();
            this.salesPayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.salesTotalNum = new System.Windows.Forms.Label();
            this.salesTotal = new System.Windows.Forms.Label();
            this.salesLine = new System.Windows.Forms.Label();
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
            this.inventAddCancelBtn = new System.Windows.Forms.Button();
            this.inventAddContinPanel = new System.Windows.Forms.Panel();
            this.inventAddContinBtn = new System.Windows.Forms.Button();
            this.inventAddContLabel = new System.Windows.Forms.Label();
            this.inventPriceTxtbox = new System.Windows.Forms.NumericUpDown();
            this.inventQtyTxtbox = new System.Windows.Forms.NumericUpDown();
            this.inventAddAddBtn = new System.Windows.Forms.Button();
            this.inventAddCateBox = new System.Windows.Forms.ComboBox();
            this.inventPriceLabel = new System.Windows.Forms.Label();
            this.inventQtyLabel = new System.Windows.Forms.Label();
            this.inventCateLabel = new System.Windows.Forms.Label();
            this.inventNameLabel = new System.Windows.Forms.Label();
            this.inventFormLabel = new System.Windows.Forms.Label();
            this.inventNameTxtbox = new System.Windows.Forms.TextBox();
            this.inventCancelBtn = new System.Windows.Forms.Button();
            this.inventEditBtn = new System.Windows.Forms.Button();
            this.inventSearchBtn = new System.Windows.Forms.Button();
            this.inventAddNew = new System.Windows.Forms.Button();
            this.InventDescription = new System.Windows.Forms.Label();
            this.inventDataList = new System.Windows.Forms.DataGridView();
            this.inventSearchBar = new System.Windows.Forms.TextBox();
            this.inventDescPanel = new System.Windows.Forms.Panel();
            this.inventDescConfirmPanel = new System.Windows.Forms.Panel();
            this.inventDescConfirmBtn = new System.Windows.Forms.Button();
            this.inventDescConfirmLabel = new System.Windows.Forms.Label();
            this.inventDescPriceTextbox = new System.Windows.Forms.NumericUpDown();
            this.inventDescCheckbox = new System.Windows.Forms.CheckBox();
            this.inventDescCheckLabel = new System.Windows.Forms.Label();
            this.inventDescIDTxtbox = new System.Windows.Forms.NumericUpDown();
            this.inventDescIDLabel = new System.Windows.Forms.Label();
            this.inventDescQTYTxtbox = new System.Windows.Forms.NumericUpDown();
            this.inventDescCateBox = new System.Windows.Forms.ComboBox();
            this.inventDescPriceLabel = new System.Windows.Forms.Label();
            this.inventDescQTYLabel = new System.Windows.Forms.Label();
            this.inventDescCateLabel = new System.Windows.Forms.Label();
            this.inventDescNameLabel = new System.Windows.Forms.Label();
            this.inventDescNameTxtbox = new System.Windows.Forms.TextBox();
            this.reportsPage = new System.Windows.Forms.TabPage();
            this.reportCSVBtn = new System.Windows.Forms.Button();
            this.reportEndTitle = new System.Windows.Forms.Label();
            this.reportEndDate = new System.Windows.Forms.DateTimePicker();
            this.reportStartTitle = new System.Windows.Forms.Label();
            this.reportStartDate = new System.Windows.Forms.DateTimePicker();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.reportMenuPanel = new System.Windows.Forms.Panel();
            this.reportCategories = new System.Windows.Forms.Button();
            this.reportsProducts = new System.Windows.Forms.Button();
            this.reportEmployee = new System.Windows.Forms.Button();
            this.forecastPage = new System.Windows.Forms.TabPage();
            this.forcastEmailSCV = new System.Windows.Forms.Button();
            this.forecastCSVBtn = new System.Windows.Forms.Button();
            this.forecastChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.forecastDropDown = new System.Windows.Forms.ComboBox();
            this.forcastMenuPanel = new System.Windows.Forms.Panel();
            this.forecastCategoriesBtn = new System.Windows.Forms.Button();
            this.forecastProductBtn = new System.Windows.Forms.Button();
            this.forcasrSettingPanel = new System.Windows.Forms.Panel();
            this.forecastEndDate = new System.Windows.Forms.Label();
            this.forecastDropdownTitle = new System.Windows.Forms.Label();
            this.forecastEndDate2 = new System.Windows.Forms.DateTimePicker();
            this.forecastStartDate = new System.Windows.Forms.DateTimePicker();
            this.forecastStartTitle = new System.Windows.Forms.Label();
            this.homePage = new System.Windows.Forms.TabPage();
            this.HomeTitleLabel = new System.Windows.Forms.Label();
            this.powerButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.tabView.SuspendLayout();
            this.userPage.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.profilePage.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.salesPage.SuspendLayout();
            this.salesOldOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTranList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataList)).BeginInit();
            this.inventPage.SuspendLayout();
            this.inventAddForm.SuspendLayout();
            this.inventAddContinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventPriceTxtbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventQtyTxtbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDataList)).BeginInit();
            this.inventDescPanel.SuspendLayout();
            this.inventDescConfirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescPriceTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescIDTxtbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescQTYTxtbox)).BeginInit();
            this.reportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.reportMenuPanel.SuspendLayout();
            this.forecastPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastChart)).BeginInit();
            this.forcastMenuPanel.SuspendLayout();
            this.forcasrSettingPanel.SuspendLayout();
            this.homePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebar.Controls.Add(this.forecastTab);
            this.sidebar.Controls.Add(this.homeTab);
            this.sidebar.Controls.Add(this.reportsTab);
            this.sidebar.Controls.Add(this.reportPanel);
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
            this.forecastTab.Location = new System.Drawing.Point(0, 345);
            this.forecastTab.Margin = new System.Windows.Forms.Padding(0);
            this.forecastTab.Name = "forecastTab";
            this.forecastTab.Size = new System.Drawing.Size(115, 115);
            this.forecastTab.TabIndex = 4;
            this.forecastTab.UseVisualStyleBackColor = false;
            this.forecastTab.Visible = false;
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
            this.homeTab.Click += new System.EventHandler(this.homeTab_Click);
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
            this.reportsTab.Visible = false;
            this.reportsTab.Click += new System.EventHandler(this.reportsTab_Click);
            // 
            // reportPanel
            // 
            this.reportPanel.Location = new System.Drawing.Point(115, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1805, 1080);
            this.reportPanel.TabIndex = 1;
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
            this.tabView.Controls.Add(this.userPage);
            this.tabView.Controls.Add(this.profilePage);
            this.tabView.Controls.Add(this.salesPage);
            this.tabView.Controls.Add(this.inventPage);
            this.tabView.Controls.Add(this.reportsPage);
            this.tabView.Controls.Add(this.forecastPage);
            this.tabView.Controls.Add(this.homePage);
            this.tabView.ItemSize = new System.Drawing.Size(0, 1);
            this.tabView.Location = new System.Drawing.Point(115, 1);
            this.tabView.Margin = new System.Windows.Forms.Padding(0);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(1805, 1079);
            this.tabView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabView.TabIndex = 1;
            // 
            // userPage
            // 
            this.userPage.Controls.Add(this.loginPasswordTitle);
            this.userPage.Controls.Add(this.userPassField);
            this.userPage.Controls.Add(this.loginUserTitle);
            this.userPage.Controls.Add(this.userUsrField);
            this.userPage.Controls.Add(this.loginPanel);
            this.userPage.Location = new System.Drawing.Point(4, 5);
            this.userPage.Name = "userPage";
            this.userPage.Padding = new System.Windows.Forms.Padding(3);
            this.userPage.Size = new System.Drawing.Size(1797, 1070);
            this.userPage.TabIndex = 4;
            this.userPage.Text = "userPage";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // loginPasswordTitle
            // 
            this.loginPasswordTitle.AutoSize = true;
            this.loginPasswordTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTitle.ForeColor = System.Drawing.Color.Black;
            this.loginPasswordTitle.Location = new System.Drawing.Point(732, 499);
            this.loginPasswordTitle.Name = "loginPasswordTitle";
            this.loginPasswordTitle.Size = new System.Drawing.Size(134, 31);
            this.loginPasswordTitle.TabIndex = 4;
            this.loginPasswordTitle.Text = "Password";
            // 
            // userPassField
            // 
            this.userPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassField.Location = new System.Drawing.Point(738, 533);
            this.userPassField.Name = "userPassField";
            this.userPassField.Size = new System.Drawing.Size(327, 35);
            this.userPassField.TabIndex = 3;
            // 
            // loginUserTitle
            // 
            this.loginUserTitle.AutoSize = true;
            this.loginUserTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserTitle.ForeColor = System.Drawing.Color.Black;
            this.loginUserTitle.Location = new System.Drawing.Point(732, 400);
            this.loginUserTitle.Name = "loginUserTitle";
            this.loginUserTitle.Size = new System.Drawing.Size(151, 31);
            this.loginUserTitle.TabIndex = 2;
            this.loginUserTitle.Text = "User Name";
            // 
            // userUsrField
            // 
            this.userUsrField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUsrField.Location = new System.Drawing.Point(738, 434);
            this.userUsrField.Name = "userUsrField";
            this.userUsrField.Size = new System.Drawing.Size(327, 35);
            this.userUsrField.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPanel.Controls.Add(this.userLoginBtn);
            this.loginPanel.Controls.Add(this.loginTitle);
            this.loginPanel.ForeColor = System.Drawing.Color.White;
            this.loginPanel.Location = new System.Drawing.Point(552, 245);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(699, 510);
            this.loginPanel.TabIndex = 6;
            // 
            // userLoginBtn
            // 
            this.userLoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginBtn.Location = new System.Drawing.Point(211, 393);
            this.userLoginBtn.Name = "userLoginBtn";
            this.userLoginBtn.Size = new System.Drawing.Size(253, 44);
            this.userLoginBtn.TabIndex = 5;
            this.userLoginBtn.Text = "Login";
            this.userLoginBtn.UseVisualStyleBackColor = false;
            this.userLoginBtn.Click += new System.EventHandler(this.userLoginBtn_Click);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.Black;
            this.loginTitle.Location = new System.Drawing.Point(58, 39);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(589, 55);
            this.loginTitle.TabIndex = 1;
            this.loginTitle.Text = "Please Enter Login Details";
            // 
            // profilePage
            // 
            this.profilePage.Controls.Add(this.profilePanel);
            this.profilePage.Location = new System.Drawing.Point(4, 5);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(1797, 1070);
            this.profilePage.TabIndex = 5;
            this.profilePage.Text = "profileName";
            this.profilePage.UseVisualStyleBackColor = true;
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilePanel.Controls.Add(this.profileHireDate);
            this.profilePanel.Controls.Add(this.profileID);
            this.profilePanel.Controls.Add(this.profileName);
            this.profilePanel.Controls.Add(this.profileLogout);
            this.profilePanel.Controls.Add(this.profileTitle);
            this.profilePanel.ForeColor = System.Drawing.Color.White;
            this.profilePanel.Location = new System.Drawing.Point(556, 220);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(685, 630);
            this.profilePanel.TabIndex = 12;
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
            // profileTitle
            // 
            this.profileTitle.AutoSize = true;
            this.profileTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileTitle.ForeColor = System.Drawing.Color.Black;
            this.profileTitle.Location = new System.Drawing.Point(200, 4);
            this.profileTitle.Name = "profileTitle";
            this.profileTitle.Size = new System.Drawing.Size(310, 63);
            this.profileTitle.TabIndex = 8;
            this.profileTitle.Text = "User Profile";
            this.profileTitle.Click += new System.EventHandler(this.label6_Click);
            // 
            // salesPage
            // 
            this.salesPage.Controls.Add(this.label1);
            this.salesPage.Controls.Add(this.searchAllBtn);
            this.salesPage.Controls.Add(this.salesQTYLabel);
            this.salesPage.Controls.Add(this.inventButtonLabel);
            this.salesPage.Controls.Add(this.salesOldOrderPanel);
            this.salesPage.Controls.Add(this.salesOldOrder);
            this.salesPage.Controls.Add(this.salesTranList);
            this.salesPage.Controls.Add(this.salesAddBtn);
            this.salesPage.Controls.Add(this.salesPayButton);
            this.salesPage.Controls.Add(this.cancelButton);
            this.salesPage.Controls.Add(this.salesTotalNum);
            this.salesPage.Controls.Add(this.salesTotal);
            this.salesPage.Controls.Add(this.salesLine);
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
            this.salesPage.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPage.Location = new System.Drawing.Point(4, 5);
            this.salesPage.Margin = new System.Windows.Forms.Padding(0);
            this.salesPage.Name = "salesPage";
            this.salesPage.Size = new System.Drawing.Size(1797, 1070);
            this.salesPage.TabIndex = 0;
            this.salesPage.Text = "tabPage1";
            this.salesPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1142, 757);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Number of Items:";
            // 
            // searchAllBtn
            // 
            this.searchAllBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchAllBtn.FlatAppearance.BorderSize = 0;
            this.searchAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchAllBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAllBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchAllBtn.Location = new System.Drawing.Point(758, 975);
            this.searchAllBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchAllBtn.Name = "searchAllBtn";
            this.searchAllBtn.Size = new System.Drawing.Size(70, 70);
            this.searchAllBtn.TabIndex = 45;
            this.searchAllBtn.Text = "ALL";
            this.searchAllBtn.UseCompatibleTextRendering = true;
            this.searchAllBtn.UseVisualStyleBackColor = false;
            this.searchAllBtn.Click += new System.EventHandler(this.searchAllBtn_Click);
            // 
            // salesQTYLabel
            // 
            this.salesQTYLabel.AutoSize = true;
            this.salesQTYLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesQTYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesQTYLabel.ForeColor = System.Drawing.Color.Black;
            this.salesQTYLabel.Location = new System.Drawing.Point(1727, 757);
            this.salesQTYLabel.Name = "salesQTYLabel";
            this.salesQTYLabel.Size = new System.Drawing.Size(35, 37);
            this.salesQTYLabel.TabIndex = 44;
            this.salesQTYLabel.Text = "0";
            this.salesQTYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inventButtonLabel
            // 
            this.inventButtonLabel.AutoSize = true;
            this.inventButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.inventButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.inventButtonLabel.Location = new System.Drawing.Point(346, 757);
            this.inventButtonLabel.Name = "inventButtonLabel";
            this.inventButtonLabel.Size = new System.Drawing.Size(241, 37);
            this.inventButtonLabel.TabIndex = 43;
            this.inventButtonLabel.Text = "Select by Name";
            // 
            // salesOldOrderPanel
            // 
            this.salesOldOrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesOldOrderPanel.Controls.Add(this.salesOldPay);
            this.salesOldOrderPanel.Controls.Add(this.salesCancel);
            this.salesOldOrderPanel.Controls.Add(this.salesOldOrderTitle);
            this.salesOldOrderPanel.Controls.Add(this.salesTimePicker);
            this.salesOldOrderPanel.Location = new System.Drawing.Point(565, 258);
            this.salesOldOrderPanel.Name = "salesOldOrderPanel";
            this.salesOldOrderPanel.Size = new System.Drawing.Size(642, 298);
            this.salesOldOrderPanel.TabIndex = 42;
            this.salesOldOrderPanel.Visible = false;
            // 
            // salesOldPay
            // 
            this.salesOldPay.BackColor = System.Drawing.Color.LimeGreen;
            this.salesOldPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesOldPay.FlatAppearance.BorderSize = 0;
            this.salesOldPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesOldPay.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOldPay.ForeColor = System.Drawing.Color.Black;
            this.salesOldPay.Location = new System.Drawing.Point(428, 202);
            this.salesOldPay.Margin = new System.Windows.Forms.Padding(0);
            this.salesOldPay.Name = "salesOldPay";
            this.salesOldPay.Size = new System.Drawing.Size(135, 55);
            this.salesOldPay.TabIndex = 43;
            this.salesOldPay.Text = "Confirm";
            this.salesOldPay.UseCompatibleTextRendering = true;
            this.salesOldPay.UseVisualStyleBackColor = false;
            this.salesOldPay.Click += new System.EventHandler(this.salesOldPay_Click);
            // 
            // salesCancel
            // 
            this.salesCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.salesCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesCancel.FlatAppearance.BorderSize = 0;
            this.salesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesCancel.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesCancel.ForeColor = System.Drawing.Color.Black;
            this.salesCancel.Location = new System.Drawing.Point(68, 202);
            this.salesCancel.Margin = new System.Windows.Forms.Padding(0);
            this.salesCancel.Name = "salesCancel";
            this.salesCancel.Size = new System.Drawing.Size(133, 55);
            this.salesCancel.TabIndex = 43;
            this.salesCancel.Text = "Cancel";
            this.salesCancel.UseCompatibleTextRendering = true;
            this.salesCancel.UseVisualStyleBackColor = false;
            this.salesCancel.Click += new System.EventHandler(this.salesCancel_Click);
            // 
            // salesOldOrderTitle
            // 
            this.salesOldOrderTitle.AutoSize = true;
            this.salesOldOrderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOldOrderTitle.ForeColor = System.Drawing.Color.Black;
            this.salesOldOrderTitle.Location = new System.Drawing.Point(61, 43);
            this.salesOldOrderTitle.Name = "salesOldOrderTitle";
            this.salesOldOrderTitle.Size = new System.Drawing.Size(522, 39);
            this.salesOldOrderTitle.TabIndex = 41;
            this.salesOldOrderTitle.Text = "Please Choose A Date And Time";
            // 
            // salesTimePicker
            // 
            this.salesTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTimePicker.Location = new System.Drawing.Point(130, 105);
            this.salesTimePicker.Name = "salesTimePicker";
            this.salesTimePicker.Size = new System.Drawing.Size(363, 31);
            this.salesTimePicker.TabIndex = 40;
            // 
            // salesOldOrder
            // 
            this.salesOldOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.salesOldOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesOldOrder.FlatAppearance.BorderSize = 0;
            this.salesOldOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesOldOrder.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOldOrder.ForeColor = System.Drawing.Color.Black;
            this.salesOldOrder.Location = new System.Drawing.Point(1371, 981);
            this.salesOldOrder.Margin = new System.Windows.Forms.Padding(0);
            this.salesOldOrder.Name = "salesOldOrder";
            this.salesOldOrder.Size = new System.Drawing.Size(191, 55);
            this.salesOldOrder.TabIndex = 41;
            this.salesOldOrder.Text = "Old Order";
            this.salesOldOrder.UseCompatibleTextRendering = true;
            this.salesOldOrder.UseVisualStyleBackColor = false;
            this.salesOldOrder.Click += new System.EventHandler(this.salesOldOrder_Click);
            // 
            // salesTranList
            // 
            this.salesTranList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesTranList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesTranList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesTranList.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesTranList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesTranList.Location = new System.Drawing.Point(1149, 88);
            this.salesTranList.MultiSelect = false;
            this.salesTranList.Name = "salesTranList";
            this.salesTranList.ReadOnly = true;
            this.salesTranList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesTranList.Size = new System.Drawing.Size(613, 649);
            this.salesTranList.TabIndex = 39;
            // 
            // salesAddBtn
            // 
            this.salesAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salesAddBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.salesAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesAddBtn.FlatAppearance.BorderSize = 0;
            this.salesAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesAddBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesAddBtn.ForeColor = System.Drawing.Color.Black;
            this.salesAddBtn.Location = new System.Drawing.Point(922, 813);
            this.salesAddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.salesAddBtn.Name = "salesAddBtn";
            this.salesAddBtn.Size = new System.Drawing.Size(165, 87);
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
            this.salesPayButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.salesTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotalNum.ForeColor = System.Drawing.Color.Black;
            this.salesTotalNum.Location = new System.Drawing.Point(1621, 813);
            this.salesTotalNum.Name = "salesTotalNum";
            this.salesTotalNum.Size = new System.Drawing.Size(141, 37);
            this.salesTotalNum.TabIndex = 35;
            this.salesTotalNum.Text = "$000.00";
            this.salesTotalNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salesTotal
            // 
            this.salesTotal.AutoSize = true;
            this.salesTotal.BackColor = System.Drawing.Color.Transparent;
            this.salesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotal.ForeColor = System.Drawing.Color.Black;
            this.salesTotal.Location = new System.Drawing.Point(1142, 813);
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
            // salesTransLabel
            // 
            this.salesTransLabel.AutoSize = true;
            this.salesTransLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesTransLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTransLabel.ForeColor = System.Drawing.Color.Black;
            this.salesTransLabel.Location = new System.Drawing.Point(1142, 27);
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
            this.searchZBtn.Location = new System.Drawing.Point(678, 975);
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
            this.searchYBtn.Location = new System.Drawing.Point(599, 975);
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
            this.searchXBtn.Location = new System.Drawing.Point(517, 975);
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
            this.searchWBtn.Location = new System.Drawing.Point(434, 975);
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
            this.searchVBtn.Location = new System.Drawing.Point(352, 975);
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
            this.searchUBtn.Location = new System.Drawing.Point(271, 975);
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
            this.searchTBtn.Location = new System.Drawing.Point(188, 975);
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
            this.searchSBtn.Location = new System.Drawing.Point(105, 975);
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
            this.searchRBtn.Location = new System.Drawing.Point(758, 894);
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
            this.searchQBtn.Location = new System.Drawing.Point(678, 894);
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
            this.searchPBtn.Location = new System.Drawing.Point(599, 894);
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
            this.searchOBtn.Location = new System.Drawing.Point(517, 894);
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
            this.searchNBtn.Location = new System.Drawing.Point(434, 894);
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
            this.searchMBtn.Location = new System.Drawing.Point(352, 894);
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
            this.searchLBtn.Location = new System.Drawing.Point(271, 894);
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
            this.searchKBtn.Location = new System.Drawing.Point(188, 894);
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
            this.searchJBtn.Location = new System.Drawing.Point(105, 894);
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
            this.searchIBtn.Location = new System.Drawing.Point(758, 813);
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
            this.searchHBtn.Location = new System.Drawing.Point(678, 813);
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
            this.searchGBtn.Location = new System.Drawing.Point(599, 813);
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
            this.searchFBtn.Location = new System.Drawing.Point(517, 813);
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
            this.searchEBtn.Location = new System.Drawing.Point(434, 813);
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
            this.searchDBtn.Location = new System.Drawing.Point(352, 813);
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
            this.searchCBtn.Location = new System.Drawing.Point(271, 813);
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
            this.searchBBtn.Location = new System.Drawing.Point(188, 813);
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
            this.searchABtn.Location = new System.Drawing.Point(105, 813);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salesDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDataList.DefaultCellStyle = dataGridViewCellStyle4;
            this.salesDataList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesDataList.Location = new System.Drawing.Point(37, 89);
            this.salesDataList.MultiSelect = false;
            this.salesDataList.Name = "salesDataList";
            this.salesDataList.ReadOnly = true;
            this.salesDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataList.Size = new System.Drawing.Size(1038, 649);
            this.salesDataList.TabIndex = 1;
            this.salesDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataList_CellClick);
            this.salesDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataList_CellContentClick);
            // 
            // salesSearchBox
            // 
            this.salesSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesSearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.salesSearchBox.Location = new System.Drawing.Point(120, 21);
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
            this.salesSearchButton.Location = new System.Drawing.Point(963, 21);
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
            this.inventPage.Controls.Add(this.inventSearchBtn);
            this.inventPage.Controls.Add(this.inventAddNew);
            this.inventPage.Controls.Add(this.InventDescription);
            this.inventPage.Controls.Add(this.inventDataList);
            this.inventPage.Controls.Add(this.inventSearchBar);
            this.inventPage.Controls.Add(this.inventDescPanel);
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
            this.inventAddForm.BackColor = System.Drawing.Color.White;
            this.inventAddForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventAddForm.Controls.Add(this.inventAddCancelBtn);
            this.inventAddForm.Controls.Add(this.inventAddContinPanel);
            this.inventAddForm.Controls.Add(this.inventPriceTxtbox);
            this.inventAddForm.Controls.Add(this.inventQtyTxtbox);
            this.inventAddForm.Controls.Add(this.inventAddAddBtn);
            this.inventAddForm.Controls.Add(this.inventAddCateBox);
            this.inventAddForm.Controls.Add(this.inventPriceLabel);
            this.inventAddForm.Controls.Add(this.inventQtyLabel);
            this.inventAddForm.Controls.Add(this.inventCateLabel);
            this.inventAddForm.Controls.Add(this.inventNameLabel);
            this.inventAddForm.Controls.Add(this.inventFormLabel);
            this.inventAddForm.Controls.Add(this.inventNameTxtbox);
            this.inventAddForm.Enabled = false;
            this.inventAddForm.Location = new System.Drawing.Point(390, 224);
            this.inventAddForm.Name = "inventAddForm";
            this.inventAddForm.Size = new System.Drawing.Size(566, 585);
            this.inventAddForm.TabIndex = 40;
            this.inventAddForm.Visible = false;
            // 
            // inventAddCancelBtn
            // 
            this.inventAddCancelBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.inventAddCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventAddCancelBtn.FlatAppearance.BorderSize = 0;
            this.inventAddCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventAddCancelBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddCancelBtn.ForeColor = System.Drawing.Color.Black;
            this.inventAddCancelBtn.Location = new System.Drawing.Point(48, 483);
            this.inventAddCancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventAddCancelBtn.Name = "inventAddCancelBtn";
            this.inventAddCancelBtn.Size = new System.Drawing.Size(120, 71);
            this.inventAddCancelBtn.TabIndex = 45;
            this.inventAddCancelBtn.Text = "Cancel";
            this.inventAddCancelBtn.UseCompatibleTextRendering = true;
            this.inventAddCancelBtn.UseVisualStyleBackColor = false;
            this.inventAddCancelBtn.Click += new System.EventHandler(this.inventAddCancelBtn_Click);
            // 
            // inventAddContinPanel
            // 
            this.inventAddContinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventAddContinPanel.Controls.Add(this.inventAddContinBtn);
            this.inventAddContinPanel.Controls.Add(this.inventAddContLabel);
            this.inventAddContinPanel.Enabled = false;
            this.inventAddContinPanel.Location = new System.Drawing.Point(122, 167);
            this.inventAddContinPanel.Name = "inventAddContinPanel";
            this.inventAddContinPanel.Size = new System.Drawing.Size(344, 236);
            this.inventAddContinPanel.TabIndex = 44;
            this.inventAddContinPanel.Visible = false;
            // 
            // inventAddContinBtn
            // 
            this.inventAddContinBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inventAddContinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventAddContinBtn.FlatAppearance.BorderSize = 0;
            this.inventAddContinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventAddContinBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddContinBtn.ForeColor = System.Drawing.Color.Black;
            this.inventAddContinBtn.Location = new System.Drawing.Point(111, 105);
            this.inventAddContinBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventAddContinBtn.Name = "inventAddContinBtn";
            this.inventAddContinBtn.Size = new System.Drawing.Size(120, 71);
            this.inventAddContinBtn.TabIndex = 45;
            this.inventAddContinBtn.Text = "Continue";
            this.inventAddContinBtn.UseCompatibleTextRendering = true;
            this.inventAddContinBtn.UseVisualStyleBackColor = false;
            this.inventAddContinBtn.Click += new System.EventHandler(this.inventAddContinBtn_Click);
            // 
            // inventAddContLabel
            // 
            this.inventAddContLabel.AutoSize = true;
            this.inventAddContLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddContLabel.ForeColor = System.Drawing.Color.Black;
            this.inventAddContLabel.Location = new System.Drawing.Point(53, 50);
            this.inventAddContLabel.Name = "inventAddContLabel";
            this.inventAddContLabel.Size = new System.Drawing.Size(249, 37);
            this.inventAddContLabel.TabIndex = 45;
            this.inventAddContLabel.Text = "Product added!";
            // 
            // inventPriceTxtbox
            // 
            this.inventPriceTxtbox.DecimalPlaces = 2;
            this.inventPriceTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventPriceTxtbox.Location = new System.Drawing.Point(81, 393);
            this.inventPriceTxtbox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.inventPriceTxtbox.Name = "inventPriceTxtbox";
            this.inventPriceTxtbox.Size = new System.Drawing.Size(412, 31);
            this.inventPriceTxtbox.TabIndex = 43;
            // 
            // inventQtyTxtbox
            // 
            this.inventQtyTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventQtyTxtbox.Location = new System.Drawing.Point(81, 312);
            this.inventQtyTxtbox.Name = "inventQtyTxtbox";
            this.inventQtyTxtbox.Size = new System.Drawing.Size(412, 31);
            this.inventQtyTxtbox.TabIndex = 42;
            // 
            // inventAddAddBtn
            // 
            this.inventAddAddBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.inventAddAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventAddAddBtn.FlatAppearance.BorderSize = 0;
            this.inventAddAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventAddAddBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddAddBtn.ForeColor = System.Drawing.Color.Black;
            this.inventAddAddBtn.Location = new System.Drawing.Point(405, 483);
            this.inventAddAddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventAddAddBtn.Name = "inventAddAddBtn";
            this.inventAddAddBtn.Size = new System.Drawing.Size(120, 71);
            this.inventAddAddBtn.TabIndex = 41;
            this.inventAddAddBtn.Text = "Add Product";
            this.inventAddAddBtn.UseCompatibleTextRendering = true;
            this.inventAddAddBtn.UseVisualStyleBackColor = false;
            this.inventAddAddBtn.Click += new System.EventHandler(this.inventAddAddBtn_Click);
            // 
            // inventAddCateBox
            // 
            this.inventAddCateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inventAddCateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddCateBox.FormattingEnabled = true;
            this.inventAddCateBox.Location = new System.Drawing.Point(81, 235);
            this.inventAddCateBox.Name = "inventAddCateBox";
            this.inventAddCateBox.Size = new System.Drawing.Size(412, 33);
            this.inventAddCateBox.TabIndex = 9;
            // 
            // inventPriceLabel
            // 
            this.inventPriceLabel.AutoSize = true;
            this.inventPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.inventPriceLabel.Location = new System.Drawing.Point(76, 361);
            this.inventPriceLabel.Name = "inventPriceLabel";
            this.inventPriceLabel.Size = new System.Drawing.Size(257, 29);
            this.inventPriceLabel.TabIndex = 8;
            this.inventPriceLabel.Text = "Sales Price per Item:";
            // 
            // inventQtyLabel
            // 
            this.inventQtyLabel.AutoSize = true;
            this.inventQtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventQtyLabel.ForeColor = System.Drawing.Color.Black;
            this.inventQtyLabel.Location = new System.Drawing.Point(76, 280);
            this.inventQtyLabel.Name = "inventQtyLabel";
            this.inventQtyLabel.Size = new System.Drawing.Size(215, 29);
            this.inventQtyLabel.TabIndex = 6;
            this.inventQtyLabel.Text = "Quantity In Stock:";
            // 
            // inventCateLabel
            // 
            this.inventCateLabel.AutoSize = true;
            this.inventCateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventCateLabel.ForeColor = System.Drawing.Color.Black;
            this.inventCateLabel.Location = new System.Drawing.Point(76, 203);
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
            this.inventNameLabel.Location = new System.Drawing.Point(76, 126);
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
            this.inventFormLabel.Location = new System.Drawing.Point(31, 56);
            this.inventFormLabel.Name = "inventFormLabel";
            this.inventFormLabel.Size = new System.Drawing.Size(302, 37);
            this.inventFormLabel.TabIndex = 1;
            this.inventFormLabel.Text = "New Product Form";
            // 
            // inventNameTxtbox
            // 
            this.inventNameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventNameTxtbox.Location = new System.Drawing.Point(81, 155);
            this.inventNameTxtbox.Name = "inventNameTxtbox";
            this.inventNameTxtbox.Size = new System.Drawing.Size(412, 35);
            this.inventNameTxtbox.TabIndex = 0;
            // 
            // inventCancelBtn
            // 
            this.inventCancelBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.inventCancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventCancelBtn.Enabled = false;
            this.inventCancelBtn.FlatAppearance.BorderSize = 0;
            this.inventCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventCancelBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventCancelBtn.ForeColor = System.Drawing.Color.Black;
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
            this.inventEditBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventEditBtn.ForeColor = System.Drawing.Color.Black;
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
            // inventAddNew
            // 
            this.inventAddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventAddNew.FlatAppearance.BorderSize = 0;
            this.inventAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventAddNew.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddNew.ForeColor = System.Drawing.Color.Black;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.inventDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventDataList.DefaultCellStyle = dataGridViewCellStyle6;
            this.inventDataList.Location = new System.Drawing.Point(36, 72);
            this.inventDataList.MultiSelect = false;
            this.inventDataList.Name = "inventDataList";
            this.inventDataList.ReadOnly = true;
            this.inventDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // inventDescPanel
            // 
            this.inventDescPanel.BackColor = System.Drawing.Color.White;
            this.inventDescPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventDescPanel.Controls.Add(this.inventDescConfirmPanel);
            this.inventDescPanel.Controls.Add(this.inventDescPriceTextbox);
            this.inventDescPanel.Controls.Add(this.inventDescCheckbox);
            this.inventDescPanel.Controls.Add(this.inventDescCheckLabel);
            this.inventDescPanel.Controls.Add(this.inventDescIDTxtbox);
            this.inventDescPanel.Controls.Add(this.inventDescIDLabel);
            this.inventDescPanel.Controls.Add(this.inventDescQTYTxtbox);
            this.inventDescPanel.Controls.Add(this.inventDescCateBox);
            this.inventDescPanel.Controls.Add(this.inventDescPriceLabel);
            this.inventDescPanel.Controls.Add(this.inventDescQTYLabel);
            this.inventDescPanel.Controls.Add(this.inventDescCateLabel);
            this.inventDescPanel.Controls.Add(this.inventDescNameLabel);
            this.inventDescPanel.Controls.Add(this.inventDescNameTxtbox);
            this.inventDescPanel.Enabled = false;
            this.inventDescPanel.Location = new System.Drawing.Point(1260, 72);
            this.inventDescPanel.Name = "inventDescPanel";
            this.inventDescPanel.Size = new System.Drawing.Size(508, 864);
            this.inventDescPanel.TabIndex = 44;
            // 
            // inventDescConfirmPanel
            // 
            this.inventDescConfirmPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventDescConfirmPanel.Controls.Add(this.inventDescConfirmBtn);
            this.inventDescConfirmPanel.Controls.Add(this.inventDescConfirmLabel);
            this.inventDescConfirmPanel.Enabled = false;
            this.inventDescConfirmPanel.Location = new System.Drawing.Point(81, 313);
            this.inventDescConfirmPanel.Name = "inventDescConfirmPanel";
            this.inventDescConfirmPanel.Size = new System.Drawing.Size(344, 236);
            this.inventDescConfirmPanel.TabIndex = 48;
            this.inventDescConfirmPanel.Visible = false;
            // 
            // inventDescConfirmBtn
            // 
            this.inventDescConfirmBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inventDescConfirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventDescConfirmBtn.FlatAppearance.BorderSize = 0;
            this.inventDescConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventDescConfirmBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescConfirmBtn.ForeColor = System.Drawing.Color.Black;
            this.inventDescConfirmBtn.Location = new System.Drawing.Point(111, 105);
            this.inventDescConfirmBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventDescConfirmBtn.Name = "inventDescConfirmBtn";
            this.inventDescConfirmBtn.Size = new System.Drawing.Size(120, 71);
            this.inventDescConfirmBtn.TabIndex = 45;
            this.inventDescConfirmBtn.Text = "Continue";
            this.inventDescConfirmBtn.UseCompatibleTextRendering = true;
            this.inventDescConfirmBtn.UseVisualStyleBackColor = false;
            this.inventDescConfirmBtn.Click += new System.EventHandler(this.inventDescConfirmBtn_Click);
            // 
            // inventDescConfirmLabel
            // 
            this.inventDescConfirmLabel.AutoSize = true;
            this.inventDescConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescConfirmLabel.ForeColor = System.Drawing.Color.Black;
            this.inventDescConfirmLabel.Location = new System.Drawing.Point(33, 44);
            this.inventDescConfirmLabel.Name = "inventDescConfirmLabel";
            this.inventDescConfirmLabel.Size = new System.Drawing.Size(283, 37);
            this.inventDescConfirmLabel.TabIndex = 45;
            this.inventDescConfirmLabel.Text = "Product Updated!";
            // 
            // inventDescPriceTextbox
            // 
            this.inventDescPriceTextbox.DecimalPlaces = 2;
            this.inventDescPriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescPriceTextbox.Location = new System.Drawing.Point(53, 388);
            this.inventDescPriceTextbox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.inventDescPriceTextbox.Name = "inventDescPriceTextbox";
            this.inventDescPriceTextbox.Size = new System.Drawing.Size(412, 31);
            this.inventDescPriceTextbox.TabIndex = 49;
            // 
            // inventDescCheckbox
            // 
            this.inventDescCheckbox.AutoSize = true;
            this.inventDescCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescCheckbox.ForeColor = System.Drawing.Color.Black;
            this.inventDescCheckbox.Location = new System.Drawing.Point(151, 495);
            this.inventDescCheckbox.Name = "inventDescCheckbox";
            this.inventDescCheckbox.Size = new System.Drawing.Size(184, 33);
            this.inventDescCheckbox.TabIndex = 47;
            this.inventDescCheckbox.Text = "Discontinued?";
            this.inventDescCheckbox.UseVisualStyleBackColor = true;
            // 
            // inventDescCheckLabel
            // 
            this.inventDescCheckLabel.AutoSize = true;
            this.inventDescCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescCheckLabel.ForeColor = System.Drawing.Color.Black;
            this.inventDescCheckLabel.Location = new System.Drawing.Point(48, 463);
            this.inventDescCheckLabel.Name = "inventDescCheckLabel";
            this.inventDescCheckLabel.Size = new System.Drawing.Size(242, 29);
            this.inventDescCheckLabel.TabIndex = 46;
            this.inventDescCheckLabel.Text = "Product Avaliability:";
            // 
            // inventDescIDTxtbox
            // 
            this.inventDescIDTxtbox.Enabled = false;
            this.inventDescIDTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescIDTxtbox.Location = new System.Drawing.Point(196, 37);
            this.inventDescIDTxtbox.Name = "inventDescIDTxtbox";
            this.inventDescIDTxtbox.Size = new System.Drawing.Size(44, 31);
            this.inventDescIDTxtbox.TabIndex = 45;
            // 
            // inventDescIDLabel
            // 
            this.inventDescIDLabel.AutoSize = true;
            this.inventDescIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescIDLabel.ForeColor = System.Drawing.Color.Black;
            this.inventDescIDLabel.Location = new System.Drawing.Point(48, 37);
            this.inventDescIDLabel.Name = "inventDescIDLabel";
            this.inventDescIDLabel.Size = new System.Drawing.Size(142, 29);
            this.inventDescIDLabel.TabIndex = 44;
            this.inventDescIDLabel.Text = "Product ID:";
            // 
            // inventDescQTYTxtbox
            // 
            this.inventDescQTYTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescQTYTxtbox.Location = new System.Drawing.Point(53, 309);
            this.inventDescQTYTxtbox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.inventDescQTYTxtbox.Name = "inventDescQTYTxtbox";
            this.inventDescQTYTxtbox.Size = new System.Drawing.Size(412, 31);
            this.inventDescQTYTxtbox.TabIndex = 42;
            // 
            // inventDescCateBox
            // 
            this.inventDescCateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inventDescCateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescCateBox.FormattingEnabled = true;
            this.inventDescCateBox.Location = new System.Drawing.Point(53, 232);
            this.inventDescCateBox.Name = "inventDescCateBox";
            this.inventDescCateBox.Size = new System.Drawing.Size(412, 33);
            this.inventDescCateBox.TabIndex = 9;
            // 
            // inventDescPriceLabel
            // 
            this.inventDescPriceLabel.AutoSize = true;
            this.inventDescPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.inventDescPriceLabel.Location = new System.Drawing.Point(48, 358);
            this.inventDescPriceLabel.Name = "inventDescPriceLabel";
            this.inventDescPriceLabel.Size = new System.Drawing.Size(257, 29);
            this.inventDescPriceLabel.TabIndex = 8;
            this.inventDescPriceLabel.Text = "Sales Price per Item:";
            // 
            // inventDescQTYLabel
            // 
            this.inventDescQTYLabel.AutoSize = true;
            this.inventDescQTYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescQTYLabel.ForeColor = System.Drawing.Color.Black;
            this.inventDescQTYLabel.Location = new System.Drawing.Point(48, 277);
            this.inventDescQTYLabel.Name = "inventDescQTYLabel";
            this.inventDescQTYLabel.Size = new System.Drawing.Size(215, 29);
            this.inventDescQTYLabel.TabIndex = 6;
            this.inventDescQTYLabel.Text = "Quantity In Stock:";
            // 
            // inventDescCateLabel
            // 
            this.inventDescCateLabel.AutoSize = true;
            this.inventDescCateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescCateLabel.ForeColor = System.Drawing.Color.Black;
            this.inventDescCateLabel.Location = new System.Drawing.Point(48, 200);
            this.inventDescCateLabel.Name = "inventDescCateLabel";
            this.inventDescCateLabel.Size = new System.Drawing.Size(222, 29);
            this.inventDescCateLabel.TabIndex = 4;
            this.inventDescCateLabel.Text = "Product Category:";
            // 
            // inventDescNameLabel
            // 
            this.inventDescNameLabel.AutoSize = true;
            this.inventDescNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescNameLabel.ForeColor = System.Drawing.Color.Black;
            this.inventDescNameLabel.Location = new System.Drawing.Point(48, 123);
            this.inventDescNameLabel.Name = "inventDescNameLabel";
            this.inventDescNameLabel.Size = new System.Drawing.Size(186, 29);
            this.inventDescNameLabel.TabIndex = 2;
            this.inventDescNameLabel.Text = "Product Name:";
            // 
            // inventDescNameTxtbox
            // 
            this.inventDescNameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventDescNameTxtbox.Location = new System.Drawing.Point(53, 152);
            this.inventDescNameTxtbox.Name = "inventDescNameTxtbox";
            this.inventDescNameTxtbox.Size = new System.Drawing.Size(412, 35);
            this.inventDescNameTxtbox.TabIndex = 0;
            // 
            // reportsPage
            // 
            this.reportsPage.Controls.Add(this.reportCSVBtn);
            this.reportsPage.Controls.Add(this.reportEndTitle);
            this.reportsPage.Controls.Add(this.reportEndDate);
            this.reportsPage.Controls.Add(this.reportStartTitle);
            this.reportsPage.Controls.Add(this.reportStartDate);
            this.reportsPage.Controls.Add(this.reportChart);
            this.reportsPage.Controls.Add(this.reportsGrid);
            this.reportsPage.Controls.Add(this.reportMenuPanel);
            this.reportsPage.Location = new System.Drawing.Point(4, 5);
            this.reportsPage.Name = "reportsPage";
            this.reportsPage.Size = new System.Drawing.Size(1797, 1070);
            this.reportsPage.TabIndex = 2;
            this.reportsPage.Text = "Reports";
            this.reportsPage.UseVisualStyleBackColor = true;
            this.reportsPage.Click += new System.EventHandler(this.reportsPage_Click);
            // 
            // reportCSVBtn
            // 
            this.reportCSVBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.reportCSVBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportCSVBtn.FlatAppearance.BorderSize = 0;
            this.reportCSVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportCSVBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportCSVBtn.ForeColor = System.Drawing.Color.Transparent;
            this.reportCSVBtn.Location = new System.Drawing.Point(1411, 989);
            this.reportCSVBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reportCSVBtn.Name = "reportCSVBtn";
            this.reportCSVBtn.Size = new System.Drawing.Size(208, 73);
            this.reportCSVBtn.TabIndex = 7;
            this.reportCSVBtn.Text = "Export CSV";
            this.reportCSVBtn.UseVisualStyleBackColor = false;
            this.reportCSVBtn.Click += new System.EventHandler(this.reportCSVBtn_Click);
            // 
            // reportEndTitle
            // 
            this.reportEndTitle.AutoSize = true;
            this.reportEndTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reportEndTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportEndTitle.ForeColor = System.Drawing.Color.Black;
            this.reportEndTitle.Location = new System.Drawing.Point(972, 136);
            this.reportEndTitle.Name = "reportEndTitle";
            this.reportEndTitle.Size = new System.Drawing.Size(101, 25);
            this.reportEndTitle.TabIndex = 24;
            this.reportEndTitle.Text = "End Date";
            this.reportEndTitle.Click += new System.EventHandler(this.label5_Click);
            // 
            // reportEndDate
            // 
            this.reportEndDate.Location = new System.Drawing.Point(926, 173);
            this.reportEndDate.Name = "reportEndDate";
            this.reportEndDate.Size = new System.Drawing.Size(191, 20);
            this.reportEndDate.TabIndex = 23;
            // 
            // reportStartTitle
            // 
            this.reportStartTitle.AutoSize = true;
            this.reportStartTitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reportStartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportStartTitle.ForeColor = System.Drawing.Color.Black;
            this.reportStartTitle.Location = new System.Drawing.Point(559, 136);
            this.reportStartTitle.Name = "reportStartTitle";
            this.reportStartTitle.Size = new System.Drawing.Size(108, 25);
            this.reportStartTitle.TabIndex = 22;
            this.reportStartTitle.Text = "Start Date";
            this.reportStartTitle.Click += new System.EventHandler(this.label4_Click);
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
            chartArea1.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.reportChart.Legends.Add(legend1);
            this.reportChart.Location = new System.Drawing.Point(306, 212);
            this.reportChart.Name = "reportChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.reportChart.Series.Add(series1);
            this.reportChart.Size = new System.Drawing.Size(1073, 400);
            this.reportChart.TabIndex = 19;
            this.reportChart.Text = "chart1";
            // 
            // reportsGrid
            // 
            this.reportsGrid.AllowUserToAddRows = false;
            this.reportsGrid.AllowUserToDeleteRows = false;
            this.reportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportsGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.reportsGrid.Location = new System.Drawing.Point(306, 644);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.ReadOnly = true;
            this.reportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportsGrid.Size = new System.Drawing.Size(1073, 418);
            this.reportsGrid.TabIndex = 18;
            // 
            // reportMenuPanel
            // 
            this.reportMenuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.reportMenuPanel.Controls.Add(this.reportCategories);
            this.reportMenuPanel.Controls.Add(this.reportsProducts);
            this.reportMenuPanel.Controls.Add(this.reportEmployee);
            this.reportMenuPanel.Location = new System.Drawing.Point(306, 6);
            this.reportMenuPanel.Name = "reportMenuPanel";
            this.reportMenuPanel.Size = new System.Drawing.Size(1073, 118);
            this.reportMenuPanel.TabIndex = 17;
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
            // forecastPage
            // 
            this.forecastPage.Controls.Add(this.forcastEmailSCV);
            this.forecastPage.Controls.Add(this.forecastCSVBtn);
            this.forecastPage.Controls.Add(this.forecastChart);
            this.forecastPage.Controls.Add(this.forecastDropDown);
            this.forecastPage.Controls.Add(this.forcastMenuPanel);
            this.forecastPage.Controls.Add(this.forcasrSettingPanel);
            this.forecastPage.Location = new System.Drawing.Point(4, 5);
            this.forecastPage.Name = "forecastPage";
            this.forecastPage.Size = new System.Drawing.Size(1797, 1070);
            this.forecastPage.TabIndex = 6;
            this.forecastPage.Text = "forecastPage";
            this.forecastPage.UseVisualStyleBackColor = true;
            // 
            // forcastEmailSCV
            // 
            this.forcastEmailSCV.BackColor = System.Drawing.Color.SteelBlue;
            this.forcastEmailSCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forcastEmailSCV.FlatAppearance.BorderSize = 0;
            this.forcastEmailSCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forcastEmailSCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastEmailSCV.ForeColor = System.Drawing.Color.Transparent;
            this.forcastEmailSCV.Location = new System.Drawing.Point(1313, 675);
            this.forcastEmailSCV.Margin = new System.Windows.Forms.Padding(0);
            this.forcastEmailSCV.Name = "forcastEmailSCV";
            this.forcastEmailSCV.Size = new System.Drawing.Size(208, 73);
            this.forcastEmailSCV.TabIndex = 22;
            this.forcastEmailSCV.Text = "Email CSV";
            this.forcastEmailSCV.UseVisualStyleBackColor = false;
            this.forcastEmailSCV.Click += new System.EventHandler(this.forcastEmailSCV_Click);
            // 
            // forecastCSVBtn
            // 
            this.forecastCSVBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.forecastCSVBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forecastCSVBtn.FlatAppearance.BorderSize = 0;
            this.forecastCSVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forecastCSVBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastCSVBtn.ForeColor = System.Drawing.Color.Transparent;
            this.forecastCSVBtn.Location = new System.Drawing.Point(1313, 763);
            this.forecastCSVBtn.Margin = new System.Windows.Forms.Padding(0);
            this.forecastCSVBtn.Name = "forecastCSVBtn";
            this.forecastCSVBtn.Size = new System.Drawing.Size(208, 73);
            this.forecastCSVBtn.TabIndex = 21;
            this.forecastCSVBtn.Text = "Export CSV";
            this.forecastCSVBtn.UseVisualStyleBackColor = false;
            this.forecastCSVBtn.Click += new System.EventHandler(this.forecastCSVBtn_Click);
            // 
            // forecastChart
            // 
            chartArea2.Name = "ChartArea1";
            this.forecastChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.forecastChart.Legends.Add(legend2);
            this.forecastChart.Location = new System.Drawing.Point(392, 436);
            this.forecastChart.Name = "forecastChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.forecastChart.Series.Add(series2);
            this.forecastChart.Size = new System.Drawing.Size(897, 400);
            this.forecastChart.TabIndex = 20;
            this.forecastChart.Text = "chart1";
            // 
            // forecastDropDown
            // 
            this.forecastDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastDropDown.FormattingEnabled = true;
            this.forecastDropDown.Location = new System.Drawing.Point(604, 203);
            this.forecastDropDown.Name = "forecastDropDown";
            this.forecastDropDown.Size = new System.Drawing.Size(434, 33);
            this.forecastDropDown.TabIndex = 19;
            // 
            // forcastMenuPanel
            // 
            this.forcastMenuPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.forcastMenuPanel.Controls.Add(this.forecastCategoriesBtn);
            this.forcastMenuPanel.Controls.Add(this.forecastProductBtn);
            this.forcastMenuPanel.Location = new System.Drawing.Point(392, 6);
            this.forcastMenuPanel.Name = "forcastMenuPanel";
            this.forcastMenuPanel.Size = new System.Drawing.Size(897, 118);
            this.forcastMenuPanel.TabIndex = 18;
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
            // forcasrSettingPanel
            // 
            this.forcasrSettingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.forcasrSettingPanel.Controls.Add(this.forecastEndDate);
            this.forcasrSettingPanel.Controls.Add(this.forecastDropdownTitle);
            this.forcasrSettingPanel.Controls.Add(this.forecastEndDate2);
            this.forcasrSettingPanel.Controls.Add(this.forecastStartDate);
            this.forcasrSettingPanel.Controls.Add(this.forecastStartTitle);
            this.forcasrSettingPanel.Location = new System.Drawing.Point(392, 119);
            this.forcasrSettingPanel.Name = "forcasrSettingPanel";
            this.forcasrSettingPanel.Size = new System.Drawing.Size(897, 253);
            this.forcasrSettingPanel.TabIndex = 19;
            // 
            // forecastEndDate
            // 
            this.forecastEndDate.AutoSize = true;
            this.forecastEndDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forecastEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastEndDate.ForeColor = System.Drawing.Color.Black;
            this.forecastEndDate.Location = new System.Drawing.Point(545, 152);
            this.forecastEndDate.Name = "forecastEndDate";
            this.forecastEndDate.Size = new System.Drawing.Size(101, 25);
            this.forecastEndDate.TabIndex = 28;
            this.forecastEndDate.Text = "End Date";
            // 
            // forecastDropdownTitle
            // 
            this.forecastDropdownTitle.AutoSize = true;
            this.forecastDropdownTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastDropdownTitle.ForeColor = System.Drawing.Color.Black;
            this.forecastDropdownTitle.Location = new System.Drawing.Point(337, 50);
            this.forecastDropdownTitle.Name = "forecastDropdownTitle";
            this.forecastDropdownTitle.Size = new System.Drawing.Size(216, 31);
            this.forecastDropdownTitle.TabIndex = 20;
            this.forecastDropdownTitle.Text = "Select A Product";
            // 
            // forecastEndDate2
            // 
            this.forecastEndDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastEndDate2.Location = new System.Drawing.Point(455, 180);
            this.forecastEndDate2.Name = "forecastEndDate2";
            this.forecastEndDate2.Size = new System.Drawing.Size(279, 26);
            this.forecastEndDate2.TabIndex = 27;
            // 
            // forecastStartDate
            // 
            this.forecastStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastStartDate.Location = new System.Drawing.Point(124, 180);
            this.forecastStartDate.Name = "forecastStartDate";
            this.forecastStartDate.Size = new System.Drawing.Size(279, 26);
            this.forecastStartDate.TabIndex = 25;
            // 
            // forecastStartTitle
            // 
            this.forecastStartTitle.AutoSize = true;
            this.forecastStartTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.forecastStartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastStartTitle.ForeColor = System.Drawing.Color.Black;
            this.forecastStartTitle.Location = new System.Drawing.Point(207, 152);
            this.forecastStartTitle.Name = "forecastStartTitle";
            this.forecastStartTitle.Size = new System.Drawing.Size(108, 25);
            this.forecastStartTitle.TabIndex = 26;
            this.forecastStartTitle.Text = "Start Date";
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.HomeTitleLabel);
            this.homePage.Controls.Add(this.powerButton);
            this.homePage.Controls.Add(this.userButton);
            this.homePage.Location = new System.Drawing.Point(4, 5);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(1797, 1070);
            this.homePage.TabIndex = 3;
            this.homePage.Text = "Home";
            // 
            // HomeTitleLabel
            // 
            this.HomeTitleLabel.AutoSize = true;
            this.HomeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.HomeTitleLabel.Location = new System.Drawing.Point(565, 494);
            this.HomeTitleLabel.Name = "HomeTitleLabel";
            this.HomeTitleLabel.Size = new System.Drawing.Size(613, 73);
            this.HomeTitleLabel.TabIndex = 6;
            this.HomeTitleLabel.Text = "Hawthorn Pharmacy";
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
            this.userButton.Text = "Not Signed In";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
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
            this.userPage.ResumeLayout(false);
            this.userPage.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.profilePage.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.salesPage.ResumeLayout(false);
            this.salesPage.PerformLayout();
            this.salesOldOrderPanel.ResumeLayout(false);
            this.salesOldOrderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTranList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataList)).EndInit();
            this.inventPage.ResumeLayout(false);
            this.inventPage.PerformLayout();
            this.inventAddForm.ResumeLayout(false);
            this.inventAddForm.PerformLayout();
            this.inventAddContinPanel.ResumeLayout(false);
            this.inventAddContinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventPriceTxtbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventQtyTxtbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDataList)).EndInit();
            this.inventDescPanel.ResumeLayout(false);
            this.inventDescPanel.PerformLayout();
            this.inventDescConfirmPanel.ResumeLayout(false);
            this.inventDescConfirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescPriceTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescIDTxtbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDescQTYTxtbox)).EndInit();
            this.reportsPage.ResumeLayout(false);
            this.reportsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            this.reportMenuPanel.ResumeLayout(false);
            this.forecastPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forecastChart)).EndInit();
            this.forcastMenuPanel.ResumeLayout(false);
            this.forcasrSettingPanel.ResumeLayout(false);
            this.forcasrSettingPanel.PerformLayout();
            this.homePage.ResumeLayout(false);
            this.homePage.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button inventTab;
        private System.Windows.Forms.Button salesTab;
        private System.Windows.Forms.Button homeTab;
        private System.Windows.Forms.Button reportsTab;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage salesPage;
        private System.Windows.Forms.TabPage inventPage;
        private Panel inventDescPanel;
        private Panel inventDescConfirmPanel;
        private Button inventDescConfirmBtn;
        private Label inventDescConfirmLabel;
        private CheckBox inventDescCheckbox;
        private Label inventDescCheckLabel;
        private NumericUpDown inventDescIDTxtbox;
        private Label inventDescIDLabel;
        private NumericUpDown inventDescQTYTxtbox;
        private ComboBox inventDescCateBox;
        private Label inventDescPriceLabel;
        private Label inventDescQTYLabel;
        private Label inventDescCateLabel;
        private Label inventDescNameLabel;
        private TextBox inventDescNameTxtbox;
        private Panel inventAddForm;
        private Panel inventAddContinPanel;
        private Button inventAddContinBtn;
        private Label inventAddContLabel;
        private NumericUpDown inventPriceTxtbox;
        private NumericUpDown inventQtyTxtbox;
        private Button inventAddAddBtn;
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
        private Button inventSearchBtn;
        private Button inventEditBtn;
        private TabPage userPage;
        private Label loginTitle;
        private TextBox userUsrField;
        private Label loginUserTitle;
        private Label loginPasswordTitle;
        private TextBox userPassField;
        private Button userLoginBtn;
        private Panel loginPanel;
        private TabPage profilePage;
        private Label profileTitle;
        private Panel profilePanel;
        private Button profileLogout;
        private Label profileHireDate;
        private Label profileID;
        private Label profileName;
        private Button inventCancelBtn;
        private Button reportsProducts;
        private Button reportCategories;
        private Button reportEmployee;
        private Panel reportMenuPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private DataGridView reportsGrid;
        private Label reportStartTitle;
        private DateTimePicker reportStartDate;
        private Label reportEndTitle;
        private DateTimePicker reportEndDate;
        private Button forecastTab;
        private TabPage forecastPage;
        private Label forecastDropdownTitle;
        private ComboBox forecastDropDown;
        private Panel forcastMenuPanel;
        private Button forecastCategoriesBtn;
        private Button forecastProductBtn;
        private Panel forcasrSettingPanel;
        private Label forecastEndDate;
        private DateTimePicker forecastEndDate2;
        private DateTimePicker forecastStartDate;
        private Label forecastStartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart forecastChart;
        private ComboBox inventAddCateBox;
        private Label inventPriceLabel;
        private Label inventQtyLabel;
        private Label inventCateLabel;
        private Label inventNameLabel;
        private Label inventFormLabel;
        private TextBox inventNameTxtbox;
        private NumericUpDown inventDescPriceTextbox;
        private Button inventAddCancelBtn;
        private Panel salesOldOrderPanel;
        private Button salesOldPay;
        private Button salesCancel;
        private Label salesOldOrderTitle;
        private DateTimePicker salesTimePicker;
        private Button salesOldOrder;
        private Button reportCSVBtn;
        private Button forecastCSVBtn;
        private Button forcastEmailSCV;
        private Label HomeTitleLabel;
        private Label inventButtonLabel;
        private Label salesQTYLabel;
        private Button searchAllBtn;
        private Label label1;
    }
}

