using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var stopwatch = Stopwatch.StartNew();

        Console.WriteLine("Fetching weather status for 3 cities");

       
        Task<string> city1 = GetWeatherAsync("Chennai");
        Task<string> city2 = GetWeatherAsync("Kolkata");
        Task<string> city3 = GetWeatherAsync("Bangalore");

       
        var results = await Task.WhenAll(city1, city2, city3);

        stopwatch.Stop();

       
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine($"\nTotal time taken: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task<string> GetWeatherAsync(string city)
    {
        var delay = new Random().Next(1000, 3000);
        await Task.Delay(delay);
        return $"Weather for {city}: {delay} ms (simulated)";
    }
}