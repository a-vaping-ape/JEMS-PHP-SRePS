using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS {
   public class Sale {
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
    }
}
