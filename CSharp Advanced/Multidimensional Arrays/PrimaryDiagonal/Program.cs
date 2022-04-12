using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] squareMatrix = new int[input, input];

            for (int i = 0; i < squareMatrix.GetLength(0); i++)
            {
                var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < squareMatrix.GetLength(1); j++)
                {
                    squareMatrix[i, j] = numbers[j];
                }
            }
            int sum = 0;
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    sum += squareMatrix[row, row];
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
