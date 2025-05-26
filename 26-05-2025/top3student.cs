using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public string Name { get; set; }
        public int Marks {  get; set; }
        public string Grade { get; set; }
    }
}

        class Program
        {
            static void Main()
            {
                // 1. Add 10 students to the list
                List<Student> students = new List<Student>
            {
                new Student { Name = "Kirthicka", Marks = 95, Grade = "A+" },
                new Student { Name = "Betty", Marks = 90, Grade = "A" },
                new Student { Name = "Rohini", Marks = 85, Grade = "A" },
                new Student { Name = "Kpreetha", Marks = 98, Grade = "A+" },
                new Student { Name = "Rohith", Marks = 70, Grade = "B+" },
                new Student { Name = "Tirlok", Marks = 78, Grade = "B+" },
                new Student { Name = "Dinesh", Marks = 38, Grade = "E" },
                new Student { Name = "Heera", Marks = 60, Grade = "C" },
                new Student { Name = "KJohn", Marks = 65, Grade = "C+" },
                new Student { Name = "Charlie", Marks = 88, Grade = "A" }
            };
            var top3Students = students.OrderByDescending(s => s.Marks).Take(3);

            
            var grouped = top3Students.GroupBy(s => s.Grade);

           
            Console.WriteLine("Top 3 Students Grouped by Grade:");
            foreach (var group in grouped)
            {
                Console.WriteLine($"Grade: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  Name: {student.Name}, Marks: {student.Marks}");
                }
            }
        }
    }
}
    


