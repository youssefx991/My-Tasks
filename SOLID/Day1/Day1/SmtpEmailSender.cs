namespace Day1;

// ── Concrete infrastructure classes ──────────────────────
public class SmtpEmailSender : IEmailClient
{
	public void Send(string to, string sub, string body) => Console.WriteLine($"[SMTP] {to}");
}
