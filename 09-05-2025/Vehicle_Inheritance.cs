 //Parent class

 internal class Vehicle
 {
     public string Make;
     public string Model;

     public void DisplayVehicle()
     {
         Console.WriteLine("Make : " + Make);
         Console.WriteLine("Model : " + Model);
     }
 }

 // derived class

 internal class Car : Vehicle
{
    public string FuelType;

   public void DisplayCar()
    {
        Console.WriteLine("Car Fuel type : " + FuelType);
    }
}

// Main class

class Program
{
    

    public static void Main()
    {
        Car mycar = new Car();

        mycar.Make = "Toyota";
        mycar.Model = "Corolla";
        mycar.FuelType = "Petrol";

        mycar.DisplayVehicle();
        mycar.DisplayCar();

    }
}