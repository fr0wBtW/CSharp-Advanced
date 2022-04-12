using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> inputNumbers = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    inputNumbers.Enqueue(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(", ", inputNumbers));
        }
    }
}
