using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPSRePS {
    public partial class MainView : Form {
        // TODO sprint2: implement authorisation + levels of security

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

        // navigate to the inventory view
        private void OpenInventory(object sender, EventArgs e) {
            tabView.SelectTab("inventPage");
            updateTabButtons();
        }

        // navigate to the sales view
        private void OpenSales(object sender, EventArgs e) {
            tabView.SelectTab("salesPage");
            updateTabButtons();
        }

        // navigate to the create sales report view
        private void OpenReports(object sender, EventArgs e) {
            tabView.SelectTab("reportsPage");
            updateTabButtons();
        }

        private void OpenHome(object sender, EventArgs e)
        {
            tabView.SelectTab("homePage");
            updateTabButtons();
        }

        // close the application
        private void CloseApp(object sender, EventArgs e) {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salesSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchABtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
