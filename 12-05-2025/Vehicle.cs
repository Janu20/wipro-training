//abstract class
    abstract class Vehicle
    {
        public string Brand;
        public int Year;

        public void DiaplayInfo()
        {
            Console.WriteLine("Brand : " + Brand +"\n"+ " Year : " + Year);
            Console.WriteLine(" ");
        }

        public abstract void Start();
    }

// class 1 implements abstract method

 class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("The car starting with the key");
        Console.WriteLine(" ");
    }
}

// class 2 implements abstract method

  class Bike : Vehicle
 {
     public override void Start()
     {
         Console.WriteLine("The bike starting with the kick");
         Console.WriteLine(" ");
     }
 }

//main class

class Program
{
    

    public static void Main()
    {

        Car car = new Car();

      
        car.Brand = "Rolls-Roys La Rose Noire Droptail";
        car.Year = 2023;

        car.DiaplayInfo();
        car.Start();

        

        Bike bike = new Bike();

        bike.Brand = "Neiman Marcus";
        bike.Year = 2008;

        bike.DiaplayInfo();
        bike.Start();

        
        

    }
}
