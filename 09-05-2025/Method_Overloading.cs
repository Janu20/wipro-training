   internal class Calculator
 {
     public int Add(int a, int b)
     {
         return a + b;
     }
    
     public double Add(double a, double b)
     {

         return a + b;

     }
     public int Add(int a,int b,int c)
     {
         return a + b + c;
     }

     public int Sub(int a, int b)
     {
         return a - b;

     }
     public double Sub(double a, int b)
     {
         return a - b;
     }
     public int Sub(int a,int b,int c)
     {
         return a - b - c;
     }

     public int Mul(int a,int b)
     {
         return a * b;
     }

     public double Mul(double a,double b)
     {
         return a * b;
     }

     public double Mul(double a, double b,double c)
     {
         return a * b * c;
     }

     public int Div(int a, int b)
     {
         return a / b;
     }

     public double Div(double a,int b) {

         return a / b;
     }

     public int Div(int a,int b, int c)
     {
         return a / b / c;
     }
    
 }

 // Main class

 class Program
{
    

    public static void Main()
    {
        Calculator cal = new Calculator();

        Console.WriteLine("Addition");
        Console.WriteLine("2+3= " + (cal.Add(2,3)));
        Console.WriteLine("2.3+2.5= " + cal.Add(2.3, 2.5));
        Console.WriteLine("1+2+9= " + cal.Add(1, 2, 9));

        Console.WriteLine("");
        Console.WriteLine("Subtraction");

        Console.WriteLine("2-1= " + cal.Sub(2, 1));
        Console.WriteLine("2.5-1= " + cal.Sub(2.5, 1));
        Console.WriteLine("10-3-1= " + cal.Sub(10, 3, 1));

        Console.WriteLine("");
        Console.WriteLine("Multiplication");

        Console.WriteLine("2*1= " + cal.Mul(2, 1));
        Console.WriteLine("2.1*2.1= " + cal.Mul(2.1, 2.1));
        Console.WriteLine("1.0*1.0*2.0= " + cal.Mul(1.0, 1.0, 2.0));

        Console.WriteLine("");
        Console.WriteLine("Division");

        Console.WriteLine("4/2= " + cal.Div(4, 2));
        Console.WriteLine("4.2/2= " + cal.Div(4.2, 2));
        Console.WriteLine("8/4/2= " + cal.Div(8, 4, 2));
    }
}
