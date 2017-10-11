using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS
{
    public class Sale : HasSQLTable
    {
        // fields
        private int _id;
        private string _date;
        private string _employee;
        private int _employeeID;
        private List<ItemSale> _itemSaleList = new List<ItemSale>();

        // mysql query constants
        private const string _SQLTable = "sales";
        private const string _SQLcols = _SQLTable + "(SalesID, SalesDate,EmployeeID)";

        public int ID { get => _id; set => _id = value; }
        public string Date { get => _date; set => _date = value; }
        public string Employee { get => _employee; set => _employee = value; }
        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
       
        public List<ItemSale> ItemSaleList { get => _itemSaleList; set => _itemSaleList = value; }

        // constructor to init data
        public Sale(int id, string date, string employee)
        {
            this.ID = id;
            this.Date = date;
            this.Employee = employee;
        }

        // empty constructor - autogenerates data
        public Sale()
        {
            this.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //hard coded for now as this has not been implemented in the GUI
            //this.EmployeeID = 1;

        }

        public string SelectThisObject()
        {
           return "SELECT SalesID FROM sales " +
                "WHERE SalesDate = '" + Date + 
                "' AND " + " EmployeeID = '" + EmployeeID + "';";
        }

        // gets columns used by the mySQL table
        private string GetSQLValues()
        {
            //return ID.ToString() + "," + Date + "," + Employee;
           
            //sales is has an atuo incrementing primary key
            return "NULL,'" + Date + "','" + EmployeeID + "'";
        }

        // returns a mySQL INSERT statement
        override public string GetINSERT()
        {
            return base.GetINSERT(_SQLcols, GetSQLValues());
        }

        // returns a mySQL DELETE statement
        override public string GetDELETE()
        {
            return base.GetDELETE(_SQLTable, ID.ToString());
        }

        // returns a mySQL UPDATE statement
        //public override string GetUPDATE(string updateName, string updateValue)
        //{
        //    return base.GetUPDATE(_SQLTable, updateName, updateValue, "SalesID", Id.ToString());
        //}

        public override string GetUPDATE()
        {
            return
                "UPDATE product" +
                "SET SalesDate = '" + Date + "'," +
                "EmployeeID = '" + 0 + "'," +
                "WHERE SalesID = " + ID;
        }
    }
}
