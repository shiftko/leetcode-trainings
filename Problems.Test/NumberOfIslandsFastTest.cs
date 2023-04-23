namespace Problems.Test;

public class NumberOfIslandsFastTest
{
    private readonly List<(char[][] Input, int Output)> _testData = new()
    {
        (Input: new[]
        {
            new[] { '1', '1', '1', '1', '0' },
            new[] { '1', '1', '0', '1', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '1', '1', '1', '1', '0' },
            new[] { '0', '0', '0', '0', '0' },
        }, Output: 1),
        (Input: new[]
        {
            new[] { '1', '1', '0', '0', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '0', '0', '1', '0', '0' },
            new[] { '0', '0', '0', '1', '1' },
        }, Output: 3),
        (Input: new[]
        {
            new[] { '1', '0', '1' },
            new[] { '0', '1', '0' },
            new[] { '1', '0', '1' },
        }, Output: 5),
        (Input: new[]
        {
            new[] { '0', '1', '0' },
            new[] { '1', '0', '1' },
            new[] { '0', '1', '0' },
        }, Output: 4),
        (Input: new[]
        {
            new[] { '1', '1', '0' },
            new[] { '1', '1', '0' },
            new[] { '0', '0', '0' },
        }, Output: 1),
        (Input: new[]
        {
            new[] { '1', '1', '1' },
            new[] { '1', '0', '1' },
            new[] { '1', '1', '1' },
        }, Output: 1),
        (Input: new[]
        {
            new[] { '1', '1', '1' },
            new[] { '0', '1', '0' },
            new[] { '1', '1', '1' },
        }, Output: 1),

        (Input: new[]
        {
            new[] { '1', '1', '1', '1', '1', '0', '1', '1', '1', '1' },
            new[] { '1', '0', '1', '0', '1', '1', '1', '1', '1', '1' },
            new[] { '0', '1', '1', '1', '0', '1', '1', '1', '1', '1' },
            new[] { '1', '1', '0', '1', '1', '0', '0', '0', '0', '1' },
            new[] { '1', '0', '1', '0', '1', '0', '0', '1', '0', '1' },
            new[] { '1', '0', '0', '1', '1', '1', '0', '1', '0', '0' },
            new[] { '0', '0', '1', '0', '0', '1', '1', '1', '1', '0' },
            new[] { '1', '0', '1', '1', '1', '0', '0', '1', '1', '1' },
            new[] { '1', '1', '1', '1', '1', '1', '1', '1', '0', '1' },
            new[] { '1', '0', '1', '1', '1', '1', '1', '1', '1', '0' }
        }, Output: 2)
    };

    [Fact]
    public void NumIslandsTest()
    {
        foreach (var (input, output) in _testData)
        {
            Assert.Equal(output, NumberOfIslandsFast.GetNumIslands(input));
        }
    }

    [Fact]
    public void NumIslandsTest_0()
    {
        var input = new[]
        {
            new[] { '0', '0', '0' },
            new[] { '0', '0', '0' },
            new[] { '0', '0', '0' },
        };

        Assert.Equal(0, NumberOfIslandsFast.GetNumIslands(input));
    }

    [Fact]
    public void NumIslandsTest_1()
    {
        var input = new[]
        {
            new[] { '1', '1', '1' },
            new[] { '1', '0', '1' },
            new[] { '1', '1', '1' },
        };

        Assert.Equal(1, NumberOfIslandsFast.GetNumIslands(input));
    }

    [Fact]
    public void NumIslandsTest_2()
    {
        var input = new[]
        {
            new[] { '1', '0', '0' },
            new[] { '0', '0', '0' },
            new[] { '0', '0', '1' },
        };

        Assert.Equal(2, NumberOfIslandsFast.GetNumIslands(input));
    }

    [Fact]
    public void NumIslandsTest_3()
    {
        var input = new[]
        {
            new[] { '1', '0', '0' },
            new[] { '0', '1', '0' },
            new[] { '0', '0', '1' },
        };

        Assert.Equal(3, NumberOfIslandsFast.GetNumIslands(input));
    }

    [Fact]
    public void NumIslandsTest1()
    {
        var input = new[]
        {
            new[] { '1', '1', '1', '1', '1', '0', '1', '1', '1', '1' },
            new[] { '1', '0', '1', '0', '1', '1', '1', '1', '1', '1' },
            new[] { '0', '1', '1', '1', '0', '1', '1', '1', '1', '1' },
            new[] { '1', '1', '0', '1', '1', '0', '0', '0', '0', '1' },
            new[] { '1', '0', '1', '0', '1', '0', '0', '1', '0', '1' },
            new[] { '1', '0', '0', '1', '1', '1', '0', '1', '0', '0' },
            new[] { '0', '0', '1', '0', '0', '1', '1', '1', '1', '0' },
            new[] { '1', '0', '1', '1', '1', '0', '0', '1', '1', '1' },
            new[] { '1', '1', '1', '1', '1', '1', '1', '1', '0', '1' },
            new[] { '1', '0', '1', '1', '1', '1', '1', '1', '1', '0' }
        };

        Assert.Equal(2, NumberOfIslandsFast.GetNumIslands(input));
    }
}