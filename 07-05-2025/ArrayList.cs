using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)

    {
        ArrayList list = new ArrayList();

        // adding elements

        list.Add("Apple"); 
        list.Add(12);
        list.Add(12.60);

        foreach(var item in list){
            Console.WriteLine(item);
        }

        // inserting elements

        list.Insert(1, "Inserted");  

        Console.WriteLine("After inserted at 1st element : ");


        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Remove

        list.Remove("Apple"); //removing value of the element
        list.RemoveAt(1); // removing the element using index

        Console.WriteLine("After removing the elements : ");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Count of elements in arraylist

        foreach (var item in list)
        {
            Console.WriteLine("Count of list is = "+list.Count); 
            break;
        }
        //contains in the list

        if (list.Contains(12.60))
        {
            Console.WriteLine("List contains this element");
        }
        else
        {
            Console.WriteLine("List does not contains this element");
        }

        if (list.Contains("Apple"))
        {
            Console.WriteLine("List contains this element");
        }
        else
        {
            Console.WriteLine("List does not contains this element");
        }



    }
}





