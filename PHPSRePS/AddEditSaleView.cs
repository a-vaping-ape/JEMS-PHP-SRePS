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
    public partial class AddEditSaleView : Form {
        // the sale to be added or edited
        Sale workingSale = new Sale();
        
        // main constructor
        public AddEditSaleView(int saleID) {
            InitializeComponent();

            workingSale.Id = saleID;
            
            if (workingSale.Id == 0) {
                Add();
            } else {
                Edit();
            }
        }

        private void Add() {
            // add code to connect to database here

            // populate with user input
            workingSale.Date = null;
            workingSale.Employee = null;

            // add code to send data to database here as a new entry
        }

        private void Edit(){
            // add code to connect to database here

            // populate with user input
            workingSale.Date = null;
            workingSale.Employee = null;

            // add code here to fill textfields with loaded data inside toAddEdit

            // add code to update data in the database here
        }

        private void Delete() {  // not a requirement but you can add this feature if you want
            // add code to connect to database here
            
            // add code to delete entry from the database here
        }

        private void Clearfield() {
            // set each field in the UI to blank
        }
    }
}
