using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Empsalary
    {
        int Employee_id;

        double Salary;

        static void Main()
        {
            Dictionary<int,int> emp = new Dictionary<int, int>();

            emp.Add(1, 45000);
            emp.Add(2, 50000);
            emp.Add(3, 65000);
            emp.Add(4, 90000);

            int get = Convert.ToInt32(Console.ReadLine());

            foreach( var item in emp)
            {
                if (item.Key == get)
                {
                    Console.WriteLine("Salary = "+item.Value);
                }
            }
        }
    }
}
