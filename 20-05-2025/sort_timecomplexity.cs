using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Sort
    {
        public void Bubblesort(int[] numbers)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
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

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public void Selectionsort(int[] numbers)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i =0;i< numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    int min = numbers[0];

                    if(min > numbers[i]){

                        numbers[i] = min;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Selection Sort Time: " + sw.Elapsed.TotalSeconds.ToString("F6") + " ms");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
        public void Insertionsort(int[] numbers)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 1; i < numbers.Length; i++)
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


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

          
        public static void Main()
        {
            {

                int[] numbers = new int[20];

                Console.WriteLine("Enter the 20 numbers to be sorted : ");

               for(int i = 0; i < numbers.Length; i++)
                {
                   numbers[i] = int.Parse(Console.ReadLine());
                }

                Sort s1 = new Sort();

                s1.Bubblesort(numbers);

               
                s1.Selectionsort(numbers);

               
                s1.Insertionsort(numbers);

            }

        }

    }
}