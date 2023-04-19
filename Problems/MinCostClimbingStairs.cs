namespace Problems;

public static class MinCostClimbingStairs
{
    public static int GetMinCostClimbingStairs(int[] cost)
    {
        if (cost.Length < 2)
        {
            return 0;
        }

        if (cost.Length == 2)
        {
            return cost[0] < cost[1] ? cost[0] : cost[1];
        }

        var total = int.MaxValue;
        var prices = Enumerable.Repeat(int.MaxValue, cost.Length).ToArray();

        // initial setup
        prices[0] = cost[0];
        prices[1] = cost[1];

        for (int i = 0; i < prices.Length; i++)
        {
            var currentPrice = prices[i];
            var increments = new[] { 1, 2 };

            foreach (var increment in increments)
            {
                var index = i + increment;
                if (index < prices.Length)
                {
                    var nextCost = cost[index];
                    var nextPrice = currentPrice + nextCost;
                    if (nextPrice < prices[index])
                    {
                        prices[index] = nextPrice;
                    }
                }
                else
                {
                    // finish, set total
                    if (currentPrice < total)
                    {
                        total = currentPrice;
                    }
                }
            }
        }

        return total;
    }
}