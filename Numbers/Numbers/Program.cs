using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------------------------------------------------------
             * Program:     Numbers
             * Developer:   Michael Kroth
             * Date:        1/25/19
             * Purpose:     This program will use two user inputed numbers
             *              to perform multiple mathematical operations.
             * ---------------------------------------------------------*/

            // Input Variables
            int Num1;
            int Num2;

            // Output Variables
            int Sum;
            int Difference;
            int Product;
            int Quotient;
            int Remainder;
            int Average;

            // Prompts user for two numbers
            Console.WriteLine("Please enter the first number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            // Calculations 
            Sum = Num1 + Num2;
            Difference = Num1 - Num2;
            Product = Num1 * Num2;
            Quotient = Num1 / Num2;
            Remainder = Num1 % Num2;
            Average = Sum / 2;

            // Outputs answers
            Console.WriteLine("The first number was: " + Num1);
            Console.WriteLine("The second number was: " + Num2);
            Console.WriteLine("------------------------------");
            Console.WriteLine("The sum = " + Sum);
            Console.WriteLine("The difference = " + Difference);
            Console.WriteLine("The product = " + Product);
            Console.WriteLine("The quotient = " + Quotient);
            Console.WriteLine("The remainder = " + Remainder);
            Console.WriteLine("The average = " + Average);
        }
    }
}
