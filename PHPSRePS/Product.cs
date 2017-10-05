using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        //returns a row that can be used for display purposes
        public DataGridViewRow GetDataGridRow(DataGridView grid)
        {
            if ((grid.Rows.Count - 1) > -1)
            {
                DataGridViewRow row = (DataGridViewRow)grid.Rows[grid.Rows.Count - 1].Clone();
                row.Cells[0].Value = ID;
                row.Cells[1].Value = Name;
                row.Cells[2].Value = Category;
                row.Cells[3].Value = Price;
                row.Cells[4].Value = Stock;
                row.Cells[5].Value = IsDiscontinued;

                return row;
            }

            return null;
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

        public override string GetUPDATE(string table, string updateName, string updateValue, string colName, string ID)
        {
            return base.GetUPDATE(table, updateName, updateValue, colName, ID);
        }
    }
}
