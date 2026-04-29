using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;
using Task.Models;

namespace Task.Services;

public sealed class OpenAIChatCompletionService : IChatCompletionService
{
    private static readonly JsonSerializerOptions SerializerOptions = new(JsonSerializerDefaults.Web);
    private readonly HttpClient _httpClient;
    private readonly OpenAIOptions _options;

    public OpenAIChatCompletionService(HttpClient httpClient, IOptions<OpenAIOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }

    public async Task<string> GetReplyAsync(IReadOnlyCollection<ChatMessageRecord> messages, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(_options.ApiKey))
        {
            throw new InvalidOperationException("OpenAI API key is missing. Set the OpenAI__ApiKey environment variable.");
        }

        var request = new ChatCompletionRequest
        {
            Model = _options.Model,
            Messages = [
                new ChatCompletionMessage("system", _options.SystemPrompt)
            ]
        };

        foreach (var message in messages)
        {
            request.Messages.Add(new ChatCompletionMessage(message.Role switch
            {
                ChatRole.User => "user",
                ChatRole.Assistant => "assistant",
                _ => "system"
            }, message.Content));
        }

        using var httpRequest = new HttpRequestMessage(HttpMethod.Post, _options.Endpoint)
        {
            Content = JsonContent.Create(request, options: SerializerOptions)
        };

        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _options.ApiKey);

        using var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
        var responseJson = await response.Content.ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var error = JsonSerializer.Deserialize<OpenAIErrorResponse>(responseJson, SerializerOptions);
            throw new InvalidOperationException(error?.Error?.Message ?? $"OpenAI request failed with status {(int)response.StatusCode}.");
        }

        var completion = JsonSerializer.Deserialize<ChatCompletionResponse>(responseJson, SerializerOptions);
        var content = completion?.Choices.FirstOrDefault()?.Message?.Content;

        if (string.IsNullOrWhiteSpace(content))
        {
            throw new InvalidOperationException("OpenAI returned an empty response.");
        }

        return content.Trim();
    }

    private sealed class ChatCompletionRequest
    {
        public string Model { get; set; } = string.Empty;

        public List<ChatCompletionMessage> Messages { get; set; } = [];
    }

    private sealed class ChatCompletionMessage
    {
        public ChatCompletionMessage(string role, string content)
        {
            Role = role;
            Content = content;
        }

        [JsonPropertyName("role")]
        public string Role { get; }

        [JsonPropertyName("content")]
        public string Content { get; }
    }

    private sealed class ChatCompletionResponse
    {
        [JsonPropertyName("choices")]
        public List<Choice> Choices { get; set; } = [];

        public sealed class Choice
        {
            [JsonPropertyName("message")]
            public ChoiceMessage? Message { get; set; }
        }

        public sealed class ChoiceMessage
        {
            [JsonPropertyName("content")]
            public string? Content { get; set; }
        }
    }

    private sealed class OpenAIErrorResponse
    {
        [JsonPropertyName("error")]
        public OpenAIError? Error { get; set; }
    }

    private sealed class OpenAIError
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}