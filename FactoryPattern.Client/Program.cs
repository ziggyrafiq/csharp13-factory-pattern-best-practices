using FactoryPattern.Client.Factory;
using FactoryPattern.Core.Enums;

Console.WriteLine("Hello, from Ziggy Rfiq!");

var type = args.Length > 0 ? args[0] : "email";

// Fix: Convert the string 'type' to the appropriate NotificationType enum value  
if (!Enum.TryParse<NotificationType>(type, true, out var notificationType))
{
    Console.WriteLine($"Invalid notification type: {type}. Defaulting to Email.");
    notificationType = NotificationType.Email;
}

var notificationService = NotificationFactory.Create(notificationType);
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