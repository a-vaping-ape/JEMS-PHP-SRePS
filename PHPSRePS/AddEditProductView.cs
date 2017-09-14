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
        Product workingProduct = new Product();

        // main constructor
        public AddEditProductView(int productId) {
            InitializeComponent();

            workingProduct.Id = productId;

            if (workingProduct.Id == 0) {
                Add();
            } else {
                Edit();
            }
        }

        private void Add() {
            // add code to connect to database here

            // populate with user input
            workingProduct.Name = "";
            workingProduct.Category = "";
            workingProduct.Price = 0;
            workingProduct.Stock = 0;
            workingProduct.Discontinued = false;

            // add code to send data to database here as a new entry
        }

        private void Edit() {
            // add code to connect to database here

            // search database table for product with the supplied productId and populate object fields with the product's data
            workingProduct.Name = "";
            workingProduct.Category = "";
            workingProduct.Price = 0;
            workingProduct.Stock = 0;
            workingProduct.Discontinued = false;

            // add code here to fill textfields with loaded data inside toAddEdit

            // add code to update data in the database here
        }

        private void Delete() {  // not a requirement but you can add this feature if you want
            // add code to connect to database here

            // add code to delete entry from the database here
        }

        private void ClearFields() {
            // set each field in the UI to blank
        }
    }
}
