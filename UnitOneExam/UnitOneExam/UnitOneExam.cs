using System;
using static System.Console;

namespace UnitOneExam
{
    /// <summary>
    /// *******************************************************************
    /// Title:          Unit One Exam
    /// Name:           Michael Kroth
    /// Date:           02/16/19
    /// Purpose:        This program will calculate the number of bunnies 
    ///                 using the fibonacci sequence.
    /// *******************************************************************
    /// </summary>
    class UnitOneExam
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            int gen;
          
            // Welcome message
            WriteLine("Welcome to the Bunny fold size estimator");

            // Start of loop
            do 
            {
                // fibonacci variables
                int fold1 = 0;
                int fold2 = 1;
                int newFold = 0;
                int sum = 0;

                // Ask users for input
                WriteLine("How many generations would you like to estimate? (-1 to quit): ");

                if (!int.TryParse(ReadLine(), out gen)) // Validates input. Sets gen to zero if invalid
                {
                    WriteLine("Invalid input. Generations set to 0.");
                    WriteLine("The fold size estimate is {0} after {1} generations", sum, gen);
                    WriteLine("..."); // New Line
                }

                else if (gen != 0 && gen != -1) // If input is valid, Calculates the total of bunnies.
                {
                    for (int i = 0; i < gen; i++) // beginning of for loop
                    {
                        newFold = fold1 + fold2;    
                        fold2 = fold1;
                        fold1 = newFold;            // fibonacci sequence
                        sum += newFold;
                    } // end of for loop            

                    WriteLine("\nThe fold size estimate is {0} after {1} generations", (sum + 1), gen); // Outputs the answer

                    WriteLine("..."); // New Line
                }
            }while(gen != -1); // end of while loop

        } // end of main method
    } // end of class
} // end of namespace
