namespace Problems;

public static class Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        foreach (var chr in s)
        {
            var it = t.IndexOf(chr);
            if (it == -1)
            {
                return false;
            }

            t = t.Substring(it + 1);
        }

        return true;
    }
}