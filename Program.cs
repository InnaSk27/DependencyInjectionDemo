using DependencyInjectionDemo.Contracts;
using DependencyInjectionDemo.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionDemo;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddScoped<INotificationService, NotificationService>();
        services.AddScoped<IMessageService, MessageService>();

        var container = services.BuildServiceProvider();

        var notificationService = container.GetService<INotificationService>();

        notificationService?.Notify("Hello Dependency Injection!");
    }

}
