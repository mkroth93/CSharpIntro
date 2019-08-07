using System;
using static System.Console;

namespace UnitTwoExam
{
    /// <summary>
    /// Program:        Unit Two Exam: Leap Year
    /// Developer:      Michael Kroth
    /// Date:           3/6/19
    /// Purpose:        This program will be able to determine
    ///                 if a year was a leap year.
    /// </summary>
    class LeapYear
    {
        static void Main(string[] args)
        {
            // Variables
            const int SENTINEL = -1;
            int year = 0;
            string divFour;
            string divHun;
            string divFourHun;
            string isLeap;

            do
            { 
                // Gets user input. Validates input
                WriteLine("Please enter a year (-1 to quit): ");
                while (!int.TryParse(ReadLine(), out year))
                {
                    WriteLine("Invalid input. Please enter a year (-1 to quit): ");
                }

                if (year != SENTINEL)
                {
                    WriteLine($"Year entered: {year}");

                    // Checks if divisible by 4/100/400
                    divFour = divByFour(year); // calls the divByFour method
                    divHun = divByHun(year);   // calls the divByHun method
                    divFourHun = divByFourHun(year); // calls the divByFourHun method

                    // calls the leapYear method
                    isLeap = leapYear(divFour, divHun, divFourHun);

                    // Call the displayOutput method
                    displayOutput(divFour, divHun, divFourHun, isLeap);
                }

            } while (year != SENTINEL); // end of while loop

        } // end of main

        static string divByFour(int year)
        {
            return year % 4 == 0 ? "Yes" : "No"; // test if the year is divisible by 4
        } // end of divByFour

        static string divByHun(int year)
        {
           return year % 100 == 0 ? "Yes" : "No"; // test if the year is divisible by 100
        } // end of divByHun()

        static string divByFourHun(int year)
        {
            return year % 400 == 0 ? "Yes" : "No"; // test if the year is divisible by 400
        } // end of divByFourHun()

        // This method will test if the year is a leap year
        static string leapYear(string divFour, string divHun, string divFourHun)
        {
            string isLeap;

            if (divFour == "Yes")
            {
                if (divHun == "Yes")
                {
                    if (divFourHun == "Yes")
                    {
                        isLeap = "Yes";
                    }
                    else
                    {
                        isLeap = "No";
                    }
                }
                else
                {
                    isLeap = "Yes";
                }
            }
            else
            {
                isLeap = "No";
            }

            return isLeap;
        } // end of leapYear()

        // This method will display the results
        static void displayOutput(string divFour, string divHun, string divFourHun, string isLeap)
        {
            WriteLine($"Divisible by 4: {divFour}");
            WriteLine($"Divisible by 100: {divHun}");
            WriteLine($"Divisible by 400: {divFourHun}");
            WriteLine($"Leap year: {isLeap}");
        } // end of displayOutput()
    } // end of class
} // end of namespace
