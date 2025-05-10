using System;

public class Area
{
    // Method to calculate area of a rectangle
    public int CalculateRectangleArea(int length, int breadth)
    {
        return length * breadth;
    }

    // Method to calculate area of a triangle
    public double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    // Method to calculate area of a circle
    public double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Area areaCalculator = new Area();

        Console.WriteLine("Area of Rectangle: " + areaCalculator.CalculateRectangleArea(2, 3));
        Console.WriteLine("Area of Triangle: " + areaCalculator.CalculateTriangleArea(3.0, 4.0));
        Console.WriteLine("Area of Circle: " + areaCalculator.CalculateCircleArea(5.0));
    }
}
