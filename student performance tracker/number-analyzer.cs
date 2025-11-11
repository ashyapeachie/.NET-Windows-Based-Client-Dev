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
            double average = (double)sum / numbers.Length;
            // sum and average using for Loop
            
            int largest = numbers[0];
            int smallest = numbers[0]; 
            foreach (int n in numbers) {
                if (n > largest) largest = n;
                if (n < smallest) smallest = n;
            }
            // finding largest and smallest

            Console.WriteLine("\nNumbers in reverse order:");
            int index = numbers.Length - 1;
            while (index >= 0) {
                Console.Write(numbers[index] + " ");
                index--;
            }
            // reversing the output while loop

            Console.WriteLine($"\n\nSum: {sum}"); // sum
            Console.WriteLine($"Average: {average:F2}"); // avg
            Console.WriteLine($"Largest: {largest}"); // largest
            Console.WriteLine($"Smallest: {smallest}"); // smallest
        }
    }
}