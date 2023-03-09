// See https://aka.ms/new-console-template for more information

namespace LongestSubstringWithoutRepeatingCharacters;

public static class SubstringHelper
{
    public static int GetLengthOfLongestSubstringBalanced(string s)
    {
        var maxLen = 0;
        var chars = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (chars.ContainsKey(s[i]))
            {
                i = chars[s[i]];
                maxLen = Math.Max(maxLen, chars.Count);
                chars.Clear();
            }
            else
            {
                chars.Add(s[i], i);
            }
        }

        return Math.Max(maxLen, chars.Count);
    }

    public static int GetLengthOfLongestSubstringFastest(string s)
    {
        var maxLen = 0;
        var sub = "";
        foreach (var chr in s)
        {
            if (!sub.Contains(chr))
            {
                sub += chr;
            }
            else
            {
                if (sub.Length > maxLen)
                {
                    maxLen = sub.Length;
                }

                sub = sub.Substring(sub.IndexOf(chr) + 1) + chr;
            }
        }

        return sub.Length > maxLen ? sub.Length : maxLen;
    }
}