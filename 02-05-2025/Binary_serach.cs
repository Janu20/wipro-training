using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {10, 20, 30, 40, 50, 60};
        Array.Sort(arr);

        Console.WriteLine("Enter the number to search:");
        int target = int.Parse(Console.ReadLine());

        Method(arr, target);
    }

    public static void Method(int[] arr, int target)
    {
        int first = 0;
        int last = arr.Length - 1;

        while (first <= last)
        {
            int mid = (first + last) / 2;

            if (arr[mid] == target)
            {
                Console.WriteLine("Found the target " + target + " at index " + mid);
                return;
            }
            else if (arr[mid] < target)
            {
                first = mid + 1;
            }
            else
            {
                last = mid - 1;
            }
        }

        Console.WriteLine("Target not found");
    }
}
