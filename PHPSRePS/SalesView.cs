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
    public partial class SalesView : Form {
        // store all sales to be loaded in this list
        List<Sale> saleList = new List<Sale>();
            
        public SalesView() {
            InitializeComponent();
            LoadSales();
        }

        /* load data from database into saleList */
        private void LoadSales() {
            // add code to connect to database here

            while (/* enter expression to read table here */ true) {
                Sale sale = new Sale();

                // populate with database info
                sale.Id = 0;
                sale.Date = null;
                sale.Employee = null;

                saleList.Add(sale);
            }
        }

        /* display items in productList to the UI */
        private void DisplayAllSales() {
            foreach (Sale sales in saleList) {
                // do something
            }
        }

        /* go to AddEditProductView to add a product */
        private void AddSale(object sender, EventArgs e) {
            int saleId = 0;
            new AddEditSaleView(saleId).ShowDialog();
        }

        /* go to AddEditProductView to edit a product */
        private void EditSale() {
            int saleId = 1;
            new AddEditSaleView(saleId).ShowDialog();
        }
    }
}
