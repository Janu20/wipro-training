using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp4
{
    internal class Exthread
    {
        static void Main()
        {
            int a = 10;
            int b = 30;

            Thread mythread = new Thread(() =>
            {
                Console.WriteLine("Sum " + (a + b));
            });

            mythread.Start();
        }
    }
}
