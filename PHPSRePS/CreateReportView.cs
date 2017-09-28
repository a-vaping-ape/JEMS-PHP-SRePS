S using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PHPSRePS {
    public partial class CreateReportView : Form {
        // database
        Database database = new Database("", "", "", "");

        public CreateReportView() {
            InitializeComponent();
        }

        public enum GroupBy
        {
            Employee,
            Product,
            Category
        };

        #region form methods
        private void formLoadSalesReport()
        {
            List<Product> _productList = new List<Product>();

            // add code here to get user input
            int fromYear = 0;
            int fromMonth = 0;
            int fromDay = 0;
            int toYear = 0;
            int toMonth = 0;
            int toDay = 0;
            string format = "";

            // set time frame to get data from
            DateTime fromTime = new DateTime(fromYear, fromMonth, fromDay);
            DateTime toTime = new DateTime(toYear, toMonth, toDay);

            database.OpenConnection();
            string query = "SELECT * FROM products";
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // populate with database info
            }
        }

        private void formLoadSalesForecast()
        {
            
        }
        #endregion

        private void ExportSalesReport(DateTime fromTime, DateTime toTime, string format)
        {
            switch (format)
            {
                case "csv":
                    StringBuilder csvContent = new StringBuilder();
                    String csvPath = "C:\\salesreport.csv";

                    

                    File.AppendAllText(csvPath, csvContent.ToString());
                    break;
                case "pdf":
                    break;
            }
        }

        private void ExportSalesForecast(DateTime fromTime, DateTime toTime, string format)
        {

        }
    }
}
