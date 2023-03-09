namespace Problems;

public static class RunningSumOfOneDimensionalArray
{
    public static int[] RunningSum(int[] nums)
    {
        var currentSum = 0;
        var res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = currentSum += nums[i];
        }

        return res;
    }

    public static int[] RunningSum2(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0)
            {
                nums[i] += nums[i - 1];
            }
        }

        return nums;
    }
}