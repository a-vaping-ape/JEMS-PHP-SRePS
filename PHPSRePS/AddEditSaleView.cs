using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPSRePS {
    public partial class AddEditSaleView : Form {
        Sales workingSales = new workingSales();
        
        public AddEditSaleView(int SalesID) {
            InitializeComponent();
            
            workingSales.Id == SalesId;
            
            if(workingSales.Id == 0) {
                Add();
            }else {
                Edit();
            }
          }
        private void Add(){
            workingSales.date="";
            workingSales.employee="";
        }
        
        private void Edit(){
            workingSales.date="";
            workingSales.employee=""; 
        }
        
        private void Delete(){
            workingSales.date= null;
            workingSales.employee= null; 
        }
        
        private void Clearfield(){
            
        }
    }
}
