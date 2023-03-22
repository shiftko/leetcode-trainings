namespace Problems.Test;

public class MinCostClimbingStairsTest
{
    [Fact]
    public void GetMinCostClimbingStairsTest()
    {
        var payload = new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

        Assert.Equal(6, MinCostClimbingStairs.GetMinCostClimbingStairs(payload));
    }

    [Fact]
    public void GetMinCostClimbingStairsTest2()
    {
        var payload = new[] { 10, 15, 20 };

        Assert.Equal(15, MinCostClimbingStairs.GetMinCostClimbingStairs(payload));
    }
}