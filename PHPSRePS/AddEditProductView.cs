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
    public partial class AddEditProductView : Form {
        // the product to be added or edited
        Product currentProduct = new Product();

        // main constructor
        public AddEditProductView(int productId) {
            InitializeComponent();

            currentProduct.Id = productId;

            if (currentProduct.Id != 0) {
                PopulateFields();
            }
        }

        // save the info provided by the user in the fields into the database as a new entry
        private void SaveNewEntry() {
            // add code to connect to database here

            // populate with user input from UI
            currentProduct.Name = "";
            currentProduct.Category = "";
            currentProduct.Price = 0;
            currentProduct.Stock = 0;
            currentProduct.Discontinued = false;

            // add code to send data to database here as a new entry using data in currentProduct

        }

        // pre-populate the fields using data from the database associated with the selected productID
        private void PopulateFields() {
            // add code to connect to database here

            // search database table for product with the supplied productId and populate object fields with the product's data
            currentProduct.Name = "";
            currentProduct.Category = "";
            currentProduct.Price = 0;
            currentProduct.Stock = 0;
            currentProduct.Discontinued = false;

            // add code here to fill textfields in the UI with loaded data inside currentProduct (update entry with the ID of currentProduct.Id)

        }

        // update the info provided by the user in the fields into the database
        private void SaveEdits() {
            // add code to connect to database here

            // populate with user input from UI
            currentProduct.Name = "";
            currentProduct.Category = "";
            currentProduct.Price = 0;
            currentProduct.Stock = 0;
            currentProduct.Discontinued = false;

            // add code to update data in the database here using data in currentProduct

        }

        // delete the current product from the database
        // not a requirement but you can add this feature if you want
        private void Delete() {  
            // add code to connect to database here

            // add code to delete entry from the database here
        }

        private void ClearFields() {
            // set each field in the UI to blank
        }
    }
}
