using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{

    //create grid array
    public int[,] grid;

    public Grid(int width, int height)
    {
        grid = new int[width, height];
    }

    public void SetGrid(int x, int y, int value)
    {
        if (IsInGrid(x, y)) grid[x, y] = value;
    }

    public int GetGrid(int x, int y)
    {
        if (IsInGrid(x, y)) return grid[x, y];
        return -1;
    }

    private bool IsInGrid(int x, int y)
    {
        return x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1);
    }
}
