using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        List<string> images = new List<string>();
        for (int i = 1; i <= 20; i++)
        {
            images.Add($"Image_{i}.jpg");
        }

        int total = images.Count;
        int processed = 0;
        object lockObj = new object();

        Console.WriteLine("Starting batch image processing...\n");

        await Parallel.ForEachAsync(images, async (image, cancellationToken) =>
        {
           
            await Task.Delay(200);

            
            int current;
            lock (lockObj)
            {
                processed++;
                current = processed;
            }

            int percentage = (current * 100) / total;
            Console.WriteLine($"Processed: {image} ({percentage}%)");
        });

        Console.WriteLine("\nAll images processed.");
    }
}

