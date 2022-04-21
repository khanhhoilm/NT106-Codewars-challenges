using System;
//Đỗ Xuân Long - 20520619
//Đoàn Đỗ Lâm Trường - 20520338
//Phạm Văn Ngọ - 20520254
//Lê Hùng Tiến - 18521484
//Nguyễn Thanh Nam - 20520913
//Bài 1:
//Write a function which converts the input string to uppercase.
public class Kata
{
        public static string MakeUpperCase(string str)
        {
             return str.ToUpper();
        }
}
//Bài 2:
//Convert number to reversed array of digits
public static long[] Digitize(long n)
    {
      // Code goes here
      string str = n.ToString();
      char[] chArr= str.ToCharArray();
      Array.Reverse(chArr);
      long[] longArr = new long[chArr.Length];
      for (int i = 0; i < longArr.Length; i++)
      {
        long number;
        if (Int64.TryParse(chArr[i].ToString(), out number))
        {
          longArr[i] = number;
        }
      }
      return longArr;
    }
//Bài 3:
//The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.
public static int СenturyFromYear(int year)
  {
            int t=0;
            string s = year.ToString();
            if (s[2] == '0' && s[3] == '0')
                {
                    t = year/100;
                    
                }
            else
            {
                t = year/100;
                t += 1;
            }
            return t;
  }
