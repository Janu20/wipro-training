using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class EmployeeLinq
    {
        public string Name;
        public string Department;

        public static void Main()
        {
            List<EmployeeLinq> emp = new List<EmployeeLinq>();

            emp.Add(new EmployeeLinq { Name = "Janani", Department = "Software Developer" });

            emp.Add(new EmployeeLinq { Name = "Pranesh", Department = "Software Developer" });

            emp.Add(new EmployeeLinq { Name = "Leeka", Department = "Tester" });

            emp.Add(new EmployeeLinq { Name = "Tom", Department = "Tester" });

            emp.Add(new EmployeeLinq { Name = "Stuvet", Department = "HR" });

            emp.Add(new EmployeeLinq { Name = "James", Department = "HR" });

            var Filter = emp.GroupBy(emp => emp.Department);

            foreach(var filtered in Filter)
            {
                Console.WriteLine(filtered.Key + " : " );

                foreach(var f in filtered)
                {
                    Console.WriteLine(f.Name);
                }
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
