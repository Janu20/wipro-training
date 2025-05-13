

using System;

    interface IOrder
    {
        public void PlaceOrder(string item);
        public void CancleOrder(string item);
    }
    class DineInOrder : IOrder
    {
      public void PlaceOrder(string item)
        {
            Console.WriteLine("Placing dine-in order for item" +" "+ item);

        }
        public void  CancleOrder(string item)
        {
            Console.WriteLine("Cancelling dine-in order for item" +" "+ item);

        }
    }
    internal class TakeawayOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine("Placing Takeaway order for item" + " "+item);

        }
        public void CancleOrder(string item)
        {
            Console.WriteLine("Cancelling Takeaway order for item" +" "+ item);

        }
    }
class Program
{
 
    static void Main()
    {
        IOrder O;
        O = new TakeawayOrder();
        
        O.PlaceOrder("Biriyani");
        O.CancleOrder("Pizza");
        
        O = new DineInOrder();
        
        O.PlaceOrder("Biriyani");
        O.CancleOrder("Pizza");

    }
}