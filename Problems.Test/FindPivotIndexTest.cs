namespace Problems.Test;

using FPI = FindPivotIndex;

public class FindPivotIndexTest
{
    private readonly Dictionary<int[], int> _testData = new()
    {
        { new[] { 1, 7, 3, 6, 5, 6 }, 3 },
        { new[] { 1, 2, 3 }, -1 },
        { new[] { 2, 1, -1 }, 0 },
        { new[] { -1, -1, 0, 1, 1, 0 }, 5 },
        { new[] { -1, -1, 1, 1, 0, 0 }, 4 },
    };

    [Fact]
    public void PivotIndexTest()
    {
        foreach (var kvp in _testData)
        {
            Assert.Equal(kvp.Value, FPI.PivotIndex(kvp.Key));
        }
    }

    [Fact]
    public void PivotIndex2Test()
    {
        foreach (var kvp in _testData)
        {
            Assert.Equal(kvp.Value, FPI.PivotIndex2(kvp.Key));
        }
    }
}