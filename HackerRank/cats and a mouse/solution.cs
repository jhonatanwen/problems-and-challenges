class SolutionCatsAndAMouse
{
  public static string CatAndMouse(int x, int y, int z)
  {
    if (Math.Abs(z - y) > Math.Abs(z - x))
    {
      return "Cat A";
    }
    else if (Math.Abs(z - x) > Math.Abs(z - y))
    {
      return "Cat B";
    }
    else
    {
      return "Mouse C";
    }
  }
}
