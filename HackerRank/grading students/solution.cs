class SolutionGradingStudents
{
  public static List<int> GradingStudents(List<int> grades)
  {
    int n = grades.Count;
    int k = n - 1;
    var newGrades = new List<int>();

    if (1 <= n && n <= 60)
    {
      for (int i = 0; i <= k; i++)
      {
        int cond = (int)Math.Ceiling((double)grades[i] / 5) * 5;

        if (0 <= grades[i] && grades[i] <= 100)
        {
          if (grades[i] >= 38 && Math.Abs(grades[i] - cond) < 3)
          {
              newGrades.Add(cond);
          }
          else
          {
              newGrades.Add(grades[i]);
          }
        }
      }
    }

    return newGrades;
  }
}
