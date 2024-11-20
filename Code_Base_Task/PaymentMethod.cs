using System;
using System.Collections.Generic;

namespace CodeBaseTask
{
    //this is an abstract base class with an abstract method
    public abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);
    }

    // sub class CreditCardPayment 
    public class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}...");
        }
    }

    // sub class PayPalPayment
    public class PayPalPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}...");
        }
    }
    // sub class BankTransferPayment
    public class BankTransferPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing bank transfer payment of ${amount}...");
        }
    }


    public class PaymentProcessor
    {
        public void ProcessPayments(List<PaymentMethod> paymentMethods, decimal amount)
        {
            foreach (var paymentMethod in paymentMethods)
            {
                paymentMethod.ProcessPayment(amount);
            }
        }
    }
}
