namespace Day1;

// ── [VIOLATION 2: SRP + DIP] God class with 5 responsibilities
public class OrderProcessor : IOrderService
{
    // [VIOLATION 3: DIP] Hardcoded concrete dependencies
    private readonly IOrderValidator _validator;
    private readonly IOrderDiscount _discount;
    private readonly IOrderStorage _storage;
    private readonly IOrderEmailSender _emailer;
    private readonly IOrderLogger _logger;

    public OrderProcessor(IOrderValidator validator, IOrderDiscount discount, IOrderStorage storage, IOrderEmailSender emailer, IOrderLogger logger)
    {
        _validator = validator;
        _discount = discount;
        _storage = storage;
        _emailer = emailer;
        _logger = logger;
    }
    public void ProcessOrder(Order order)
    {
        _logger.Log($"Processing order {order.Id}");

        // Responsibility: Validation (should be a separate class)
        if (!_validator.IsValid(order))
            return;

        // Responsibility: Discount calculation
        var finalAmount = _discount.CalculateFinalAmount(order);


        // Responsibility: Persist
        _storage.Save(order);

        // Responsibility: Notify
        _emailer.SendConfirmationEmail(order);
    }

    //// [VIOLATION 4: OCP] Every new order type = edit this method
    //private decimal GetDiscount(Order order)
    //{
    //    if (order.OrderType == "Standard") return 0.00m;  // edit here for new types
    //    else if (order.OrderType == "Premium") return 0.10m;
    //    else if (order.OrderType == "Bulk") return 0.20m;
    //    else return 0.00m;
    //}

    //public void SendConfirmationEmail(Order order) =>
    //    _emailer.Notify(order);

    //public string GenerateReport(IEnumerable<Order> orders) =>
    //    $"Orders: {orders.Count()} | Revenue: {orders.Sum(o => o.TotalAmount):C}";

    //public string ExportToCsv(IEnumerable<Order> orders) =>
    //    string.Join("\n", orders.Select(o => $"{o.Id},{o.CustomerEmail},{o.TotalAmount}"));
}
