namespace Problems;

public static class BestTimeToBuyAndSellStock
{
    public static int GetMaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var minPrice = Int32.MaxValue;
        for (int i = 0; i < prices.Length; i++)
        {
            var currentPrice = prices[i];
            if (currentPrice < minPrice)
            {
                minPrice = currentPrice;
            }
            else
            {
                var currentProfit = currentPrice - minPrice;
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}