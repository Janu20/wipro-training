using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
     Console.Write("Enter the first number : ");    
     int num1 = int.Parse(Console.ReadLine());
     Console.Write("Enter the first number : ");
     int num2 = int.Parse(Console.ReadLine());
     Console.Write("Enter the first number : ");
     int num3 = int.Parse(Console.ReadLine());
     
     if(num1 > num2 && num1 > num3){
         Console.WriteLine(num1+" is the greatest number");
     }
     else if(num2 > num1 && num2 > num3){
          Console.WriteLine(num2+" is the greatest number");
     }
     else{
          Console.WriteLine(num3+" is the greatest number");
     }
}
}
