class SolutionStaircase
{
  public static void Staircase(int n)
  {
    if (0 < n && n <= 100)
    {
      for (int i = 1; i <= n; i++)
      {
        string output = new string(' ', n - i) + new string('#', i);
        Console.WriteLine(output);
      }
    }
  }
}
