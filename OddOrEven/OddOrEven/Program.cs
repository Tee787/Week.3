using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = (1 - 1000);
            int b = (1 - 1000);

            Console.WriteLine("****************************************************************");
            Console.WriteLine("************************Odd or Even Number**********************");
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("\nChoose your first number: ", a);
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nChoose your second number: ", b);
            b = Int32.Parse(Console.ReadLine());

            if (a%b == 0)                               //Modulus operator used to define a remainder if any
            {
                Console.WriteLine("\nNumber is even");
            }
            else
            {
                Console.WriteLine("\nNumber is odd");
            }

            Console.ReadLine();

        }
    }
}
