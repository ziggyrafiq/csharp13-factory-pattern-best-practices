using FactoryPattern.Core.Interfaces;
using FactoryPattern.Services;

namespace FactoryPattern.Client.Factory;

public static class PaymentFactory
{
    public static IPaymentProcessor Create(string method) => method.ToLower() switch
    {
        "credit" => new CreditCardProcessor(),
        "paypal" => new PayPalProcessor(),
        "bank" => new BankTransferProcessor(),
        _ => throw new ArgumentException("Unsupported payment method", nameof(method))
    };
}