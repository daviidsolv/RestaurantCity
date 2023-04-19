using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    private Grid grid;

    [SerializeField] private int width = 10;
    [SerializeField] private int height = 10;

    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private GameObject wallPrefab;
    private int tileSize;

    private float wallHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
        int startx = -width / 2;
        int starty = -height / 2;

        tileSize = (int)tilePrefab.transform.localScale.x;
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                {
                    GameObject wall = Instantiate(wallPrefab, new Vector3(startx + (tileSize / 2f) + tileSize * x, wallHeight / 2f, starty + (tileSize / 2f) + tileSize * y), Quaternion.identity);
                    wall.transform.localScale = new Vector3(tileSize, wallHeight, tileSize);
                }
                else
                {
                    Instantiate(tilePrefab, new Vector3(startx + (tileSize / 2f) + tileSize * x, 0, starty + (tileSize / 2f) + tileSize * y), Quaternion.identity);
                }
            }
        }
    }
}
