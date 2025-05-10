class Program
{
    public static void Main()
    {
        Dictionary<int, string> Employee = new Dictionary<int, string>
        {
            {1,"Janani" },
            {2,"Nisha" },
            {3,"Harish" },
            {4,"Thruv" }
        };
        Employee[2] = "Ananya";

        foreach(var item in Employee)
        {
            Console.WriteLine(item);
        }
    }
}
