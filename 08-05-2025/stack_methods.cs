using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
class Program
{
    public static void Main()
    {
        Stack<string> books = new Stack<string>();

        books.Push("C# Programming");
        books.Push("Machine Learning");
        books.Push("Data structures and algorithms");

        Console.WriteLine("Pushed books are : ");

        foreach(var item in books)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Popped book : " + books.Pop());

        Console.WriteLine("Peeked book : " + books.Peek());





    }
}
