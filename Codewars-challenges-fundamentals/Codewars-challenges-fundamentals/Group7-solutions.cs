using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Codewars_challenges_fundamentals
{
    internal class Group7_solutions
    {
        /*
         * Hồ Minh Hào 20521290 
         * Trần Văn Quý 20521818
         * Trần Ngọc Quý 20521817
         * Đỗ Phi Sơn 20521839
         * Phạm Đình Công 20521144
         
        
        1.
         */
        /*Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each.
         * If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
         *Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
        */
        public class LoveDetector
        {
            public static bool lovefunc(int flower1, int flower2)
            {



                bool fallInLove = true;
                if ((flower1 % 2 == 0 && flower2 % 2 != 0) || (flower1 % 2 != 0 && flower2 % 2 == 0))
                {
                    fallInLove = true;
                }
                else
                {
                    fallInLove = false;
                }
                return fallInLove;
            }
        }
        //pass all test case

        //2.
        /*In this simple assignment you are given a number and have 
        to make it negative. But maybe the number is already negative?
        using System;
        */

        public static int MakeNegative(int number)
        {
            // Code?
            if (number < 0)
                return number;
            else if (number > 0)
                return (0 - number);
            else
                return 0;
        }


        //3.
        /*
        We need a function that can transform a number into a string.

        What ways of achieving this do you know?
        */
        public static string NumberToString(int num)
        {
            // code here
            //transform a number into a string
            string word;
            word = num.ToString();
            return word;
        }
        //4.

        /*Given an array of integers your solution should find the smallest integer.

       For example:

       Given [34, 15, 88, 2] your solution will return 2
       Given [34, -345, -1, 100] your solution will return -345
       You can assume, for the purpose of this kata, that the supplied array will not be empty.
       */
        public static int FindSmallestInt(int[] args)
        {
            int min = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] < min)
                {
                    min = args[i];
                }
            }
            return min;
        }

        //5
        /*Write a function which converts the input string to uppercase.*/
        public class Kata
        {
            public static string MakeUpperCase(string str)
            {
                string result = str.ToUpper();
                return result;
            }
        }

        //6
        //You get an array of numbers, return the sum of 
        //all of the positives ones.
        //Example [1,-4,7,12] => 1 + 7 + 12 = 20
        //Note: if there is nothing to sum, the sum is default to 0
        public static int PositiveSum(int[] arr)
        {
            // Your code here
            if (arr != null)
            {
                int k = 0;
                foreach (int i in arr)
                {
                    if (i > 0)
                    {
                        k += i;
                    }

                }
                return k;
            }
            else
            {
                return 0;
            }
        }

        /*7.Write a function called repeatStr which repeats the given string string exactly n times.*/
        public static class Program
        {
            public static string RepeatStr(int n, string s)
            {
                string result = "";
                for (int i = 0; i < n; i++)
                {
                    result += s;
                }
                return result;
            }
        }

        /*8.Given an integral number, determine if it's a square number:

         In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself.

           The tests will always use some integral number, so don't worry about that in dynamic typed languages.
    */
        public static bool IsSquare(int n)
        {
            if (n < 0)
                return false;
            else if ((int)Math.Sqrt(n) * (int)Math.Sqrt(n) == n)
                return true;
            else
                return false;
        }

        //9.
        /* Your task is to make a function that can take any non-negative integer as an
argument and return it with its digits in descending order. Essentially, rearrange
the digits to create the highest possible number. */
        public static int DescendingOrder(int num)
        {
            int length = num.ToString().Length;
            int[] numbers = new int[length];

            for (var i = length - 1; i >= 0; i--)
            {
                int num1 = num;
                int power = (int)Math.Pow(10, i);
                numbers[i] = num1 / power;
                num %= power;
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);
            int output = 0;

            for (var i = 0; i < length; i++)
            {
                int num1 = numbers[i];
                int power = (int)Math.Pow(10, length - i - 1);
                output += num1 * power;
            }
            return output;
        }


        //10.
        /*Description:
Make a simple function called greet that returns the most-famous "hello world!".

Style Points
Sure, this is about as easy as it gets. But how clever can you be to create the most creative hello world you can think of? What is a "hello world" solution you would want to show your friends?*/

        // public static class Kata //Đề cho class static
        //{
        public static string greet()
        {
            return "hello world!";
        }
        //}


        //11./*
        //    Write a function that takes an array of words and smashes them together into a sentence and returns the sentence.You can ignore any need to sanitize words or add punctuation, but you should add spaces between each word. 
        //Be careful, there shouldn't be a space at the beginning or the end of the sentence!
        public static string Smash(string[] words)
        {
            // Smash words
            int a = words.Length;
            for (int i = 0; i < a; i++)
            {
                words[i] = Console.ReadLine();
            }


            String Sentance = "";
            for (int i = 0; i < 100; i++)
            {

                Sentance = Sentance + words[i];
                //Console.WriteLine(words[i]);
            }
            return Sentance;
        }
        //12.
        //        Write a function which calculates the average of the numbers in a given list.

        //Note: Empty arrays should return 0.


        class AverageSolution
        {
            public static double FindAverage(double[] array)
            {
                // Your code here
                if (array.Length > 0)
                {
                    return array.Average();
                }
                else
                {
                    return 0;
                }

            }
        }


        //13.
        /*Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
invert([]) == []*/
        public static class ArraysInversion
        {
            public static int[] InvertValues(int[] input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] *= -1;
                }
                return input;
            }
        }


        //14.
        //Given a non-empty array of integers, return the result
        //of multiplying the values together in order.
        public static int Grow(int[] x)
        {
            int k = 1;
            foreach (int i in x)
            {
                k *= i;
            }
            return k;

        }
    }

}



