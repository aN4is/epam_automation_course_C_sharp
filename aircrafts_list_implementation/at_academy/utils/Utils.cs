using at_academy.crafts;
using System;
using System.Collections.Generic;

namespace at_academy.utils
{
    public class Utils
    {
        public static void CalculateTotalCargoCapacity(List<BaseAircraft> list)
        {
            float total = 0f;

            foreach (var elem in list)
            {
                total += elem.MaxCargoCapacity;
            }

            Console.WriteLine("Total cargo capacity of all avaiable aircrafts is " + total + " kg.");
            Console.WriteLine();
        }



        public static List<BaseAircraft> SortByCarryingCapacity(List<BaseAircraft> list)
        {
            Console.WriteLine();
            Console.WriteLine("Sorting the list by aircraft's carrying capacity...");
            Console.WriteLine();
            List<BaseAircraft> sorted_list = new List<BaseAircraft>(list);
            sorted_list.Sort(delegate (BaseAircraft x, BaseAircraft y)
            {
                return x.MaxCargoCapacity.CompareTo(y.MaxCargoCapacity);
            });

            return sorted_list;
        }

        //public static List<BaseAircraft> SortByCarryingCapacity(List<BaseAircraft> list)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Sorting the list by aircraft's carrying capacity...");
        //    Console.WriteLine();
        //    List<BaseAircraft> sorted_list = new List<BaseAircraft>(list);

        //    for (int i = 0; i < sorted_list.Count; i++)
        //    {
        //        for (int j = i + 1; j < sorted_list.Count; j++)
        //        {
        //            if (sorted_list[j-1].MaxCargoCapacity > sorted_list[j].MaxCargoCapacity)
        //            {
        //                sorted_list.Insert(j-1, list[j]);
        //                sorted_list.RemoveAt(j + 1);
        //            }
        //        }
        //    }
        //    return sorted_list;
        //}

        public static void Search(List<BaseAircraft> list, string searchName)
        {
            foreach (BaseAircraft elem in list)
            {
                if (elem.Name == searchName)
                {
                    Console.WriteLine();
                    Console.WriteLine("Searching for an aircraft with the name of '" + searchName + "' in our list.");
                    Console.WriteLine();
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("1 match found...");
                    Console.WriteLine("Name is " + elem.Name);
                    Console.WriteLine("Weight is " + elem.Weight);
                    Console.WriteLine("Maximum Take Off Weight = " + elem.MaxTakeOffWeight);
                    Console.WriteLine("Maximum passengers capacity is " + elem.MaxPassengersCapacity);
                    Console.WriteLine("Maximum flight distance is " + elem.MaxDistance);
                    Console.WriteLine("Maximum cargo capacity is " + elem.MaxCargoCapacity);
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                }
            }
        }


        public static void PrintExistingAircrafts(List<BaseAircraft> list)
        {
            Console.WriteLine();
            Console.WriteLine("List of available aircrafts is the following: ");
            Console.WriteLine();
            int i = 0;
            foreach (BaseAircraft elem in list)
            {
                Console.WriteLine(i + 1 + ". name = {0}; weight = {1}; maxTakeOffWeight = {2}; maxPassengersCapacity = {3}; maxDistance = {4}; maxCargoCapacity = {5}.",
                                            elem.Name,
                                            elem.Weight,
                                            elem.MaxTakeOffWeight,
                                            elem.MaxPassengersCapacity,
                                            elem.MaxDistance,
                                            elem.MaxCargoCapacity);
                Console.WriteLine();
                i++;
            }
        }        
    }
}
