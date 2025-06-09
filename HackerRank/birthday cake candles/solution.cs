class SolutionBirthdayCakeCandles
{
  public static int BirthdayCakeCandles(int[] candles)
  {
    int n = candles.Length;
    int k = n - 1;
    int blown;

    int[] c = candles.OrderByDescending(x => x).ToArray();

    if (1 <= n && n <= Math.Pow(10, 5) && 1 <= c[k] && c[0] <= Math.Pow(10, 7))
    {
      if (c[0] != c[1])
      {
        blown = 1;
      }
      else
      {
        blown = 2;
        for (int i = 1; i < k; i++)
        {
          if (c[i] == c[i + 1] && c[0] == c[i])
          {
            blown++;
          }
        }
      }
    }
    else
    {
      blown = 0;
    }

    return blown;
  }
}