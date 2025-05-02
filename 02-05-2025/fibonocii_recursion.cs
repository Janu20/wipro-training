using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        int num = int.Parse(Console.ReadLine()); 
        fib(num, 0, 1);  
    }

    public static void fib(int num, int a, int b)
    {
        if (num <= 0)
        {
            return;  
        }

        Console.Write(a + " ");  

        fib(num - 1, b, a + b);  
    }
}
