//1. Return Negative
using System;

public static class Kata
{
    public static int MakeNegative(int number)
    {
        // Code?
        if (number > 0) return -number;
        return number;
    }
}

//2. Opposite number
using System;

public class Kata
{
    public static int Opposite(int number)
    {
        // Happy Coding
        return -number;
    }
}

//4. Century from year
public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        if (year % 100 == 0) return (year / 100);
        return (year / 100) + 1;
    }
}

//5.Convert boolean values to strings 'Yes' or 'No'.
using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        if (word == true) return "Yes";
        return "No";
    }
}
//6 DNA to RNA

