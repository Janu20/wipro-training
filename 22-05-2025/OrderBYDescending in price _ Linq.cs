using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Sortproduct
    {
        public int ID;
        public string Name;
        public double Price;

        static void Main()
        {
            List<Sortproduct> product = new List<Sortproduct>();

            product.Add(new Sortproduct { ID = 1, Name = "AAA", Price = 5672 });
            product.Add(new Sortproduct { ID = 1, Name = "BBB", Price = 9872 });
            product.Add(new Sortproduct { ID = 1, Name = "CCC", Price = 5872 });
            product.Add(new Sortproduct { ID = 1, Name = "DDD", Price = 9876 });
            product.Add(new Sortproduct { ID = 1, Name = "EEE", Price = 4567 });

            var desc = product.OrderByDescending(p => p.Price);

            foreach(var item in desc)
            {
                Console.WriteLine(" Name : " + item.Name + " ID : " + item.ID + " Price : " + item.Price);
            }

        }
    }
}
