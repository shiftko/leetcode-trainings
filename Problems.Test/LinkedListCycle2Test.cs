using _llh = Problems.Shared.LinkedListHelper;

namespace Problems.Test;

public class LinkedListCycle2Test
{
    private readonly (int[] Input, int Index, int? Output)[] _testData =
    {
        (new[] { 3, 2, 0, -4 }, 1, 2),
        (new[] { 1, 2 }, 0, 1),
        (new[] { 1 }, -1, null),
    };

    [Fact]
    public void DetectCycleTest()
    {
        foreach (var tuple in _testData)
        {
            var headNode = _llh.CreateSequenceAndGetHead(tuple.Input, cycleIndex: tuple.Index);

            var headNodeRes = LinkedListCycle2.DetectCycle(headNode);

            Assert.Equal(tuple.Output, headNodeRes?.Val);
        }
    }

    [Fact]
    public void DetectCycle2Test()
    {
        foreach (var tuple in _testData)
        {
            var headNode = _llh.CreateSequenceAndGetHead(tuple.Input, cycleIndex: tuple.Index);

            var headNodeRes = LinkedListCycle2.DetectCycle2(headNode);

            Assert.Equal(tuple.Output, headNodeRes?.Val);
        }
    }
}