namespace Day1;

public static class Program
{
	public static void Main()
	{
		var orders = new List<Order>
		{
			new()
			{
				CustomerEmail = "standard@shop.com",
				OrderType = "Standard",
				TotalAmount = 100m,
				Items = new List<OrderItem> { new() { ProductName = "Mouse", Quantity = 1, UnitPrice = 100m } }
			},
			new()
			{
				CustomerEmail = "premium@shop.com",
				OrderType = "Premium",
				TotalAmount = 200m,
				Items = new List<OrderItem> { new() { ProductName = "Keyboard", Quantity = 1, UnitPrice = 200m } }
			},
			new()
			{
				CustomerEmail = "bulk@shop.com",
				OrderType = "Bulk",
				TotalAmount = 500m,
				Items = new List<OrderItem> { new() { ProductName = "Monitor", Quantity = 5, UnitPrice = 100m } }
			}
		};

		foreach (var order in orders)
		{
			var processor = CreateProcessor(order.OrderType);
			processor.ProcessOrder(order);
		}
	}

	private static IOrderService CreateProcessor(string orderType)
	{
		var strategy = CreateStrategy(orderType);

		IOrderValidator validator = new OrderValidator();
		IOrderDiscount discount = new OrderDiscount(strategy);
		IOrderStorage storage = new OrderStorage(new SqlOrderStorage());
		IOrderEmailSender emailSender = new OrderEmailSender(new SmtpEmailSender());
		IOrderLogger logger = new ConsoleOrderLogger();

		return new OrderProcessor(validator, discount, storage, emailSender, logger);
	}

	private static IDiscountStrategy CreateStrategy(string orderType)
	{
		return orderType switch
		{
			"Premium" => new PremiumDiscountStrategy(),
			"Bulk" => new BulkDiscountStrategy(),
			_ => new StandardDiscountStrategy(),
		};
	}
}
