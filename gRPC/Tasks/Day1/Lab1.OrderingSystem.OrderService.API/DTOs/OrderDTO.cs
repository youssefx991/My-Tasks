namespace Lab1.OrderingSystem.OrderService.API.DTOs
{
    public class OrderDTO
    {
        public int? Id { get; set; }
        public int? UserId { get; set; } 
        public string? UserName { get; set; }
        public List<ItemDTO>? Items { get; set; } = new List<ItemDTO>();
    }
}
