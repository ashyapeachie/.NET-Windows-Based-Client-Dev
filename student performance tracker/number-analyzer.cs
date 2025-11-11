/* 
Author: Aham
Filename: number-analyzer.cs 
Description: console app that asks user for a list of numbers, splits
    the input into an array, and calculates
 */

using System;
using System.Linq;

namespace NumberAnalyzer {
    class Program {
        static void Main() {
            Console.WriteLine();
            Console.WriteLine();
            string input = Console.ReadLine();

            string[] parts = input.Split(',');
            int[] numbers = new int[parts.Length];
            // splitting input and convert to int array

            for (int i = 0; i < parts.Length; i++) {
                int.TryParse(parts[i].Trim(), out numbers[i]);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            } 
            // double average 
            // sum and average using for Loop
            
            int largest = numbers[0];
            int smallest = numbers[0];
            // finding largest and smallest 

            foreach (int n in numbers)
            {

            }


            // reversing the output while loop

            Console.WriteLine(); // sum
            Console.WriteLine(); // avg
            Console.WriteLine(); // largest
            Console.WriteLine(); // smallest
        }
    }
}