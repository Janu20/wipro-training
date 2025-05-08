
   
    public static void Main(string[] args)

    {
       //List creation

        List<string> fruits = new List<string>() { "Apple", "Banana" };

        // add elements

        fruits.Add("Cherry");
        fruits.Add("Mango");
        fruits.Add("Grapes");

        //insert elements

        fruits.Insert(2, "Blueberry");

        //remove elements

        fruits.Remove("Banana");

        // remove elements using index

        fruits.RemoveAt(3);

        //check elements using contains

        if (fruits.Contains("Apple"))
        {
            Console.WriteLine("Present 'apple'");
        }
        else
        {
            Console.WriteLine("Not present 'apple'");
        }

        // sort elements

        fruits.Sort();

        foreach (string item in fruits)
        {
            Console.WriteLine(item);
        }

        
    }
}