class SolutionMiniMaxSum
{
  public static void MiniMaxSum(List<int> arr)
  {
    long min = 0, max = 0;
    var ar = arr.OrderBy(x => x).ToArray();
    int n = arr.Count - 1;

    for (int i = 0; i <= n; i++)
    {
      if (1 <= ar[0] && ar[n] <= Math.Pow(10, 9))
      {
          if (i <= n - 1)
          {
              min += ar[i];
          }
          if (i > 0)
          {
              max += ar[i];
          }
      }
    }

    Console.WriteLine($"{min} {max}");
  }
}
