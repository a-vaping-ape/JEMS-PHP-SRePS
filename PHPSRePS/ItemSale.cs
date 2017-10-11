using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS
{
    public class ItemSale : HasSQLTable
    {
        // class fields
        private int _saleID;
        private int _productID;
        private int _quantity;

        // mysql query constants
        private const string _SQLTable = "itemsales";
        private const string _SQLcols = _SQLTable + "(SalesID,ProductID,Quantity)";

        // constructor to init data
        public ItemSale(int saleID, int productID, int quantity)
        {
            SaleID = saleID;
            ProductID = productID;
            Quantity = quantity;
        }

        // empty constructor
        public ItemSale()
        {

        }

        // class properties
        public int SaleID { get => _saleID; set => _saleID = value; }
        public int ProductID { get => _productID; set => _productID = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        #region mysql methods
        // gets columns used by the mySQL table
        private string GetSQLValues()
        {
            return "'" + SaleID.ToString() + "','" + ProductID.ToString() + "','" + Quantity + "'";
        }

        // returns a mySQL INSERT statement
        override public string GetINSERT()
        {
            return base.GetINSERT(_SQLcols, GetSQLValues());
        }
        #endregion
    }
}
