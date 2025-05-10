class Program
{
    public static void Main()
    {

        List<int> num = new List<int> { 20, 40, 60, 80, 100 };

        Console.WriteLine("Index of 60 = " + num.IndexOf(60));

        Console.WriteLine("Contains 40 = " + num.Contains(40));
     
        
    }
}
