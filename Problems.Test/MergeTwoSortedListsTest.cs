namespace Problems.Test;

public class MergeTwoSortedListsTest
{
    private readonly Dictionary<Dictionary<string, int[]>, int[]> _testData = new()
    {
        { new() { { "set1", new[] { 1, 2, 4 } }, { "set2", new[] { 1, 3, 4 } } }, new[] { 1, 1, 2, 3, 4, 4 } },
        { new() { { "set1", new[] { 1, 2, 4 } }, { "set2", new int[] { } } }, new[] { 1, 2, 4 } },
        { new() { { "set1", new int[] { } }, { "set2", new[] { 4, 5, 6 } } }, new[] { 4, 5, 6 } },
        { new() { { "set1", new int[] { } }, { "set2", new int[] { } } }, new int[] { } },
    };

    [Fact]
    public void MergeTwoListsTest()
    {
        foreach (var kvp in _testData)
        {
            var headNode1 = CreateSequenceAndGetHead(kvp.Key["set1"]);
            var headNode2 = CreateSequenceAndGetHead(kvp.Key["set2"]);

            var headNodeRes = MergeTwoSortedLists.MergeTwoLists(headNode1, headNode2);

            Assert.Equal(kvp.Value, GetValues(headNodeRes));
        }
    }

    private static ListNode? CreateSequenceAndGetHead(IReadOnlyList<int> set)
    {
        ListNode? headNode = null;
        for (var i = set.Count - 1; i >= 0; i--)
        {
            var currentNode = new ListNode(set[i], headNode);
            headNode = currentNode;
        }

        return headNode;
    }

    private static int[] GetValues(ListNode? node)
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