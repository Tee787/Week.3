using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();              //declaring all variables to be used
            int randomNumber = random.Next(1, 11);
            int guess;
            int numberOfGuesses = 4;
            bool gameOver = false;

            Console.WriteLine("*****************************************************");
            Console.WriteLine("******************Guess My Number********************");
            Console.WriteLine("*****************************************************\n");
            Console.WriteLine("Guess my number between 1 and 10 What is it? ");

            while (gameOver == false)                               //While loop statement used with "if" and "if else" statements inside the "while loop" statement
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;

                if (guess != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("\nSorry, that's 4 guesses");
                    gameOver = true;
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("\nCongratulations! You have guessed my number! ");
                    gameOver = true;
                }
                else if (guess > randomNumber)

                    Console.WriteLine("\nSorry, My number is smaller than the number you have guessed. Try again: ");

                else if (guess < randomNumber)

                    Console.WriteLine("\nSorry, my number is higher than the number you have guessed. Please try again ");

            }
            Console.Read();
        }
    }
}
