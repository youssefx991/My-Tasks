namespace Day1;

public interface IEmailClient
{
    void Send(string to, string subject, string body);
}