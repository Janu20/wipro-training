using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Product
    {
        public string Name;

        public double price;

        static void Main()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product { Name = "AAA", price = 1098.45 });
            product.Add(new Product { Name = "BBB", price = 489.23 });
            product.Add(new Product { Name = "CCC", price = 3897.34 });

            var Filter_list = product.Where(p => p.price > 500);

            foreach(var item in Filter_list)
            {
                Console.WriteLine(item.Name+" , "+item.price);
            }

        }
    }
}
