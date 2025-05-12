using System;

public class HelloWorld
{
    public double CalculatePower(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }
  
  public int CalculatePower(int baseNumber, int exponent)
    {
        return (int)Math.Pow(baseNumber, exponent);
    }
    public static void Main(string[] args)
    {
        HelloWorld hw = new HelloWorld();
       
        Console.WriteLine("2 raised to the power of 2 is: " +  hw.CalculatePower(2, 2));
        
        Console.WriteLine("3.0 raised to the power of 2.5 is: " +  hw.CalculatePower(3.0, 2.5));
    }
}
