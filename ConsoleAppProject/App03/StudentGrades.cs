using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// 
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
        /// 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
                {
                    "David", "Charlie", "Bill", "Tom", "Liam", "Eddy", "Mcihael", "Alesha", "Chelsea", "Shanice"
                };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void Run()
        {
            ConsoleHelper.OutputHeading("App03 Student Grades Program");
            InputMarks();
            OutputMarks();
        }

        /// <summary>
        /// 
        /// </summary>
        public void InputMarks()
        {
            ConsoleHelper.OutputTitle("Inputting Student Marks");

            int index = 0;
            foreach (string student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"Enter a mark for student {student} > ", 0, 100);
                Marks[index] = mark;
                index++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle("Outputting student marks and grades");
            for (int index = 0; index < Marks.Length; index++)
            {
                Console.WriteLine($"{Students[index]} {Marks[index]} ");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public Grades ConvertToGrade(int mark)
        {
            return Grades.F;
        }

        public void CalculateStats()
        {
            throw new NotImplementedException();
        }
    }

    
}
