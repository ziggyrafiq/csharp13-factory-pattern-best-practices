﻿namespace FactoryPattern.Core.Interfaces;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
