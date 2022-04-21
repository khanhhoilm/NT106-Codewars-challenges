/*
 * Nguyễn Duy Tân	20521875
Hồ Thị Thanh Tâm	20521866
Nguyễn Thị Kim Ngân	20520915
Trần Gia Băng	20521093
 */

//1.Beginner Series #1 School Paperwork

public static class Paper
    {
        public static int Paperwork(int n, int m)
        {
            int sotrang;
            if (n < 0 || m < 0)
            {
                sotrang = 0;
            }
            else sotrang = n * m;
            return sotrang;
        }
    }
 //2/Keep Hydrated!

    public class Kata
    {
        public static int Litres(double time)
        {
            double litres;
            litres = time * 0.5;
            int intlitres = (int)litres;
            return intlitres;
        }
    }
//3/ Sum of positive
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum = sum + arr[i];
                }
            }
            return sum;
        }
    }

//4. Convert a string to an array
    namespace Solution
    {
        using System;

        public class Solution
        {
            public static string[] StringToArray(string str)
            {
                return str.Split(" ");
            }
        }
//5. Basic Mathematical Operations
        namespace Solution
        {
            public static class Program
            {
                public static double basicOp(char operation, double value1, double value2)
                {
                    switch (operation)
                    {
                        case ('+'):
                            return value1 + value2;
                            break;
                        case ('-'):
                            return value1 - value2;
                            break;
                        case ('*'):
                            return value1 * value2;
                            break;
                        case ('/'):
                            return value1 / value2;
                            break;
                    }
                    return -1;
                }
            }
//  6.  Consider an array/list of sheep where some sheep may be missing from their place.We need a function that counts the number of sheep present in the array (true means present).
        using System;

            public static class Kata
            {
                public static int CountSheeps(bool[] sheeps)
                {
                    int count = 0;
                    for (int i = 0; i < sheeps.Length; i++)
                    {
                        if (sheeps[i] == true)

        }
/*7. Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
*/
        using System;

        public class LoveDetector
                {
                    public static bool lovefunc(int flower1, int flower2)
                    {
                        //Moment of truth...
                        if ((flower1 % 2 == 0 && flower2 % 2 == 0) || (flower1 % 2 != 0 && flower2 % 2 != 0))
                            return false;
                        else return true;
                    }
                }

// 8. Complete the square sum function so that it squares each number passed into it and then sums the results together.
//  For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.

        public static class Kata
                {
                    public static int SquareSum(int[] n)
                    {
                        int result = 0;
                        for (int i = 0; i < n.Length; i++)
                            result += n[i] * n[i];
                        return result;
                    }
                }
//9. Write a function that takes an array of words and smashes them together into a sentence and returns the sentence.You can ignore any need to sanitize words or add punctuation, but you should add spaces between each word. Be careful, there shouldn't be a space at the beginning or the end of the sentence!
        public class Kata
                {
                    public static string Smash(string[] words)
                    {
                        string str = "";
                        for (int i = 0; i < words.Length - 1; i++)
                            str += words[i] + " ";
                        str += words[words.Length - 1];
                        return str;
                    }
                }
// 10. Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.
        using System;
        using System.Collections.Generic;

        public class Kata
            {
                public static int CountBits(int n)
                {
                    List<int> binary = new List<int>();
                    while (n > 0)
                    {
                        binary.Add(n % 2);
                        n = n / 2;
                    }
                    int count = 0;
                    foreach (int temp in binary)
                    {
                        if (temp == 1)
                            count++;
                    }
                    return count;
                    return -1;
                }
            }
//11. Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.
            using System;
        public class Sum
            {
                public int GetSum(int a, int b)
                {
                    int max = a, min = b;
                    if (a < b)
                    {
                        max = b;
                        min = a;
                    }
                    int result = 0;
                    int i;
                    for (i = min; i <= max; i++)
                        result = result + i;
                    return result;
                }
            }
//12. Vowel Count Return the number(count) of vowels in the given string.
        using System;
        using System.Linq;

        public static class Kata
            {
                public static int GetVowelCount(string str)
                {
                    int vowelCount = 0;
                    int i = 0;
                    while (i < str.Length)
                    {
                        if ((str[i] == 'a') || (str[i] == 'e') || (str[i] == 'i') || (str[i] == 'o') || (str[i] == 'u'))
                            vowelCount++;
                        i++;
                    }
                    return vowelCount;
                }
            }
//13. You get an array of numbers, return the sum of all of the positives ones
        using System.Linq;

        public class Kata
            {
                public static int PositiveSum(int[] arr)
                {
                    // Your code here
                    int sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] > 0)
                        {
                            sum = sum + arr[i];
                        }
                    }
                    return sum;
                }
            }
/*14. Is a number prime?
Define a function that takes one integer argument and returns logical value true or false depending on if the integer is a prime.
Per Wikipedia, a prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.*/
            public static class Kata
            {
                public static bool IsPrime(int n)
                {
                    if (n <= 1)
                        return false;
                    else
                    {
                        int i = 0;
                        for (i = 2; i < n; i++)
                            if (n % i == 0)
                                return false;
                        return true;
                    }
                }
            }

        
