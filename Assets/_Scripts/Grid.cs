using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    public static int TILE = 0;
    public static int WALL = 1;
    public static int TABLE = 2;

    //create grid array
    public int[,] grid;

    public int width;
    public int height;

    public Grid(int width, int height)
    {
        grid = new int[width, height];
        this.width = width;
        this.height = height;
    }

    public Grid(int[,] grid)
    {
        this.grid = grid;
        width = grid.GetLength(0);
        height = grid.GetLength(1);
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

    public static Grid FromString(string s) {
        return JsonUtility.FromJson<Grid>(s);
    }

    //method to parse string to int[,] grid
    public static Grid ParseGrid(string s)
    {
        //split string into rows
        string[] rows = s.Split('\n');

        //get width and height
        int width = rows[0].Split(',').Length;
        int height = rows.Length;

        //create grid
        int[,] grid = new int[width, height];

        //loop through rows
        for (int y = 0; y < height; y++)
        {
            //split row into cells
            string[] cells = rows[y].Split(',');

            //loop through cells
            for (int x = 0; x < width; x++)
            {
                //parse cell to int
                grid[x, y] = int.Parse(cells[x]);
            }
        }

        return new Grid(grid);
    }

    //method to convert int[,] grid to string
    public override string ToString()
    {
        //get width and height
        int width = grid.GetLength(0);
        int height = grid.GetLength(1);

        //create string
        string s = "";

        //loop through rows
        for (int y = 0; y < height; y++)
        {
            //loop through cells
            for (int x = 0; x < width; x++)
            {
                //add cell to string
                s += grid[x, y];

                //add comma if not last cell
                if (x < width - 1) s += ",";
            }

            //add new line if not last row
            if (y < height - 1) s += "\n";
        }

        return s;
    }    
}
