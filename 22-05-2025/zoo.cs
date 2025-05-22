

public abstract class Animal
{
    
    public string Name { get; set; }
    public int Age { get; set; }

   
    public abstract void MakeSound();

    
    public void Feed()
    {
        Console.WriteLine("Feeding the animal");
    }
}
public class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the lion roars!");
    }
}


public class Elephant : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the elephant trumpets!");
    }
}


public class Monkey : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the monkey chatters!");
    }
}
public class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the lion roars!");
    }
}


public class Elephant : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the elephant trumpets!");
    }
}


public class Monkey : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the monkey chatters!");
    }
}using System;

public class Program
{
    public static void Main()
    {
       
        Zoo zoo = new Zoo();

     
        Lion lion = new Lion { Name = "Leo", Age = 5 };
        Elephant elephant = new Elephant { Name = "Ella", Age = 10 };
        Monkey monkey = new Monkey { Name = "Momo", Age = 3 };

        zoo.AddAnimal(lion);
        zoo.AddAnimal(elephant);
        zoo.AddAnimal(monkey);

        
        zoo.MakeAllSounds();

      
        zoo.FeedAllAnimals();
    }
}

