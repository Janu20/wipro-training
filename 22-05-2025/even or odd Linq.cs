using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Oddoreven
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            List<int> even_num = numbers.Where(n => n % 2 == 0).ToList();

            List<int> odd_num = numbers.Where(n => n%2 != 0).ToList();

            Console.WriteLine("Even numbers are : ");

            foreach (int even in even_num)
            {
               
                Console.WriteLine(even);
            }

            Console.WriteLine("Odd numbers are : ");

            foreach (int odd in odd_num)
            {
               
                Console.WriteLine(odd);
            }



        }
    }
}
