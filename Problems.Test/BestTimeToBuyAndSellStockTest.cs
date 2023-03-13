using BT = Problems.BestTimeToBuyAndSellStock;

namespace Problems.Test;

public class BestTimeToBuyAndSellStockTest
{
    private readonly Dictionary<int[], int> _testData = new()
    {
        { new[] { 7, 1, 5, 3, 6, 4 }, 5 },
        { new[] { 7, 6, 4, 3, 1 }, 0 },
        { new[] { 1, 2 }, 1 },
    };

    [Fact]
    public void GetMaxProfitTest()
    {
        foreach (var kvp in _testData)
        {
            var res = BT.GetMaxProfit(kvp.Key);
            Assert.Equal(kvp.Value, res);
        }
    }
}