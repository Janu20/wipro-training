using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
      int num1 = 12;
      int num2 = 12;
      
      Console.WriteLine(mul(num1,num2));
      Console.WriteLine(div(num1,num2));
}
static int mul(int a,int b){
    return a*b;
    
}
static int div(int a,int b){
    return a/b;
}
}