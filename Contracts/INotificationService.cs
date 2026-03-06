namespace DependencyInjectionDemo.Contracts;
public interface INotificationService
{
    void Notify(string message);
    int IncrementAndSeeCount();
    int IncrementAndSeeCountTwo();

}