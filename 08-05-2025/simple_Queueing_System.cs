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
        Queue<string> customers = new Queue<string>();

        customers.Enqueue("Preethi");
        customers.Enqueue("Rohith");
        customers.Enqueue("Somesh");
        customers.Enqueue("Sandy");

        Console.WriteLine("Seving customer : ");

        while(customers.Count > 0)
        {
            Console.WriteLine(customers.Dequeue());
        }
    }
}
