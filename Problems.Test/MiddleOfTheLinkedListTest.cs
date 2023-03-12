using _llh = Problems.Shared.LinkedListHelper;

namespace Problems.Test;

public class MiddleOfTheLinkedListTest
{
    private readonly Dictionary<int[], int[]> _testData = new()
    {
        { new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 } },
        { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 4, 5, 6 } },
    };

    [Fact]
    public void GetMiddleNodeTest()
    {
        foreach (var kvp in _testData)
        {
            var node = _llh.CreateSequenceAndGetHead(kvp.Key);

            var midNode = MiddleOfTheLinkedList.GetMiddleNode(node);

            Assert.Equal(kvp.Value, _llh.GetValues(midNode));
        }
    }
}