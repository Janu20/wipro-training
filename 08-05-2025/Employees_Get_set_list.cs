using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }

}


class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { ID = 1, Name = "Janani G"});
        employees.Add(new Employee { ID = 2, Name = "Nisha" });
        employees.Add(new Employee { ID = 3, Name = "Hema" });
        employees.Add(new Employee { ID = 4, Name = "Priya" });
        employees.Add(new Employee { ID = 5, Name = "Kowsi" });

        employees.RemoveAll(e => e.Name == "Priya");

        if (employees.Exists (e => e.Name =="Janani G"))
        {

            Console.WriteLine("contains");
        }
        else
        {
            Console.WriteLine("Not contains");
        }
        foreach(Employee employee in employees)
        {
            Console.WriteLine("ID : " + employee.ID + "Name : " + employee.Name );
        }
        Console.WriteLine("Total number of employees = " + employees.Count);

        Console.WriteLine(employees.Find(e => e.Name.EndsWith('a')));
    }
}
