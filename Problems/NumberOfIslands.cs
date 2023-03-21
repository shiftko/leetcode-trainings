namespace Problems;

public static class NumberOfIslands
{
    enum CellState
    {
        IsLand = '1',
        IsWater = '0'
    }

    public static int GetNumIslands(char[][] grid)
    {
        const char land = '1';
        const char water = '0';

        var islandCounter = 0;

        var nodeList =
            new Dictionary<(int m, int n), ((int m, int n)? parentX, (int m, int n)? parentY, int? islandId)>();
        var cellQueue = new List<((int m, int n) cell, ((int m, int n)? parentX, (int m, int n)? parentY) ancestors)>
        {
            (cell: (m: 0, n: 0), ancestors: (parentX: null, parentY: null))
        };

        var counter = 0;
        while (counter < cellQueue.Count)
        {
            var index = counter++;
            var currentCell = cellQueue[index].cell;
            var currentCellAncestors = cellQueue[index].ancestors;

            // add or update node
            if (nodeList.TryGetValue(currentCell, out var ancestors))
            {
                if (ancestors.parentX is null)
                {
                    nodeList[currentCell] = ancestors with { parentX = currentCellAncestors.parentX };
                }
                else if (ancestors.parentY is null)
                {
                    nodeList[currentCell] = ancestors with { parentY = currentCellAncestors.parentY };
                }
            }
            else
            {
                nodeList.Add(currentCell, (currentCellAncestors.parentX, currentCellAncestors.parentY, islandId: null));
            }

            // add next cells to queue
            if (currentCell.m + 1 < grid.Length)
            {
                cellQueue.Add((currentCell with { m = currentCell.m + 1 }, (parentX: currentCell, parentY: null)));
            }

            if (currentCell.n + 1 < grid[currentCell.m].Length)
            {
                cellQueue.Add((currentCell with { n = currentCell.n + 1 }, (parentX: null, parentY: currentCell)));
            }
        }

        // count islands
        var islandId = 0;
        foreach (var (cell, ancestors) in nodeList)
        {
            var cellState = grid[cell.m][cell.n] == land ? CellState.IsLand : CellState.IsWater;

            var parentX = ancestors.parentX;

            var parentXState = parentX is null
                ? CellState.IsWater
                : grid[parentX.Value.m][parentX.Value.n] == land
                    ? CellState.IsLand
                    : CellState.IsWater;

            var parentY = ancestors.parentY;
            var parentYState = parentY is null
                ? CellState.IsWater
                : grid[parentY.Value.m][parentY.Value.n] == land
                    ? CellState.IsLand
                    : CellState.IsWater;

            if (cellState == CellState.IsWater)
            {
                continue;
            }

            if (parentXState == CellState.IsWater && parentYState == CellState.IsWater)
            {
                islandCounter++;
                nodeList[cell] = ancestors with { islandId = islandId++ };
            }
            else if (parentXState == CellState.IsLand && parentYState == CellState.IsLand)
            {
                // if parents have different islandId - we should reduce counter
                var px = parentX ?? throw new ArgumentNullException();
                var py = parentY ?? throw new ArgumentNullException();
                if (nodeList[px].islandId != nodeList[py].islandId)
                {
                    islandCounter--;
                    // in this case we have collision we need to edit the identifiers
                }

                nodeList[cell] = ancestors with { islandId = nodeList[px].islandId };
            }
            else
            {
                // the case where one of the parents is land and the other is not
                if (parentXState == CellState.IsLand)
                {
                    // this cell is an extension of the island and should get its id
                    var parent = parentX ?? throw new ArgumentNullException();
                    nodeList[cell] = ancestors with { islandId = nodeList[parent].islandId };
                }
                else
                {
                    // this cell is an extension of the island and should get its id
                    var parent = parentY ?? throw new ArgumentNullException();
                    nodeList[cell] = ancestors with { islandId = nodeList[parent].islandId };
                }
            }
        }

        return islandCounter;
    }
}