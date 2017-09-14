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
        }

        // navigate to the inventory view
        private void OpenInventory(object sender, EventArgs e) {
            new InventoryView().ShowDialog();
        }

        // navigate to the sales view
        private void OpenSales(object sender, EventArgs e) {
            new SalesView().ShowDialog();
        }

        // navigate to the create sales report view
        private void OpenCreateSalesReport(object sender, EventArgs e) {
            new CreateReportView().ShowDialog();
        }

        // close the application
        private void CloseApp(object sender, EventArgs e) {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
