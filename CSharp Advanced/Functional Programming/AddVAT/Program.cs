using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersWithVAT = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x + (x * 20 / 100));
            foreach (var number in numbersWithVAT)
            {
                Console.WriteLine("{0:F2}", number);
            }
        }
    }
}
