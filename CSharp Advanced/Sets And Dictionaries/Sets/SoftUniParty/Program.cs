using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            while(true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                char isNumber = input[0];

                if (char.IsDigit(isNumber))
                {
                    vipGuests.Add(input);
                }
                else if (input.Length == 8)
                {
                    regularGuests.Add(input);
                }
            }
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                char isNumber = input[0];

                if (char.IsDigit(isNumber))
                {
                    vipGuests.Remove(input);
                }
                else if (input.Length == 8)
                {
                    regularGuests.Remove(input);
                }
            }
            int sum = vipGuests.Count + regularGuests.Count;
            Console.WriteLine(sum);

            if (vipGuests.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipGuests));
            }
            Console.WriteLine(string.Join(Environment.NewLine, regularGuests));
        }
    }
}
