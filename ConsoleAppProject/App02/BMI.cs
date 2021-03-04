using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// BMI App - allowing users to see their BMI
    /// and to find out whether they are healthy or not
    /// </summary>
    /// <author>
    /// Edrick yapi version 1
    /// </author>
    public class BMI
    {
        public const string IMPERIAL = "imperial";
        public const string METRIC = "metric";
        public string [] choice = { METRIC, IMPERIAL };
        public string input;
        public double stones;
        public double lbs;
        public double feet;
        public double inches;
        public double kg;
        public double metres;
        public double BMIoutput;
        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE = 34.9;
        public const double OBESE2 = 39.9;
        public const double OBESE3 = 40.0;
        public void Run()
        {
            outputheading();
            SelectChoice();
            Result();
            BAME();
        }

        //Method for the heading
        public void outputheading()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("        Calculating BMI       ");
            Console.WriteLine("         by Edrick Yapi       ");
            Console.WriteLine("------------------------------");
        }

        //Method to allow users to use either imperial or metric measurements
        public void SelectChoice()
        {
            Console.WriteLine("Would you like to use Imperial or Metric?");
            input = Console.ReadLine().ToLower();

            if (input.Equals("imperial"))
            {
                Console.WriteLine("You have selected to use: Imperial Measurements");
                Console.WriteLine("Enter your weight in stones:");
                stones = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your weight in lbs:");
                lbs = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your height in feet:");
                feet = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your height in inches:");
                inches = Convert.ToDouble(Console.ReadLine());
                CalculateImperialBMI();
            }
            else if (input.Equals("metric"))
            {
                Console.WriteLine("You have selected to use: Metric Measurements");
                Console.WriteLine("Enter your weight in kg:");
                kg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your height in metres:");
                metres = Convert.ToDouble(Console.ReadLine());
                CalculateMetricBMI();
            }
            else
            {
                Console.WriteLine("Invalid Input!! Please select either Imperial or Metric");
            }
            
          
        }

        //Method for calculating the BMI of the user
        public double CalculateImperialBMI()
        {
            double pounds = stones * 14;
            double weightimperial = lbs + pounds;

            double height = ((feet * 12) + inches);
            BMIoutput = ((weightimperial * 703) / (height * height));
            return BMIoutput;
        }

        public double CalculateMetricBMI()
        {
            BMIoutput = (kg / (metres * metres));
            return BMIoutput;
        }

        //method for printing out their bmi
        public void Result()
        {
            if (BMIoutput < UNDERWEIGHT)
            {
                Console.WriteLine("Your BMI is " + BMIoutput + ". You appear to be underweight.\n");
            }
            else if (BMIoutput <= NORMAL)
            {
                Console.WriteLine("Your BMI is " + BMIoutput + ". You are a normal weight.\n");
            }
            else if (BMIoutput <= OVERWEIGHT)
            {
                Console.WriteLine("Your BMI is " + BMIoutput + ". You appear to be overweight.\n");
            }
            else if (BMIoutput <= OBESE)
            {
                Console.WriteLine("Your BMI is " + BMIoutput + ". You appear to be in the first stage of obesity.\n");
            }
            else if (BMIoutput <= OBESE2)
            {
                Console.WriteLine("Your BMI is " + BMIoutput + ". You appear to be in the second stage of obesity.\n");
            }
            else if (BMIoutput >= OBESE3)
            {
                Console.WriteLine("Your BMI is " + BMIoutput + ". You appear to be extremely obese.\n");
            }
        }

        //method for printing out a warning for people who are of the thnic minority
        public void BAME()
        {
            Console.WriteLine("If you are Black, Asian or other minority ethnic groups, you have a higher risk.\n" +
                "Adults 23.0 or more are at increased risk.\nAdults 27.5 or more are at high risk.");
        }
    }
}
