// abstract class

abstract class Shape
{
    public abstract void Draw();

    public void Display()
    {
        Console.WriteLine("This is a shape");
    }

}

// abstract method implementing class

 class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// main class

class Program
{
    

    public static void Main()
    {

        Circle circle = new Circle();

        circle.Draw();
        

    }
}
