namespace Day1;

// ── Entities ────────────────────────────────────────────
public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string CustomerEmail { get; set; }
    public string OrderType { get; set; }  // "Standard", "Premium", "Bulk"
    public decimal TotalAmount { get; set; }
    public List<OrderItem> Items { get; set; } = new();
}
