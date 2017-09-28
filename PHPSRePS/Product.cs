using MySql.Data.MySqlClient;

namespace PHPSRePS
{
    public class Product : HasSQLTable
    {
        private const string _SQLTable = "products";
        private  const string _SQLcols = _SQLTable+"(ProductID,ProductName,CategoryID,UnitPrice,UnitsInStock,Discontinued)";
        // private const string _values = 

        private int _id;
        private string _name;
        private string _category;
        private float _price;
        private int _stock;
        private bool _discontinued;

        public int ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Category { get => _category; set => _category = value; }
        public float Price { get => _price; set => _price = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public bool IsDiscontinued { get => _discontinued; set => _discontinued = value; }

        // constructor to init data
        public Product(int id, string name, string category, float price, int stock, bool discontinued)
        {
            this.ID = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Stock = stock;
            this.IsDiscontinued = discontinued;
        }

        // empty constructor
        public Product()
        {

        }

        //gets coulombs used by the mySQL table
        private string GetSQLValues()
        {
            return ID.ToString() + "," + Name + "," + 
                   Category + "," + Price.ToString()+"," + 
                   Stock.ToString() + "," + IsDiscontinued.ToString();
        }

        //returns a mySQL INSERT statement
        override public string GetINSERT()
        { 
            return base.GetINSERT(_SQLcols, GetSQLValues());
        }

        //returns a mySQL DELETE statement
        override public string GetDELETE()
        {
            return base.GetDELETE("product", ID.ToString());
        }

        public override string GetUPDATE()
        {
            Database database = new Database();
            string query = "SELECT CategoryID FROM categories WHERE CategoryName = " + Category;
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            return 
                "UPDATE product" +
                "SET ProductName = '" + Name + "'," +
                "CategoryID = '" + reader.GetInt32("CategoryID") + "'," +
                "UnitPrice = '" + Price + "'," +
                "UnitsInStock = '" + Stock + "'," +
                "Discontinued = '" + (IsDiscontinued ? 1 : 0) + "' " +
                "WHERE ProductID = " + ID;
        }
    }
}
