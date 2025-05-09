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
        Console.WriteLine(cal.Add(1, 2));
    }
}

