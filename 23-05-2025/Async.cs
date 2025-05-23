using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class3
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Work started");

            await DoAsyncWork();

            Console.WriteLine("Work completed..");
        }
        static async Task DoAsyncWork()
        {
            Console.WriteLine("Working...");
            await Task.Delay(2000);
            Console.WriteLine("Async work done");
        }
    }
}
