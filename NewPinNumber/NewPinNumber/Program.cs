using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Attempts = 0;                               //Int used to define numerical values
               string pinCode1, pinCode2;                   //String to define text 
               //Simple iteration upto three times
               for (int i = 0; i < 4; i++)
               {
                   Console.WriteLine("Enter a 4-digit pin: ");
                   pinCode1 = Console.ReadLine();
                   Console.WriteLine("Re-enter your 4-digit pin again: ");
                   pinCode2 = (Console.ReadLine());

                   if (Attempts >= 1000 || Attempts <= 9999)//"||" operator meaning or.

                       Console.WriteLine("ERROR! Pin number does not match. Please try again: ");

                   else if (pinCode1 != "valid" || pinCode2 != "valid")
                       Attempts++;


                   else
                   {
                       Console.WriteLine("Match successful");
                   }                  

                       break;                            //Meaning code will break 5
               }          


               Console.ReadKey();
        }
    }
}
