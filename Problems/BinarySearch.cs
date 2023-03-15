namespace Problems;

public static class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        if (!nums.Any() || target > nums[^1] || target < nums[0])
        {
            return -1;
        }

        var lIndex = 0;
        var rIndex = nums.Length - 1;
        while (rIndex >= lIndex)
        {
            var checkIndex = lIndex + (rIndex - lIndex) / 2;
            if (nums[checkIndex] == target)
            {
                return checkIndex;
            }

            if (nums[checkIndex] < target)
            {
                lIndex = checkIndex + 1;
            }
            else
            {
                rIndex = checkIndex - 1;
            }
        }

        return -1;
    }
}