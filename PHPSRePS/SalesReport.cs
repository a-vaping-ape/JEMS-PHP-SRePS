using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;


namespace PHPSRePS
{
    public class SalesReport : Report
    {
        public struct ProductReport
        {
            public string productName;
            public string categoryName;
            public float unitPrice;
            public int quantitySold;
            public float totalRevenue;
        };

        public struct EmployeeReport
        {
            public string employeeName;
            public int salesCount;
            public float totalRevenue;
        };

        public struct CategoryReport
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

        public List<RevenueFormat> GetRevenues(string groupBy)
        {
            List<RevenueFormat> result = new List<RevenueFormat>();
            RevenueFormat format;

            if ((groupBy == "products") && (_categoryReportList.Count > 0))
            {
                foreach (ProductReport report in _productReportList)
                {
                    format = new RevenueFormat();
                    format.Title = report.productName;
                    format.Cost = report.totalRevenue;
                    result.Add(format);
                }
            }
            else if ((groupBy == "employee") && (_employeeReportList.Count > 0))
            {
                foreach (EmployeeReport report in _employeeReportList)
                {
                    format = new RevenueFormat();
                    format.Title = report.employeeName;
                    format.Cost = report.totalRevenue;
                    result.Add(format);
                }
            }
            else if ((groupBy == "category") && (_productReportList.Count > 0))
            {
                foreach (CategoryReport report in _categoryReportList)
                {
                    format = new RevenueFormat();
                    format.Title = report.categoryName;
                    format.Cost = report.totalRevenue;
                    result.Add(format);
                }
            }

            return result;
        }

        private DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        public DataTable GetSource(string groupBy)
        {
            List<string[]> rows = new List<string[]>();
            DataTable table = new DataTable();

            if ((groupBy == "products") && (_categoryReportList.Count > 0)) {

                foreach (ProductReport entry in _productReportList)
                {
                    string[] row = { entry.productName, entry.categoryName, entry.unitPrice.ToString(), entry.quantitySold.ToString(), entry.totalRevenue.ToString() };
                    rows.Add(row);
                }

                table = ConvertListToDataTable(rows);
                table.Columns["Column1"].ColumnName = "Product";
                table.Columns["Column2"].ColumnName = "Category";
                table.Columns["Column3"].ColumnName = "Unit Price";
                table.Columns["Column4"].ColumnName = "Quantity";
                table.Columns["Column5"].ColumnName = "Total Revenue";
            }
            else if ((groupBy == "employee") && (_employeeReportList.Count > 0))
            {

                foreach (EmployeeReport entry in _employeeReportList)
                {
                    string[] row = { entry.employeeName, entry.salesCount.ToString(), entry.totalRevenue.ToString() };
                    rows.Add(row);
                }

                table = ConvertListToDataTable(rows);
                table.Columns["Column1"].ColumnName = "Employee";
                table.Columns["Column2"].ColumnName = "No. of sales";
                table.Columns["Column3"].ColumnName = "Total Revenue";
            }
            else if ((groupBy == "category") && (_productReportList.Count > 0))
            {
                foreach (CategoryReport entry in _categoryReportList)
                {
                    string[] row = { entry.categoryName,entry.salesCount.ToString(),entry.totalRevenue.ToString()};
                    rows.Add(row);
                }

                table = ConvertListToDataTable(rows);
                table.Columns["Column1"].ColumnName = "Category";
                table.Columns["Column2"].ColumnName = "No. of sales";
                table.Columns["Column3"].ColumnName = "Total Revenue";
            }

            return table;
        }


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
                        productReport.productName = (string)reader.GetString("Product");
                        productReport.categoryName = (string)reader.GetString("Category");
                        productReport.unitPrice = (float)reader.GetFloat("Unit Price");
                        productReport.quantitySold = (int)reader.GetInt32("Quantity Sold");
                        productReport.totalRevenue = (float)reader.GetFloat("Total Revenue");
                        ProductSalesReport.Add(productReport);
                        break;
                    case "employee":
                        EmployeeReport employeeReport;
                        employeeReport.employeeName = (string)reader.GetString("Employee");
                        employeeReport.salesCount = (int)reader.GetInt32("No. of Sales");
                        employeeReport.totalRevenue = (float)reader.GetFloat("Total Revenue");
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
