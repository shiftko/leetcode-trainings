// See https://aka.ms/new-console-template for more information

int LengthOfLongestSubstring(string s)
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

// expected 3
Console.WriteLine(LengthOfLongestSubstring("pwwkew"));

// expected 3
Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));