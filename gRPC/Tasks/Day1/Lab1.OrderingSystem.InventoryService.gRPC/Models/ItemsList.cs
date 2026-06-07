namespace Lab1.OrderingSystem.InventoryService.gRPC.Models
{
    public static class ItemsList
    {
        public static List<Item> Items = new List<Item>()
        {
            new Item() { Id = 1, Name = "Pasta", Quantity = 10 },
            new Item() { Id = 2, Name = "Pizza", Quantity = 5 },
            new Item() { Id = 3, Name = "Salad", Quantity = 20 },
            new Item() { Id = 4, Name = "Soup", Quantity = 15 },
            new Item() { Id = 5, Name = "Burger", Quantity = 8 },
            new Item() { Id = 6, Name = "Fries", Quantity = 12 },
            new Item() { Id = 7, Name = "Soda", Quantity = 25 },
            new Item() { Id = 8, Name = "Juice", Quantity = 18 }
        };
    }
}
