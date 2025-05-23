using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class4
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Starting all tasks : ");

            Task task1 = DoWorkAsync("T1", 3000);
            Task task2 = DoWorkAsync("T2", 2000);
            Task task3 = DoWorkAsync("T3", 1000);

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("All task completed.");
        }
    
    static async Task DoWorkAsync(string name, int delay)
        {
            Console.WriteLine(name + " started.");
            await Task.Delay(delay);
            Console.WriteLine(name + " completed after the dealy " + delay + "ms");
        }
    }
}
