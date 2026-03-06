using DependencyInjectionDemo.Contracts;
using DependencyInjectionDemo.Services;
using Autofac;

namespace DependencyInjectionDemo;

class Program
{
    static void Main(string[] args)
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<NotificationService>().As<INotificationService>();
        builder.RegisterType<MessageService>().As<IMessageService>().SingleInstance();

        var container = builder.Build();

        var notificationService = container.Resolve<INotificationService>();

        notificationService.Notify("Hello Dependency Injection!");

         Console.WriteLine($"NumberOnel: {notificationService.IncrementAndSeeCount}");
         Console.WriteLine($"NumberOnel: {notificationService.IncrementAndSeeCountTwo}");
    }

}
