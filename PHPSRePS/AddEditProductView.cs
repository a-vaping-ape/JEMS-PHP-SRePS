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
        int _productId;
        Product toAddEdit = new Product();

        public AddEditProductView(int productId) {
            InitializeComponent();

            toAddEdit.Id = productId;

            if (toAddEdit.Id == 0) {
                Add();
            } else {
                Edit();
            }
        }

        private void Add() {
            // add code to connect to database here

            // populate with user input
            toAddEdit.Name = "";
            toAddEdit.Category = "";
            toAddEdit.Price = 0;
            toAddEdit.Stock = 0;
            toAddEdit.Discontinued = false;

            // add code to send data to database here
        }

        private void Edit() {
            // add code to connect to database here

            // search database table for product with the supplied productId and populate object fields with the product's data
            toAddEdit.Name = "";
            toAddEdit.Category = "";
            toAddEdit.Price = 0;
            toAddEdit.Stock = 0;
            toAddEdit.Discontinued = false;

            // add code here to fill textfields with loaded data inside toAddEdit
        }

        private void ClearFields() {
            // set each field in the UI to blank
        }
    }
}
