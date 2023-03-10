namespace Problems.Test;

using IS = IsomorphicStrings;

public class IsomorphicStringsTest
{
    private readonly Dictionary<Dictionary<char, string>, bool> _testData = new()
    {
        { new Dictionary<char, string> { { 's', "egg" }, { 't', "add" } }, true },
        { new Dictionary<char, string> { { 's', "foo" }, { 't', "bar" } }, false },
        { new Dictionary<char, string> { { 's', "paper" }, { 't', "title" } }, true },
        { new Dictionary<char, string> { { 's', "xsxs" }, { 't', "baba" } }, true },
        { new Dictionary<char, string> { { 's', "badc" }, { 't', "baba" } }, false },
    };

    [Fact]
    public void IsIsomorphicTest()
    {
        foreach (var kvp in _testData)
        {
            Assert.Equal(kvp.Value, IS.IsIsomorphic(kvp.Key['s'], kvp.Key['t']));
        }
    }
}