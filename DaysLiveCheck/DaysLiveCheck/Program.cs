using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysLiveCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* do
            {
                Console.Write("Enter Your Age: ");
                age = int.Parse(Console.ReadLine());

            } while (age <= 0 || age > 120); 

            int dayLive = (currentYear - (currentYear - age)) * 365;
            Console.WriteLine("You have lived for: " + dayLive + " days");
            Console.ReadKey(); */

            Console.Write("Enter Your Age: ");
            string input = Console.ReadLine();
            int age;

            // Try parsing the input
            if (!int.TryParse(input, out age))
            {
                Console.WriteLine("Invalid input! Exiting the program.");
                Console.ReadKey(); // Exit the program
            }
            else if (age <= 0 || age > 120)
            {
                Console.WriteLine("you Enter The Wrong Age!");
            }
            else
            {
                int currentYear = DateTime.Now.Year;
                int dayLive = (currentYear - (currentYear - age)) * 365;
                Console.WriteLine("You have lived for: " + dayLive + " days");
            }
            Console.ReadKey();
        }
    }
}
