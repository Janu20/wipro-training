    
    // the ThreadPool.QueueUserWorkItem(...) schedules work to be run on an available thread.
    using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class Class2
    {
        // This method will be executed by the threads from the thread pool
        public static void DoWork(object state)
        {
            // Display a message that the task has started
            Console.WriteLine("ThreadPool task started - " + state);

            // Simulate some work by pausing the thread for 1 second
            Thread.Sleep(1000);

            // Display a message that the task has finished
            Console.WriteLine("ThreadPool task finished - " + state);
        }

        static void Main()
        {
            // Loop to queue 5 tasks to the thread pool
            for (int i = 1; i <= 5; i++)
            {
                // QueueUserWorkItem assigns the DoWork method to a thread in the pool
                // "Task : i" is passed as the 'state' object to DoWork
                ThreadPool.QueueUserWorkItem(DoWork, "Task : " + i);
            }

            // Inform that the main thread continues its execution
            Console.WriteLine("Main thread continues...");

            // Wait for 3 seconds so thread pool threads have time to finish
            Thread.Sleep(3000);

            // End message from the main thread
            Console.WriteLine("Main thread finished");
        }
    }
}
