using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PHPSRePS
{
    public abstract class Report
    {
        private DateTime _startDate;
        private DateTime _endDate;

        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }

        public Report()
        {

        }

        public abstract void ExportToCSV();

    }
}
