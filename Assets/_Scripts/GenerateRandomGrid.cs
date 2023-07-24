using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomGrid
{
    private static int width = 20;
    private static int height = 20;

    public static Grid Generate()
    {
        Grid grid = new Grid(width, height);
        // create grid
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                {
                    grid.SetGrid(x, y, Grid.WALL);
                }
                else
                {
                    grid.SetGrid(x, y, Grid.TILE);

                    if (Random.Range(0f, 100f) > 95f)
                    {
                        grid.SetGrid(x, y, Grid.TABLE);
                    }
                }
            }
        }

        return grid;
    }

}
