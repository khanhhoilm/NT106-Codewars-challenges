//Convert a Number to a String!
//Tran Hoang Long 20520625
using System;

public class Kata
{
  public static string NumberToString(int num)
  {
    return num.ToString();
  }
}

//Are You Playing Banjo?
using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    if (name[0] == 'R' || name[0] == 'r') {
      return (name + " plays banjo");
      }
      return (name + " does not play banjo");
    
  }
}
