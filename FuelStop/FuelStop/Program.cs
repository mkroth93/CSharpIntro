using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------------------------------------------------------
             * Program:     Fuel Stop
             * Developer:   Michael Kroth
             * Date:        1/28/19
             * Purpose:     This program will make a decision as to which station offers
             *              the most economical fuel price.
             * ---------------------------------------------------------*/

            // Input variables
            var aGallon = 0.00;
            var cLiter = 0.00;

            // Outputs program explanation.
            WriteLine("Which gas station should be used?");
            WriteLine();
            WriteLine("The first value entered is price per liter at the Canadian station.");
            WriteLine("The second value entered is the price per gallon at the American station.");
            WriteLine();
            WriteLine("A decision is made as to which station offers the most economical fuel price.");

            // Prompts users for gas station prices
            Write("Please enter the price per Canadian liter: ");
            if (!double.TryParse(ReadLine(), out cLiter))              // Checks to see if input is valid
            {
                Write("Invalid data entered - 0 recorded for price"); 
                cLiter = 0.00;                                         // sets value to zero if invalid
            }

            Write("Please enter the price per American gallon: ");
            if (!double.TryParse(ReadLine(), out aGallon))             // Checks to see if input is valid
            {
                WriteLine("Invalid data entered - 0 recorded for price");
                aGallon = 0.00;                                        // sets value to zero if invalid
            }
            WriteLine();
            WriteLine("\tWhich station has the best fuel prices?");
            WriteLine();

            // Converts price per liter to gallons
            double cGallon = cLiter * 3.785;

            // Outputs the prices
            WriteLine("American Station - Price per gallon: {0:C}", aGallon);
            WriteLine("Canadian Station - Price per liter: {0:C}", cLiter);
            WriteLine("Canadian liter converted to price per gallon: {0:C}", cGallon);
            WriteLine();
            WriteLine();

            // Decides which gas station to buy from
            if (aGallon < cGallon && aGallon > 0 && cGallon > 0)
                WriteLine("Buy from the American station!");
            if (aGallon == 0.00 || cGallon == 0.00)
                WriteLine("Zero price cannot be used for comparison");
            if (aGallon > cGallon && aGallon > 0 && cGallon > 0)
                WriteLine("Buy from the Canadian station!");
        }
    }
}
