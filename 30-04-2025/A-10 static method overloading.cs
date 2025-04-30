using System;

public class HelloWorld
{
    public static int add(int a,int b ){
          
       return a + b;
      
    }
    public static double add (int a, double b){
        return a + b;
    }
    public static void Main(string[] args)
    {
       
       Console.WriteLine( add(1,5));
       Console.WriteLine( add(1,5.5));
        
        
        
       
    }
}