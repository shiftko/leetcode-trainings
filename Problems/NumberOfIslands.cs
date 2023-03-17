namespace Problems;

public static class NumberOfIslands
{
    public static int GetNumIslands(char[][] grid)
    {
        var land = '1';
        var water = '0';
        var islands = 0;
        var checkedSet = new List<(int x, int y)>();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                var cell = (x: i, y: j);
                if (checkedSet.Contains(cell))
                {
                    continue;
                }

                checkedSet.Add(cell);
                if (grid[cell.x][cell.y] == water)
                {
                    continue;
                }

                // we have land here so we will get all cells for this land
                var index = 0;
                var island = new List<(int x, int y)> { cell };

                do
                {
                    var currentCell = island[index++];
                    if (grid[currentCell.x][currentCell.y] == land)
                    {
                        if (currentCell.x - 1 >= 0)
                        {
                            var checkNext = currentCell with { x = currentCell.x - 1 };
                            if (!checkedSet.Contains(checkNext))
                            {
                                checkedSet.Add(checkNext);
                                island.Add(checkNext);
                            }
                        }

                        if (currentCell.x + 1 < grid.Length)
                        {
                            var checkNext = currentCell with { x = currentCell.x + 1 };
                            if (!checkedSet.Contains(checkNext))
                            {
                                checkedSet.Add(checkNext);
                                island.Add(checkNext);
                            }
                        }

                        if (currentCell.y - 1 >= 0)
                        {
                            var checkNext = currentCell with { y = currentCell.y - 1 };
                            if (!checkedSet.Contains(checkNext))
                            {
                                checkedSet.Add(checkNext);
                                island.Add(checkNext);
                            }
                        }

                        if (currentCell.y + 1 < grid[currentCell.x].Length)
                        {
                            var checkNext = currentCell with { y = currentCell.y + 1 };
                            if (!checkedSet.Contains(checkNext))
                            {
                                checkedSet.Add(checkNext);
                                island.Add(checkNext);
                            }
                        }
                    }
                } while (index < island.Count);

                islands++;
            }
        }

        return islands;
    }
}