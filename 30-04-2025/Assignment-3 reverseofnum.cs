using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string sum="";
        
        while(num >0){
            int last = num%10;
            sum += last;
            num = num/10;
            
        }
        Console.WriteLine(sum);
        
        
            
        }
    }
