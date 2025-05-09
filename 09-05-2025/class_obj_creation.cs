using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Student
{
    public int RollNumber;
    public string Name;
    public int Marks;

    public  void Method()
    {
        Console.WriteLine("Roll_no = " + RollNumber);
        Console.WriteLine("Name = " + Name);
        Console.WriteLine("Marks = " + Marks);

    }

}


class Program
{
    

    public static void Main()
    {
        Student student1 = new Student();
        student1.RollNumber = 1;
        student1.Name = "Rohit";
        student1.Marks = 86;

        student1.Method();

        Student student2 = new Student();
        student2.RollNumber = 2;
        student2.Name = "Prasath";
        student2.Marks = 75;

        student2.Method();


    }
}
