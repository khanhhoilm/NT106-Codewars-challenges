
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
        /// Does my number look big in this? by Dương Đức Anh 20520131
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool Narcissistic(int value)
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
        /// Multiples of 3 or 5 by Dương Đức Anh 20520131
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        int Solution(int value)
        {
            if (value < 0) return 0;
            int sum = 0;
            for (int i = 0; i < value; i++)
                if ((i % 3 == 0) || (i % 5 == 0))
                    sum += i;
            return sum;
        }

        /// <summary>
        /// Count the number of Duplicates by Nguyễn Anh Tài
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>

        public static int DuplicateCount(string str)
        {
            Stack checkedChars = new Stack();
            Stack dupChars = new Stack();

            str = str.ToLower();

            for (int i = 1; i < str.Length; i++)
            {
                var alreadyCounted = checkedChars.Contains(str[i]) && dupChars.Contains(str[i]);

                if (!checkedChars.Contains(str[i]))
                {
                    checkedChars.Push(str[i]);
                }
                else if (checkedChars.Contains(str[i]))
                {
                    dupChars.Push(str[i]);
                }
                else if (alreadyCounted)
                {
                    continue;
                }
            }
            return dupChars.Count;
        }

        /// <summary>
        /// Ones and Zeros by Nguyễn Mỹ Báo 19120550
        /// </summary>
        /// <param name="num"></param>
        /// <param name="exp"></param>
        /// <returns></returns>

        double binaryArrayToNumber(int[] BinaryArray)
        {
            double sum = 0;
            int index = BinaryArray.Length;
            for (int i = 0; i < index; i++)
            {
                if (BinaryArray[i] == 1)
                {
                    sum += HamPow(2, index - (i + 1));
                }
                else
                {
                    sum += 0;
                }
            }

            return sum;
        }
    double HamPow(int num, int exp)
    {
        double ket_qua = 1;
        int i;
        for (i = 1; i <= exp; i++)
            ket_qua = ket_qua * num;
        return ket_qua;
    }
        /// <summary>
        /// Credit Card Mask by  Dương Đức Anh 20520131
        /// </summary>
        /// <param name="cc"></param>
        /// <returns></returns>
        public static string Maskify(string cc)
        {
            int n = 0;
            string temp = cc;
            n = temp.Length;
            if (n > 4)
            {
                temp = cc.Substring(n - 4);
                for (int i = 0; i < n - 4; i++)
                {
                    temp = "#" + temp;
                }
            }
            else temp = cc;
            return temp;
        }
    }
}

