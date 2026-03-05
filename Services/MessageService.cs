
namespace DependencyInjectionDemo.Services;

public class MessageService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}