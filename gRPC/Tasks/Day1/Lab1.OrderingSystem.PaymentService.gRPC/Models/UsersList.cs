namespace Lab1.OrderingSystem.PaymentService.gRPC.Models
{
    public static class UsersList
    {
        public static List<User> Users = new List<User>
        {
            new User { id = 1, name = "Alice", Balance = 100 },
            new User { id = 2, name = "Bob", Balance = 50 },
            new User { id = 3, name = "Charlie", Balance = 200 },
            new User { id = 4, name = "David", Balance = 150 },
            new User { id = 5, name = "Eve", Balance = 80 },
            new User { id = 6, name = "Frank", Balance = 120 },
            new User { id = 7, name = "Grace", Balance = 90 },
        };
    }
}
