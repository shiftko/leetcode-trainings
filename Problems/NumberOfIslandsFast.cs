namespace Problems;

public static class NumberOfIslandsFast
{
    public static int GetNumIslands(char[][] grid)
    {
        int Result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    SinkTheIsland(grid, (m: i, n: j));
                    Result++;
                }
            }
        }

        return Result;
    }

    private static void SinkTheIsland(char[][] grid, (int m, int n) land)
    {
        grid[land.m][land.n] = '0';

        if (land.m - 1 >= 0 && grid[land.m - 1][land.n] == '1')
        {
            SinkTheIsland(grid, land with { m = land.m - 1 });
        }

        if (land.m + 1 < grid.Length && grid[land.m + 1][land.n] == '1')
        {
            SinkTheIsland(grid, land with { m = land.m + 1 });
        }

        if (land.n - 1 >= 0 && grid[land.m][land.n - 1] == '1')
        {
            SinkTheIsland(grid, land with { n = land.n - 1 });
        }

        if (land.n + 1 < grid[land.m].Length && grid[land.m][land.n + 1] == '1')
        {
            SinkTheIsland(grid, land with { n = land.n + 1 });
        }
    }
}