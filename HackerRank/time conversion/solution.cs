class SolutionTimeConversion
{
  public static string TimeConversion(string s)
  {
    string n = s.Substring(0, 2);

    if (s.Contains("AM"))
    {
      if (n == "12")
      {
        int hrs = int.Parse(n) - 12;
        string hrsStr = hrs.ToString().PadLeft(2, '0');
        return hrsStr + s.Substring(2, 6);
      }
      else
      {
        return s.Substring(0, 8);
      }
    }
    else if (n != "12")
    {
      int hrs = int.Parse(n) + 12;
      string hrsStr = hrs.ToString();
      return hrsStr + s.Substring(2, 6);
    }
    else
    {
      return s.Substring(0, 8);
    }
  }
}
