using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{
    class group15_solutions
    {
        /*
         * Nguyen Quoc Thinh - 20521964
         * Nguyen Thanh Cong - 20521143
         */


        /*1. In this simple assignment you are given a number and have to 
         * make it negative. But maybe the number is already negative? */
        public static int MakeNegative(int number)
        {
            if (number <= 0)
            {
                return number;
            }
            else
            {
                return (0 - number);
            }
        }

        /* 2. Create a function that takes an integer as an argument 
         * and returns "Even" for even numbers or "Odd" for odd numbers.*/
        public class SolutionClass
        {
            public static string EvenOrOdd(int number)
            {
                if (number % 2 == 0)
                {
                    return "Even";
                }
                return "Odd";
            }
        }

        /* 3. Very simple, given an integer or a floating-point number, find its opposite.*/
        public static int Opposite(int number)
        {
            return -number;
        }

        /* 4. Write a function named setAlarm which receives two parameters. The first parameter, employed, 
         * is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation. */
        public static bool SetAlarm(bool employed, bool vacation)
        {
            if ((employed == true && vacation == true) || (employed == false && vacation == false) || (employed == false && vacation == true))
            {
                return false;
            }
            return true;
        }
    }
}
