using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Ex_10
    {
        static void Main()
        {
            int count = 1;

            Dictionary<string, int> Eng = new Dictionary<string, int>();
            Dictionary<string, int> Tam = new Dictionary<string, int>();
            Dictionary<string, int> Sci = new Dictionary<string, int>();
            Dictionary<string, int> Soc = new Dictionary<string, int>();
            Dictionary<string, int> Math = new Dictionary<string, int>();
            Dictionary<string, int> Total = new Dictionary<string, int>();

            while (count <= 3)
            {
                Console.WriteLine($"\nStudent {count}:");
                Console.Write("Enter your Name: ");
                string name = Console.ReadLine();

                English(Eng, Total, name);
                Tamil(Tam, Total, name);
                Social(Soc, Total, name);
                Science(Sci, Total, name);
                Maths(Math, Total, name);

                count++;
            }

            Console.WriteLine("\nTotal Scores for each student:");
            foreach (var entry in Total)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }

            var avg = Total.Average(a => a.Value);
            Console.WriteLine("Average Score = " + avg);

            var minimum = Total.Min(m => m.Value);
            Console.WriteLine("Minimum score = "+minimum);

            var maximum = Total.Max(m => m.Value);
            Console.WriteLine("Maximum Score = "+maximum);
        }

        public static void English(Dictionary<string, int> Eng, Dictionary<string, int> Total, string name)
        {
            Console.Write("Enter your English Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            Eng[name] = mark;

            if (!Total.ContainsKey(name))
                Total[name] = 0;

            Total[name] += mark;

        }

        public static void Tamil(Dictionary<string, int> Tam, Dictionary<string, int> Total, string name)
        {
            Console.Write("Enter your Tamil Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            Tam[name] = mark;

            if (!Total.ContainsKey(name)) Total[name] = 0;
            Total[name] += mark;
        }

        public static void Social(Dictionary<string, int> Soc, Dictionary<string, int> Total, string name)
        {
            Console.Write("Enter your Social Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            Soc[name] = mark;

            if (!Total.ContainsKey(name)) Total[name] = 0;
            Total[name] += mark;
        }

        public static void Science(Dictionary<string, int> Sci, Dictionary<string, int> Total, string name)
        {
            Console.Write("Enter your Science Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            Sci[name] = mark;

            if (!Total.ContainsKey(name)) Total[name] = 0;
            Total[name] += mark;
        }

        public static void Maths(Dictionary<string, int> Math, Dictionary<string, int> Total, string name)
        {
            Console.Write("Enter your Maths Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            Math[name] = mark;

            if (!Total.ContainsKey(name)) Total[name] = 0;
            Total[name] += mark;
        }
    }
}
