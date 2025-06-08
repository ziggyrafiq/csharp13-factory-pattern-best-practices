using FactoryPattern.Core.Interfaces;

namespace FactoryPattern.Services;

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) =>
        Console.WriteLine($"Processing credit card payment: ${amount}");
}
