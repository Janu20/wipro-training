using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int count = 1;
        int[] arr = { 1, 2, 3, 1, 2, 4, 5, 5 };
        bool[] visited = new bool[arr.Length]; 

        for (int i = 0; i < arr.Length; i++)
        {
            if (visited[i]) continue;

            count = 1;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true; 
                }
            }

            Console.WriteLine(arr[i] + " has been repeated " + count + " time(s)");
        }
    }
}
