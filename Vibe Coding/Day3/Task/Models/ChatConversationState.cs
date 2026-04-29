namespace Task.Models;

public sealed class ChatConversationState
{
    public List<ChatMessageRecord> Messages { get; set; } = [];
}