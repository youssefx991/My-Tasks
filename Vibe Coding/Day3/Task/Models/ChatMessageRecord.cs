namespace Task.Models;

public enum ChatRole
{
    System,
    User,
    Assistant
}

public sealed class ChatMessageRecord
{
    public string Id { get; set; } = string.Empty;

    public ChatRole Role { get; set; }

    public string Content { get; set; } = string.Empty;

    public DateTimeOffset CreatedAtUtc { get; set; }

    public string? ReplyToMessageId { get; set; }
}