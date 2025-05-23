using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {

        public static  void PrintNumbers()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Thread " + i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Thread mythread = new Thread(PrintNumbers);
            mythread.Start();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Main " + i);
                Thread.Sleep(500);
            }

        }
    }
}
