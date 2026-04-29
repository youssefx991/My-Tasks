using System.ComponentModel.DataAnnotations;

namespace Task.Models;

public sealed class ChatPageViewModel
{
    public List<ChatMessageViewModel> Messages { get; set; } = [];

    public string? ReplyToMessageId { get; set; }

    public string? ReplyToContent { get; set; }

    [Required]
    [StringLength(4000, MinimumLength = 1)]
    public string Prompt { get; set; } = string.Empty;
}