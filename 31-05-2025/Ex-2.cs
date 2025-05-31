using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Employee
    {
        public int ID;
        public string Name;
        public string Department;
        public double Salary;
    }
    class EmployeeMain
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            list.Add( new Employee{ ID = 1, Name =" Anand" ,Department = "HR",Salary=50000});
            list.Add( new Employee { ID = 2, Name = " Benny", Department = "IT", Salary = 80000 });
            list.Add(new Employee { ID = 3, Name = " Charlie", Department = "Testing", Salary = 60000 });
            list.Add(new Employee { ID = 4, Name = " Dinesh", Department = "IT", Salary = 90000 });
            list.Add(new Employee { ID = 5, Name = " Eric", Department = "HR", Salary = 45000 });
            Console.WriteLine("");
            Console.WriteLine("Select the department : ");
            Console.WriteLine("IT");
            Console.WriteLine("HR");
            Console.WriteLine("Testing");
            string enter = Console.ReadLine();
            Console.WriteLine("");

            if ( enter == "IT")
            {
                var dept_IT = list.Where(e => e.Department == "IT");
                foreach(var item in dept_IT)
                {
                    Console.WriteLine(item.Name + " " + item.Department);
                }
            }
            if (enter == "HR")
            {
                var dept_HR = list.Where(e => e.Department == "HR");
                foreach (var item in dept_HR)
                {
                    Console.WriteLine(item.Name+" "+item.Department);
                }
            }
            if (enter == "Testing")
            {
                var dept_T = list.Where(e => e.Department == "Testing");
                foreach (var item in dept_T)
                {
                    Console.WriteLine(item.Name + " " + item.Department);
                }
            }

            Console.WriteLine("Sorted Salary in descending order : ");
            Console.WriteLine("");

            var sal = list.OrderByDescending(s => s.Salary);

            foreach (var item in sal)
            {
                Console.WriteLine(item.Name+" "+item.Salary+" "+item.Department);
            }

            Console.WriteLine("Average salary by department");
            Console.WriteLine("");

            var s_d = list.GroupBy(g => g.Department);

            foreach( var group in s_d)
            {
                var avg = group.Average(s => s.Salary);
                Console.WriteLine(group.Key + " : " + avg);
            }



        }
    }
}
