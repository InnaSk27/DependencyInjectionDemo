using DependencyInjectionDemo.Contracts;

namespace DependencyInjectionDemo.Services;


public class MessageService : IMessageService
{
    
    public int Count = 0;

    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }

    public int IncrementAndSeeCount()
    {
        Count++;

        return Count;
    }
}