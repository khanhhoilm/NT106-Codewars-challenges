using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codewars_challenges_fundamentals
{
    //Phan Minh Đạt - 20521177
    //Đặng Trọng Danh - 20521160
    //Hà Văn Đạt - 20521166
    //Nguyễn Văn Đạt - 20521174
    //Nguyễn Hoàng Anh Đức - 20520451
    
    public partial class nhom11_solutions : Form
    {
        public nhom11_solutions()
        {
            InitializeComponent();
        }
        ////Sum of positive
        public class Kata
        {
            public static int PositiveSum(int[] arr)
            {
                // Your code here


                int tong = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                        tong += arr[i];
                }
                return tong;
            }
            //Invert values
            public static class ArraysInversion
            {
                public static int[] InvertValues(int[] input)
                {
                    //Code it!
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] = -input[i];
                    }
                    return input;
                }
            }
            //MakeUpperCase
            public class Kata
            {
                public static string MakeUpperCase(string str)
                {
                    string strup = str.ToUpper();
                    return strup;
                }

            }
            //Rock Paper Scissors!
            public class Kata
            {
                public int getState(string str)
                {
                    switch (str)
                    {
                        case "rock": return 1;
                        case "scissors": return 2;
                        case "paper": return 3;
                    }
                    return 0;
                }
                public string Rps(string p1, string p2)
                {
                    int diff = getState(p1) - getState(p2);
                    if (diff == -1 || diff == 2)
                    {
                        return "Player 1 won!";
                    }
                    else if (diff == 0)
                    {
                        return "Draw!";
                    }

                    return "Player 2 won!";
                }
            }
            //Find the first non-consecutive number
            public class Kata
            {
                public static object FirstNonConsecutive(int[] arr)
                {
                    int j = 0;
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        j = i + 1;
                        if (arr[i] + 1 != arr[j])
                            break;
                    }
                    if (j == arr.Length - 1)
                        return null;
                    else return arr[j];


                }
            }
            //Calculate average
            class AverageSolution
            {
                public static double FindAverage(double[] array)
                {
                    // Your code here    
                    double tong = 0;
                    int a = array.Length;
                    if (a == 0)
                        return 0;
                    else for (int i = 0; i < array.Length; i++)
                        {
                            tong += array[i];
                        }
                    return tong / array.Length;
                }
            }
            //Calculate BMI
            public class Kata
            {
                public static string Bmi(double weight, double height)
                {
                    double bmi = weight / (height * height);
                    string a = "";
                    if (bmi > 30)
                        a = "Obese";
                    else if (bmi > 25)
                        a = "Overweight";
                    else if (bmi > 18.5)
                        a = "Normal";
                    else a = "Underweight";
                    return a;
                }
            }
            //Opposite number
            public class Kata
            {
                public static int Opposite(int number)
                {
                    // Happy Coding
                    int a = -number;
                    return a;
                }
            }
            //Convert a Boolean to a String
            public class kata
            {
                public static string boolean_to_string(bool b)
                {
                    //Please don't delete me!
                    string value = b.ToString();
                    return value;
                }
            }
            //Convert a string to an array
            public class Solution
            {
                public static string[] StringToArray(string str)
                {
                    // code code code      
                    string[] strArray = new string[] { "" };
                    strArray = str.Split(' ');
                    return strArray;
                }
            }
        }
        //Multiplysss
        public class CustomMath
        {
            public static int multiply(int a, int b)
            {
                return a * b;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
