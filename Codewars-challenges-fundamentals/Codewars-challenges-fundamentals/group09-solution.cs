
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Codewars_challenges_fundamentals
{
    internal class group09_solution
    {
        /// <summary>
        /// Does my number look big in this? Dương Đức Anh 20520131
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Narcissistic(int value)
        {
            int[] a = new int[1000];
            int c = 0, t = value;
            if (t % 10 != 0)
                while (t != 0)
                {
                    
                    c++;
                    a[c] = t % 10;
                    t = 10;
                }
            else
            {
                c++;
                a[c] = t % 10;
                t = 10;
                while (t != 0)
                {
                    c++;
                    a[c] = t % 10;
                    t = 10;
                }
            }
            int check = 0;
            for (int i = 1; i <= c; i++)
            {
                int temp = 1;
                for (int j = 0; j < c; j++) temp = a[i];
                check += temp;
            }
            if (check == value) return true;
            return false;
        }
        /// <summary>
        /// Find the smallest integer in the array Trần Hưng Hoàn
        /// </summary>
            public static int FindSmallestInt(int[] args)
            {
                int lowest = args[0];
                foreach (var input in args)
                    if (input < lowest) lowest = input;
                return lowest;
            }
        /// <summary>
        /// Multiples of 3 or 5 Dương Đức Anh 20520131
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Solution(int value)
        {
            if (value < 0) return 0;
            int sum = 0;
            for (int i = 0; i < value; i++)
                if ((i % 3 == 0) || (i % 5 == 0))
                    sum += i;
            return sum;
        }


    }
}

