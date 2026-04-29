using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using SimpleChatBot.Models;
using SimpleChatBot.Services;

namespace SimpleChatBot.Controllers;

public class ChatController : Controller
{
    private const string SessionKey = "chat_history";
    private readonly IOllamaChatService _chatService;

    public ChatController(IOllamaChatService chatService)
    {
        _chatService = chatService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var messages = GetMessagesFromSession();
        var model = new ChatViewModel
        {
            Messages = messages
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ChatViewModel model, CancellationToken cancellationToken)
    {
        var messages = GetMessagesFromSession();

        if (!ModelState.IsValid)
        {
            model.Messages = messages;
            return View(model);
        }

        var userMessage = new ChatMessage
        {
            Role = "user",
            Content = model.Prompt.Trim()
        };
        messages.Add(userMessage);

        var assistantReply = await _chatService.GenerateAsync(messages, cancellationToken);

        messages.Add(new ChatMessage
        {
            Role = "assistant",
            Content = assistantReply
        });

        SaveMessagesToSession(messages);

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Clear()
    {
        HttpContext.Session.Remove(SessionKey);
        return RedirectToAction(nameof(Index));
    }

    private List<ChatMessage> GetMessagesFromSession()
    {
        var raw = HttpContext.Session.GetString(SessionKey);
        if (string.IsNullOrWhiteSpace(raw))
        {
            return new List<ChatMessage>();
        }

        return JsonSerializer.Deserialize<List<ChatMessage>>(raw) ?? new List<ChatMessage>();
    }

    private void SaveMessagesToSession(List<ChatMessage> messages)
    {
        var capped = messages.TakeLast(20).ToList();
        var raw = JsonSerializer.Serialize(capped);
        HttpContext.Session.SetString(SessionKey, raw);
    }
}
