namespace Problems;

public static class IsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var relations = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (relations.ContainsKey(s[i]))
            {
                if (relations[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (relations.ContainsValue(t[i]))
                {
                    return false;
                }

                relations.Add(s[i], t[i]);
            }
        }

        return true;
    }
}