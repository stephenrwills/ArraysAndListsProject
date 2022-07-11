using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                    evens.Add(item);
                else
                {
                    odds.Add(item);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var item in evens)
            {
                Console.WriteLine($"{item} will be an even number");
            }

            foreach (var item in odds)
            {
                Console.WriteLine($"{item} will be an odd number");
            }
        }
    }
}
