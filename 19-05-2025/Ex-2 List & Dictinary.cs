using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
       public int EmployeeID { get; set; }

       public string Name { get; set; }

      public  double Salary { get; set; }
    }
}
    class Program
    {

        public static void Main()
        {

            List<Employee> employee = new List<Employee>();

            employee.Add(new Employee { EmployeeID = 1, Name = "Janani", Salary = 50000 });
            employee.Add(new Employee { EmployeeID = 2, Name = "Deepak", Salary = 60000 });
            employee.Add(new Employee { EmployeeID = 3, Name = "Hari", Salary = 30000 });
            employee.Add(new Employee { EmployeeID = 4, Name = "Mano", Salary = 40000 });
            employee.Add(new Employee { EmployeeID = 5, Name = "Leeka", Salary = 30000 });

            Employee highpaid = employee.OrderByDescending(employee=>employee.Salary).First();

            Console.WriteLine("The employee getting max salary :");
            Console.WriteLine("Name : " + highpaid.Name + " "+"Salary = " + highpaid.Salary);

            Dictionary  <int,string>  edic= new Dictionary<int, string>();

            edic.Add(1, "Janani");
            edic.Add(2, "Deepak");
            edic.Add(3, "Hari");
            edic.Add(4, "Mano");
            edic.Add(5, "Leeka");

            foreach ( var item in edic)
            {
                Console.WriteLine(item);
            }

            int search = int.Parse(Console.ReadLine());
            foreach (var item in edic)
            {
                if(search == item.Key)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
