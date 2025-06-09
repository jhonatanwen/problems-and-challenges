class SolutionCoutingValleys
{
  public static int CountingValleys(int steps, string path)
  {
    char[] pathArray = path.ToCharArray();
    int seaLevel = 0;
    int actStep = 0;
    int lastStep = 0;
    int valleys = 0;

    for (int i = 0; i < steps; i++)
    {
      switch (pathArray[i])
      {
        case 'U':
          lastStep = actStep;
          actStep++;
          break;
        case 'D':
          lastStep = actStep;
          actStep--;
          break;
      }

      if (i > 0)
      {
        if (actStep > lastStep && actStep == seaLevel)
        {
          valleys++;
        }
      }
    }

    return valleys;
  }
}
