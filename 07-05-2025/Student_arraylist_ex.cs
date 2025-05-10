using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)

    {
        ArrayList students = new ArrayList() ;

        students.Add("Janani");
        students.Add("Hema");
        students.Add("Priya");
        students.Add("Sagar");
        students.Add("Dhanush");

        Console.WriteLine("The added names are : ");
        foreach (string item in students)
        {
            Console.WriteLine(item);
        }

        students.RemoveAt(2);
        Console.WriteLine("The elements after the 2nd name removed  : ");
        foreach (string item in students)
        {
            Console.WriteLine( item);
        }



    }
}




