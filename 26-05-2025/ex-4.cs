using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadQueueExample
{
    class Program
    {
        static Queue<string> taskQueue = new Queue<string>();
        static readonly object queueLock = new object();
        static bool allTasksEnqueued = false;

        static void Worker()
        {
            while (true)
            {
                string task = null;

                lock (queueLock)
                {
                    while (taskQueue.Count == 0)
                    {
                        if (allTasksEnqueued)
                            return;

                        Monitor.Wait(queueLock);
                    }

                    task = taskQueue.Dequeue();
                }


                Console.WriteLine($"Processing: {task}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread workerThread = new Thread(Worker);
            workerThread.Start();


            for (int i = 1; i <= 5; i++)
            {
                lock (queueLock)
                {
                    string task = $"Task {i}";
                    taskQueue.Enqueue(task);
                    Console.WriteLine($"Enqueued: {task}");
                    Monitor.Pulse(queueLock);
                }

                Thread.Sleep(500);


                lock (queueLock)
                {
                    allTasksEnqueued = true;
                    Monitor.Pulse(queueLock);
                }


                workerThread.Join();
                Console.WriteLine("All tasks completed. Exiting.");
            }
        }
    }
}

