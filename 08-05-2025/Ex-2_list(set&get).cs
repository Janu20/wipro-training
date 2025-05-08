using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Price { get; set; }
}



class Program
{
    

    public static void Main()
    {
        List<Product> products = new List<Product>();
        products.Add (new Product  { Id=1, Name="AAA", Price=24509});
        products.Add(new Product { Id=2, Name="BBB", Price=45000});
        products.Add(new Product { Id = 3, Name = "CCC", Price = 55000 });
        products.Add(new Product { Id = 4, Name = "DDD", Price = 95000 });
        products.Add(new Product { Id = 5, Name = "EEE", Price = 46000 });

        var des_order_price = products.OrderByDescending(p => p.Price);

        Console.WriteLine("Sorted in descending order by price : " );

        foreach(var item in des_order_price)
        {
            Console.WriteLine(item.Price);
        }

        var max_price = products.Max(p => p.Price);
        Console.WriteLine("The product with highest price is " + max_price);

        var min_price = products.Min(p => p.Price);
       
        Console.WriteLine("The product with Lowest price is " + min_price);








    }
}