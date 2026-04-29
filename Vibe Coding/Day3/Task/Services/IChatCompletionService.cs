using Task.Models;

namespace Task.Services;

public interface IChatCompletionService
{
    Task<string> GetReplyAsync(IReadOnlyCollection<ChatMessageRecord> messages, CancellationToken cancellationToken = default);
}