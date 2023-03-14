using _nth = Problems.Shared.NAryTreeHelper;
using _llh = Problems.Shared.LinkedListHelper;

namespace Problems.Test;

public class NAryTreePreorderTraversalTest
{
    private readonly Dictionary<int?[], int[]> _testData = new()
    {
        { new int?[] { 1, null, 3, 2, 4, null, 5, 6 }, new[] { 1, 3, 5, 6, 2, 4 } },
        {
            new int?[]
            {
                1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null,
                null, 14
            },
            new[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 }
        },
        {
            new int?[] { }, new int[] { }
        }
    };

    [Fact]
    public void PreorderTest()
    {
        foreach (var kvp in _testData)
        {
            var node = _nth.CreateNAryTreeAndReturnHead(kvp.Key);

            var nodeRes = NAryTreePreorderTraversal.Preorder(node);


            Assert.Equal(kvp.Value, nodeRes.ToArray());
        }
    }
}