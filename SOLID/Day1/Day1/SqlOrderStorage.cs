namespace Day1;

// ── [VIOLATION 5: LSP] ArchiveOrderStorage breaks base class contract
public class SqlOrderStorage : IOrderWriter, IOrderReader
{
    public virtual void Save(Order o) => Console.WriteLine($"[SQL] Saved {o.Id}");
    public virtual IEnumerable<Order> GetAll() => Enumerable.Empty<Order>();
}
