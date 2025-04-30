using System;

public class HelloWorld
{
    public static void method(int[] arr, int array_element)
    {
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == array_element)
            {
                Console.WriteLine("The element " + array_element + " is found at index: " + i);
                found = true;
                break; 
            }
        }

        if (!found)
        {
            Console.WriteLine("The element " + array_element + " was not found in the array.");
        }
    }

    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.Write("Give me the array element: ");
        int array_element = int.Parse(Console.ReadLine());

        method(arr, array_element);
    }
}
