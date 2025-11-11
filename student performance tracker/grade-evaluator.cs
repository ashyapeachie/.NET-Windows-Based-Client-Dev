/* 
Author: Aham
Filename: grade-evaluator.cs or Program.cs
Description: console app that asks user to input a numeric grade, uses 
    if / else if to get letter grade, and uses a switch statement to 
    give a response / remark
 */ 

using System;

namespace GradeEvaluator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Grade Evaluator");
            Console.Write("Please enter number grade (0 - 100): ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int grade)) {
                string letterGrade;
                string remark;

                if (grade >= 90) letterGrade = "A";
                else if (grade >= 80) letterGrade = "B";
                else if (grade >= 70) letterGrade = "C";
                else if (grade >= 60) letterGrade = "D";
                else letterGrade = "F";
                // control structure- if else chain

                switch (letterGrade)
                {
                    case "A":
                        remark = "Excellent work!";
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "B":
                        remark = "Good job!";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "C":
                        remark = "Satisfactory.";
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "D":
                        remark = "Needs improvement.";
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        remark = "Failed. Study harder!";
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                }
                // control structure- switch statement

                Console.WriteLine($"\nLetter Grade: {letterGrade}");
                Console.WriteLine($"Remark: {remark}");

            } else { 
                Console.WriteLine("This is an invalid input- please enter a valid number");
            }
            Console.ResetColor();
        }
    }
}