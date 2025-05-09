using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using ConsoleApp1;
class Program
{
    

    public static void Main()
    {
        //EXTERNAL INSTANTIATION

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

        //INLINE INSTANTIATION

        Student student3 = new Student { RollNumber = 3 ,Name ="Janani",Marks =98};

        Student student4 = new Student { RollNumber = 4 ,Name="Deepak",Marks=95};

        student3.Method();
        student4.Method();


    }
}
