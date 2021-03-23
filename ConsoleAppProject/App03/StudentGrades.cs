using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Application for inputting, converting and outputting marks
    /// and grades of students, as well as calculating the meanm, minimum
    /// and maximum marks
    /// </summary>
    public class StudentGrades
    {
        public const int LowestMark = 0;
        public const int LowestD = 40;
        public const int LowestC = 50;
        public const int LowestB = 60;
        public const int LowestA = 70;
        public const int HighestMark = 100;



        public string [] Students { get; set; }

        public int [] Marks { get; set; }

        public int [] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// an array of 10 students who's marks will be converted
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
                {
                    "David", "Charlie", "Bill", "Tom", "Liam", "Eddy", "Michael", "Alesha", "Chelsea", "Shanice"
                };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// the run method for the application
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App03 Student Grades Program");

            string[] choices = new string[]
            {
                "Input Marks",
                "Output Marks",
                "Calculate Stats",
                "Calculate Grade Profile",
                "Quit"
            };

            bool finished = false;
            while(!finished)
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: InputMarks(); break;
                    case 2: OutputMarks(); break;
                    case 3: CalculateStats(); break;
                    case 4: CalculateGradeProfile(); break;
                    case 5: finished = true;break;
                }
            }
        }

        /// <summary>
        /// the method for the marks to be entered and stored per student
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputTitle("Inputting Student Marks...");

            int index = 0;
            foreach (string student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"Enter a mark for student {student} > ", 0, 100);
                Marks[index] = mark;
                index++;
            }
        }

        /// <summary>
        /// the method for the marks and the grades of each student to be displayed
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle("Outputting student marks and grades...");
            for (int index = 0; index < Marks.Length; index++)
            {
                Grades grade = ConvertToGrade(Marks[index]);
                Console.WriteLine($"{Students[index]} {Marks[index]} {grade}");
            }
        }

        /// <summary>
        /// the method for converting each mark to a specific grade
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 70)
            {
                return Grades.A;
            }
            else if (mark >= 60)
            {
                return Grades.B;
            }
            else if (mark >= 50)
            {
                return Grades.C;
            }
            else if (mark >= 40)
            {
                return Grades.D;
            }
            else 
            {
                return Grades.F;
            }            
        }

        /// <summary>
        /// the method for calculating and outputing the minimum, maximum, and mean of the marks
        /// </summary>
        public void CalculateStats()
        {
            ConsoleHelper.OutputTitle("Calculating Stats...");
            Minimum = Marks[0];
            Maximum = Marks[0];
            
            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total += mark;
            }
            Mean = total / Marks.Length;

            Console.WriteLine($"The Minimum Mark is: {Minimum}\nThe Maximum Mark is: {Maximum}\nThe Average Mark is: {Mean}");
        }

        /// <summary>
        /// This method calculates the grade profile
        /// </summary>
        public void CalculateGradeProfile()
        {
            ConsoleHelper.OutputTitle("Calculating Grade Profile...");
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }

        /// <summary>
        /// this method outputs the grade profile
        /// </summary>
        public void OutputGradeProfile()
        {
            ConsoleHelper.OutputTitle("Outputting Grade Profile...");
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }
    }

    
}
