namespace SimpleChatBot.Models;

public class OllamaOptions
{
    public string ApiUrl { get; set; } = "https://api.openai.com/v1/chat/completions";
    public string Model { get; set; } = "gpt-4o-mini";
    public string ApiKey { get; set; } = string.Empty;
}
