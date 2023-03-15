namespace Problems.Test;

public class BinarySearchTest
{
    private readonly ((int[] Nums, int Target) Input, int Output)[] _testData =
    {
        new((new[] { -1, 0, 3, 5, 9, 12 }, 9), 4),
        new((new[] { -1, 0, 3, 5, 9, 12 }, -1), 0),
        new((new[] { -1, 0, 3, 5, 9, 12 }, 0), 1),
        new((new[] { -1, 0, 3, 5, 9, 12 }, 33), -1),
        new((new[] { -1, 0, 3, 5, 9, 12 }, 12), 5),
        new((Array.Empty<int>(), 9), -1),
    };

    [Fact]
    public void SearchTest()
    {
        foreach (var set in _testData)
        {
            Assert.Equal(set.Output, BinarySearch.Search(set.Input.Nums, set.Input.Target));
        }
    }
}