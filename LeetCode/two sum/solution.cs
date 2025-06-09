public class SolutionTwoSum
{
  public static int[] TwoSum(int[] nums, int target)
  {
    var numToPositionMap = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
      int complement = target - nums[i];
      if (numToPositionMap.TryGetValue(complement, out int value))
      {
        return [value, i];
      }
      numToPositionMap[nums[i]] = i;
    }

    return [];
  }
}