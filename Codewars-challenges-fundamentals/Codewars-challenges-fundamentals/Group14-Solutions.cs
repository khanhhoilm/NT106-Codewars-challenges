using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{
    class Group14_Solutions
    {
        //Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
        public string boolToWord(bool word)
        {
            if (word)
            {
                return "Yes";
            }
            return "No";
        }

        //Code as fast as you can! You need to double the integer and return it.
        public static int DoubleInteger(int n)
        {
            return n * 2;
        }

        //Write a function to split a string and convert it into an array of words.
        public static string[] StringToArray(string str)
        {
            string[] arr = str.Split(' ');
            return arr;
        }

        //Our football team finished the championship. The result of each match look like "x:y". Results of all matches are recorded in the collection.
        public static int TotalPoints(string[] games)
        {

            int point = 0;

            foreach (string item in games)
            {
                string[] str = item.Split(':');
                int x = int.Parse(str[0]);
                int y = int.Parse(str[1]);
                if (x > y)
                {
                    point += 3;
                }
                else if (x == y)
                {
                    point += 1;
                }
            }

            return point;
        }

        //Given an array of integers your solution should find the smallest integer
        public static int FindSmallestInt(int[] args)
        {
            int min = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] < min)
                {
                    min = args[i];
                }
            }

            return min;
        }

    }

}
