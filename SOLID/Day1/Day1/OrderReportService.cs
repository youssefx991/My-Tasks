using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class OrderReportService : IOrderReporter
    {
        public string GenerateReport(IEnumerable<Order> orders) =>
            $"Orders: {orders.Count()} | Revenue: {orders.Sum(o => o.TotalAmount):C}";

        public string ExportToCsv(IEnumerable<Order> orders) =>
        string.Join("\n", orders.Select(o => $"{o.Id},{o.CustomerEmail},{o.TotalAmount}"));
    }
}
