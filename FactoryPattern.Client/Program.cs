
using FactoryPattern.Client.Factory;
using FactoryPattern.Core.Enums;


Console.WriteLine("Hello, from Ziggy Rfiq!");

var type = args.Length > 0 ? args[0] : "email";
var notificationService = NotificationFactory.Create(type);
notificationService.Send("Hello from C# 13 Factory Pattern Code Example by Ziggy Rafiq!");

var client = new NotificationClient(NotificationType.Email);
client.Notify("Welcome to Ziggy Rafiq Srvice!");


try
{
    var processor = PaymentFactory.Create(PaymentMethod.CreditCard);
    processor.ProcessPayment(99.99m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}