class Program
{
    public static void Main()
    {
        Dictionary<int, string> Student = new Dictionary<int, string>();

        //add

        Student.Add(1, "Janani");
        Student.Add(2, "Hema");
        Student.Add(3, "Komel");
        Student.Add(4, "Nisha");

        // access element by key

        Console.WriteLine("Accessing 3rd student = " + Student[3]);

        //remove element by key

        Student.Remove(4);

        //count

        Console.WriteLine("The count of the students is = "+Student.Count());

        //containskey

        Console.WriteLine("Contains student key of 1 = " + Student.ContainsKey(1));

        //contains value

        Console.WriteLine("Contains student value of  Janani = " + Student.ContainsKey(0));

        //print all key and value

        foreach (var item in Student)
        {
            Console.WriteLine(" key : "+ item.Key+" "+"value : " + item.Value);
        }
    }
}