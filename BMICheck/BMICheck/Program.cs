using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;

            Console.Write("Please enter a height in meters: ");
            height = float.Parse(Console.ReadLine());
            Console.Write("Please enter your weight: ");
            weight = float.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi + ", ");

            if (bmi < 18)
                Console.WriteLine("Underweight");
            else if (bmi < 25.0)
                Console.WriteLine("Normal");
            else if (bmi < 30.0)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");

            Console.ReadKey();
        }
    }
}
