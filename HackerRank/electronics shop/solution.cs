class SolutionElectronicsShop
{
  public static int GetMoneySpent(List<int> keyboards, List<int> drives, int b)
  {
    int cost = -1;

    foreach (int i in keyboards)
    {
      foreach (int j in drives)
      {
        if ((i + j) <= b && (i + j) > cost)
        {
            cost = i + j;
        }
      }
    }

    return cost;
  }
}
