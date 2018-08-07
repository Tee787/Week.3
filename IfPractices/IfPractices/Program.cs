using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comparing Integers Exercise

            /*int a, b;

            Console.WriteLine("______________Welcome!________________");
            Console.WriteLine("");
            Console.WriteLine("Please enter your first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            b = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} is greater than {1}", a, b);
                Console.Read();
            }
            else if (a == b)
            {
                Console.WriteLine("a {0} is equal to b", a);
                Console.Read();
            }
            else if (a < b)
            {
                Console.WriteLine("a {0} is les than b", a);
            }

            Console.ReadLine();*/

            //Guess my number Exercise

            Random random = new Random (); 
            int randomNumber = random.Next(1, 11);
            int guess;
            int numberOfGuesses = 4;
            bool gameOver = false;

            Console.WriteLine("______________Welcome!______________");
            Console.WriteLine("");
            Console.WriteLine("Guess my number between 1 and 10 What is it? ");

            while (gameOver == false)
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
