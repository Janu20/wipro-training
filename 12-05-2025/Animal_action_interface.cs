//interface
    interface IAnimalActions
    {
        public void Eat();
        public void Sleep();
    }

// class 1

     class Lion : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine(" Lion is eating meat");
            Console.WriteLine(" ");
        }

        public void Sleep()
        {
            Console.WriteLine("Lion is sleeping");
            Console.WriteLine(" ");

        }
    }

//class 2

     class Elephant : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine(" Elephant is eating grass");
            Console.WriteLine(" ");
        }

        public void Sleep()
        {
            Console.WriteLine("Elephant is sleeping");
            Console.WriteLine(" ");

        }
    }

// main class

class Program
{
    

    public static void Main()
    {

        IAnimalActions animal;

        animal = new Lion();

        animal.Eat();
        animal.Sleep();

        animal = new Elephant();
        animal.Eat();
        animal.Sleep();





    }
}
