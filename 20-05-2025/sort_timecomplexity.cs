using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Sort
    {
        public void Bubblesort(List<int> numbers)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    int temp;
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;

                    }
                }

            }
            sw.Stop();
            Console.WriteLine("Bubble Sort Time: " + sw.Elapsed.TotalSeconds.ToString("F6") + " ms");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public void Selectionsort(List<int>numbers)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i =0;i< numbers.Count - 1; i++)
            {
                for(int j = i + 1; j < numbers.Count; j++)
                {
                    int min = numbers[0];

                    if(min > numbers[i]){

                        numbers[i] = min;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Selection Sort Time: " + sw.Elapsed.TotalSeconds.ToString("F6") + " ms");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }
        public void Insertionsort(List<int> numbers)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 1; i < numbers.Count; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            sw.Stop();
            Console.WriteLine("Insertion Sort Time: " + sw.Elapsed.TotalSeconds.ToString("F6") + " ms");

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

          
        public static void Main()
        {
            {

                List<int> numbers = new List<int>() { 3, 4, 5, 1, 7, 8, 2, 10,6,9,20,18,19,16,15,17,11,12,14,13 };

                Sort s1 = new Sort();

                s1.Bubblesort(numbers);

                Console.WriteLine("Selection sort : ");
                s1.Selectionsort(numbers);

                Console.WriteLine("Insertion sort : ");
                s1.Insertionsort(numbers);

            }

        }

    }
}