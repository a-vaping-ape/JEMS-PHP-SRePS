using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPSRePS {
    public partial class CreateReportView : Form {
        // database
        Database database = new Database("", "", "", "");

        public CreateReportView() {
            InitializeComponent();
        }

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

            // set time frame to get data from
            DateTime fromTime = new DateTime(fromYear, fromMonth, fromDay);
            DateTime toTime = new DateTime(toYear, toMonth, toDay);
            
        }

        private void formLoadSalesForecast()
        {

        }
        #endregion

        private void LoadSalesReport(DateTime fromTime, DateTime toTime, string format)
        {

        }

        private void LoadSalesForecast(DateTime fromTime, DateTime toTime, string format) {

        }
    }
}
