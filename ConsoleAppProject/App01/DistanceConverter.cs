using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converting distances
    /// </summary>
    /// <author>
    /// Edrick Yapi version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feet;
        private double metres;

        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateMetres();
            CalculateFeet();
            OutputMetres();
            OutputFeet();
            OutputMiles();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("     Convert Miles to Feet     ");
            Console.WriteLine("         by Edrick Yapi        ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }

        //Prompt for the user to enter the Miles
        //Miles will be a double data type
        private void InputMiles()
        {
            Console.WriteLine("Enter the number of miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        //method to calculate the miles inputted to feet
        //feet will be a double data type
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " mile(s) is equivalent to " + metres + "m.");
        }

        //method to calculate the miles inputted to feet
        //feet will be a double data type
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " mile(s) is equivalent to " + feet + " ft.");
        }

        private void OutputMiles()
        {
            Console.WriteLine(feet + " ft is equivalent to " + miles + " mi.");
        }
    }
}
