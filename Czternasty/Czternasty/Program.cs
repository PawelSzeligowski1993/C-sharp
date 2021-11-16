using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czternasty
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int gessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;

                if (guessCount == gessLimit)
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses != true)
            {
                Console.Write("You Win!");
            }else
                Console.Write("You Loser!");

            Console.ReadLine();
        }
    }
}
