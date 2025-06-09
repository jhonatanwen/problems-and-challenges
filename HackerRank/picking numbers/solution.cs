class SolutionPickingNumbers
{
  public static int PickingNumbers(List<int> a)
  {
    var freq = new Dictionary<int, int>();
    foreach (int num in a)
    {
      if (freq.ContainsKey(num))
      {
        freq[num]++;
      }
      else
      {
        freq[num] = 1;
      }
    }

    int maxLength = 0;
    foreach (int num in freq.Keys)
    {
      int option1 = freq[num];
      int option2 = freq[num];

      if (freq.ContainsKey(num + 1))
      {
        option2 += freq[num + 1];
      }

      int bestForThisNum = Math.Max(option1, option2);
      maxLength = Math.Max(maxLength, bestForThisNum);
    }

    return maxLength;
  }
}
