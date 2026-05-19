using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public interface IOrderReporter
    {
        public string GenerateReport(IEnumerable<Order> orders);

        public string ExportToCsv(IEnumerable<Order> orders);
    }
}
