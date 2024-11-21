using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (0 to 6): ");
            string input = Console.ReadLine();
            int dayNumber;

            // Check if the input is a valid number
            if (!int.TryParse(input, out dayNumber) || dayNumber < 0 || dayNumber > 6)
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and 6.");
                Console.ReadKey();
            }

            // Match the number to a day of the week
            string dayName;
            switch (dayNumber)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Unknown";
                    break; // This should never be reached
            }

            Console.WriteLine("Today is: " + dayName);
            Console.ReadKey();
        }
    }
}
