// interface

namespace ConsoleApp1
{
    interface IPayment
    {
        void ProcessPayment(decimal amount);
    }
}

// class 1 implements interface
   class CreditCardPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing credit card payment of " + amount);
        }
    }


// class 2 implements interface

internal class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Prpcessing PayPal payment of " + amount);
    }

}

// main class

class Program
{
    

    public static void Main()
    {

        IPayment payment;
         payment = new CreditCardPayment();

        payment.ProcessPayment(1500.50m);

        payment = new PayPalPayment();

        payment.ProcessPayment(2500.75m);

    }
}
