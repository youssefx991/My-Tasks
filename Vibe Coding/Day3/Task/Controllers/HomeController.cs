using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Task.Infrastructure;
using Task.Models;
using Task.Services;

namespace Task.Controllers;

public class HomeController : Controller
{
    private const string ConversationSessionKey = "chat.conversation";
    private readonly ILogger<HomeController> _logger;
    private readonly IChatCompletionService _chatCompletionService;

    public HomeController(ILogger<HomeController> logger, IChatCompletionService chatCompletionService)
    {
        _logger = logger;
        _chatCompletionService = chatCompletionService;
    }

    public IActionResult Index()
    {
        var conversation = GetConversation();

        return View(BuildPageViewModel(conversation));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ChatPageViewModel model, CancellationToken cancellationToken)
    {
        var conversation = GetConversation();
        var replyTarget = conversation.Messages.FirstOrDefault(message => message.Id == model.ReplyToMessageId);

        if (string.IsNullOrWhiteSpace(model.Prompt))
        {
            ModelState.AddModelError(nameof(ChatPageViewModel.Prompt), "Type a message before sending it.");
            return View(BuildPageViewModel(conversation, model.Prompt));
        }

        conversation.Messages.Add(new ChatMessageRecord
        {
            Id = Guid.NewGuid().ToString("N"),
            Role = ChatRole.User,
            Content = BuildUserMessageContent(model, replyTarget),
            CreatedAtUtc = DateTimeOffset.UtcNow,
            ReplyToMessageId = replyTarget?.Id
        });

        try
        {
            var assistantReply = await _chatCompletionService.GetReplyAsync(conversation.Messages, cancellationToken);

            conversation.Messages.Add(new ChatMessageRecord
            {
                Role = ChatRole.Assistant,
                Content = assistantReply,
                CreatedAtUtc = DateTimeOffset.UtcNow
            });

            SaveConversation(conversation);

            return View(BuildPageViewModel(conversation));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to generate chat completion.");
            ModelState.AddModelError(string.Empty, "The assistant could not respond right now. Check the configuration and try again.");
            return View(BuildPageViewModel(conversation, model.Prompt));
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private ChatConversationState GetConversation()
    {
        var conversation = HttpContext.Session.GetJson<ChatConversationState>(ConversationSessionKey);

        return conversation ?? new ChatConversationState();
    }

    private void SaveConversation(ChatConversationState conversation)
    {
        HttpContext.Session.SetJson(ConversationSessionKey, conversation);
    }

    private static ChatPageViewModel BuildPageViewModel(ChatConversationState conversation, string? prompt = null)
    {
        return new ChatPageViewModel
        {
            Prompt = prompt ?? string.Empty,
            Messages = conversation.Messages
                .Select(message => new ChatMessageViewModel
                {
                    Id = message.Id,
                    Role = message.Role,
                    Content = message.Content,
                    CreatedAtUtc = message.CreatedAtUtc,
                    ReplyToMessageId = message.ReplyToMessageId
                })
                .ToList()
        };
    }

    private static string BuildUserMessageContent(ChatPageViewModel model, ChatMessageRecord? replyTarget)
    {
        var prompt = model.Prompt.Trim();

        if (replyTarget is null)
        {
            return prompt;
        }

        return $"Replying to assistant message:\n{replyTarget.Content}\n\nUser reply:\n{prompt}";
    }
}
