namespace Day1;

public class ArchiveOrderStorage : IOrderReader  // read-only, yet inherits Save()
{
    //public override void Save(Order order)          // BREAKS the contract!
    //    => throw new NotSupportedException("Read-only archive — Save() not supported.");

    public IEnumerable<Order> GetAll() =>
        Enumerable.Empty<Order>(); // simulates fetching from archive
}
