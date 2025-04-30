using System;

public class HelloWorld
{
    public static int method1(int num){
        return num * num;
    }
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The square number is "+method1(num));
        
        
        
            
        }
    }

