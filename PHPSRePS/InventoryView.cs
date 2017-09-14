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
    public partial class InventoryView : Form {
        // store all products to be loaded in this list
        List<Product> productList = new List<Product>();

        public InventoryView() {
            InitializeComponent();
            LoadProducts();
        }

        /* load data from database into productList */
        private void LoadProducts() {
            // add code to connect to database here
             
            while (/* enter expression to read table here */ true) {
                Product product = new Product();

                // populate with database info
                product.Id = 0;
                product.Name = "";
                product.Category = "";
                product.Price = 0;
                product.Stock = 0;
                product.Discontinued = false;

                productList.Add(product);
            }
        }

        /* display items in productList to the UI */
        private void DisplayAllProducts() {
            foreach (Product product in productList) {
                // do something
            }
        }

        /* go to AddEditProductView to add a product */
        private void AddProduct(object sender, EventArgs e) {
            int productId = 0;
            new AddEditProductView(productId).ShowDialog();
        }

        /* go to AddEditProductView to edit a product */
        private void EditProduct() {
            int productId = 1;
            //  int productId = Convert.ToInt32(listView1.FocusedItem.Text);
            new AddEditProductView(productId).ShowDialog();
        }
    }
}
