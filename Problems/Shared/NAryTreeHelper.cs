namespace Problems.Shared;

public static class NAryTreeHelper
{
    public static Node? CreateNAryTreeAndReturnHead(int?[] values)
    {
        var nodeDictionary = new Dictionary<int, Node>();
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
                var node = new Node((int)value);
                nodeDictionary.Add(dicIndex++, node);

                if (headIndex is not null && nodeDictionary.TryGetValue((int)headIndex, out var headNode))
                {
                    if (headNode.children is null)
                    {
                        headNode.children = new List<Node>();
                    }

                    headNode.children.Add(node);
                }
            }
        }

        return nodeDictionary.Any() ? nodeDictionary[0] : null;
    }
}