using FactoryPattern.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Services
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount) =>
            Console.WriteLine($"📧 Processing PayPal payment: ${amount}");
    }
}
