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
        Queue<string> Q = new Queue<string>();

        Q.Enqueue("Jana");
        Q.Enqueue("Deepu");
        Q.Enqueue("Amir");
        Q.Enqueue("Harsh");

        Console.WriteLine("Peek : "+Q.Peek());
        Console.WriteLine("Dequeue : " + Q.Dequeue());
        foreach (var item in Q)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Peek : " + Q.Peek());
    }
}
