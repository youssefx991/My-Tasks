using System.ComponentModel.DataAnnotations;

namespace SimpleChatBot.Models;

public class ChatViewModel
{
    [Required]
    [Display(Name = "Message")]
    public string Prompt { get; set; } = string.Empty;

    public List<ChatMessage> Messages { get; set; } = new();

    public string? ErrorMessage { get; set; }
}
