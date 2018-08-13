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
            //1. Comparing Integers Exercise

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

            //2. Guess my number Exercise

            /*Random random = new Random (); 
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
            Console.Read();*/

            // 3. Grade Exercise

            //public static float GetUserInput ()
            //{
            //    int assignment;
            //    bool check = false;
            //    float percentage = 0;

            //    Console.WriteLine("**************Welcome!*****************");
            //    Console.WriteLine("\nPlease enter the marks for all assignments: ");
            //    for (int i = 1; i <= 4; i++)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Enter marks for assignment " + i + ":");
            //            assignment = int.Parse(Console.ReadLine());
            //            if (assignment >= 101 || assignment <= 0)
            //                Console.WriteLine("Error, try again.");
            //            else
            //                break;
            //        } while (!check);
            //        percentage = percentage + assignment;
            //    }

            //    return percentage/4;
            //float percentage = GetUserInput();                   


            //    Console.WriteLine("\nYour overall marks are: {0} ", percentage);

            //    if (percentage >= 90 && percentage <= 100)
            //    {
            //        Console.WriteLine("\nYour grade will be A+");
            //    }
            //    else if (percentage >= 80 && percentage <= 90)
            //    {
            //        Console.WriteLine("\nYour grade will be A");
            //    }
            //    else if (percentage >= 70 && percentage <= 80)
            //    {
            //        Console.WriteLine("\nYour grade will be B+");
            //    }
            //    else if (percentage >= 60 && percentage <= 70)
            //    {
            //        Console.WriteLine("\nYour grade will be B");
            //    }
            //    else if (percentage >= 50 && percentage <= 60)
            //    {
            //        Console.WriteLine("\nYour grade will be C");
            //    }
            //    else if (percentage >= 40 && percentage <= 50)
            //    {
            //        Console.WriteLine("\nYour grade will be D");
            //    }
            //    else if (percentage >= 0 && percentage <= 40)
            //    {
            //        Console.WriteLine("\nYour grade will be F");
            //    }
            //    else if (percentage > 100)
            //    {
            //        Console.WriteLine("\nERROR! Try again: ");
            //    }
            //    else if (percentage <= 0)
            //    {
            //        Console.WriteLine("\nERROR! Try again: ");
            //    }
            //Console.ReadLine();


            //4.Odd or Even Exercise

            /*int a = (1 - 1000);
            int b = (1 - 1000);

            Console.WriteLine("************************Welcome**********************");
            Console.WriteLine("\nChoose your first number: ", a);
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nChoose your second number: ", b);
            b = Int32.Parse(Console.ReadLine());

            if (a%b == 0)
            {
                Console.WriteLine("\nNumber is even");
            }
            else
            {
                Console.WriteLine("\nNumber is odd");
            }
            
            Console.ReadLine();*/

            //5. New pin number program

            /*int Attempts = 0;
            string pinCode1, pinCode2;
            //Simple iteration upto three times
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a 4-digit pin: ");
                pinCode1 = Console.ReadLine();
                Console.WriteLine("Re-enter your 4-digit pin again: ");
                pinCode2 = (Console.ReadLine());

                if (Attempts >= 1000 || Attempts <= 9999)
                
                    Console.WriteLine("ERROR! Pin number does not match. Please try again: ");
                
                else if (pinCode1 != "valid" || pinCode2 != "valid")
                    Attempts++;

                
                else
                {
                    Console.WriteLine("Match successful");
                }                  
                                
                    break;
            }          
            

            Console.ReadKey();*/

           
               
            }










        }

       

        
    }
}
