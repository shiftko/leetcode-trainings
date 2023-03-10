namespace Problems.Test;

public class SubsequenceTest
{
    private readonly Dictionary<Dictionary<char, string>, bool> _testData = new()
    {
        { new Dictionary<char, string> { { 's', "abc" }, { 't', "ahbgdc" } }, true },
        { new Dictionary<char, string> { { 's', "axc" }, { 't', "ahbgdc" } }, false },
        { new Dictionary<char, string> { { 's', "aaaaaa" }, { 't', "bbaaaa" } }, false },
        { new Dictionary<char, string> { { 's', "ab" }, { 't', "baab" } }, true },
    };

    [Fact]
    public void IsSubsequenceTest()
    {
        foreach (var kvp in _testData)
        {
            Assert.Equal(kvp.Value, Subsequence.IsSubsequence(kvp.Key['s'], kvp.Key['t']));
        }
    }
}