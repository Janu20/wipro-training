using System;

interface Ishape{
    
    void Draw();
}

class Circle : Ishape{
    
    public void Draw (){
        Console.WriteLine("Drawing a circle");
    }
}
class Program {
	static void Main() {
      Circle c = new Circle();
      c.Draw();
	}
}