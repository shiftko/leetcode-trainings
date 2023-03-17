using Problems.Shared;

namespace Problems.Test;

public class LowestCommonAncestorBinarySearchTreeTest
{
    private readonly List<((int?[] root, int p, int q) input, int output)> _testData = new()
    {
        (new(new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 }, 2, 8), 6),
    };

    [Fact]
    public void GetMaxProfitTest()
    {
        foreach (var set in _testData)
        {
            var node = TreeNodeHelper.CreateBinaryTreeAndReturnHead(set.input.root);
            var res = LowestCommonAncestorBinarySearchTree.LowestCommonAncestor(node, node.left, node.right);
            Assert.Equal(node, res);
        }
    }
}