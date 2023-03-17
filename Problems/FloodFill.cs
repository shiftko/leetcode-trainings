namespace Problems;

public static class FloodFill
{
    public static int[][] GetFloodFill(int[][] image, int sr, int sc, int color)
    {
        var basePixelValue = image[sr][sc];

        var keepSet = new HashSet<(int sr, int sc)>();
        var checkSet = new List<(int sr, int sc)>();

        checkSet.Add(new(sr, sc));

        var counter = 0;
        while (counter < checkSet.Count)
        {
            var set = checkSet[counter++];
            if (basePixelValue == image[set.sr][set.sc])
            {
                image[set.sr][set.sc] = color;

                if (set.sr - 1 >= 0)
                {
                    var next = (set.sr - 1, set.sc);
                    if (!checkSet.Contains(next))
                    {
                        checkSet.Add(next);
                    }
                }

                if (set.sr + 1 < image.Length)
                {
                    var next = (set.sr + 1, set.sc);
                    if (!checkSet.Contains(next))
                    {
                        checkSet.Add(next);
                    }
                }

                if (set.sc - 1 >= 0)
                {
                    var next = (set.sr, set.sc - 1);
                    if (!checkSet.Contains(next))
                    {
                        checkSet.Add(next);
                    }
                }

                if (set.sc + 1 < image[set.sr].Length)
                {
                    var next = (set.sr, set.sc + 1);
                    if (!checkSet.Contains(next))
                    {
                        checkSet.Add(next);
                    }
                }
            }
        }

        return image;
    }
}