using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Student
    {
        public static void Main() {
            List<string> stu = new List<string>();

            stu.Add("Janani");
            stu.Add("Hema");
            stu.Add("Arthy");
            stu.Add("Betty");
            stu.Add("Keerthana");

           foreach(var students in stu)
            {
                Console.WriteLine(students);
            }

            stu.Sort();

            Console.WriteLine("Student names after sorted");

            foreach (var students in stu)
            {
                Console.WriteLine(students);
            }
        }
    }
}
