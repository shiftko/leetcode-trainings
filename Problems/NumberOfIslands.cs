namespace Problems;

public static class NumberOfIslands
{
    public static int GetNumIslands(char[][] grid)
    {
        const char land = '1';
        const char water = '0';
        var islandСounter = 0;
        var checkedSet = new List<((int m, int n) cell, HashSet<(int m, int n)> island)>();

        var counter = 0;
        while (counter < checkedSet.Count)
        {
            var cell = checkedSet[counter].cell;
            var island = checkedSet[counter].island;

            if (grid[cell.m][cell.n] == land)
            {
                island.Add(cell);
            }

            // add next cells to checked set
            if (cell.m - 1 >= 0)
            {
                checkedSet.Add((cell with { m = cell.m - 1 }, island));
            }

            if (cell.m + 1 < grid.Length)
            {
                checkedSet.Add((cell with { m = cell.m + 1 }, island));
            }

            if (cell.n - 1 >= 0)
            {
                checkedSet.Add((cell with { n = cell.n - 1 }, island));
            }

            if (cell.n + 1 < grid[cell.m].Length)
            {
                checkedSet.Add((cell with { n = cell.n + 1 }, island));
            }
        }

        return counter;
    }
}