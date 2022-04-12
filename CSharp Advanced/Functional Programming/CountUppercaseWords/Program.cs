using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" ");

            Func<string, bool> upperCaseFirstLetter = word => char.IsUpper(word[0]);
            var upperLetterWords = text.Where(upperCaseFirstLetter);
            foreach (var word in upperLetterWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
