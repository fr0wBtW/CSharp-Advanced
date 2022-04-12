using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Paid")
                {
                  while(names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else if (input == "End")
                {
                    break;
                }
                else
                {
                    names.Enqueue(input);
                }
            }
            Console.WriteLine("{0} people remaining.", names.Count);
        }
    }
}
