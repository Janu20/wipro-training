using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.Write("Enter the mark : ") ;   
       int mark = int.Parse(Console.ReadLine());
       
       if(mark >= 90){
             Console.WriteLine("Grade : A ");
       }
       else if(mark >=75){
           Console.WriteLine("Grade : B ");
       }
       else if(mark >=60){
           Console.WriteLine("Grade : C ");
       }
       else{
           Console.WriteLine("Grade : D ");
       }
       
    }
}