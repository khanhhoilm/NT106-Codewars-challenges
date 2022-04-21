using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{
    class group16_solutions
    {
        /*Given an array of integers your solution should find the smallest integer.*/
        public static int FindSmallestInt(int[] args)
        {
            int min = 99999;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] < min)
                    min = args[i];
            }
            return min;
        }

        /*Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.*/
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        /*Write a function which calculates the average of the numbers in a given list.*/
        public static double FindAverage(double[] array)
        {
            double sum = 0;
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }
                double ave = sum / array.Length;

                return ave;
            }
            else
            {
                return 0;
            }
        }
    }
}
