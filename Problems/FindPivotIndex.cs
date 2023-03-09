namespace Problems;

public class FindPivotIndex
{
    public static int PivotIndex(int[] nums)
    {
        var index = -1;
        var baseSum = nums.Sum();
        for (int i = 0; i < nums.Length; i++)
        {
            if ((i == 0 || i == nums.Length - 1) && baseSum - nums[i] == 0)
            {
                return i;
            }

            var li = i;
            var leftSum = 0;
            while (li > 0)
            {
                leftSum += nums[--li];
            }

            var ri = i;
            var rightSum = 0;
            while (ri < nums.Length - 1)
            {
                rightSum += nums[++ri];
            }

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return index;
    }

    public static int PivotIndex2(int[] nums)
    {
        int index = -1;
        int lastIndex = nums.Length - 1;
        int baseSum = nums.Sum();

        if (baseSum - nums[0] == 0)
        {
            return 0;
        }

        var leftSum = nums[0];
        for (int i = 1; i < lastIndex; i++)
        {
            if (leftSum == baseSum - leftSum - nums[i])
            {
                return i;
            }

            leftSum += nums[i];
        }

        if (baseSum - nums[lastIndex] == 0)
        {
            return lastIndex;
        }

        return index;
    }
}