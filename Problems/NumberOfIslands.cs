namespace Problems;

public static class NumberOfIslands
{
    enum CellState
    {
        Land = '1',
        Water = '0'
    }

    public static int GetNumIslands(char[][] grid)
    {
        var islandCounter = 0;

        var initialCell = new Cell(0, 0, grid, null);

        var queue = new List<Cell> { initialCell };

        var processedCells = new Dictionary<(int m, int n), Cell>();

        var counter = 0;
        while (counter < queue.Count)
        {
            var currentCell = queue[counter++];

            if (processedCells.TryGetValue((currentCell.M, currentCell.N), out var processedCell))
            {
                if (currentCell.IsLand())
                {
                    if (currentCell.Prev.IsLand() && processedCell.Prev.IsLand())
                    {
                        if (currentCell.Prev.Island.Id != processedCell.Prev.Island.Id)
                        {
                            currentCell.Island = currentCell.Prev.Island;
                            currentCell.Island.Cells.Add(currentCell);
                            MergeIslands(processedCell, currentCell);
                            islandCounter--;
                        }
                    }
                    else if (currentCell.Prev.IsLand() && !processedCell.Prev.IsLand())
                    {
                        processedCell.Island = currentCell.Prev.Island;
                        processedCell.Island.Cells.Add(processedCell);
                        islandCounter--;
                    }
                }
            }
            else
            {
                if (currentCell.IsLand())
                {
                    if (currentCell.Prev is not null && currentCell.Prev.IsLand())
                    {
                        // inherits reference on an island and expands it
                        currentCell.Island = currentCell.Prev.Island;
                        currentCell.Island?.Cells.Add(currentCell);
                    }
                    else
                    {
                        // creates new island and expands it
                        currentCell.Island = new Island(new List<Cell> { currentCell });
                        islandCounter++;
                    }
                }

                processedCells.Add((currentCell.M, currentCell.N), currentCell);

                #region Add the following cells to the processing queue

                if (currentCell.M + 1 < grid.Length)
                {
                    queue.Add(new Cell(currentCell.M + 1, currentCell.N, grid, currentCell));
                }

                if (currentCell.N + 1 < grid[currentCell.M].Length)
                {
                    queue.Add(new Cell(currentCell.M, currentCell.N + 1, grid, currentCell));
                }

                #endregion
            }
        }

        return islandCounter;
    }

    private static void MergeIslands(Cell processedCell, Cell currentCell)
    {
        foreach (var cell in currentCell.Island.Cells)
        {
            cell.Island = processedCell.Island;
            cell.Island.Cells.Add(cell);
        }
    }

    private class Cell
    {
        public readonly int M;
        public readonly int N;
        public readonly char[][] Grid;
        public Cell? Prev;

        public Island? Island = null;

        public Cell(int m, int n, char[][] grid, Cell? prev)
        {
            M = m;
            N = n;
            Grid = grid;
            Prev = prev;
        }

        public bool IsLand()
        {
            return (CellState)Grid[M][N] == CellState.Land;
        }
    }

    private class Island
    {
        public Guid Id { get; private set; }
        public List<Cell> Cells;

        public Island(List<Cell> cells)
        {
            Cells = cells;
            Id = Guid.NewGuid();
        }
    }
}