using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converting distances
    /// </summary>
    /// <author>
    /// Edrick Yapi version 3
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;
        public const string MILES = "Miles";
        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double OutputDistance { get; set; }
        public double InputDistance { get; set; }

        //this method is used to run the application
        public void Run()
        {
            OutputHeading();
            Console.WriteLine("Select distance to convert from > ");
            string input = InputChoices();
            FromUnit = SelectChoice(input);
            Console.WriteLine($"\nYou have selected {FromUnit}");
            Console.WriteLine("\nSelect distance to convert into > ");
            string input2 = InputChoices();
            ToUnit = SelectChoice(input2);
            Console.WriteLine($"\nYou have selected {ToUnit}");
            Console.WriteLine($"\nConverting {FromUnit} to {ToUnit}");
            Console.Write($"\nEnter distance in {FromUnit} > ");
            InputDistance = InputData();
            CalculateDistance();
        }

        //this method holds the data that the user inputs
        public double InputData()
        {
            string data = Console.ReadLine();
            return Convert.ToDouble(data);
        }

        //this method is the options for which units the user would like to convert from and to
        //the numbers correspond to which unit is which
        public string SelectChoice(string input)
        {
            if (input.Equals("1"))
            {
                return FEET;
            }

            else if (input.Equals("2"))
            {
                return METRES;
            }

            else if (input.Equals("3"))
            {
                return MILES;
            }

            Console.WriteLine("Select either 1, 2 or 3");
            return null;
        }

        //this method allows the users to pick which unit they would like to work with
        public string InputChoices()
        {
            Console.WriteLine($"\n1. {FEET}\n2. {METRES} \n3. {MILES} ");
            Console.Write("\nPlease enter your choice > ");
            string input = Console.ReadLine();
            return input;
        }

        //method for outputing the header
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("     Distance Converter       ");
            Console.WriteLine("       By Edrick Yapi         ");
            Console.WriteLine("----------------------------\n");
        }

        // this method calculates the distance of each unit depending on the 
        //distance in which theuser has input
        public void CalculateDistance()
        {
            if (FromUnit == METRES && ToUnit == METRES)
            {
                OutputDistance = InputDistance;
            }

            else if (FromUnit == METRES && ToUnit == MILES)
            {
                OutputDistance = InputDistance / METRES_IN_MILES;
            }

            else if (FromUnit == METRES && ToUnit == FEET)
            {
                OutputDistance = InputDistance * FEET_IN_METRES;
            }

            else if (FromUnit == MILES && ToUnit == METRES)
            {
                OutputDistance = InputDistance * METRES_IN_MILES;
            }

            else if (FromUnit == MILES && ToUnit == MILES)
            {
                OutputDistance = InputDistance;
            }

            else if (FromUnit == MILES && ToUnit == FEET)
            {
                OutputDistance = InputDistance * FEET_IN_MILES;
            }

            else if (FromUnit == FEET && ToUnit == METRES)
            {
                OutputDistance = InputDistance / FEET_IN_METRES;
            }

            else if (FromUnit == FEET && ToUnit == MILES)
            {
                OutputDistance = InputDistance / FEET_IN_MILES;
            }

            else if (FromUnit == FEET && ToUnit == FEET)
            {
                OutputDistance = InputDistance;
            }

            Console.WriteLine($"\n{InputDistance} {FromUnit} is equivalent to {OutputDistance} {ToUnit}");
        }
    }
}
