class program
{
    public static void Main(string[] args)

    {
        Method();


    }
    public static void Method()
    {
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}


