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
        builder.RegisterType<MessageService>().As<IMessageService>();

        var container = builder.Build();

        var notificationService = container.Resolve<INotificationService>();

        notificationService?.Notify("Hello Dependency Injection!");
    }

}
