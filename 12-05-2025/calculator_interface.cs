    
    // interface class
    interface ICalculator
    {
        public int Add (int a,int b);
        public int Subtract (int a, int b);

        public int Multiply(int a, int b);

        public int Divide(int a , int b);
    }

// a class implements interface

    internal class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

// main class

class Program
{
    

    public static void Main()
    {

        ICalculator calc;

        Console.WriteLine(calc = new SimpleCalculator());
        Console.WriteLine( calc.Subtract(9, 5));
        Console.WriteLine(calc.Add(10, 10));
        Console.WriteLine(calc.Multiply(4, 8));
        Console.WriteLine(calc.Divide(9, 3));

    }
}
