namespace ITI46.Ecommerce.Core.Ordering.Entities.InventoryAggregate
{
    public class Inventory
    {
        private List<InventoryItem> Items { get; set; } = [];

        public IEnumerable<InventoryItem> All => Items;

        public void AddItem (InventoryItem item)
        {
            Items.Add(item);
        }
    }
}
