using System;

namespace GuessGame_WhileLoop
{
    internal static class Program
    {
        private static void Main()
        {
            var rnd = new Random();

            Console.Write("Please enter the maximum answer you wish to guess: ");
            var maxAnswer = Convert.ToInt32(Console.ReadLine());
            var answer = rnd.Next(1, maxAnswer + 1);

            Console.Clear();
            Console.Write($"Please enter your guess between 1 and {maxAnswer}, or 0 to exit: ");

            Guessing.Guesses(answer + 1, answer);
        }
    }
}
