using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        public static void Dowork(string name)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Thread " + name + " Step " + i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Thread " + name + " finished");
        }
    
    static void Main()
        {
            Thread t1 = new Thread(() => Dowork("A"));
            Thread t2 = new Thread(() => Dowork("B"));
            Thread t3 = new Thread(() => Dowork("C"));

            t1.Start();
            t1.Join(); // make sure after the t1 completes the t2 will executes

            t2.Start();
            t2.Join();

            t3.Start();
            t3.Join();
        }
    }
}
