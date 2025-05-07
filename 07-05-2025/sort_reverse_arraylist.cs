using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)

    {
        ArrayList list = new ArrayList() { 2, 3, 4, 5, 9, 10, 1 };
        ArrayList list2 = new ArrayList() { 1,2,3,4,5 };



        list.Sort();
        Console.WriteLine("List after sorted :");
        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        list2.Reverse();
        Console.WriteLine("List after reversed :");
        foreach (int item in list2)
        {
            Console.WriteLine(item);
        }

    }
}





