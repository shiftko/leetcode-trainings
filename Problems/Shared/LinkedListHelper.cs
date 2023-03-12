namespace Problems.Shared;

public static class LinkedListHelper
{
    public static ListNode? CreateSequenceAndGetHead(IReadOnlyList<int> set)
    {
        ListNode? headNode = null;
        for (var i = set.Count - 1; i >= 0; i--)
        {
            var currentNode = new ListNode(set[i], headNode);
            headNode = currentNode;
        }

        return headNode;
    }

    public static ListNode? CreateSequenceAndGetHead(IReadOnlyList<int> set, int cycleIndex)
    {
        if (cycleIndex < 0)
        {
            return CreateSequenceAndGetHead(set);
        }

        ListNode? prevNode = null;
        ListNode? tailNode = null;
        for (var i = set.Count - 1; i >= 0; i--)
        {
            var currentNode = new ListNode(set[i], prevNode);
            prevNode = currentNode;

            if (i == set.Count - 1)
            {
                tailNode = currentNode;
            }

            if (i == cycleIndex)
            {
                if (tailNode != null)
                {
                    tailNode.Next = currentNode;
                }
            }
        }

        return prevNode;
    }

    public static int[] GetValues(ListNode? node)
    {
        var values = new List<int>();
        while (node is not null)
        {
            values.Add(node.Val);
            node = node.Next;
        }

        return values.ToArray();
    }
}