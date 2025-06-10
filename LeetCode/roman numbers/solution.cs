public class SolutionRomanNumbers
{
  public static int RomanToInt(string s)
  {
    char[] sCharArray = s.ToCharArray();
    Dictionary<char, int> romanNumbers = new Dictionary<char, int>()
    {
      {'I', 1},
      {'V', 5},
      {'X', 10},
      {'L', 50},
      {'C', 100},
      {'D', 500},
      {'M', 1000}
    };
    int result = 0;

    for (int i = 0; i < sCharArray.Length; i++)
    {
      if (i < sCharArray.Length - 1 && romanNumbers[sCharArray[i]] < romanNumbers[sCharArray[i + 1]])
      {
        result -= romanNumbers[sCharArray[i]];
        continue;
      }

      result += romanNumbers[sCharArray[i]];
    }

    return result;
  }
}