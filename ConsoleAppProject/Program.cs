using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Edrick 22/04/2021
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI calculator = new BMI();

        private static StudentGrades grades = new StudentGrades();

        private static NetworkApp app04 = new NetworkApp();

        public static BMI BMI
        {
            get => default;
        }

        public static StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            string[] choices = { "Distance Converter", "BMI Calculator", "Student Marks", "Social Network" };


            int choiceNo = ConsoleHelper.SelectChoice(choices);

            if (choiceNo == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (choiceNo == 2)
            {
                BMI calculater = new BMI();
                calculater.Run();
            }
            else if (choiceNo == 3)
            {
                StudentGrades grades = new StudentGrades();
                grades.Run();
            }
            else if (choiceNo == 4)
            {
                app04.DisplayMenu();
            }
            else Console.WriteLine("Invalid Choice !");
        }
    }
}

