using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{

    /*
     Thành viên
    20520168 - Phan Nguyễn Văn Duy
    20520810 - Vi Minh Tiến
    20520880 - Nguyễn Đàm Nhật Anh
    20521742 - Khưu Minh Phong
     */
    internal class group3_solutions
    {
        /*
         Description:
            Make a simple function called greet that returns the most-famous "hello world!".

            Style Points
            Sure, this is about as easy as it gets. But how clever can you be to create the most creative hello world you can think of? What is a "hello world" solution you would want to show your friends?
         */
        public static class Kata
        {
            public static string greet()
            {
                return "hello world!";
            }
        

        /*
         Very simple, given an integer or a floating-point number, find its opposite.

            Examples:

            1: -1
            14: -14
            -34: 34
         */

       
                public static int Opposite(int number)
                {
                    return number * (-1);
                }

            /*
             Nathan loves cycling.

             Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.

             You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.

             For example:

             time = 3 ----> litres = 1

             time = 6.7---> litres = 3

             time = 11.8--> litres = 5
             */

            public static int Litres(double time)
            {
                double litres = System.Math.Truncate(time * 0.5);
                int result = System.Convert.ToInt32(System.Math.Floor(litres));
                return result;
            }

            /*
             Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.

              Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
             
             */

            public static bool lovefunc(int flower1, int flower2)
            {
                if ((flower1 % 2 == 0 && flower2 % 2 == 0) || (flower1 % 2 != 0 && flower2 % 2 != 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


            /*
             Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).

                The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

                Mind the input validation.
             */

            public static int Sum(int[] numbers)
            {
                int min = numbers[0], max = numbers[0];
                int sum = 0;
                foreach (int item in numbers)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                    if (item > max)
                    {
                        max = item;
                    }
                }
                foreach (int item in numbers)
                {
                    sum += item;
                }
                sum = sum - min - max;
                return sum;

            }


            //Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
            public static string boolToWord(bool word)
            {
                string res = word == true ? "Yes" : "No";
                return res;
            }
            //Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer. If the array does not contain any numbers then you should return 0.
            public static int countArray(double[] array)
            {
                int count = 0;
                foreach (double item in array)
                {
                    count++;
                }
                return count;
            }
            public static double SumArray(double[] array)
            {
                double sum = 0;
                if (countArray(array) == 0)
                {
                    return 0;
                }
                else
                {
                    foreach (double item in array)
                    {
                        sum += item;
                    }
                }
                return sum;
            }
            //In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?
            public static int MakeNegative(int number)
            {
                if (number < 0)
                {
                    return number;
                }
                else
                {
                    return number * -1;
                }
                return 0;
            }
            //You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.

            //Array can contain numbers or strings.X can be either.

            //Return true if the array contains the value, false if not.
            public static bool Check(object[] a, object v) => a.Contains(v);
            //    Given an array of integers your solution should find the smallest integer.

            //For example:

            //Given[34, 15, 88, 2] your solution will return 2
            //Given[34, -345, -1, 100] your solution will return -345
            //You can assume, for the purpose of this kata, that the supplied array will not be empty.
            public static int FindSmallestInt(int[] args)
            {
                int min = args[0];
                foreach (int item in args)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }
        
            //This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.
            public static int Multiply(int x)
            {
                if (x % 2 == 0) { return x * 8; } else { return x * 9; }
                return 0;
            }
            //We need a function that can transform a string into a number. What ways of achieving this do you know?

            //Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.
            public static int StringToNumber(String str) => int.Parse(str);


            //Code as fast as you can! You need to double the integer and return it.


            public static int DoubleInteger(int n)
            {
                return (2 * n);
                //Double the input!
            }

            //Given a year, return the century it is in.

            public static int СenturyFromYear(int year)
            {
                if (year % 100 > 0)
                {
                    return (year / 100) + 1;
                }

                return year / 100;
            }

            //Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.



            public static string EvenOrOdd(int number)
            {
                if (number % 2 == 0)
                {
                    return "Even";
                }
                return "Odd";
                // Code goes here ...
            }

            //Given a non-empty array of integers, return the result of multiplying the values together in order. Example:[1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24

            public static int countA1(int[] x)
            {
                int count = 0;
                foreach (int item in x)
                    count++;
                return count;
            }
            public static int Grow(int[] x)
            {
                int s = 1;
                for (int i = 0; i < countA1(x); i++)
                {
                    s = s * x[i];
                }

                return s;
            }

            //Build a function that returns an array of integers from n to 1 where n>0.Example : n=5 --> [5,4,3,2,1]


            public static int[] ReverseSeq(int n)
            {
                int[] a = new int[n];
                for (int i = n; i > 0; i--)
                {
                    a[(n - i)] = i;
                }
                return a;
            }


            //You get an array of numbers, return the sum of all of the positives ones.Example [1,-4,7,12] => 1 + 7 + 12 = 20


            public static int countA(int[] x)
            {
                int count = 0;
                foreach (int item in x)
                    count++;
                return count;
            }
            public static int PositiveSum(int[] arr)
            {
                int s = 0;
                for (int i = 0; i < countA(arr); i++)
                {
                    if (arr[i] < 0) s = s;
                    else s += arr[i];
                }
                // Your code here
                return s;
            }


            //Write function bmi that calculates body mass index (bmi = weight / height2).

            //if bmi <= 18.5 return "Underweight"

            //if bmi <= 25.0 return "Normal"

            //if bmi <= 30.0 return "Overweight"

            //if bmi > 30 return "Obese"

            public static string Bmi(double weight, double height)
            {
                double temp = weight / (height * height);
                if (temp <= 18.5) return "Underweight";
                else if (18.5 < temp && temp <= 25.0) return "Normal";
                else if (25.0 < temp && temp <= 30.0) return "Overweight";
                else return "Obese";
            }
        }
    }
}
