using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
     int mul;    
     int num =int.Parse(Console.ReadLine());
     fac(num,1);
     
    }
    public static void fac(int num,int mul){
        if(num==0){
            Console.WriteLine(mul);
            return;
        }
        
         mul *= num;
         
        fac(num-1,mul);
    }
        
    }  
    

