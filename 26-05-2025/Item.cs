using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Item
    {
        public string Name {  get; set; }
        public string  Type { get; set; }
        public int  Stock { get; set; }
        public int Price {  get; set; }
    }
}

 internal class ItemMain
    {
        public static void Main(string[] args)
        {
            List<Item> list = new List<Item>();

            list.Add(new Item { Name = "Samsung", Type = "Mobile", Stock = 1000, Price = 25000 });
            list.Add(new Item { Name = "Vivo", Type = "Mobile", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "HP", Type = "Laptop", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "Dell", Type = "Laptop", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "Lenovo", Type = "Laptop", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "Canon", Type = "Printer", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "HP", Type = "Printer", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "Apple", Type = "Mobile", Stock = 3000, Price = 50000 });
            list.Add(new Item { Name = "L&G", Type = "TV", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "Panasonic", Type = "TV", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "Lenovo", Type = "Mobile", Stock = 500, Price = 23000 });
            list.Add(new Item { Name = "Oppo", Type = "Mobile", Stock = 10000, Price = 18000 });
            list.Add(new Item { Name = "Sony", Type = "TV", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "Whirphool", Type = "Washing Machine", Stock = 2000, Price = 20000 });
            list.Add(new Item { Name = "IFB", Type = "Washing Machine", Stock = 2000, Price = 20000 });

            Console.WriteLine("Low stock item :");
            var Low_stock = list.OrderBy(s => s.Stock).First();

            
                Console.WriteLine(Low_stock.Name);
            

            Console.WriteLine("Group by type : ");
            var g_type = list.GroupBy(t => t.Type);

            foreach (var item in g_type)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("High priced item : ");
            var H_p = list.OrderByDescending(p => p.Price).First();

          
                Console.WriteLine(H_p.Name);
            
        }
    }
}
