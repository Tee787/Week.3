using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Comparing Integers Exercise

            int a, b; //Declaring variables to be used

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*************************Comparing Integers**********************");
            Console.WriteLine("*****************************************************************\n");
            
            Console.WriteLine("Please enter your first number: ");
            a = Int32.Parse(Console.ReadLine());                    //Convert method used in this code
            Console.WriteLine("\nPlease enter your second number: ");
            b = Int32.Parse(Console.ReadLine());

            if (a > b)                                              //If statement used declaring whether the 1st variable is greater than 2nd variable
            {
                Console.WriteLine("{0} is greater than {1}", a, b);
                Console.Read();
            }
            else if (a == b)                                       //else if statement used declaring whether the 1st variable is equal to 2nd variable
            {
                Console.WriteLine("a {0} is equal to b", a);
                Console.Read();
            }
            else if (a < b)                                       //else if statement used declaring whether the 1st variable is less than 2nd variable
            {
                Console.WriteLine("a {0} is les than b", a);
            }

            Console.ReadLine();
        }
    }
}
