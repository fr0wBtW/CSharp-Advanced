using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>(Console.ReadLine().Split(' '));
            int number = int.Parse(Console.ReadLine());

            while (names.Count != 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    var nthChild = names.Dequeue();
                    names.Enqueue(nthChild);
                }
                Console.WriteLine("Removed {0}", names.Dequeue());
            }
            Console.WriteLine("Last is {0}", names.Dequeue());
        }
    }
}

