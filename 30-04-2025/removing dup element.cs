using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 1, 2, 4, 5, 5 };
        int n = arr.Length;

        // Create a new array to store unique elements
        int[] tempArr = new int[n];
        int tempIndex = 0;

        // Loop through the original array
        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;

            // Check if the element is already in the tempArr
            for (int j = 0; j < tempIndex; j++)
            {
                if (arr[i] == tempArr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            // If it's not a duplicate, add it to the tempArr
            if (!isDuplicate)
            {
                tempArr[tempIndex] = arr[i];
                tempIndex++;
            }
        }

        // Print the unique elements
        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < tempIndex; i++)
        {
            Console.WriteLine(tempArr[i]);
        }
    }
}
