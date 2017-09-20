using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PHPSRePS
{
    public partial class AddEditProductView : Form
    {
        // the product to be added or edited
        Product currentProduct = new Product();

        // database
        Database database = new Database("", "", "", "");

        // main constructor
        public AddEditProductView(int productId)
        {
            InitializeComponent();

            currentProduct.Id = productId;

            if (currentProduct.Id != 0)
            {
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
            currentProduct.Name = "";
            currentProduct.Category = "";
            currentProduct.Price = 0;
            currentProduct.Stock = 0;
            currentProduct.Discontinued = false;

            // save to db
            switch (action)
            {
                case Action.Add: // save the info provided by the user in the fields into the database as a new entry
                    query = currentProduct.GetINSERT();
                    break;
                case Action.Edit: // update the info provided by the user in the fields into the database
                    query = currentProduct.GetUPDATE();
                    break;
            }

            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
        }

        // pre-populate the fields using data from the database associated with the selected productID
        public void PopulateFields()
        {
            database.OpenConnection();
            string query = database.generateQuery("All Products"); // hmmmmm
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);

            // search database table for product with the supplied productId and populate object fields with the product's data
            currentProduct.Name = "";
            currentProduct.Category = "";
            currentProduct.Price = 0;
            currentProduct.Stock = 0;
            currentProduct.Discontinued = false;

            // add code here to fill textfields in the UI with loaded data inside currentProduct (update entry with the ID of currentProduct.Id)

        }

        public void ClearFields()
        {
            // set each field in the UI to blank
        }
    }
}
