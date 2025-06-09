public class SolutionIsPalindrome
{
  public bool IsPalindrome(int x)
  {
    if (x < 0) return false;

    int num = x;
    int originalNum = x;
    int reversedNum = 0;
    int leftestDecimalExponent = 0;
    int rightestDecimalExponent = 0;

    while (x >= 10)
    {
      x /= 10;
      leftestDecimalExponent++;
    }

    int originalLeftestDecimalExponent = leftestDecimalExponent;

    while (rightestDecimalExponent <= originalLeftestDecimalExponent)
    {
      int leftest_digit = num / (int)Math.Pow(10, leftestDecimalExponent);
      reversedNum += leftest_digit * (int)Math.Pow(10, rightestDecimalExponent); ;
      num -= leftest_digit * (int)Math.Pow(10,leftestDecimalExponent);
      leftestDecimalExponent--;
      rightestDecimalExponent++;
    }

    if (originalNum == reversedNum)
    {
      return true;
    }

    return false;
  }
}