using DependencyInjectionDemo.Contracts;

namespace DependencyInjectionDemo.Services;


public class MessageService : IMessageService
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}