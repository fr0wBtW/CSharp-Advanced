using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>(expression.Reverse());
         
            while (stack.Count != 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

                if(operand == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else if(operand == "-")
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
