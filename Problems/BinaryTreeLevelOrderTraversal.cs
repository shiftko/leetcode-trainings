using Problems.Shared;

namespace Problems;

public static class BinaryTreeLevelOrderTraversal
{
    public static IList<IList<int>> LevelOrder(TreeNode root)
    {
        var collector = new List<List<int>>();
        if (root is null)
        {
            return collector.ToArray();
        }

        collector.Add(new List<int> { root.val });

        var nodesList = new List<TreeNode> { root };
        while (nodesList.Any())
        {
            var nextList = new List<TreeNode>();
            var values = new List<int>();
            foreach (var node in nodesList)
            {
                if (node.left is not null)
                {
                    nextList.Add(node.left);
                    values.Add(node.left.val);
                }

                if (node.right is not null)
                {
                    nextList.Add(node.right);
                    values.Add(node.right.val);
                }
            }

            if (values.Any())
            {
                collector.Add(values);
            }

            nodesList = nextList;
        }

        return collector.ToArray();
    }
}