using System;

public class HelloWorld
{
    static void Main(){
       Console.Write("Enter the number : ");
       int num = int.Parse(Console.ReadLine());
       if(num % 2 == 0){
           Console.WriteLine("The number you have enter "+ num+" is even");
       }
       else{
            Console.WriteLine("The number you have enter "+ num+" is odd");
       }
    
}

}