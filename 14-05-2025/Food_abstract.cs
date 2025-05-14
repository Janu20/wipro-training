 abstract class FoodOrder
 {
     public abstract void PlaceOrder(string item);

     public void OrderInfo()
     {
         Console.WriteLine("Placing food order");
     }
 }
   internal class FastFoodOrder : FoodOrder
  {
      public override void PlaceOrder(string item)
      {
          Console.WriteLine("Order placed for " + item + " at Fast Food Outlet");
      }
  }
   internal class FineDiningOrder : FoodOrder
 {
     public override void PlaceOrder(string item)
     {
         Console.WriteLine("Order placed for " + item + " at Fine Dining Restaurent");
     }
 }
 class Program
{
 
    static void Main()
    {
        FoodOrder fo;
        fo = new FastFoodOrder();
        fo.PlaceOrder("Pizza");

        fo = new FineDiningOrder();
        fo.PlaceOrder("Idly-Sambar");


        


    }
}