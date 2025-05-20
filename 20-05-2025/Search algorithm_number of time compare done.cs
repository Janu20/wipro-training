using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Searching
    {
        public void LinearSearch(int[] arr, int key)
        {
            int count = 0;

           for(int i = 0;i< arr.Length; i++)
            {
                
                   if (arr[i] == key)
                {

                    Console.WriteLine("Key is found" + key);
                    break;
                   
                    
                    }
                count++;
            }

            Console.WriteLine("Number of times comparison made in linear search :"+ count);
            if (count == arr.Length)
            {
                Console.WriteLine("Key not found");
            }
            }
        public void BinarySearch(int[] arr, int key)
        {
            int first = 0;
            int last = arr.Length - 1;
            int count = 0;

            while (first <= last)
            {
                int mid = (first + last) / 2;
                count++;

                if (arr[mid] == key)
                {
                    Console.WriteLine("Key found: " + key);
                   
                }
                else if (arr[mid] < key)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }

            if (count == arr.Length)
            {
                Console.WriteLine("Key not found.");
            }
            Console.WriteLine("Number of comparisons done in binary search  : " + count);
        }





        public static void Main()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the 10 numbers : ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the Key to be found : ");

            int key = int.Parse(Console.ReadLine());


            Searching S = new Searching();

            

            S.BinarySearch(arr, key);
            S.LinearSearch(arr, key);
        }
    }
}


