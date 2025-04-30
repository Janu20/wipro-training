using System;

public class HelloWorld
{
    public static int add(int a,int b ){
          
       return a + b;
      
    }
    public static double add (int a, double b){
        return a + b;
    }
    
    public static int sub(int a, int b){
        return a-b;
    }
     public static double sub(double a, double b){
        return a-b;
    }
     public static double mul(int a, int b){
        return a*b;
    }
     public static double mul(int a, double b){
        return a*b;
    }
    public static void Main(string[] args)
    {
       
       Console.WriteLine( add(1,5));
       Console.WriteLine( add(1,5.5));
       Console.WriteLine(sub(1.5,0.5));
       Console.WriteLine(sub(2.5,2));
       Console.WriteLine(mul(5,9));
       Console.WriteLine(mul(3,2.5));
        
        
        
       
    }
}