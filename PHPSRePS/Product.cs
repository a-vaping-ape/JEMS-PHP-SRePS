using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS {
    public class Product : HasSQLTable {
        private const string _SQLTable = "products";
        private  const string _SQLcols = _SQLTable+"(ProductID,ProductName,CategoryID,UnitPrice,UnitsInStock,Discontinued)";
        private const string _values = 

        private int _id;
        private string _name;
        private string _category;
        private float _price;
        private int _stock;
        private bool _discontinued;

        public Product() {

        }
        
        public int Id {
            get => _id;
            set => _id = value;
        }

        public string Name {
            get => _name;
            set => _name = value;
        }

        public string Category {
            get => _category;
            set => _category = value;
        }

        public float Price {
            get => _price;
            set => _price = value;
        }

        public int Stock {
            get => _stock;
            set => _stock = value;
        }

        public bool Discontinued {
            get => _discontinued;
            set => _discontinued = value;
        }

        //gets coulombs used by the mySQL table
        private string GetSQLValues()
        {
            return Id.ToString() + "," + Name + "," + 
                   Category + "," + Price.ToString()+"," + 
                   Stock.ToString() + "," + Discontinued.ToString();
        }

        //returns a mySQL INSERT statement
        override public string GetINSERT(){ 
            return base.GetINSERT(_SQLcols, GetSQLValues());
        }

        //returns a mySQL DELETE statement
        override public string GetDELETE(){
            return base.GetDELETE("product", Id.ToString());
        }

        //returns a mySQL UPDATE statement
        public override string GetUPDATE(string updateName, string updateValue)
        {
            return base.GetUPDATE(_SQLTable, updateName, updateValue,"ProductID", Id.ToString());
        }
    }
}
