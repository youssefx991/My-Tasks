namespace Day1;

// ── [VIOLATION 1: ISP] One fat interface forces ALL methods on every implementor
public interface IOrderService
{
    public void ProcessOrder(Order order);           // processing concern
    //void SendConfirmationEmail(Order order);  // notification concern
    //string GenerateReport(IEnumerable<Order> orders);  // reporting concern
    //string ExportToCsv(IEnumerable<Order> orders);     // export concern
}
