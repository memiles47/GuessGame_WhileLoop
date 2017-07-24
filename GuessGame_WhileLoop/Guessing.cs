using System;

namespace GuessGame_WhileLoop
{
    internal static class Guessing
    {
        public static void Guesses(int guess, int answer)
        {
            while (guess != answer)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == 0)
                    break;

                if (guess < answer)
                    Console.Write("Please guess higher: ");

                else if (guess > answer)
                    Console.Write("Please guess lower: ");

                else
                    Console.Write("\nGreat job, you guessed correctly.");
            }

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}