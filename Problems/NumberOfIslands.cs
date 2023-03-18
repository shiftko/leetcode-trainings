namespace Problems;

public static class NumberOfIslands
{
    public static int GetNumIslands(char[][] grid)
    {
        const char land = '1';
        const char water = '0';
        var islandСounter = 0;

        var cells = new Dictionary<(int m, int n), HashSet<(int m, int n)>>();
        var cellQueue = new List<((int m, int n) cell, HashSet<(int m, int n)> lands)>
        {
            (cell: (0, 0), lands: new HashSet<(int m, int n)>())
        };

        var counter = 0;
        while (counter < cellQueue.Count)
        {
            var cell = cellQueue[counter].cell;
            var lands = cellQueue[counter++].lands;

            if (grid[cell.m][cell.n] == land)
            {
                if (cells.TryGetValue((cell.m, cell.n), out var landList))
                {
                    lands.UnionWith(landList);
                }
                else
                {
                    cells.Add((cell.m, cell.n), new HashSet<(int m, int n)>(lands));
                    islandСounter++;
                }

                lands.Add(cell);
            }
            else
            {
                lands = new HashSet<(int m, int n)>();
            }

            if (cell.m + 1 < grid.Length)
            {
                cellQueue.Add((cell with { m = cell.m + 1 }, lands));
            }

            if (cell.n + 1 < grid[cell.m].Length)
            {
                cellQueue.Add((cell with { n = cell.n + 1 }, lands));
            }
        }

        return islandСounter;
    }
}