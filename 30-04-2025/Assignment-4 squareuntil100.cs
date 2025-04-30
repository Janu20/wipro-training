using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        for(int i=num ;i*i<=100;i++){
            Console.WriteLine(i*i);
        }
        
        
            
        }
    }