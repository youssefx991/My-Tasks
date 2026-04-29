using SimpleChatBot.Models;

namespace SimpleChatBot.Services;

public interface IOllamaChatService
{
    Task<string> GenerateAsync(List<ChatMessage> messages, CancellationToken cancellationToken = default);
}
