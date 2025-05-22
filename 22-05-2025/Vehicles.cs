using System.Data.SqlClient;

abstract class Vehicle
{
    public int VehicleNumber;
    public string Brand;
    public double RatePerDay;

    public virtual double CalculateRate(int day)
    {
        return RatePerDay* day;
    }
}
class Car : Vehicle
{
    public override double CalculateRate(int day)
    {

        Console.WriteLine("Car rate :");
        int surcharge = 2000;
        return base.CalculateRate(day) + surcharge;
    }
}
class Bike : Vehicle
{
    public override double CalculateRate(int day)
    {

        Console.WriteLine("Bike rate :");
        int surcharge = 1000;
        return base.CalculateRate(day) + surcharge;
    }
}

class Truck : Vehicle
{
    public override double CalculateRate(int day)
    {
        Console.WriteLine("Truck rate :");
        int surcharge = 3000;
        return base.CalculateRate(day) + surcharge;
    }
}


class Program { 
    static void Main()
    {

        List<Vehicle> list = new List<Vehicle>();

        list.Add(new Car() { VehicleNumber = 976478, Brand = "Audi", RatePerDay = 200 });
        list.Add(new Bike() { VehicleNumber = 78976, Brand = "R-15", RatePerDay = 100 });
        list.Add(new Truck() { VehicleNumber = 800760, Brand = "Tanzz", RatePerDay = 500 });

        foreach (var vehicles in list)
        {
            Console.WriteLine("Vehicle Number = " + vehicles.VehicleNumber + " Brand = " + vehicles.Brand+ " RatePerDay = " + vehicles.RatePerDay);
            Console.WriteLine(vehicles.CalculateRate(10));
           
        }
       
}
}
