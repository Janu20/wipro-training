using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
class Program
{
    public static void Main()
    {
        ArrayList students = new ArrayList();

        students.Add("Rakesh");
        students.Add("Praveen");
        students.Add("yuvan");
        students.Add("Kannan");
        students.Add("Dev");

        students.Remove("Praveen");

        Console.WriteLine("Names after removed 'Praveen' : ");

        foreach(var item in students)
        {
            Console.WriteLine(item);
        }

        if (students.Contains("yuvan"))
        {
            Console.WriteLine("It has 'yuvan' name");
        }

        else
        {
            Console.WriteLine("It has 'yuvan' name");
        }




    }
}
