// goal: if, if else, and switch statements
// remember to add proper header 

using System;

namespace GradeEvaluator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Grade Evaluator");
            Console.Write();

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

                switch (letterGrade) {
                    case "A":
                        break;
                    case "B":
                        break;
                    case "C":
                        break;
                    case "D":
                        break;
                    default:
                        break;
                }
                // switch statement
            } else { 
                Console.WriteLine("This is an invalid input- please enter a valid number");
            }
            // Console.___();
        }
    }
}