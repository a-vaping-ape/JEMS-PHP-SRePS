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
    public partial class SalesView : Form {
        List<Sales> salesList = new List<Sales>();
            
        public SalesView() {
            InitializeComponent();
            LoadSales();
        }

        private void LoadSales() {
            string query = "select * from t_user";  
            MySqlConnection myConnection = new MySqlConnection("server=XX;user id=XX;password=XX;database=XX");  
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);  
            myConnection.Open();  
            myCommand.ExecuteNonQuery();  
            MySqlDataReader myDataReader = myCommand.ExecuteReader();  
            string XX = "";  
            
            while (myDataReader.Read() == true)  
            {  
                sales.id = 0;
                sales.date ="";
                sales.employee ="";
                
                saleslist.add(product);
            }
            
            myDataReader.Close();  
            myConnection.Close();  
        }

        private void DisplayAllSales() {
            foreach(Sales sales in saleslist){
            }
        }

        private void AddSale(object sender, EventArgs e) {
            int salesId = 0;
            new AddEditSaleView(SalestId).ShowDialog();
        }

        private void EditSale() {
            int salesId = 1;
            new AddEditSaleView(SalestId).ShowDialog();
        }
    }
}
