class SolutionDiagonalDifference
{
  public static int DiagonalDifference(List<List<int>> arr)
  {
    int n = arr.Count - 1;
    int dlr = 0, drl = 0;

    for (int i = 0; i <= n; i++)
    {
      dlr += arr[i][i];
      drl += arr[i][n - i];
    }

    return Math.Abs(dlr - drl);
  }
}
