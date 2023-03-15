namespace Problems;

// https://leetcode.com/problems/first-bad-version/
public class FirstBadVersion : VersionControl
{
    public int GetFirstBadVersion(int n)
    {
        var minVer = 0;
        var maxVer = n;
        var checkedVersions = new HashSet<int>();
        while (minVer <= maxVer)
        {
            var checkVer = minVer + (maxVer - minVer) / 2;

            if (IsBadVersion(checkVer))
            {
                if (checkedVersions.Contains(checkVer - 1))
                {
                    return checkVer;
                }

                maxVer = checkVer - 1;
            }
            else
            {
                if (checkedVersions.Contains(checkVer + 1))
                {
                    return checkVer + 1;
                }

                minVer = checkVer + 1;
            }

            checkedVersions.Add(checkVer);
        }

        return n;
    }
}

public class VersionControl
{
    protected static bool IsBadVersion(int checkVer)
    {
        return false;
    }
}