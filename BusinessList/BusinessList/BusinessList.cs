using System;
using static System.Console;

namespace BusinessList
{
    class BusinessList
    {
        /// <summary>
        /// Title:      Business List
        /// Name:       Michael Kroth
        /// Date:       02/20/19
        /// Purpose:    This program will prompt for business name and
        ///             number of employees. The data will then be displayed.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Variable Declarations
            string busName = "";
            string tryAgain;
            int numEmploy = 0;

            do
            {
                DisplayInstructions(); // calls for method to display instructions
                busName = InputName(); // calls for method to get business name
                numEmploy = InputEmployees(busName); // calls for method to get number of employees
                DisplayOutput(busName, numEmploy); // calls for method to display the info.

                Write("Enter another (Y/N?): ");
                tryAgain = ReadLine();
            } while (tryAgain == "y" || tryAgain == "Y");

        } // end of main

        // This method displays the instructions to the user
        static void DisplayInstructions()
        {
            WriteLine("Welcome to the Business List");
            WriteLine("Business List for Springfield");
            WriteLine();
        } // end of DisplayInstructions

        // This method gets business name from user
        static string InputName()
        {
            string name;
            WriteLine("What is the business name? ");
            name = ReadLine();
            return name;
        } // end of InputName 

        // This method gets number of employees from user 
        static int InputEmployees(string busName)
        {
            int temp;
            WriteLine($"How many people does {busName} employ? ");
            while(!int.TryParse(ReadLine(), out temp))
            {
                WriteLine("Invalid value. Please re-enter.");
                WriteLine($"How many people does {busName} employ? ");
            }
            return temp;
        } // end of InputEmployees

        // This method displays the business info
        static void DisplayOutput(string busName, int numEmploy)
        {
            WriteLine($"{busName} employs {numEmploy:N0} people");
        } // end of DisplayOutput
    } // end of class
} // end of namespace
