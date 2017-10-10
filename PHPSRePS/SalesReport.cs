using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using MySql.Data.MySqlClient;

namespace PHPSRePS
{
    public class SalesReport : Report
    {
        struct ProductReport
        {
            public string productName;
            public string categoryName;
            public float unitPrice;
            public int quantitySold;
            public float totalRevenue;
        };

        struct EmployeeReport
        {
            public string employeeName;
            public int salesCount;
            public float totalRevenue;
        };

        struct CategoryReport
        {
            public string categoryName;
            public int salesCount;
            public float totalRevenue;
        };

        private List<ProductReport> _productReportList = new List<ProductReport>();
        private List<EmployeeReport> _employeeReportList = new List<EmployeeReport>();
        private List<CategoryReport> _categoryReportList = new List<CategoryReport>();

        // OUTPUT DATA SET
        // GET ALL DATA FROM HERE
        // REFER TO ProductReport, EmployeeReport, CategoryReport STRUCTS FOR FORMAT
        public List<ProductReport> ProductSalesReport { get => _productReportList; set => _productReportList = value; }
        public List<EmployeeReport> EmployeeSalesReport { get => _employeeReportList; set => _employeeReportList = value; }
        public List<CategoryReport> CategorySalesReport { get => _categoryReportList; set => _categoryReportList = value; }

        Database database = new Database();

        public SalesReport(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        // CALL THIS ONLY
        // load data from the database into local lists
        public void LoadReport(DateTime startDate, DateTime endDate)
        {
            PopulateReportList("product", startDate, endDate);
            PopulateReportList("employee", startDate, endDate);
            PopulateReportList("category", startDate, endDate);
        }

        public void PopulateReportList(string groupBy, DateTime startDate, DateTime endDate)
        {
            database.OpenConnection();

            string query = database.generateSalesReportQuery(groupBy, startDate, endDate);
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (groupBy)
                {
                    case "product":
                        ProductReport productReport;
                        productReport.productName = reader.GetString("Product");
                        productReport.categoryName = reader.GetString("Category");
                        productReport.unitPrice = reader.GetFloat("Unit Price");
                        productReport.quantitySold = reader.GetInt32("Quantity Sold");
                        productReport.totalRevenue = reader.GetFloat("Total Revenue");
                        ProductSalesReport.Add(productReport);
                        break;
                    case "employee":
                        EmployeeReport employeeReport;
                        employeeReport.employeeName = reader.GetString("Employee");
                        employeeReport.salesCount = reader.GetInt32("No. of Sales");
                        employeeReport.totalRevenue = reader.GetFloat("Total Revenue");
                        EmployeeSalesReport.Add(employeeReport);
                        break;
                    case "category":
                        CategoryReport categoryReport;
                        categoryReport.categoryName = reader.GetString("Category");
                        categoryReport.salesCount = reader.GetInt32("No. of Sales");
                        categoryReport.totalRevenue = reader.GetFloat("Total Revenue");
                        CategorySalesReport.Add(categoryReport);
                        break;
                    default:
                        break;
                }
            }

            database.CloseConnection();
        }

        // export data to 3 separate csv files for product sales, employee sales and category sales
        public override void ExportToCSV()
        {
            StringBuilder productSalesCSVData = new StringBuilder();
            StringBuilder employeeSalesCSVData = new StringBuilder();
            StringBuilder categorySalesCSVData = new StringBuilder();

            String productSalesCSVPath = AppDomain.CurrentDomain.BaseDirectory + "\\reports\\product_sales_report" + StartDate.ToShortDateString() + "-" + EndDate.ToShortDateString() + ".csv";
            String employeeSalesCSVPath = AppDomain.CurrentDomain.BaseDirectory + "\\reports\\employee_sales_report" + StartDate.ToShortDateString() + "-" + EndDate.ToShortDateString() + ".csv";
            String categorySalesCSVPath = AppDomain.CurrentDomain.BaseDirectory + "\\reports\\category_sales_report" + StartDate.ToShortDateString() + "-" + EndDate.ToShortDateString() + ".csv";

            productSalesCSVData.AppendLine("'Product', 'Category', 'Unit Price', 'Quantity Sold', 'Total Revenue'");
            foreach (ProductReport productReport in ProductSalesReport)
            {
                productSalesCSVData.AppendFormat("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}'", productReport.productName, productReport.categoryName, productReport.unitPrice, productReport.quantitySold, productReport.totalRevenue);
                productSalesCSVData.AppendLine();
            }

            employeeSalesCSVData.AppendLine("'Employee', 'No. of Sales', 'Total Revenue'");
            foreach (EmployeeReport employeeReport in EmployeeSalesReport)
            {
                employeeSalesCSVData.AppendFormat("'{0}', '{1}', '{2}'", employeeReport.employeeName, employeeReport.salesCount, employeeReport.totalRevenue);
                employeeSalesCSVData.AppendLine();
            }

            categorySalesCSVData.AppendLine("'Category', 'No. of Sales', 'Total Revenue'");
            foreach (CategoryReport categoryReport in CategorySalesReport)
            {
                categorySalesCSVData.AppendFormat("'{0}', '{1}', '{2}'", categoryReport.categoryName, categoryReport.salesCount, categoryReport.totalRevenue);
                categorySalesCSVData.AppendLine();
            }

            File.AppendAllText(productSalesCSVPath, productSalesCSVData.ToString());
            File.AppendAllText(employeeSalesCSVPath, employeeSalesCSVData.ToString());
            File.AppendAllText(categorySalesCSVPath, categorySalesCSVData.ToString());
        }
    }
}
