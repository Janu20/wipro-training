//parent class
 internal class Shape
 {
     public virtual void Draw()
     {
         Console.WriteLine("Drawing");
     }
 }

 // child class

   internal class Circle : Shape
  {
      public override void Draw()
      {
          Console.WriteLine("Drawing a Circle");
      }
  }

  // main class

  class Program
{
    

    public static void Main()
    {
        Shape S = new Shape();
        S.Draw();

        Circle C = new Circle();
        C.Draw();

        //Shape reference holding a circle object

        Shape SS = new Circle();


        SS.Draw();

    }
}
