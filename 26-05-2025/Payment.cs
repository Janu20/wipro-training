using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   interface  IPaymentProcess 
    {
        public void ProcessPayment();
    }
}

    abstract class PaymentGateway
    {
      public string GatewayName { set; get; }


        public void validate()
        {
            
            Console.WriteLine(GatewayName +" has been validating...");
            Console.WriteLine(GatewayName + " validated.");
        }
    }

 internal class PayPal : PaymentGateway, IPaymentProcess
    {
        public void ProcessPayment()
        {
            GatewayName = "Paypal";
            validate();
            
                Console.WriteLine("Enter the amount to be paid via PayPal : ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount > 0)
                {
                    Console.WriteLine("Payment done with the amount of " + amount + " in PayPal");
                }
                else
                {
                    Console.WriteLine("Amount should not be zero");
                }

            }
        }
    



    internal class RazorPay : PaymentGateway, IPaymentProcess
    {
        public void ProcessPayment()
        {
            GatewayName = "RazorPay";
            validate();
            
                Console.WriteLine("Enter the amount to be paid via RazorPay : ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount > 0)
                {
                    Console.WriteLine("Payment done with the amount of " + amount + " in RazorPay");
                }
                else
                {
                    Console.WriteLine("Amount should not be zero");
                }

            }
        }
    


    internal class Strip : PaymentGateway, IPaymentProcess
    {
        public void ProcessPayment()
        {
            GatewayName = "Strip";
            validate();
           
            
                Console.WriteLine("Enter the amount to be paid via Strip : ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount > 0)
                {
                    Console.WriteLine("Payment done with the amount of " + amount + " in Strip");
                }
                else
                {
                    Console.WriteLine("Amount should not be zero");
                }

            }
        }
    



class Program
{
    static void Main()
    {
       

        List<IPaymentProcess> payment = new List<IPaymentProcess>
        {
            new PayPal(),
            new RazorPay(),
            new Strip()
        };

        foreach (var item in payment)
        {
            item.ProcessPayment();
            Console.WriteLine(); // Just for spacing
        }

        Console.WriteLine("All payments processed.");
        Console.ReadKey(); // So the console doesn't close immediately
    }
}
