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

    public struct SalesForecast
    {
        public DateTime date;
        public int quantity;
    }

    // NOTE this is the forecast report for only ONE individual product OR a category of products, specify which one with the groupBy constructor param
    public class ForecastReport : Report
    {
        public struct SalesHistory
        {
            public DateTime date;
            public int quantity;
        }

        public struct SalesPerDay
        {
            public int day;
            public int quantity;
        }

        // y = mx + c where m = gradient, c = yInt
        struct Line
        {
            public double yInt;
            public double gradient;
        }

        Database database = new Database();

        private List<SalesHistory> _salesHistoryList = new List<SalesHistory>();
        private List<SalesForecast> _salesForecastList = new List<SalesForecast>();
        private List<SalesHistory> SalesHistoryReport { get => _salesHistoryList; set => _salesHistoryList = value; }
        
        // OUTPUT DATA SET
        // GET ALL DATA FROM HERE
        // REFER TO SalesForecast STRUCT FOR FORMAT
        public List<SalesForecast> SalesForecastReport { get => _salesForecastList; set => _salesForecastList = value; }


        public ForecastReport(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        // CALL THIS ONLY
        // load data from the database into local lists
        public void LoadReport(string itemName, string groupBy)
        {
            PopulateSalesHistoryList(itemName, groupBy);
            GenerateForecastData();
        }

        public void AddSale(DateTime date, int quantity)
        {
            SalesHistory toAdd;
            toAdd.date = date;
            toAdd.quantity = quantity;
            SalesHistoryReport.Add(toAdd);
        }

        // get all sales data from the database for working with later
        public void PopulateSalesHistoryList(string itemName, string groupBy)
        {
            database.OpenConnection();

            string query = database.generateSalesHistoryQuery(itemName, groupBy);
            MySqlCommand cmd = new MySqlCommand(query, database.Connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SalesHistory salesHistory;
                string dateString = reader.GetString("Date");

                salesHistory.date = Convert.ToDateTime(dateString);

                salesHistory.quantity = reader.GetInt32("Quantity");
                SalesHistoryReport.Add(salesHistory);
            }

            database.CloseConnection();
        }

        private void GenerateForecastData()
        {
            List<SalesPerDay> salesData = new List<SalesPerDay>();
            List<SalesPerDay> forecastData = new List<SalesPerDay>();
            Line regressionLine;

            if (_salesHistoryList.Count > 1)
            {
                int dayCounter = 0;
                int forecastStartDay = Math.Abs((StartDate - SalesHistoryReport.First().date).Days);
                int totalDays = (EndDate - StartDate).Days;
                int forecastEndDay = forecastStartDay + totalDays;

                // populate sales list using day count instead of date (yyyy/mm/dd)
                for (int i = 0; i < SalesHistoryReport.Count; i++)
                {
                    SalesPerDay dailySale;

                    if (i < 1)
                    {
                        dayCounter += 1;
                    }
                    else
                    {
                        dayCounter += (SalesHistoryReport[i].date - SalesHistoryReport[i - 1].date).Days;
                    }

                    dailySale.day = dayCounter;
                    dailySale.quantity = SalesHistoryReport[i].quantity;
                    salesData.Add(dailySale);
                }

                regressionLine = GetRegressionLine(salesData);

                for (int i = forecastStartDay; i < forecastEndDay; i++)
                {
                    SalesForecast dailyForecast;
                    dailyForecast.date = StartDate.AddDays(i).Date;
                    dailyForecast.quantity = Convert.ToInt32(Math.Round(regressionLine.gradient * i + regressionLine.yInt, MidpointRounding.AwayFromZero));
                    SalesForecastReport.Add(dailyForecast);
                }
            }
        }

        // calculate linear regression for the data set and return the equation variables (gradient and y-int)
        private Line GetRegressionLine(List<SalesPerDay> salesData)
        {
            // result variable
            Line regressionLine;

            // line variables
            double rSq;
            double yInt;
            double gradient;

            // calculation variables
            double sumX = 0;
            double sumY = 0;
            double sumXSq = 0;
            double sumYSq = 0;
            double ssX = 0;
            double ssY = 0;
            double sumCodeviates = 0;
            double sCo = 0;
            double count = salesData.Count;

            // we matlab now bois
            foreach (SalesPerDay sale in salesData)
            {
                double x = sale.day;
                double y = sale.quantity;
                sumCodeviates += x * y;
                sumX += x;
                sumY += y;
                sumXSq += x * x;
                sumYSq += y * y;
            }

            ssX = sumXSq - ((sumX * sumX) / count);
            ssY = sumYSq - ((sumY * sumY) / count);
            double RNumerator = (count * sumCodeviates) - (sumX * sumY);
            double RDenominator = (count * sumXSq - (sumX * sumX)) * (count * sumYSq - (sumY * sumY));
            sCo = sumCodeviates - ((sumX * sumY) / count);

            double meanX = sumX / count;
            double meanY = sumY / count;
            double dblR = RNumerator / Math.Sqrt(RDenominator);
            rSq = dblR * dblR;
            yInt = meanY - ((sCo / ssX) * meanX);
            gradient = sCo / ssX;

            regressionLine.yInt = yInt;
            regressionLine.gradient = gradient;

            return regressionLine;
        }

        // export data to csv file
        public override void ExportToCSV()
        {
            StringBuilder forecastCSVData = new StringBuilder();

            String forecastCSVPath = AppDomain.CurrentDomain.BaseDirectory + "\\reports\\forecast_report" + StartDate.ToShortDateString() + "-" + EndDate.ToShortDateString() + ".csv";

            forecastCSVData.AppendLine("'Date', 'Quantity'");
            foreach (SalesForecast salesForecast in SalesForecastReport)
            {
                forecastCSVData.AppendFormat("'{0}', '{1}'", salesForecast.date.ToShortDateString(), salesForecast.quantity);
                forecastCSVData.AppendLine();
            }

            File.AppendAllText(forecastCSVPath, forecastCSVData.ToString());
        }

    }
}
