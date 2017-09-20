using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS
{
    public class HasSQLTable
    {
        //returns a mySQL INSERT statement called by child classes
        virtual public string GetINSERT(string cols, string values)
        {
            return 
                "INSERT INTO " + cols +
                "VALUES(" +values+ ");";       
        }

        //overloading used by child classes
        virtual public string GetINSERT()
        {
            return "";
        }

        //returns a mySQL DELETE statement
        virtual public string GetDELETE(string table, string ID)
        {
            return
                "DELETE FROM " + table +
                "WHERE ProductID='" + ID + "';";
        }

        virtual public string GetDELETE()
        {
            return "";
        }

        //returns a mySQL UPDATE statement
        virtual public string GetUPDATE(string table,string updateName, string updateValue, string colName,string ID)
        {
            return
                "UPDATE " + table +
                "SET " + updateName + "='" + updateName + "'" +
                "WHERE " + colName + "='" + ID + "';";
        }

        //overloading used by child classes
        virtual public string GetUPDATE()
        {
            return "";
        }

        //returns a mySQL UPDATE statement
        virtual public string GetUPDATE(string updateName, string updateValue)
        {
            return "";
        }
    }
}
