using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the jagged array and initialize it with scores
            int[][] studentScores = new int[3][]
            {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
            };

            // Print the scores of each student
            Console.WriteLine("Student Scores:");
            Console.WriteLine("----------------");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Calculate and print the average score for each student
            Console.WriteLine("Average Scores:");
            Console.WriteLine("----------------");
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine($"Student {i + 1}: {average:F2}");
            }
            Console.WriteLine();

            // Calculate and print the average score for all students combined
            Console.WriteLine("Average Score for All Students Combined:");
            Console.WriteLine("----------------------------------------");
            int totalSum = 0;
            int totalCount = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }
            double totalAverage = (double)totalSum / totalCount;
            Console.WriteLine($"Average Score: {totalAverage:F2}");

            Console.ReadLine();
        }
    }
}
