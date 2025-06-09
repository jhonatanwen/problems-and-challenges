class SolutionSockMerchant
{
  public static int SockMerchant(int n, List<int> ar)
  {
    int pair = 0;

    for (int i = 0; i < n; i++)
    {
      for (int j = i + 1; j < n; j++)
      {
        if (ar[i] == ar[j] && ar[i] != -1)
        {
          pair++;
          ar[j] = -1;
          break;
        }
      }
    }

    return pair;
  }
}
