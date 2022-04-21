using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{
    internal class group12_solutions
    {
        //Đề bài1: Write a function that takes an array of numbers and returns the sum of the numbers.
        //The numbers can be negative or non-integer.
        //If the array does not contain any numbers then you should return 0.
        public static double SumArray(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        //Đề bài 2: Very simple, given an integer or a floating-point number, find its opposite.
        public static int Opposite(int number)
        {
            int oppNum = 0 - number;
            return oppNum;
        }
    }
}
// Thành viên nhóm 12:
// Thái Thị Nhung: 20521726
// Lê Thị Anh Thư: 20521986
// Nguyễn Thị Kim Thùy: 20522004
// Nguyễn Thị Trà Tiên: 20520804
// Đỗ Thị Minh Oanh: 19521982

