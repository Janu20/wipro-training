using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Phonebook
    {
        static void Main()
        {
            Dictionary<string, long> dic = new Dictionary<string, long>();

            dic.Add("Janani", 7397330875);
            dic.Add("Hemashree", 9876434682);
            dic.Add("Roshan", 9875223432);

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter the name : ");
            string name = Console.ReadLine();

            foreach (var item in dic) {

                if (name == item.Key)
                {
                    Console.WriteLine(name+" phone number is : "+item.Value);

                }
        }
        }
    }
}