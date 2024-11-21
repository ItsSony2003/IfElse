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
            int age;
            int currentYear = DateTime.Now.Year;

            /* do
            {
                Console.Write("Enter Your Age: ");
                age = int.Parse(Console.ReadLine());

            } while (age <= 0 || age > 120); 

            int dayLive = (currentYear - (currentYear - age)) * 365;
            Console.WriteLine("You have lived for: " + dayLive + " days");
            Console.ReadKey(); */

            Console.Write("Enter Your Age: ");
            age = int.Parse(Console.ReadLine());
            if (age <= 0 || age > 120)
            {
                Console.WriteLine("you Enter The Wrong Age!");
            }
            else
            {
                int dayLive = (currentYear - (currentYear - age)) * 365;
                Console.WriteLine("You have lived for: " + dayLive + " days");
            }
            Console.ReadKey();
        }
    }
}
