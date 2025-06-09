class SolutionPlusMinus
{
  public static void PlusMinus(List<int> arr)
  {
    int m = arr.Count;
    int pos = 0, neg = 0, zro = 0;

    if (0 < m && m <= 100)
    {
      for (int i = 0; i < m; i++)
      {
        if (-100 <= arr[i] && arr[i] <= 100)
        {
          if (arr[i] > 0)
          {
            pos++;
          }
          else if (arr[i] < 0)
          {
            neg++;
          }
          else
          {
            zro++;
          }
        }
      }

      double posr = (double)pos / m;
      double negr = (double)neg / m;
      double zror = (double)zro / m;

      Console.WriteLine(posr.ToString("F6"));
      Console.WriteLine(negr.ToString("F6"));
      Console.WriteLine(zror.ToString("F6"));
    }
  }
}
