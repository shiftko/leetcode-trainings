using Problems.Shared;

namespace Problems;

public static class LowestCommonAncestorBinarySearchTree
{
    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var nodes = new List<(TreeNode node, HashSet<TreeNode> parents)>();
        nodes.Add((root, new HashSet<TreeNode>()));

        var foundP = false;
        var foundQ = false;

        var parentsP = new HashSet<TreeNode>();
        var parentsQ = new HashSet<TreeNode>();

        var counter = 0;
        while (counter < nodes.Count && (!foundP || !foundQ))
        {
            var node = nodes[counter].node;
            var parents = nodes[counter++].parents;

            if (node == p)
            {
                foundP = true;
                parentsP = parents;
            }

            if (node == q)
            {
                foundQ = true;
                parentsQ = parents;
            }

            if (!foundP || !foundQ)
            {
                parents.Add(node);
                if (node.left is not null)
                {
                    nodes.Add((node.left, new HashSet<TreeNode>(parents)));
                }

                if (node.right is not null)
                {
                    nodes.Add((node.right, new HashSet<TreeNode>(parents)));
                }
            }
        }

        if (parentsP.Contains(q))
        {
            return q;
        }

        if (parentsQ.Contains(p))
        {
            return p;
        }

        return (parentsP.Intersect(parentsQ)).LastOrDefault() ?? root;
    }
}