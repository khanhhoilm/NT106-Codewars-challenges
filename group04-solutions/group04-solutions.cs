// Đỗ Trần Phương Nam 19520749
//Trương Huỳnh Quý 19522110
//Võ Thanh Phong 19522017
// Lưu Tinh Anh 20520386
// Huỳnh Quang Vũ 19522532 


//Bai1:You Can't Code Under Pressure #1

using System;

public static class Kata1
{
    public static int DoubleInteger(int n)
    {
        return 2 * n;
    }
}

//Bai2:Grasshopper - Summation



public static class Kata2
{
    public static int summation(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        return sum;
    }
}

//Bai3:Beginner Series #2 Clock


  public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        int result = 0;
        result = (h * 60 * 60 + m * 60 + s) * 1000;
        return result;
    }
}

//Bai4: Multiply
public class CustomMath
{
    public static int multiply(int a, int b)
    {
        return a * b;
    }
}


//Calculate BMI
public class Kata3
{
    public static string Bmi(double weight, double height)
    {
        var bmi = weight / (height * height);
        if (bmi <= 18.5)
        {
            return "Underweight";
        }
        if (bmi <= 25.0)
            return "Normal";

        if (bmi <= 30.0)
            return "Overweight";

        if (bmi > 30)
            return "Obese";
        return null;
    }
}

//Beginner Series #1 School Paperwork
public static class Paper
{
    public static int Paperwork(int n, int m)
    {
        if (n <= 0 || m <= 0)
        {
            return 0;
        }
        else
            return n * m;
    }
}

//Return Negative


public static class Kata
{
    public static int MakeNegative(int number)
    {
        int myInt = 0 - System.Math.Abs(number);
        return myInt;
    }
}

//Opposites Attract


public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    {
        if (flower1 % 2 == 0 && flower2 % 2 == 1 || flower1 % 2 == 1 && flower2 % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//Convert boolean values to strings 'Yes' or 'No'.
public static class Kata4
{
    public static string boolToWord(bool word)
    {
        return word ? "Yes" : "No";
    }
}