using at_academy.crafts;
using System;


namespace at_academy.utils
{
    public class Utils
    {
        public static void calculateTotalCargoCapacity(BaseAircraft[] arr)
        {
            float total = 0f;

            foreach (var elem in arr)
            {
                total += elem.MaxCargoCapacity;
            }

            Console.WriteLine("Total cargo capacity of all avaiable aircrafts is " + total + " kg.");
            Console.WriteLine();
        }



        public static BaseAircraft[] sortByCarryingCapacity(BaseAircraft[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Sorting the list by aircraft's carrying capacity...");
            Console.WriteLine();
            BaseAircraft[] sorted_arr = arr;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].MaxCargoCapacity < arr[j].MaxCargoCapacity)
                    {
                        BaseAircraft tempAircraft = arr[i];
                        sorted_arr[i] = arr[j];
                        sorted_arr[j] = tempAircraft;
                    }
                }
            }
            return sorted_arr;
        }


        public static void search(BaseAircraft[] arr, string searchName)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name == searchName)
                {
                    Console.WriteLine();
                    Console.WriteLine("Searching for an aircraft with the name of '" + searchName + "' in our list.");
                    Console.WriteLine();
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1 match found...");
                    Console.WriteLine("Name is " + arr[i].Name);
                    Console.WriteLine("Weight is " + arr[i].Weight);
                    Console.WriteLine("Maximum Take Off Weight = " + arr[i].MaxTakeOffWeight);
                    Console.WriteLine("Maximum passengers capacity is " + arr[i].MaxPassengersCapacity);
                    Console.WriteLine("Maximum flight distance is " + arr[i].MaxDistance);
                    Console.WriteLine("Maximum cargo capacity is " + arr[i].MaxCargoCapacity);
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                }
            }
        }


        public static void printExistingAircrafts(BaseAircraft[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("List of available aircrafts is the following: ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + 1 + ". name = {0}; weight = {1}; maxTakeOffWeight = {2}; maxPassengersCapacity = {3}; maxDistance = {4}; maxCargoCapacity = {5}.",
                                            arr[i].Name,
                                            arr[i].Weight,
                                            arr[i].MaxTakeOffWeight,
                                            arr[i].MaxPassengersCapacity,
                                            arr[i].MaxDistance,
                                            arr[i].MaxCargoCapacity);
                Console.WriteLine();
            }
        }

        public static void sort(BaseAircraft[] arr, float aircraftPropery)
        {
            for (int i = 1; i < arr.Length; i++)
            {

                var a = arr[i - 1];
                var b = arr[i];

                if (a.AvgSpeed < b.AvgSpeed)
                {

                }
            }
        }

        public static void printAircraftInfo(BaseAircraft obj)
        {
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! {0}", obj);

        }


    }
}
