using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class StudentLinq
    {
        public string Name;
        public int Marks;
    
    static void Main()
        {
            List<StudentLinq> student = new List<StudentLinq>();

            student.Add(new StudentLinq { Name = "Kowshik", Marks = 89 });
            student.Add(new StudentLinq { Name = "Anand", Marks = 65 });
            student.Add(new StudentLinq { Name = "Shankar", Marks = 75 });
            student.Add(new StudentLinq { Name = "Benny", Marks = 90 });
            student.Add(new StudentLinq { Name = "Charles", Marks = 50 });
            student.Add(new StudentLinq { Name = "Dinesh", Marks = 60 });

            var Filter = student.OrderByDescending(s => s.Marks).Take(3);

            foreach (var item in Filter)
            {
                Console.WriteLine(item.Name + " " + item.Marks);
            }

        }
    }
}
