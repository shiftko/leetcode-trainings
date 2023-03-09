namespace LongestSubstringWithoutRepeatingCharacters.Test;

public class TestSubstringHelper
{
    [Fact]
    public void GetLengthOfLongestSubstringTest()
    {
        var testData = new Dictionary<string, int>
        {
            { "abcabcbb", 3 },
            { "bbbbb", 1 },
            { "pwwkew", 3 },
        };

        foreach (var kvp in testData)
        {
            Assert.Equal(kvp.Value, SubstringHelper.GetLengthOfLongestSubstringBalanced(kvp.Key));
            Assert.Equal(kvp.Value, SubstringHelper.GetLengthOfLongestSubstringFastest(kvp.Key));
        }
    }
}