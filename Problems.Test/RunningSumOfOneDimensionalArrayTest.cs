namespace Problems.Test;

using RSOODA = RunningSumOfOneDimensionalArray;

public class RunningSumOfOneDimensionalArrayTest
{
    private readonly Dictionary<int[], int[]> _testData = new()
    {
        { new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 } },
        { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 } },
        { new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 } },
    };

    [Fact]
    public void RunningSumTest()
    {
        foreach (var kvp in _testData)
        {
            Assert.Equal(kvp.Value, RSOODA.RunningSum(kvp.Key));
        }
    }

    [Fact]
    public void RunningSum2Test()
    {
        foreach (var kvp in _testData)
        {
            Assert.Equal(kvp.Value, RSOODA.RunningSum2(kvp.Key));
        }
    }
}