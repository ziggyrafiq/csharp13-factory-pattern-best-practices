using FactoryPattern.Core.Interfaces;

namespace FactoryPattern.Services;
public class BankTransferProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) =>
        Console.WriteLine($"Processing bank transfer payment: ${amount}");
}
