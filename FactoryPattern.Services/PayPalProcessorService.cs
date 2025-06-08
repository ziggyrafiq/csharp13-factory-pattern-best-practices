﻿using FactoryPattern.Core.Interfaces;

namespace FactoryPattern.Services;
public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) =>
        Console.WriteLine($"Processing PayPal payment: ${amount}");
}
