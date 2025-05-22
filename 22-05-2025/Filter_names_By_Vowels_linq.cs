using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Names
    {
        static void Main()
        {
            List<string> list = new List<string> { "Janani","Arun","Eshwar","Tom","Isrel","Obama","Hema"};

            var filterA = list.Where(n => n.StartsWith("A"));
            var filterE= list.Where(n => n.StartsWith("E"));
            var filterI = list.Where(n => n.StartsWith("I"));
            var filterO = list.Where(n => n.StartsWith("O"));
            var filterU = list.Where(n => n.StartsWith("U"));

            foreach (var item in filterA)
            {
                Console.WriteLine(item);
            }
            foreach (var item in filterE)
            {
                Console.WriteLine(item);
            }
            foreach (var item in filterI)
            {
                Console.WriteLine(item);
            }
            foreach (var item in filterO)
            {
                Console.WriteLine(item);
            }
            foreach (var item in filterU)
            {
                Console.WriteLine(item);
            }




        }
    }
}