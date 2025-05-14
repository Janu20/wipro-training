 interface IBankAccount
 {
     public void Deposite(double amount);
     public void Withdraw(double amount);
     public void CheckBalance(double amount);

 }
 internal class CurrentAccount : IBankAccount
{
    public void Deposite(double amount)
    {
        Console.WriteLine(amount + " has been deposited in your current account");
    }
    public void Withdraw(double amount)
    {
        Console.WriteLine(amount + " has been withdrawed in your current account");
    }
    public void CheckBalance(double amount)
    {
        if (amount == 0)
        {
            Console.WriteLine("You have Zero balance in your current account");
        }
        else
        {
            Console.WriteLine("The amount balance in your current account = " + amount);
        }
    }
}

 internal class SavingAccount : IBankAccount
 {
     public void Deposite(double amount)
     {
         Console.WriteLine(amount + " has been deposited in your saving account");
     }
     public void Withdraw(double amount)
     {
         Console.WriteLine(amount + " has been withdrawd in your saving account");
     }
     public void CheckBalance(double amount)
     {
         if(amount == 0)
         {
             Console.WriteLine("You have Zero balance in your saving account");
         }
         else
         {
             Console.WriteLine("The amount balance in your saving account = " + amount);
         }
     }
 }

 class Program
{
 
    static void Main()
    {
        IBankAccount ib;
        ib = new SavingAccount();

        ib.Deposite(25000);
        ib.Withdraw(10000);
        ib.CheckBalance(15000);

        ib = new CurrentAccount();
        ib.Deposite(15000);
        ib.Withdraw(5000);
        ib.CheckBalance(10000);


    }
}




