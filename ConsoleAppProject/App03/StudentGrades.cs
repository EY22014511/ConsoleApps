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
                    case 5: finished = true; break;
                }
            }
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
                Grades grade = ConvertToGrade(Marks[index]);
                Console.WriteLine($"{Students[index]} {Marks[index]} {grade}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark > 70)
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

            return Grades.F;
        }

        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

        public void CalculateGradeProfile()
        {

        }
    }

    
}
