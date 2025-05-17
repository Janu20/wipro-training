    interface IMaintenance
    {
        public void Service();
        public void Repair();
    }
internal class CarMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}

internal class BikeMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Bike is being repaired");
    }
}

    class Program
    {

        public static void Main()
        {
            IMaintenance IM;
            IM = new CarMaintenance();
            IM.Repair();
            IM.Service();

            IM = new BikeMaintenance();
            IM.Repair();
            IM.Service();

        }
    }
