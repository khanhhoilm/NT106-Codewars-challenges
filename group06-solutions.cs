//Convert a Number to a String!
//Tran Hoang Long 20520625
using System;
using System.Linq; //Sum of Positives

public class Kata
{
  public static string NumberToString(int num)
  {
    return num.ToString();
  }
  
  //Are You Playing Banjo?
  public static string AreYouPlayingBanjo(string name)
  {
    if (name[0] == 'R' || name[0] == 'r') {
      return (name + " plays banjo");
      }
    return (name + " does not play banjo");
  }
  
  //Sum of Positives
  public static int PositiveSum(int[] arr)
  {
    int Sum = 0;
    foreach (int i in arr){
      if (i > 0) {
        Sum += i;
      }
    }
    return Sum;
  }
  
  //Remove all whitespaces
  public static string NoSpace(string input)
    {
      return input.Replace(" ", String.Empty);
    } 
  
  //DNA2RNA
  public string dnaToRna(string dna)
    {
      return dna.Replace('T', 'U');
    }
  
  //Opposites Attract
  public static bool lovefunc(int flower1, int flower2)
    { 
        int s= flower1 +flower2;
      if (s%2==1)
        return true;
      else return false;
      
    }
}
//
