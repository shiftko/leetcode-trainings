namespace Problems.Shared;

public class TreeNodeHelper
{
    public static TreeNode? CreateBinaryTreeAndReturnHead(int?[] values)
    {
        var nodeDictionary = new Dictionary<int, TreeNode>();
        var dicIndex = 0;
        int? headIndex = null;

        foreach (var value in values)
        {
            if (value is null)
            {
                if (headIndex is null)
                {
                    headIndex = 0;
                }
                else
                {
                    headIndex++;
                }
            }
            else
            {
                var node = new TreeNode((int)value);
                nodeDictionary.Add(dicIndex++, node);

                if (headIndex is not null && nodeDictionary.TryGetValue((int)headIndex, out var headNode))
                {
                    if (headNode.left is null)
                    {
                        headNode.left = node;
                    }
                    else if (headNode.right is null)
                    {
                        headNode.right = node;
                    }
                }
                else
                {
                    headIndex = 0;
                }
            }
        }

        return nodeDictionary.Any() ? nodeDictionary[0] : null;
    }
}