using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Product
    {
        public int ID;

        public string Name;

        public double Price;
    }

    class CartItem : Product
    {
        public string Product;

        public int Quantity;

        public double GetTotalPrice()
        {
            return Quantity * Price;
        }
    }
    class ShoppingCart : CartItem
    {
        List<CartItem> items = new List<CartItem>();

        public void AddItem()
        {
            int i = 1;
            while (i <= 2)
            {
                Console.WriteLine("Add " + i + " product : ");

                Console.WriteLine("Enter the product to be added");
                string addproduct = Console.ReadLine();

                Console.WriteLine("Enter the ID of the product");
                int addID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the quantity of the product");
                int addquantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the price of the product");
                double addprice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the name to be added");
                string addname = Console.ReadLine();



                base.Product = addproduct;
                base.ID = addID;
                base.Quantity = addquantity;
                base.Price = addprice;
                Name = addname;



                items.Add(new CartItem { Name = addname, Product = addproduct, ID = addID, Quantity = addquantity, Price = addprice });
                i++;
               
            }


        }
        public void RemoveItem()
        {
            Console.WriteLine("Enter product ID to remove:");
            int id = Convert.ToInt32(Console.ReadLine());

            int removedCount = items.RemoveAll(item => item.ID == id);

            if (removedCount > 0)
            {
                Console.WriteLine("Item(s) with ID " + id + " removed successfully.");
            }
            else
            {
                Console.WriteLine("No item found with ID " + id + ".");
            }
        }


        public void ShowCart()
        {
            foreach (var i in items)
            {
                Console.WriteLine("Name = "+i.Name+" ID = "+i.ID+" Product = "+i.Product+" Quantity = "+i.Quantity+" Price = "+i.Price);
                Console.WriteLine("Total price = " + i.GetTotalPrice());
            }
        }
    
}
    class program
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItem();
            cart.RemoveItem();
            cart.ShowCart();
        }
    }
}
