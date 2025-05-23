using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Parameterthread
    {
        static void Print(object message)
        {
            Console.WriteLine(message);

        }

        static void Main()
        {
            Thread mythread = new Thread(new ParameterizedThreadStart(Print));
            mythread.Start("Hello");
        }
    }
}
