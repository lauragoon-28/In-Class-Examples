﻿using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Please enter your grade");
                answer = Console.ReadLine();
                string lg = ConvertGradeToLetterGrade(Convert.ToDouble(answer));

                Console.WriteLine($"Congrats you have a {lg}!");

                Console.WriteLine("Do you wnat to convert another grade? yes or no");
                answer = Console.ReadLine().ToLower();

            } while (answer[0] == 'y');   
        }
        /// <summary>
        /// Converts a grade (e.g. 78.6) to a letter grade (C)
        /// </summary>
        /// <param name="grade">A double representing the grade</param>
        /// <returns>The letter grade associated with the grade, and N/A if the grade is below 0</returns>
        static string ConvertGradeToLetterGrade(double grade) 
        {
            string letter = "";

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else if (grade >= 0)
            {
                letter = "F";
            }
            else
            {
                letter = "N/A";
            }

            return letter;
        }
    }
}
