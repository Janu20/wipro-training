class Program
{
   
    public static void Main() 
    {
        int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        int amount = Convert.ToInt32(Console.ReadLine());
        
        List <int> usedcoin = new List<int>();

       int Totalcoinused = 0;

        foreach(var coin in denominations)
        {
            while(amount >= coin)
            {
                amount = amount - coin;
                usedcoin.Add(coin);
                Totalcoinused++;
            }
        }
        foreach (var item in usedcoin)
        {
            Console.WriteLine("Coin used = " + item);
        }

        Console.WriteLine("Total number of coin used = " + Totalcoinused);
    }
}
