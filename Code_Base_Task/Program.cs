using Code_Base_Task;
using CodeBaseTask;
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Fetch data from two APIs asynchronously");
        Console.WriteLine("2. Process different payment methods polymorphically");
        Console.Write("Enter your choice (1, or 2): ");


        string choice = Console.ReadLine();

        if (choice == "1")
        {
            ApiFetcher fetcher = new ApiFetcher();
            await fetcher.FetchDataFromApis();
        }
        else if (choice == "2")
        {
            List<PaymentMethod> paymentMethods = new List<PaymentMethod>
            {
                new CreditCardPayment(),
                new PayPalPayment(),
                new BankTransferPayment()
            };

            PaymentProcessor paymentProcessor = new PaymentProcessor();
            decimal amount = 100.00m;
            paymentProcessor.ProcessPayments(paymentMethods, amount);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }


}
