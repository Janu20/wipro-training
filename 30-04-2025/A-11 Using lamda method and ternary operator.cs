using System;

public class HelloWorld
{
    public static int m1(int a, int b) => a+b;
    
    public static int m2(int a, int b) => a-b;
    
    public static int m3(int a, int b) => a*b;
    
    public static double m4(int a, int b) => b==0 ? 0 : a/b; //ternary operator
    public static void Main(string[] args)
    {
        Console.WriteLine ("add = "+m1(6,2));
        Console.WriteLine ("sub = "+m2(6,2));
        Console.WriteLine ("mul = "+m3(6,2));
        Console.WriteLine ("div = "+m4(6,2));
        Console.WriteLine ("div = "+m4(6,0));
        
    }
}