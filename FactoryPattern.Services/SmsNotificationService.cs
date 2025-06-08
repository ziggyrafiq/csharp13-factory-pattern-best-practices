using FactoryPattern.Core.Interfaces;

namespace FactoryPattern.Services;
public class SmsNotificationService : INotificationService
{
    public void Send(string message) => Console.WriteLine($" SMS: {message}");
}