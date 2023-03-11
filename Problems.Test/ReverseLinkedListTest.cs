using Problems.Shared;
using _llh = Problems.Shared.LinkedListHelper;

namespace Problems.Test;

public class ReverseLinkedListTest
{
    private readonly Dictionary<int[], int[]> _testData = new()
    {
        { new[] { 1, 1, 2, 3, 4, 4 }, new[] { 4, 4, 3, 2, 1, 1 } },
    };

    [Fact]
    public void ReverseListTest()
    {
        foreach (var kvp in _testData)
        {
            var headNode = _llh.CreateSequenceAndGetHead(kvp.Key);

            ListNode? headNodeRes = ReverseLinkedList.ReverseList(headNode);

            Assert.Equal(kvp.Value, _llh.GetValues(headNodeRes));
        }
    }
}