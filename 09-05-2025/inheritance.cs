
// parent class

 class Animal
    {
      public  string Name;
       public string Species;

        public void DisplayAnimal()
        {
            Console.WriteLine("Name ; " + Name);
            Console.WriteLine("Species : " + Species);
        }
    }

// child class inheriting parent class

internal class Dog : Animal
{
    public string Breed;

   public void DisplayDog()
    {
        Console.WriteLine("Breed : " + Breed);
    }
}

// main class

class Program
{
    

    public static void Main()
    {
        Dog mydog = new Dog();

        mydog.Name = "Buddy";
        mydog.Species = "Canine";
        mydog.Breed = "Labrador";

        mydog.DisplayAnimal();
        mydog.DisplayDog();

    }
}