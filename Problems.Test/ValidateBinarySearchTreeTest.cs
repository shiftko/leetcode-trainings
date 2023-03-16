using Problems.Shared;

namespace Problems.Test;

public class ValidateBinarySearchTreeTest
{
    private readonly Dictionary<int?[], bool> _testData = new()
    {
        { new int?[] { 5, 1, 4, null, null, 3, 6 }, false },
        { new int?[] { 5, 4, 6, null, null, 3, 7 }, false },
        // { new int?[] { 120, 70, 140, 50, 100, 130, 160, 20, 55, 75, 110, 119, 135, 150, 200 }, false },
        { new int?[] { 2, 1, 3 }, true },
        { new int?[] { 2, 2, 2 }, false },
        { new int?[] { 0, -1 }, true },
    };

    [Fact]
    public void GetMaxProfitTest()
    {
        foreach (var kvp in _testData)
        {
            var node = TreeNodeHelper.CreateBinaryTreeAndReturnHead(kvp.Key);
            var res = ValidateBinarySearchTree.IsValidBST(node);
            Assert.Equal(kvp.Value, res);
        }
    }
}