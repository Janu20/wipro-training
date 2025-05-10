using System;

class Payment
{
    public string Currency;
    public decimal Amount;
    
    public void ProcessPayment(){
        Console.WriteLine("Processing the payment... "+"Amount : "+Amount +" Currency : "+ Currency);
    }
   
}
class CreditCardPayment : Payment
{
    long CardNumber;
    
     public void ProcessPayment(decimal Amount,string Currency)
    {
        Console.WriteLine("Processing.......");
        Console.WriteLine("Amount : " + Amount);
        Console.WriteLine("Currency : "+Currency);
    }
   
    public void Card(long CardNumber){
        Console.WriteLine("CardNumber : "+CardNumber);
    }
}
class PayPalPayment : Payment
{
    string EmailAddress;
    
    public void ProcessPayment( decimal Amount)
    {
        Console.WriteLine("Processing.......");
        Console.WriteLine("Amount : "+ Amount);
    }
    public void Email(string EmailAddress){
        Console.WriteLine("Email : "+EmailAddress);
        
    }
    
}
public class Program
{
    public static void Main(string[] args)
    {
      CreditCardPayment CCP = new CreditCardPayment();
      PayPalPayment     PPP = new PayPalPayment ();
      
      
     CCP.ProcessPayment(25000,"USD");
     PPP.ProcessPayment(45000);
     CCP.Amount=8976;
     CCP.Currency="USD";
     CCP.ProcessPayment();
     CCP.Card(789864457);
     PPP.Email("gjanani@2020gmail.com");
      
      
    }
}