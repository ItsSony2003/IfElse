using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (0–999): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number) || number < 0 || number > 999)
            {
                Console.WriteLine("Out of ability");
                return;
            }

            Console.WriteLine("The number in words is: " + ConvertNumberToWords(number));
            Console.ReadKey();
        }

        static string ConvertNumberToWords(int number)
        {
            if (number == 0)
            {
                return "zero";
            }

            string result = "";

            // Handle hundreds
            if (number >= 100)
            {
                int hundreds = number / 100;
                result += ConvertSingleDigitToWord(hundreds) + " hundred";
                number %= 100;
                if (number > 0)
                {
                    result += " and ";
                }
            }

            // Handle tens and teens
            if (number >= 10 && number < 20)
            {
                result += ConvertTeenToWord(number);
            }
            else if (number >= 20)
            {
                int tensPlace = number / 10;
                int onesPlace = number % 10;
                result += ConvertTensPlaceToWord(tensPlace);
                if (onesPlace > 0)
                {
                    result += "-" + ConvertSingleDigitToWord(onesPlace);
                }
            }
            else if (number > 0)
            {
                // Handle single digits
                result += ConvertSingleDigitToWord(number);
            }

            return result;
        }

        static string ConvertSingleDigitToWord(int digit)
        {
            switch (digit)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "";
            }
        }

        static string ConvertTeenToWord(int number)
        {
            switch (number)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default: return "";
            }
        }

        static string ConvertTensPlaceToWord(int tensPlace)
        {
            switch (tensPlace)
            {
                case 2: return "twenty";
                case 3: return "thirty";
                case 4: return "forty";
                case 5: return "fifty";
                case 6: return "sixty";
                case 7: return "seventy";
                case 8: return "eighty";
                case 9: return "ninety";
                default: return "";
            }
        }
    }
}
