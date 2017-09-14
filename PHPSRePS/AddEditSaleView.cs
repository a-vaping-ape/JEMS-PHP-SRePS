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
        Sale currentSale = new Sale();

        // main constructor
        public AddEditSaleView(int saleID) {
            InitializeComponent();

            currentSale.Id = saleID;

            if (currentSale.Id != 0) {
                PopulateFields();
            }
        }

        // save the info provided by the user in the fields into the database as a new entry
        private void SaveNewEntry() {
            // add code to connect to database here

            // populate with user input from UI
            currentSale.Date = null;
            currentSale.Employee = null;

            // add code to send data to database here as a new entry using data in currentSale

        }

        // pre-populate the fields using data from the database associated with the selected saleID
        private void PopulateFields() {
            // add code to connect to database here

            // search database table for sale with the supplied saleId and populate object fields with the product's data
            currentSale.Date = null;
            currentSale.Employee = null;

            // add code here to fill textfields in the UI with loaded data inside currentSale (update entry with the ID of currentSale.Id)
        }

        // update the info provided by the user in the fields into the database
        private void SaveEdits() {
            // add code to connect to database here

            // populate with user input from UI
            currentSale.Date = null;
            currentSale.Employee = null;

            // add code to update data in the database here using data in currentSale

        }

        // delete the current sale from the database
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
