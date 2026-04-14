namespace Day3.Models
{
    public class UserList
    {
        public static List<User> Users { get; set; } = new List<User>
        {
            new User { Id = 1, Name = "Alice", Image = "1.jpg" },
            new User { Id = 2, Name = "Bob", Image = "2.jpg" },
            new User { Id = 3, Name = "Charlie", Image = "3.jpg" },
            new User { Id = 4, Name = "Diana", Image = "4.jpg" },
            new User { Id = 5, Name = "Eve", Image = "5.jpg" },
            new User { Id = 6, Name = "Frank", Image = "6.jpg" },
            new User { Id = 7, Name = "Grace", Image = "7.jpg" },
        };
    }
}
