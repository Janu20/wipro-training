using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Countstu
    {
        public string Name;
        public int Marks;

        static void Main()
        {
            List<Countstu> stu = new List<Countstu>();

            stu.Add(new Countstu { Name = "Anvith", Marks = 67 });
            stu.Add(new Countstu { Name = "Bob", Marks = 78 });
            stu.Add(new Countstu { Name = "Charls", Marks = 60 });
            stu.Add(new Countstu { Name = "Devid", Marks = 89});
            stu.Add(new Countstu { Name = "Zain", Marks = 97 });

            var avg = stu.Average(s => s.Marks);
            int count = 0;

             foreach(var item in stu)
                {
                 if (item.Marks > avg)
                {
                    Console.WriteLine(item.Name);
                    count++;
                }

                }
            Console.WriteLine("Number of students scored above average = " +count);
            }
        }
    }

