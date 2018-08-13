using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            {
               //Variables declared by a "string" method
                string letter1, letter2, letter3;

                Console.WriteLine("****************** Palindrome *****************************");
                
                Console.WriteLine("\nEnter the first letter: ,");
                letter1 = (Console.ReadLine());

                Console.WriteLine("\nEnter the second letter: ,");
                letter2 = (Console.ReadLine());

                Console.WriteLine("\nEnter the third letter: ,");
                letter3 = (Console.ReadLine());
                //Here we are using another "if" and "else" statement inside the first "if" statement.
                //Note: There are no opening and closing braces ({}) used with the inside "if" and else statement
                //Note: With the first "if" statement, no semi-colon (;) is needed after the Parentheses (bracket)
                //Note: Also no Parentheses and "braces" used with the second "else" statement, 
                if (letter1 == letter3)
                {   //Here we are using "vowels" in our "if" statement to find if the user has selected a vowel in this exercise
                    if (letter1 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
                        Console.WriteLine("\n{0} {1} {2} is a Palindrome", letter1, letter2, letter3);
                    else 
                        Console.WriteLine("\nIt is not a palindrome");
                }
                else
                    Console.WriteLine("\n{0} {1} {2} is not a Palindrome", letter1, letter2, letter3);
                //The console will inform the user if the kletters selected are not Palindrome
                Console.WriteLine("\nEnd of exercise. Press enter to continue");              
                //At the end of your coding, you must have a "Console.ReadLine();" for the console to read your code
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
