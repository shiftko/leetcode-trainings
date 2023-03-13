namespace Problems.Test;

public class LongestPalindromeTest
{
    private readonly Dictionary<string, int> _testData = new()
    {
        { "abccccdd", 7 },
        { "bb", 2 },
        { "a", 1 },
    };


    [Fact]
    public void GetLongestPalindromeTest()
    {
        foreach (var kvp in _testData)
        {
            Assert.Equal(kvp.Value, LongestPalindrome.GetLongestPalindrome(kvp.Key));
        }
    }
}