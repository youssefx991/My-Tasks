using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using SimpleChatBot.Models;

namespace SimpleChatBot.Services;

public class OllamaChatService : IOllamaChatService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly OllamaOptions _options;

    public OllamaChatService(IHttpClientFactory httpClientFactory, IOptions<OllamaOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<string> GenerateAsync(List<ChatMessage> messages, CancellationToken cancellationToken = default)
    {
        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            apiKey = _options.ApiKey;
        }

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            return "Missing OPENAI_API_KEY. Set it as an environment variable or in appsettings.";
        }

        var client = _httpClientFactory.CreateClient();

        using var request = new HttpRequestMessage(HttpMethod.Post, _options.ApiUrl);
        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

        var requestMessages = new List<object>
        {
            new
            {
                role = "system",
                content = "You are a helpful assistant. Keep responses concise."
            }
        };

        requestMessages.AddRange(messages.Select(m => new
        {
            role = m.Role,
            content = m.Content
        }));

        var payload = new
        {
            model = _options.Model,
            messages = requestMessages,
            temperature = 0.7
        };

        request.Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

        using var response = await client.SendAsync(request, cancellationToken);
        var body = await response.Content.ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return $"Model request failed ({(int)response.StatusCode}): {body}";
        }

        using var document = JsonDocument.Parse(body);
        if (document.RootElement.TryGetProperty("choices", out var choicesElement)
            && choicesElement.ValueKind == JsonValueKind.Array
            && choicesElement.GetArrayLength() > 0)
        {
            var first = choicesElement[0];
            if (first.TryGetProperty("message", out var messageElement)
                && messageElement.TryGetProperty("content", out var contentElement))
            {
                return contentElement.GetString() ?? string.Empty;
            }
        }

        return "No assistant message found in the chat completion output.";
    }
}
