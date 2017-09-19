using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS {
   public class Sale : HasSQLTable {
       private const string _SQLTable = "sales";
       private const string _SQLcols = _SQLTable + "(SalesID,SalesDate,EmployeeID)";

       private int _id;
       private string _date;
       private string _employee;
       
       public Sale() {
       }
       
       public int Id {
         get => _id;
         set => _id = value;          
       }
       
       public string Date {
         get => _date;
         set => _date = value;   
       }
       
       public string Employee {
         get => _employee;
         set => _employee = value;   
       }

        //gets coulombs used by the mySQL table
        private string GetSQLValues()
        {
            return Id.ToString() + "," + Date + "," + Employee;
        }

        //returns a mySQL INSERT statement
        override public string GetINSERT()
        {
            return base.GetINSERT(_SQLcols, GetSQLValues());
        }

        //returns a mySQL DELETE statement
        override public string GetDELETE()
        {
            return base.GetDELETE(_SQLTable, Id.ToString());
        }

        //returns a mySQL UPDATE statement
        public override string GetUPDATE(string updateName, string updateValue)
        {
            return base.GetUPDATE(_SQLTable, updateName, updateValue, "SalesID", Id.ToString());
        }
    }
}
