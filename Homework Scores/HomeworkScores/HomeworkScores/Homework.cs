using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Homework_Scores
{
    class Homework
    {
        /// <summary>
        /// Title:      Homework Scores
        /// Name:       Michael Kroth
        /// Date:       03/18/19
        /// Purpose:    This program will take homework scores 0-10 and store them in an array.
        ///             The program will then get the average excluding lowest and highest score.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Variables
            int[] scores = new int[1];
            int input;
            int count = 0;
            decimal average;

            // Calls method to output instructions
            Instructions();

            // Calls method to get scores and save them into an array until user is finished
            do
            {
                input = UserInput();
                SaveScores(ref scores, input, count);
                count++; // keeps track of size of array
            } while (input != -99); // end of while loop

            // Calls method to get the average score
            average = GetAverage(scores);

            // Calls method to output the average
            OutputAverage(average);
        }// end of main

        static void Instructions()
        {
            WriteLine("\n8-2 Project 6 - Begin");
            WriteLine("*** You will be prompted to enter homework scores.                ***");
            WriteLine("*** Valid values are 0 through 10.                                ***");
            WriteLine("*** The highest and lowest scores will be discarded.              ***");
            WriteLine("*** Average is calculated (and displayed) using remaining values. ***\n\n");
        }// end of Instructions method

        static int UserInput()
        {
            int input;
            bool isValid = false;

            do
            {
                WriteLine("Please enter homework score [0 to 10] (-99 to exit): ");
                while (!int.TryParse(ReadLine(), out input))
                {
                    WriteLine("\tInvalid data - re-enter homework score: ");
                }

                if (input > 10 || input < 0 && input != -99)
                {
                    WriteLine($"\nThe integer entered, {input}, is not between 0 and 10.\n");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }

            } while (isValid == false);

            return input;
        }// end of UserInput method

        static void SaveScores(ref int[] scores, int input, int count)
        {
            if (input != -99)
            {
                scores[count] = input;
                Array.Resize(ref scores, scores.Length + 1); // Array increases with each loop
            }
            else
                Array.Resize(ref scores, scores.Length - 1); // Array decreases by one if user quits
        } // end of SaveScores

        static decimal GetAverage(int[] scores)
        {
            int max, min;
            int total = 0;

            Array.Sort(scores);
            max = scores[scores.Length - 1];
            min = scores[0];
            WriteLine("Highest Score:	{0}", max);
            WriteLine("Lowest Score:	{0}\n", min);

            // Finds the average excluding the lowest and highest scores
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            total -= (max + min);

            return total / (scores.Length - 2);
        }// end of GetAverage method

        static void OutputAverage(decimal average)
        {
            WriteLine("Average Score (excluding lowest & highest scores): {0:N1}", average);
            WriteLine("\n8-2 Project 6 - End");
        }// end of Output Average

    }// end of class
}// end of namespace
