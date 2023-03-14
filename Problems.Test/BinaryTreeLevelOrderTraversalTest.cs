using _tnh = Problems.Shared.TreeNodeHelper;

namespace Problems.Test;

public class BinaryTreeLevelOrderTraversalTest
{
    private readonly Dictionary<int?[], int[][]> _testData = new()
    {
        { new int?[] { 3, 9, 20, null, null, 15, 7 }, new[] { new[] { 3 }, new[] { 9, 20 }, new[] { 15, 7 } } },
        { new int?[] { 1 }, new[] { new[] { 1 } } },
        { new int?[] { }, new int[][] { } },
    };

    [Fact]
    public void PreorderTest()
    {
        foreach (var kvp in _testData)
        {
            var node = _tnh.CreateBinaryTreeAndReturnHead(kvp.Key);

            var nodeRes = BinaryTreeLevelOrderTraversal.LevelOrder(node);

            Assert.Equal(kvp.Value, nodeRes.ToArray());
        }
    }
}