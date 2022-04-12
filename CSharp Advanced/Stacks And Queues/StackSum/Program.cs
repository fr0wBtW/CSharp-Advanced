using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>(numbers);

            while (true)
            {
                var input = Console.ReadLine().ToLower();
                string[] command = input.Split();

                string firstCommand = command[0];

                if(firstCommand == "end")
                {
                    break;
                }

                if (firstCommand == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    numbersStack.Push(firstNumber);
                    int secondNumber = int.Parse(command[2]);
                    numbersStack.Push(secondNumber);
                }
                else if (firstCommand == "remove")
                {
                    int firstNumber = int.Parse(command[1]);

                    if (firstNumber > numbersStack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < firstNumber; i++)
                    {
                        numbersStack.Pop();
                    }
                }
            }
            Console.WriteLine("Sum: {0}", numbersStack.Sum());
        }
    }
}
