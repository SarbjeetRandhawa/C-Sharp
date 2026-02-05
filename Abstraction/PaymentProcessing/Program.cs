using System;
namespace Abstraction
{
    public interface IpaymentMethod
    {
        bool paymentProcessing(Decimal amount);
    }
    public class Creditcard : IpaymentMethod
    {
        public bool paymentProcessing(Decimal amount)
        {
            Console.WriteLine($"payment is processed {amount:C}");
            return true;
        }
    } 
    public class DebitCard : IpaymentMethod
    {
        public bool paymentProcessing(Decimal amount)
        {
            Console.WriteLine($"payment is processed {amount:C}");
            return true;
        }
    }

    public class Checkoutsystem
    {
        public void checkout(IpaymentMethod method, Decimal amount)
        {

            if (method.paymentProcessing(amount))
            {
                Console.WriteLine("Payment process successful");

            }
            else
            {
                Console.WriteLine("payment failed");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            Checkoutsystem c = new();
            IpaymentMethod creditcard = new Creditcard();
            IpaymentMethod debitcard = new DebitCard();

            c.checkout(debitcard, 800);
            c.checkout(creditcard, 1000);

        }
    }
}