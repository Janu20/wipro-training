abstract class Animal
   {
       public abstract void MakeSound();

       public void Eat()
       {
           Console.WriteLine("Animal is eating");
       }
   }

 internal class Dog : Animal
  {
      public override void MakeSound()
      {
          Console.WriteLine("Barks");
      }
  }

 internal class Cat : Animal
 {
     public override void MakeSound()
     {
         Console.WriteLine("Meows");
     }
 }

     class Program
    {

        public static void Main()
        {
            Animal A;
            A = new Dog();
            A.MakeSound();
            A.Eat();
            A = new Cat();
            A.MakeSound();
            A.Eat();



        }
    }
