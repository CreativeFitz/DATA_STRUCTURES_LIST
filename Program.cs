using System;
using System.Collections.Generic;

namespace Chapter4_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////Planet and Spaceships ///////////////////////

            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //Add() Jupiter and Saturn at the end of the list.
            // Create another List that contains that last two planet of our solar system.
            // Combine the two lists by using AddRange().
            // Use Insert() to add Earth, and Venus in the correct order.
            // Use Add() again to add Pluto to the end of the list.
            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> finalPlanets = new List<string>(){
                "Uranus",
                "Neptune"
            };

            List<string> rockyPlanets = new List<string>();

            planetList.AddRange(finalPlanets);

            planetList.ForEach(planet => Console.WriteLine(planet));

            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            rockyPlanets = planetList.GetRange(0, 4);

            Console.WriteLine("-----------------------------------------");

            planetList.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine("-----------------------------------------");

            rockyPlanets.ForEach(planet => Console.WriteLine(planet));

            Console.WriteLine("-----------------------------------------");

            Random random = new Random();
            List<int> numbers = new List<int> {
                        random.Next(6),
                        random.Next(6),
                        random.Next(6),
                        random.Next(6),
                        random.Next(6),
                        random.Next(6),
                    };

                    for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
   if (numbers.Contains(i)){
       Console.WriteLine($"numbers list contains {i}");
   } else {Console.WriteLine($"numbers list does not contain {i}");
   }
};




        }
    }
}
