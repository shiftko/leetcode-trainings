namespace Problems;

public static class MinCostClimbingStairs
{
    public static int GetMinCostClimbingStairs(int[] cost)
    {
        var queue = new List<Node>
        {
            new Node(0, cost[0], null),
            new Node(1, cost[1], null)
        };
        var lastNodes = new HashSet<Node>();

        var count = 0;
        while (count < queue.Count)
        {
            var index = count++;
            var currentNode = queue[index];

            var increments = new[] { 1, 2 };
            foreach (var increment in increments)
            {
                var i = currentNode.Index + increment;
                if (i < cost.Length)
                {
                    var nextNode = new Node(i, cost[i], currentNode);
                    queue.Add(nextNode);
                }
                else
                {
                    lastNodes.Add(currentNode);
                }
            }
        }

        var costs = new HashSet<int>();
        foreach (var lastNode in lastNodes)
        {
            var currentCost = lastNode.Cost;
            var parent = lastNode.Parent;
            while (parent is not null)
            {
                currentCost += parent.Cost;
                parent = parent.Parent;
            }

            costs.Add(currentCost);
        }

        return costs.Min();
    }

    public static int GetMinCostClimbingStairsFast(int[] cost)
    {
        var costs = new HashSet<int>();
        var queue = new List<FastNode>
        {
            new FastNode(0, cost[0], cost[0]),
            new FastNode(1, cost[1], cost[1])
        };

        var count = 0;
        while (count < queue.Count)
        {
            var index = count++;
            var currentNode = queue[index];

            var increments = new[] { 1, 2 };
            foreach (var increment in increments)
            {
                var i = currentNode.Index + increment;
                if (i < cost.Length)
                {
                    var nextNode = new FastNode(i, cost[i], currentNode.TotalCost + cost[i]);
                    queue.Add(nextNode);
                }
                else
                {
                    costs.Add(currentNode.TotalCost);
                }
            }
        }

        return costs.Min();
    }

    class Node
    {
        public readonly int Index;
        public readonly int Cost;

        public Node? Parent;

        public Node(int index, int cost, Node? parent)
        {
            Index = index;
            Cost = cost;
            Parent = parent;
        }
    }

    class FastNode
    {
        public readonly int Index;
        public readonly int Cost;
        public readonly int TotalCost;

        public FastNode(int index, int cost, int totalCost)
        {
            Index = index;
            Cost = cost;
            TotalCost = totalCost;
        }
    }
}