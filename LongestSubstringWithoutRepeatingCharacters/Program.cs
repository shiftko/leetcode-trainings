// See https://aka.ms/new-console-template for more information

int LengthOfLongestSubstringBalance(string s)
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

int LengthOfLongestSubstringQuick(string s)
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

// expected 3
Console.WriteLine(LengthOfLongestSubstringBalance("pwwkew"));

// expected 3
Console.WriteLine(LengthOfLongestSubstringBalance("abcabcbb"));

// expected 3
Console.WriteLine(LengthOfLongestSubstringQuick("pwwkew"));

// expected 3
Console.WriteLine(LengthOfLongestSubstringQuick("abcabcbb"));