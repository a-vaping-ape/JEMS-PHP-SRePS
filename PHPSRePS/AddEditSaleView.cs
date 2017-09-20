using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PHPSRePS {
    public partial class AddEditSaleView : Form {
        // the sale to be added or edited
        Sale currentSale = new Sale();

        // database
        Database database = new Database("", "", "", "");

        // main constructor
        public AddEditSaleView(int saleID) {
            InitializeComponent();

            currentSale.Id = saleID;

            if (currentSale.Id != 0) {
                PopulateFields();
            }
        }

        public enum Action
        {
            Add,
            Edit
        };

        // store information in local object and save to db
        public void StoreInformation(Action action)
        {
            database.OpenConnection();
            string query = "";

            // populate with user input from UI
            currentSale.Date = "";
            currentSale.Employee = "";

            // save to db
            switch (action)
            {
                case Action.Add: // save the info provided by the user in the fields into the database as a new entry
                    query = currentSale.GetINSERT();
                    break;
                case Action.Edit: // update the info provided by the user in the fields into the database
                    query = currentSale.GetUPDATE();
                    break;
            }

            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
        }

        // pre-populate the fields using data from the database associated with the selected saleID
        private void PopulateFields() {
            database.OpenConnection();
            string query = database.generateQuery("All Products"); // hmmmmm
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);

            // search database table for product with the supplied productId and populate object fields with the product's data
            currentSale.Date = "";
            currentSale.Employee = "";

            // add code here to fill textfields in the UI with loaded data inside currentProduct (update entry with the ID of currentProduct.Id)

        }

        private void ClearFields() {
            // set each field in the UI to blank
        }
    }
}
