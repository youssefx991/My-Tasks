namespace ITI46.Ecommerce.Core.Models
{
    public class Message
    {
        public required int RecipientId { get; set; }

        public required string Subject { get; set; }

        public required string Body { get; set; }
    }
}
