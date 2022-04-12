using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string readText = Console.ReadLine();
            Stack<char> text = new Stack<char>();

            foreach (var item in readText)
            {
                char text1 = item;
                text.Push(text1);
               
            }
           while(text.Count != 0)
            {
                Console.Write(text.Pop());
            }
            Console.WriteLine();
        }
    }
}
