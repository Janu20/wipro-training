using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class CountWordLinq
    {
        public static void Main()
        {
            string sentence = "C# is great and C# is fun";

            string[] word = sentence.Split( ' ' );

            var count = word.GroupBy(word => word);

            foreach (var item in count)
            {
                Console.WriteLine(item.Key + " : "+ item.Count());


            }
              
            }
        }
    }
