namespace Problems;

public static class LongestPalindrome
{
    public static int GetLongestPalindrome(string s)
    {
        var polLen = 0;
        var chars = new Dictionary<char, int>();
        foreach (var chr in s)
        {
            if (chars.ContainsKey(chr))
            {
                chars[chr]++;
            }
            else
            {
                chars[chr] = 1;
            }
        }

        var check = false;
        foreach (var kvp in chars)
        {
            if (kvp.Value % 2 == 0)
            {
                polLen += kvp.Value;
            }
            else
            {
                polLen += kvp.Value - 1;
                check = true;
            }
        }

        return check ? polLen + 1 : polLen;
    }
}