using FactoryPattern.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Services
{
    public class BankTransferProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount) =>
            Console.WriteLine($"🏦 Processing bank transfer payment: ${amount}");
    }
}
