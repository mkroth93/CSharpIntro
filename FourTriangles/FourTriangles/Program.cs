using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------------------------------------------------------
             * Program:     Four Triangles
             * Developer:   Michael Kroth
             * Date:        2/4/19
             * Purpose:     This program will draw triangles using for loops.
             * ---------------------------------------------------------*/

            const int ROWS = 10; // number of rows for each triangle

            WriteLine("7-1 Project 5: Four Triangles");

            // outputs the first triangle
            for (int row = 0; row < ROWS; row++) // loop controls number of rows
            {
                for (int col = 0; col <= row; col++) // loop controls number of columns
                    Write("*");
                WriteLine();
            }

            WriteLine(); // space between next triangle

            // outputs the second triangle
            for (int row = 0; row < ROWS; row++) // loop controls number of rows
            {
                for (int col = ROWS - 1; col >= row; col--) // loop controls number of columns
                    Write("*");
                WriteLine();
            }

            WriteLine(); // space between next triangle

            // outputs the third triangle
            for (int row = 0; row < ROWS; row++) // loop controls number of rows
            {
                for (int space = 0; space < row; space++) // loop controls amount of blank spaces
                    Write(" ");
                for (int col = ROWS - 1; col >= row; col--) // loop controls number of columns
                {       
                    Write("*");
                }
                WriteLine();
            }

            WriteLine(); // space between next triangle

            // outputs the fourth triangle
            for (int row = 0; row < ROWS; row++) // loop controls number of rows
            {
                for(int space = ROWS - 1; space > row; space--) // loop controls amount of blank spaces
                    Write(" ");
                for (int col = 0; col <= row; col++) // loop controls number of columns
                    Write("*");
                WriteLine();
            }

            WriteLine("7-1 Project 5: Four Triangles - END");
        }
    }
}
