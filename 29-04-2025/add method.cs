using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
      int num1 = 12;
      int num2 = 12;
      
      Console.WriteLine(method(num1,num2));
}
static int method(int a,int b){
    return a+b;
    
}
}