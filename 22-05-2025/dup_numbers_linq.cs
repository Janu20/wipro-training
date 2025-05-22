using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Dupnum
    {
        static void Main()
        {
            List<int> list = new List<int> { 1,2,3,1,4,5,6,3,4,7,8,5};

            var linq = list.GroupBy(l=>l).Where(g => g.Count()>1);

            

            foreach(var item in linq)
            {
                Console.WriteLine(item.Key);
                
            }

        }
    }
}
