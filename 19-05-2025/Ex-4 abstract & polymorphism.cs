    abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);

        public void ShowPaymentMethod()
        {
            Console.WriteLine($"Payment Method: {this.GetType().Name}");
        }
    }

    class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ₹{amount}");
        }
    }

    class UPIPayment : PaymentMethod
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of ₹{amount}");
        }
    }

    class Program
    {
        static void Main()
        {
            PaymentMethod payment1 = new CreditCardPayment();
            PaymentMethod payment2 = new UPIPayment();

            payment1.ShowPaymentMethod();
            payment1.ProcessPayment(1500);

            Console.WriteLine();

            payment2.ShowPaymentMethod();
            payment2.ProcessPayment(800);
        }
    }


