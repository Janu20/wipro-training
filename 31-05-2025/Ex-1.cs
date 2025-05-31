using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Vehicel
    {
        public void VMethod()
        {
            Console.WriteLine("Welcome to Happy Vehicles!!!!");
            Console.WriteLine("");
        }
    }
    class Bike : IRentable
    {
        public void Rent()
        {
            Console.WriteLine("--------Rent for Bike---------");
            Console.WriteLine("");
            Console.WriteLine("Enter the numbers of days to be rented : ");

            int days_b = Convert.ToInt32(Console.ReadLine());
            int amountperday_b = 100;
            int tot_cost_b = days_b * amountperday_b;
            Console.WriteLine("The amount calculated for the days you wanted to be rented = " + tot_cost_b);
            Console.WriteLine("");

        }

    }
    class Car : IRentable
    {
        public void Rent()
        {
            Console.WriteLine("--------Rent for Car---------");
            Console.WriteLine("");
            Console.WriteLine("Select the type of car the amount vary for different cars : ");
            Console.WriteLine("-> Mini ");
            Console.WriteLine("-> Prime");
            Console.WriteLine("-> Mega Prime");

            string Car_Type = Console.ReadLine();
            if (Car_Type == "Mini")
            {
                Console.WriteLine("Enter the numbers of days to be rented : ");

                int days_mini = Convert.ToInt32(Console.ReadLine());
                int amountperday_mini = 200;
                int tot_cost_M = days_mini * amountperday_mini;
                Console.WriteLine("The amount calculated for the days you wanted to be rented = " + tot_cost_M);
                Console.WriteLine("");

            }
            if (Car_Type == "Prime")
            {
                Console.WriteLine("Enter the numbers of days to be rented : ");

                int days_prime = Convert.ToInt32(Console.ReadLine());
                int amountperday_prime = 200;
                int tot_cost_P = days_prime * amountperday_prime;
                Console.WriteLine("The amount calculated for the days you wanted to be rented = " + tot_cost_P);
                Console.WriteLine("");

            }
            if (Car_Type == "Mega Prime")
            {
                Console.WriteLine("Enter the numbers of days to be rented : ");

                int days_mega = Convert.ToInt32(Console.ReadLine());
                int amountperday_mega = 200;
                int tot_cost_M = days_mega * amountperday_mega;
                Console.WriteLine("The amount calculated for the days you wanted to be rented = " + tot_cost_M);
                Console.WriteLine("");

            }


        }

    }
    class Truck : IRentable
    {
        public void Rent()
        {
            Console.WriteLine("--------Rent for Truck---------");
            Console.WriteLine("");
            Console.WriteLine("Enter the numbers of days to be rented : ");

            int days_T = Convert.ToInt32(Console.ReadLine());
            int amountperday_T = 600;
            int tot_cost_T = days_T * amountperday_T;
            Console.WriteLine("The amount calculated for the days you wanted to be rented = " + tot_cost_T);
            Console.WriteLine("");

        }

    }

    interface IRentable
    {
        public void Rent();
    }
    class Pro
    {
        public static void Main(string[] args)
        {
            Vehicel vehicel = new Vehicel();
            vehicel.VMethod();

            Console.WriteLine("Select the type of vehicle");
            Console.WriteLine("1.Bike");
            Console.WriteLine("2.Car");
            Console.WriteLine("3.Truck");

            string type = Console.ReadLine();



            IRentable rent;

            if (type == "Truck")
            {
                rent = new Truck();
                rent.Rent();
            }
            if (type == "Car")
            {
                rent = new Car();
                rent.Rent();
            }
            if (type == "Bike")
            {
                rent = new Bike();
                rent.Rent();
            }


        }
    }
}
