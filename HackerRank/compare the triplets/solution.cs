class SolutionCompareTriplets
{
  public static List<int> CompareTriplets(List<int> a, List<int> b)
  {
    var comparison = new List<int>();
    var alice = 0;
    var bob = 0;

    for (int x = 0; x < a.Count; x++)
    {
      if (a[x] > b[x])
      {
        alice++;
      }
      else if (a[x] < b[x])
      {
        bob++;
      }
    }

    comparison.Add(alice);
    comparison.Add(bob);
    return comparison;
  }
}
