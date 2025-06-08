
using FactoryPattern.Core.Interfaces;
namespace FactoryPattern.Services;
public class EmailNotificationService: INotificationService
{
        public void Send(string message) => Console.WriteLine($" Email: {message}");
}
