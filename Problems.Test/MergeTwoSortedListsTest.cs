using _llh = Problems.Shared.LinkedListHelper;

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
            var headNode1 = _llh.CreateSequenceAndGetHead(kvp.Key["set1"]);
            var headNode2 = _llh.CreateSequenceAndGetHead(kvp.Key["set2"]);

            var headNodeRes = MergeTwoSortedLists.MergeTwoLists(headNode1, headNode2);

            Assert.Equal(kvp.Value, _llh.GetValues(headNodeRes));
        }
    }
}