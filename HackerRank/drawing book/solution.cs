class SolutionDrawingBook
{
  public static List<object> PagesFacesToArray(int n)
  {
    var pageFaces = new List<object> { 1 };
    int k = 1;

    if (n % 2 == 0)
    {
      for (int i = 1; i <= Math.Floor((double)n / 2); i++)
      {
        if (2 * k + 1 == n - 1)
        {
          pageFaces.Add(new int[] { 2 * k, 2 * k + 1 });
          pageFaces.Add(n);
          break;
        }
        pageFaces.Add(new int[] { 2 * k, 2 * k + 1 });
        k++;
      }
    }
    else
    {
      for (int i = 1; i <= Math.Floor((double)n / 2); i++)
      {
        pageFaces.Add(new int[] { 2 * k, 2 * k + 1 });
        k++;
      }
    }

    return pageFaces;
  }

  public static int PageCount(int n, int p)
  {
    if (p == 1 || (p == n && n % 2 == 0))
    {
      return 0;
    }

    var pages = PagesFacesToArray(n);

    if (p - 1 >= n - p)
    {
      pages.Reverse();
    }

    for (int i = 0; i < pages.Count; i++)
    {
      if (pages[i].Equals(1) || pages[i].Equals(n))
      {
        continue;
      }
      else if (pages[i] is int[] pageArray && pageArray.Contains(p))
      {
        return i;
      }
    }

    return 0;
  }
}
