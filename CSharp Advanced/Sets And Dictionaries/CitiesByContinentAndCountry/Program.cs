using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int countInput = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> map = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < countInput; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!map.ContainsKey(continent))
                {
                    map[continent] = new Dictionary<string, List<string>>();
                }
                if (!map[continent].ContainsKey(country))
                {
                    map[continent][country] = new List<string>();
                }
                map[continent][country].Add(city);
            }
            foreach (var world in map)
            {
                Console.WriteLine("{0}:", world.Key);
                foreach (var countriesCities in world.Value)
                {
                    Console.Write("{0} -> ", countriesCities.Key);
                    Console.Write(String.Join(", ",countriesCities.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
