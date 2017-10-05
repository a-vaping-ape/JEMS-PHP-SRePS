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
            this.sidebar = new System.Windows.Forms.Panel();
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
            this.salesSearchButton = new System.Windows.Forms.Button();
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
            this.inventPage = new System.Windows.Forms.TabPage();
            this.inventEditBtn = new System.Windows.Forms.Button();
            this.inventSearchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventAddNew = new System.Windows.Forms.Button();
            this.InventDescription = new System.Windows.Forms.Label();
            this.inventDataList = new System.Windows.Forms.DataGridView();
            this.inventSearchBar = new System.Windows.Forms.TextBox();
            this.reportsPage = new System.Windows.Forms.TabPage();
            this.reportTestBtn2 = new System.Windows.Forms.Button();
            this.reportTestBtn = new System.Windows.Forms.Button();
            this.reportSendReportBtn = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.tabView.SuspendLayout();
            this.homePage.SuspendLayout();
            this.salesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTranList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataList)).BeginInit();
            this.inventPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDataList)).BeginInit();
            this.reportsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebar.Controls.Add(this.homeTab);
            this.sidebar.Controls.Add(this.reportsTab);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.inventTab);
            this.sidebar.Controls.Add(this.salesTab);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(172, 1662);
            this.sidebar.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.BackgroundImage = global::PHPSRePS.Properties.Resources.Home;
            this.homeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeTab.FlatAppearance.BorderSize = 0;
            this.homeTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeTab.ForeColor = System.Drawing.Color.Transparent;
            this.homeTab.Location = new System.Drawing.Point(0, 1485);
            this.homeTab.Margin = new System.Windows.Forms.Padding(0);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(172, 177);
            this.homeTab.TabIndex = 3;
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // reportsTab
            // 
            this.reportsTab.BackColor = System.Drawing.Color.SteelBlue;
            this.reportsTab.BackgroundImage = global::PHPSRePS.Properties.Resources.Reports;
            this.reportsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportsTab.FlatAppearance.BorderSize = 0;
            this.reportsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsTab.ForeColor = System.Drawing.Color.Transparent;
            this.reportsTab.Location = new System.Drawing.Point(0, 354);
            this.reportsTab.Margin = new System.Windows.Forms.Padding(0);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Size = new System.Drawing.Size(172, 177);
            this.reportsTab.TabIndex = 2;
            this.reportsTab.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(172, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2708, 1662);
            this.panel1.TabIndex = 1;
            // 
            // inventTab
            // 
            this.inventTab.BackgroundImage = global::PHPSRePS.Properties.Resources.Inventory;
            this.inventTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventTab.FlatAppearance.BorderSize = 0;
            this.inventTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventTab.ForeColor = System.Drawing.Color.Transparent;
            this.inventTab.Location = new System.Drawing.Point(0, 177);
            this.inventTab.Margin = new System.Windows.Forms.Padding(0);
            this.inventTab.Name = "inventTab";
            this.inventTab.Size = new System.Drawing.Size(172, 177);
            this.inventTab.TabIndex = 1;
            this.inventTab.UseVisualStyleBackColor = true;
            // 
            // salesTab
            // 
            this.salesTab.BackColor = System.Drawing.Color.SteelBlue;
            this.salesTab.BackgroundImage = global::PHPSRePS.Properties.Resources.Sales;
            this.salesTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesTab.FlatAppearance.BorderSize = 0;
            this.salesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesTab.ForeColor = System.Drawing.Color.Transparent;
            this.salesTab.Location = new System.Drawing.Point(0, 0);
            this.salesTab.Margin = new System.Windows.Forms.Padding(0);
            this.salesTab.Name = "salesTab";
            this.salesTab.Size = new System.Drawing.Size(172, 177);
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
            this.tabView.ItemSize = new System.Drawing.Size(0, 1);
            this.tabView.Location = new System.Drawing.Point(172, 2);
            this.tabView.Margin = new System.Windows.Forms.Padding(0);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(2708, 1660);
            this.tabView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabView.TabIndex = 1;
            // 
            // homePage
            // 
            this.homePage.Controls.Add(this.powerButton);
            this.homePage.Controls.Add(this.userButton);
            this.homePage.Location = new System.Drawing.Point(4, 5);
            this.homePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(2700, 1651);
            this.homePage.TabIndex = 3;
            this.homePage.Text = "Home";
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.Transparent;
            this.powerButton.BackgroundImage = global::PHPSRePS.Properties.Resources.Power_Icon;
            this.powerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.powerButton.FlatAppearance.BorderSize = 0;
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.ForeColor = System.Drawing.Color.Black;
            this.powerButton.Location = new System.Drawing.Point(2628, 0);
            this.powerButton.Margin = new System.Windows.Forms.Padding(0);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(60, 62);
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
            this.userButton.Location = new System.Drawing.Point(2516, 1462);
            this.userButton.Margin = new System.Windows.Forms.Padding(0);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(172, 177);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "Username";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userButton.UseVisualStyleBackColor = false;
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
            this.salesPage.Controls.Add(this.salesSearchButton);
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
            this.salesPage.Location = new System.Drawing.Point(4, 5);
            this.salesPage.Margin = new System.Windows.Forms.Padding(0);
            this.salesPage.Name = "salesPage";
            this.salesPage.Size = new System.Drawing.Size(2700, 1651);
            this.salesPage.TabIndex = 0;
            this.salesPage.Text = "tabPage1";
            this.salesPage.UseVisualStyleBackColor = true;
            // 
            // salesTranList
            // 
            this.salesTranList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesTranList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesTranList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesTranList.Location = new System.Drawing.Point(1724, 135);
            this.salesTranList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesTranList.Name = "salesTranList";
            this.salesTranList.ReadOnly = true;
            this.salesTranList.Size = new System.Drawing.Size(849, 998);
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
            this.salesAddBtn.Location = new System.Drawing.Point(1444, 1177);
            this.salesAddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.salesAddBtn.Name = "salesAddBtn";
            this.salesAddBtn.Size = new System.Drawing.Size(168, 108);
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
            this.salesPayButton.Location = new System.Drawing.Point(2444, 1506);
            this.salesPayButton.Margin = new System.Windows.Forms.Padding(0);
            this.salesPayButton.Name = "salesPayButton";
            this.salesPayButton.Size = new System.Drawing.Size(200, 85);
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
            this.cancelButton.Location = new System.Drawing.Point(1737, 1509);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 85);
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
            this.salesTotalNum.Location = new System.Drawing.Point(2442, 1191);
            this.salesTotalNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesTotalNum.Name = "salesTotalNum";
            this.salesTotalNum.Size = new System.Drawing.Size(199, 55);
            this.salesTotalNum.TabIndex = 35;
            this.salesTotalNum.Text = "$000.00";
            // 
            // salesTotal
            // 
            this.salesTotal.AutoSize = true;
            this.salesTotal.BackColor = System.Drawing.Color.Transparent;
            this.salesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotal.ForeColor = System.Drawing.Color.Black;
            this.salesTotal.Location = new System.Drawing.Point(1726, 1191);
            this.salesTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesTotal.Name = "salesTotal";
            this.salesTotal.Size = new System.Drawing.Size(407, 55);
            this.salesTotal.TabIndex = 34;
            this.salesTotal.Text = "Transaction Total:";
            // 
            // salesLine
            // 
            this.salesLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesLine.Location = new System.Drawing.Point(1670, 32);
            this.salesLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesLine.Name = "salesLine";
            this.salesLine.Size = new System.Drawing.Size(3, 1588);
            this.salesLine.TabIndex = 33;
            // 
            // salesTransList
            // 
            this.salesTransList.Location = new System.Drawing.Point(1724, 137);
            this.salesTransList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesTransList.Name = "salesTransList";
            this.salesTransList.Size = new System.Drawing.Size(918, 996);
            this.salesTransList.TabIndex = 32;
            this.salesTransList.UseCompatibleStateImageBehavior = false;
            // 
            // salesTransLabel
            // 
            this.salesTransLabel.AutoSize = true;
            this.salesTransLabel.BackColor = System.Drawing.Color.Transparent;
            this.salesTransLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTransLabel.ForeColor = System.Drawing.Color.Black;
            this.salesTransLabel.Location = new System.Drawing.Point(1726, 32);
            this.salesTransLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesTransLabel.Name = "salesTransLabel";
            this.salesTransLabel.Size = new System.Drawing.Size(440, 64);
            this.salesTransLabel.TabIndex = 31;
            this.salesTransLabel.Text = "Transaction List";
            // 
            // salesSearchButton
            // 
            this.salesSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesSearchButton.BackgroundImage = global::PHPSRePS.Properties.Resources.Search_Icon;
            this.salesSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesSearchButton.FlatAppearance.BorderSize = 0;
            this.salesSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesSearchButton.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesSearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.salesSearchButton.Location = new System.Drawing.Point(1444, 37);
            this.salesSearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.salesSearchButton.Name = "salesSearchButton";
            this.salesSearchButton.Size = new System.Drawing.Size(57, 58);
            this.salesSearchButton.TabIndex = 30;
            this.salesSearchButton.UseCompatibleTextRendering = true;
            this.salesSearchButton.UseVisualStyleBackColor = false;
            // 
            // searchZBtn
            // 
            this.searchZBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchZBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchZBtn.FlatAppearance.BorderSize = 0;
            this.searchZBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchZBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchZBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchZBtn.Location = new System.Drawing.Point(1092, 1472);
            this.searchZBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchZBtn.Name = "searchZBtn";
            this.searchZBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchYBtn.Location = new System.Drawing.Point(945, 1472);
            this.searchYBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchYBtn.Name = "searchYBtn";
            this.searchYBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchXBtn.Location = new System.Drawing.Point(796, 1472);
            this.searchXBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchXBtn.Name = "searchXBtn";
            this.searchXBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchWBtn.Location = new System.Drawing.Point(648, 1472);
            this.searchWBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchWBtn.Name = "searchWBtn";
            this.searchWBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchVBtn.Location = new System.Drawing.Point(502, 1472);
            this.searchVBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchVBtn.Name = "searchVBtn";
            this.searchVBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchUBtn.Location = new System.Drawing.Point(356, 1472);
            this.searchUBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchUBtn.Name = "searchUBtn";
            this.searchUBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchTBtn.Location = new System.Drawing.Point(207, 1472);
            this.searchTBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchTBtn.Name = "searchTBtn";
            this.searchTBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchSBtn.Location = new System.Drawing.Point(56, 1472);
            this.searchSBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchSBtn.Name = "searchSBtn";
            this.searchSBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchRBtn.Location = new System.Drawing.Point(1240, 1325);
            this.searchRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchRBtn.Name = "searchRBtn";
            this.searchRBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchQBtn.Location = new System.Drawing.Point(1092, 1325);
            this.searchQBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchQBtn.Name = "searchQBtn";
            this.searchQBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchPBtn.Location = new System.Drawing.Point(945, 1325);
            this.searchPBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchPBtn.Name = "searchPBtn";
            this.searchPBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchOBtn.Location = new System.Drawing.Point(796, 1325);
            this.searchOBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchOBtn.Name = "searchOBtn";
            this.searchOBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchNBtn.Location = new System.Drawing.Point(648, 1325);
            this.searchNBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchNBtn.Name = "searchNBtn";
            this.searchNBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchMBtn.Location = new System.Drawing.Point(502, 1325);
            this.searchMBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchMBtn.Name = "searchMBtn";
            this.searchMBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchLBtn.Location = new System.Drawing.Point(356, 1325);
            this.searchLBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchLBtn.Name = "searchLBtn";
            this.searchLBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchKBtn.Location = new System.Drawing.Point(207, 1325);
            this.searchKBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchKBtn.Name = "searchKBtn";
            this.searchKBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchJBtn.Location = new System.Drawing.Point(56, 1325);
            this.searchJBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchJBtn.Name = "searchJBtn";
            this.searchJBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchIBtn.Location = new System.Drawing.Point(1240, 1177);
            this.searchIBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchIBtn.Name = "searchIBtn";
            this.searchIBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchHBtn.Location = new System.Drawing.Point(1092, 1177);
            this.searchHBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchHBtn.Name = "searchHBtn";
            this.searchHBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchGBtn.Location = new System.Drawing.Point(945, 1177);
            this.searchGBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchGBtn.Name = "searchGBtn";
            this.searchGBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchFBtn.Location = new System.Drawing.Point(796, 1177);
            this.searchFBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchFBtn.Name = "searchFBtn";
            this.searchFBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchEBtn.Location = new System.Drawing.Point(648, 1177);
            this.searchEBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchEBtn.Name = "searchEBtn";
            this.searchEBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchDBtn.Location = new System.Drawing.Point(502, 1177);
            this.searchDBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchDBtn.Name = "searchDBtn";
            this.searchDBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchCBtn.Location = new System.Drawing.Point(356, 1177);
            this.searchCBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchCBtn.Name = "searchCBtn";
            this.searchCBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchBBtn.Location = new System.Drawing.Point(207, 1177);
            this.searchBBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBBtn.Name = "searchBBtn";
            this.searchBBtn.Size = new System.Drawing.Size(105, 108);
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
            this.searchABtn.Location = new System.Drawing.Point(56, 1177);
            this.searchABtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchABtn.Name = "searchABtn";
            this.searchABtn.Size = new System.Drawing.Size(105, 108);
            this.searchABtn.TabIndex = 4;
            this.searchABtn.Text = "A";
            this.searchABtn.UseCompatibleTextRendering = true;
            this.searchABtn.UseVisualStyleBackColor = false;
            this.searchABtn.Click += new System.EventHandler(this.searchABtn_Click);
            // 
            // horizontalLine
            // 
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine.Location = new System.Drawing.Point(27, 111);
            this.horizontalLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(1604, 3);
            this.horizontalLine.TabIndex = 2;
            // 
            // salesDataList
            // 
            this.salesDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesDataList.Location = new System.Drawing.Point(56, 137);
            this.salesDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesDataList.Name = "salesDataList";
            this.salesDataList.ReadOnly = true;
            this.salesDataList.Size = new System.Drawing.Size(1557, 998);
            this.salesDataList.TabIndex = 1;
            this.salesDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataList_CellClick);
            this.salesDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataList_CellContentClick);
            // 
            // salesSearchBox
            // 
            this.salesSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesSearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.salesSearchBox.Location = new System.Drawing.Point(180, 42);
            this.salesSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesSearchBox.Name = "salesSearchBox";
            this.salesSearchBox.Size = new System.Drawing.Size(1258, 53);
            this.salesSearchBox.TabIndex = 0;
            this.salesSearchBox.Text = "Search product name here";
            this.salesSearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.salesSearchBox_MouseClick);
            this.salesSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salesSearchBox_KeyPress);
            // 
            // inventPage
            // 
            this.inventPage.Controls.Add(this.inventEditBtn);
            this.inventPage.Controls.Add(this.inventSearchBtn);
            this.inventPage.Controls.Add(this.dataGridView1);
            this.inventPage.Controls.Add(this.inventAddNew);
            this.inventPage.Controls.Add(this.InventDescription);
            this.inventPage.Controls.Add(this.inventDataList);
            this.inventPage.Controls.Add(this.inventSearchBar);
            this.inventPage.Location = new System.Drawing.Point(4, 5);
            this.inventPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventPage.Name = "inventPage";
            this.inventPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventPage.Size = new System.Drawing.Size(2700, 1651);
            this.inventPage.TabIndex = 1;
            this.inventPage.Text = "Inventory";
            this.inventPage.UseVisualStyleBackColor = true;
            // 
            // inventEditBtn
            // 
            this.inventEditBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.inventEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventEditBtn.FlatAppearance.BorderSize = 0;
            this.inventEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventEditBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.inventEditBtn.Location = new System.Drawing.Point(1411, 948);
            this.inventEditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventEditBtn.Name = "inventEditBtn";
            this.inventEditBtn.Size = new System.Drawing.Size(120, 93);
            this.inventEditBtn.TabIndex = 38;
            this.inventEditBtn.Text = "Edit Item";
            this.inventEditBtn.UseCompatibleTextRendering = true;
            this.inventEditBtn.UseVisualStyleBackColor = false;
            // 
            // inventSearchBtn
            // 
            this.inventSearchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventSearchBtn.BackgroundImage = global::PHPSRePS.Properties.Resources.Search_Icon;
            this.inventSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventSearchBtn.FlatAppearance.BorderSize = 0;
            this.inventSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventSearchBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.inventSearchBtn.Location = new System.Drawing.Point(939, 16);
            this.inventSearchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventSearchBtn.Name = "inventSearchBtn";
            this.inventSearchBtn.Size = new System.Drawing.Size(38, 38);
            this.inventSearchBtn.TabIndex = 37;
            this.inventSearchBtn.UseCompatibleTextRendering = true;
            this.inventSearchBtn.UseVisualStyleBackColor = false;
            this.inventSearchBtn.Click += new System.EventHandler(this.inventSearchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1169, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 849);
            this.dataGridView1.TabIndex = 36;
            // 
            // inventAddNew
            // 
            this.inventAddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventAddNew.FlatAppearance.BorderSize = 0;
            this.inventAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventAddNew.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventAddNew.ForeColor = System.Drawing.Color.Transparent;
            this.inventAddNew.Location = new System.Drawing.Point(18, 948);
            this.inventAddNew.Margin = new System.Windows.Forms.Padding(0);
            this.inventAddNew.Name = "inventAddNew";
            this.inventAddNew.Size = new System.Drawing.Size(180, 143);
            this.inventAddNew.TabIndex = 34;
            this.inventAddNew.Text = "Add new product";
            this.inventAddNew.UseCompatibleTextRendering = true;
            this.inventAddNew.UseVisualStyleBackColor = false;
            this.inventAddNew.Click += new System.EventHandler(this.addNewProduct_Click);
            // 
            // InventDescription
            // 
            this.InventDescription.AutoSize = true;
            this.InventDescription.BackColor = System.Drawing.Color.Transparent;
            this.InventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventDescription.ForeColor = System.Drawing.Color.Black;
            this.InventDescription.Location = new System.Drawing.Point(1162, 16);
            this.InventDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InventDescription.Name = "InventDescription";
            this.InventDescription.Size = new System.Drawing.Size(320, 64);
            this.InventDescription.TabIndex = 32;
            this.InventDescription.Text = "Description";
            // 
            // inventDataList
            // 
            this.inventDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventDataList.Location = new System.Drawing.Point(18, 74);
            this.inventDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventDataList.Name = "inventDataList";
            this.inventDataList.Size = new System.Drawing.Size(1111, 849);
            this.inventDataList.TabIndex = 2;
            this.inventDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventDataList_CellContentClick);
            // 
            // inventSearchBar
            // 
            this.inventSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventSearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inventSearchBar.Location = new System.Drawing.Point(172, 16);
            this.inventSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventSearchBar.Name = "inventSearchBar";
            this.inventSearchBar.Size = new System.Drawing.Size(764, 53);
            this.inventSearchBar.TabIndex = 1;
            this.inventSearchBar.Text = "Search product name here";
            this.inventSearchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventSearchBar_Click);
            this.inventSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inventSearchBar_KeyPress);
            // 
            // reportsPage
            // 
            this.reportsPage.Controls.Add(this.reportTestBtn2);
            this.reportsPage.Controls.Add(this.reportTestBtn);
            this.reportsPage.Controls.Add(this.reportSendReportBtn);
            this.reportsPage.Location = new System.Drawing.Point(4, 5);
            this.reportsPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportsPage.Name = "reportsPage";
            this.reportsPage.Size = new System.Drawing.Size(2700, 1651);
            this.reportsPage.TabIndex = 2;
            this.reportsPage.Text = "Reports";
            this.reportsPage.UseVisualStyleBackColor = true;
            // 
            // reportTestBtn2
            // 
            this.reportTestBtn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportTestBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportTestBtn2.FlatAppearance.BorderSize = 0;
            this.reportTestBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportTestBtn2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTestBtn2.ForeColor = System.Drawing.Color.Transparent;
            this.reportTestBtn2.Location = new System.Drawing.Point(74, 345);
            this.reportTestBtn2.Margin = new System.Windows.Forms.Padding(0);
            this.reportTestBtn2.Name = "reportTestBtn2";
            this.reportTestBtn2.Size = new System.Drawing.Size(201, 108);
            this.reportTestBtn2.TabIndex = 15;
            this.reportTestBtn2.Text = "Test button 2";
            this.reportTestBtn2.UseCompatibleTextRendering = true;
            this.reportTestBtn2.UseVisualStyleBackColor = false;
            // 
            // reportTestBtn
            // 
            this.reportTestBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportTestBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportTestBtn.FlatAppearance.BorderSize = 0;
            this.reportTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportTestBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTestBtn.ForeColor = System.Drawing.Color.Transparent;
            this.reportTestBtn.Location = new System.Drawing.Point(74, 195);
            this.reportTestBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reportTestBtn.Name = "reportTestBtn";
            this.reportTestBtn.Size = new System.Drawing.Size(201, 108);
            this.reportTestBtn.TabIndex = 14;
            this.reportTestBtn.Text = "Test button 1";
            this.reportTestBtn.UseCompatibleTextRendering = true;
            this.reportTestBtn.UseVisualStyleBackColor = false;
            // 
            // reportSendReportBtn
            // 
            this.reportSendReportBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportSendReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportSendReportBtn.FlatAppearance.BorderSize = 0;
            this.reportSendReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportSendReportBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportSendReportBtn.ForeColor = System.Drawing.Color.Transparent;
            this.reportSendReportBtn.Location = new System.Drawing.Point(74, 46);
            this.reportSendReportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reportSendReportBtn.Name = "reportSendReportBtn";
            this.reportSendReportBtn.Size = new System.Drawing.Size(201, 108);
            this.reportSendReportBtn.TabIndex = 13;
            this.reportSendReportBtn.Text = "Send Report";
            this.reportSendReportBtn.UseCompatibleTextRendering = true;
            this.reportSendReportBtn.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2606, 1662);
            this.Controls.Add(this.tabView);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventDataList)).EndInit();
            this.reportsPage.ResumeLayout(false);
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
        private System.Windows.Forms.Button reportTestBtn2;
        private System.Windows.Forms.Button reportTestBtn;
        private System.Windows.Forms.Button reportSendReportBtn;

        private System.Windows.Forms.DataGridView salesTranList;
        private System.Windows.Forms.ListView salesTransList;

        private System.Windows.Forms.DataGridView dataGridView1;
        private Button inventSearchBtn;
        private Button inventEditBtn;

    }
}

