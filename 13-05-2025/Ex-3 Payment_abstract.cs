abstract class PaymentGateway
 {
     public abstract void ProcessPayment(Double amount);

     public void ShowGatewayName()
     {
         Console.WriteLine("Processing the payment through gateway");
     }
 }

  class StripeGateway : PaymentGateway
 {
     public override void ProcessPayment(double amount)
     {
         Console.WriteLine("Processing the payment through Stripe " + " " + amount);
     }
 }

 class PayPalGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing the payment through PayPal " + " " + amount);
    }
}

class Program
{
    

    public static void Main()
    {


        PaymentGateway pg;
        pg = new PayPalGateway();

        pg.ShowGatewayName();
        pg.ProcessPayment(55000);

        pg = new StripeGateway();
        pg.ShowGatewayName();
        pg.ProcessPayment(75000);



    }
}
