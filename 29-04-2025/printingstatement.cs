using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
       int age = 22;
       string name = "Janani";
       bool isstudent =true;
       double fees = 6000.10;
       
        //1st method
        
         Console.WriteLine("Age = " +age);
         Console.WriteLine("Name =" + name);
         Console.WriteLine("Fees = " + fees);
         Console.WriteLine("Student = " +isstudent);
        
        // 2nd method
        
        Console.WriteLine($"Name =  {name}");
        Console.WriteLine($"age= {age}");
        Console.WriteLine($"isstudent = {isstudent}");
        Console.WriteLine($"Fees = {fees}");
}
}
