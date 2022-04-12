using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 1; i <= input; i++)
            {
                var names = Console.ReadLine();
                uniqueNames.Add(names);
            }
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
