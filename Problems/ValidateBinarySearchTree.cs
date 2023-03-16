using Problems.Shared;

namespace Problems;

public static class ValidateBinarySearchTree
{
    public enum Action
    {
        Greater,
        Less
    }

    public static bool IsValidBST(TreeNode root)
    {
        var nodes = new List<(TreeNode Node, Dictionary<TreeNode, Action> Conditions)>();
        nodes.Add(new(root, new Dictionary<TreeNode, Action>()));

        var counter = 0;
        while (counter < nodes.Count)
        {
            var current = nodes[counter++];
            foreach (var condition in current.Conditions)
            {
                var action = condition.Value;
                var prevNode = condition.Key;
                if (action == Action.Greater)
                {
                    if (current.Node.val <= prevNode.val)
                    {
                        return false;
                    }
                }
                else
                {
                    if (current.Node.val >= prevNode.val)
                    {
                        return false;
                    }
                }
            }

            var left = current.Node.left;
            var right = current.Node.right;

            if (left is null && right is null)
            {
                continue;
            }

            if (left is not null)
            {
                var leftConditions = new Dictionary<TreeNode, Action>(current.Conditions);
                leftConditions.Add(current.Node, Action.Less);
                nodes.Add(new(left, leftConditions));
            }

            if (right is not null)
            {
                var rightConditions = new Dictionary<TreeNode, Action>(current.Conditions);
                rightConditions.Add(current.Node, Action.Greater);
                nodes.Add(new(right, rightConditions));
            }
        }

        return true;
    }
}