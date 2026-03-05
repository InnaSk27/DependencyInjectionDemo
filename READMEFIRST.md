// This is a project made for the students to understand the basics and the need for Dependency Injection. 

// It does NOT include frameworks such as AutoFac nor Modules so this is just basic stuff, those aspects will be covered in part two, called DependencyInjectionDemoTwo.

// This is a setp-to-step guide on how to copy-code this project, the aim is for the project to fail at certain times, and give errors that we will be solving, again, this is made so the students understand how and why it works.

// 1 - Create the folders: Contracts and Services. You can explain as to why but the principal concept is for them to understand why the separation. It doesnt need to be this way exactly either, but separation concepts are important.

// 2 - Create the MessageService inside Services, do not add the interface. This service should be empty for now.

// This is how it should look like: 

    namespace DependencyInjectionDemo.Services;

    public class MessageService
    {

    }

// 3 - Create the IMessageService interface inside Contracts. With a member, like this:

    namespace DependencyInjectionDemo.Contracts;

    public interface IMessageService
    {
        void Send(int message);
    }

// 4 - Now add the interface to the class. This will give an error. The aim is for the students to know why,
// as they understand why, add the method in the Service.

// 5 - Create both a NotificationService and an INotificationServie in their folders (Services and Contracts). 
// This can be created completely.

// 6 - Now comes the fun part. Program.cs, where the dependencies are to be injected, and the containers built. 
// Since this can be a topic hard to grasp, we will first add only this code for the whole Program.cs:

   using DependencyInjectionDemo.Contracts;
    using DependencyInjectionDemo.Services;
    using Microsoft.Extensions.DependencyInjection;

    namespace DependencyInjectionDemo.Program;

    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddScoped<INotificationService, NotificationService>();

            var container = services.BuildServiceProvider();

            var notificationService = container.GetService<INotificationService>();

            notificationService?.Notify("Hello Dependency Injection!");
        }

    }


// And there should be an error!!! Why? well, because we havent registered IMessageService, and, when the compiler is trying to resolve that Interface, it will fail. 
// Understanding this is crucial, as this will not be shown in the editor as an error, but will explode as soon as you try to run an application that has a dependency that has not been defined.

// 7 - Add the missing scope.

         services.AddScoped<IMessageService, MessageService>();


