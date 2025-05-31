using System;

namespace SimpleCalculator
{
    internal class Program
    {
        
        static int Add(int a, int b) => a + b;
        static float Add(float a, float b) => a + b;
        static double Add(double a, double b) => a + b;

       
        static int Subtract(int a, int b) => a - b;
        static float Subtract(float a, float b) => a - b;
        static double Subtract(double a, double b) => a - b;

      
        static int Multiply(int a, int b) => a * b;
        static float Multiply(float a, float b) => a * b;
        static double Multiply(double a, double b) => a * b;

        static void Main(string[] args)
        {
            Console.WriteLine("Choose data type: int, float, double");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            Console.Write("Choose operation (add / subtract / multiply): ");
            string operation = Console.ReadLine().ToLower();

            if (type == "int")
            {
                int a = int.Parse(input1);
                int b = int.Parse(input2);
                ShowResult(operation, a, b);
            }
            else if (type == "float")
            {
                float a = float.Parse(input1);
                float b = float.Parse(input2);
                ShowResult(operation, a, b);
            }
            else if (type == "double")
            {
                double a = double.Parse(input1);
                double b = double.Parse(input2);
                ShowResult(operation, a, b);
            }
            else
            {
                Console.WriteLine("Invalid type.");
            }
        }

        static void ShowResult(string operation, int a, int b)
        {
            if (operation == "add") Console.WriteLine("Result: " + Add(a, b));
            else if (operation == "subtract") Console.WriteLine("Result: " + Subtract(a, b));
            else if (operation == "multiply") Console.WriteLine("Result: " + Multiply(a, b));
            else Console.WriteLine("Invalid operation.");
        }

        static void ShowResult(string operation, float a, float b)
        {
            if (operation == "add") Console.WriteLine("Result: " + Add(a, b));
            else if (operation == "subtract") Console.WriteLine("Result: " + Subtract(a, b));
            else if (operation == "multiply") Console.WriteLine("Result: " + Multiply(a, b));
            else Console.WriteLine("Invalid operation.");
        }

        static void ShowResult(string operation, double a, double b)
        {
            if (operation == "add") Console.WriteLine("Result: " + Add(a, b));
            else if (operation == "subtract") Console.WriteLine("Result: " + Subtract(a, b));
            else if (operation == "multiply") Console.WriteLine("Result: " + Multiply(a, b));
            else Console.WriteLine("Invalid operation.");
        }
    }
}
