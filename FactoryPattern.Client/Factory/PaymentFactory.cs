using FactoryPattern.Core.Enums;
using FactoryPattern.Core.Interfaces;
using FactoryPattern.Services;

namespace FactoryPattern.Client.Factory;

public static class PaymentFactory
{
    //public static IPaymentProcessor Create(string method) => method.ToLower() switch
    //{
    //    "credit" => new CreditCardProcessor(),
    //    "paypal" => new PayPalProcessor(),
    //    "bank" => new BankTransferProcessor(),
    //    _ => throw new ArgumentException("Unsupported payment method", nameof(method))
    //};

    public static IPaymentProcessor Create(PaymentMethod paymentMethod) =>
        paymentMethod switch
        {
            PaymentMethod.CreditCard => new CreditCardProcessor(),
            PaymentMethod.PayPal => new PayPalProcessor(),
            PaymentMethod.BankTransfer => new BankTransferProcessor(),
            _ => throw new ArgumentOutOfRangeException(nameof(paymentMethod), $"Unknown payment method: {paymentMethod}")
      };
}