namespace Problems.Test;

using LSWRC = LongestSubstringWithoutRepeatingCharacters;

public class LongestSubstringWithoutRepeatingCharactersTest
{
    private readonly Dictionary<string, int> testData = new()
    {
        { "abcabcbb", 3 },
        { "bbbbb", 1 },
        { "pwwkew", 3 },
    };

    [Fact]
    public void GetLengthOfLongestSubstringBalancedTest()
    {
        foreach (var kvp in testData)
        {
            Assert.Equal(kvp.Value, LSWRC.GetLengthOfLongestSubstringBalanced(kvp.Key));
        }
    }

    [Fact]
    public void GetLengthOfLongestSubstringFastestTest()
    {
        foreach (var kvp in testData)
        {
            Assert.Equal(kvp.Value, LSWRC.GetLengthOfLongestSubstringFastest(kvp.Key));
        }
    }
}