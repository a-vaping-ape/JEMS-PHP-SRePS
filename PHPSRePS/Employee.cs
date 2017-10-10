using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS
{
    public class Employee : HasSQLTable
    {
        private const string _SQLTable = "Employee";
        private const string _SQLcols = _SQLTable + "(EmployeeID,FirstName,LastName,IsManager,HireDate,Employed,Username,Password)";

        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private bool _isManager;
        private string _hireDate;
        private bool _employed;
        private string _username;
        private string _password;

        public Employee()
        {

        }

        public Employee(int empID, string firstName, string lastName, bool isManager, string date, bool employed)
        {
            EmployeeID = empID;
            FirstName = firstName;
            LastName = LastName;
            IsManager = isManager;
            HireDate = date;
            Employed = employed;
        }
       
        //on setting the string input is encrypted
        public string Password { get => Password; set => Password = Encrypt(value); }

        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public bool IsManager { get => _isManager; set => _isManager = value; }
        public string HireDate { get => _hireDate; set => _hireDate = value; }
        public string Username { get => _username; set => _username = value; }
        public bool Employed { get => _employed; set => _employed = value; }


        // gets columns used by the mySQL table
        private string GetSQLValues()
        {
            //sales is has an atuo incrementing primary key
            return "NULL,'" + FirstName + "','" + LastName + "','" + IsManager + "'" +
                "','" + HireDate + "','" + Username + "'" + "','" + Password + "';'";

        }

        //gives a hash of the pasword making i
        private string Encrypt(String input)
        {
            return input.GetHashCode().ToString();
        }

        // returns a mySQL INSERT statement
        override public string GetINSERT()
        {
            return base.GetINSERT(_SQLcols, GetSQLValues());
        }

        // returns a mySQL DELETE statement
        public override string GetDELETE()
        {
            return ""; //base.GetDELETE(_SQLTable, ID.ToString());
        }

        public override string GetUPDATE()
        {
            return "";/*
                "UPDATE product" +
                "SET SalesDate = '" + Date + "'," +
                "EmployeeID = '" + 0 + "'," +
                "WHERE SalesID = " + ID;*/
        }
    }
}
