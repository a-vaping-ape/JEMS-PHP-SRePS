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
    public partial class CreateReportView : Form {
        private List<Product> _productList = new List<Product>();

        public CreateReportView() {
            InitializeComponent();
        }

        private void GenerateSalesReport(DateTime fromTime, DateTime toTime, string format) {
            // add code here to connect to db

            // add code here to 
        }

        private void GeneratePredictionsReport(DateTime fromTime, DateTime toTime, string format) {

        }
    }
}
