
using FactoryPattern.Client.Factory;


Console.WriteLine("Hello, from Ziggy Rfiq!");

var type = args.Length > 0 ? args[0] : "email";
var notificationService = NotificationFactory.Create(type);
notificationService.Send("Hello from C# 13 Factory Pattern Code Example by Ziggy Rafiq!");

Console.WriteLine("Enter payment method (credit, paypal, bank):");
string method = Console.ReadLine() ?? "credit";

try
{
    var processor = PaymentFactory.Create(method);
    processor.ProcessPayment(99.99m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"❌ Error: {ex.Message}");
}