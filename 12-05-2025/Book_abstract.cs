// abstract class

    abstract class Book
    {
        public abstract void Read();

        public void GetInfo()
        {
            Console.WriteLine("This is a book");
        }
    }

// class 1

  class FictionBook : Book
 {
     public override void Read()
     {
         Console.WriteLine("Reading a fiction book");
     }
 }
//class 2

    class ScienceBook : Book
    {
        public override void Read()
        {
            Console.WriteLine("Reading a Science book");
        }
    
}
// main class

class Program
{
    

    public static void Main()
    {

        Book book;

        book = new FictionBook();
        book.GetInfo();
        book.Read();

        book = new ScienceBook();
        book.GetInfo();
        book.Read();




    }
}
