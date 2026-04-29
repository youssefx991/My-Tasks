namespace Task.Models;

public sealed class ChatMessageViewModel
{
    public string Id { get; set; } = string.Empty;

    public ChatRole Role { get; set; }

    public string Content { get; set; } = string.Empty;

    public DateTimeOffset CreatedAtUtc { get; set; }

    public string? ReplyToMessageId { get; set; }
}