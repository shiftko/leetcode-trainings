namespace Problems.Test;

public class NumberOfIslandsTest
{
    [Fact]
    public void NumIslandsTest()
    {
        var payload = new[]
        {
            new[] { '1', '1', '1', '1', '0' },
            new[] { '1', '1', '0', '1', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '1', '1', '1', '1', '0' },
            new[] { '0', '0', '0', '0', '0' },
        };
        var res = 1;

        Assert.Equal(res, NumberOfIslands.GetNumIslands(payload));
    }

    [Fact]
    public void NumIslandsTest2()
    {
        var payload = new[]
        {
            new[] { '1', '1', '0', '0', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '0', '0', '1', '0', '0' },
            new[] { '0', '0', '0', '1', '1' },
        };
        var res = 3;

        Assert.Equal(res, NumberOfIslands.GetNumIslands(payload));
    }
}