using System;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private GameObject npcPrefab;

    private Grid grid;

    [SerializeField] private int width = 10;
    [SerializeField] private int height = 10;

    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private GameObject wallPrefab;
    [SerializeField] private GameObject tablePrefab;

    private int tileSize;

    private float wallHeight = 3f;

    private List<GameObject> tiles = new List<GameObject>();
    private List<NavMeshSurface> surfaces = new List<NavMeshSurface>();

    private GridDAO gridDAO;

    private void Start() {
        GetGrid(GameManager.GetInstance().GetPlayer().GetUid());
    }

    public async void GetGrid(string owner) {
        Supabase.Client _supabase = SBManager.GetSupabase();
        var res = await _supabase.From<GridDAO>().Where(x => x.Owner == owner).Get();

        if (res.Model == null) {
            Grid newGrid = GenerateRandomGrid.Generate();
            SetGrid(newGrid);
        } else {
            gridDAO = res.Model;
            SetGrid(Grid.ParseGrid(gridDAO.Grid));
        }
    }

    private void UpdateGrid() {
        string gridString = grid.ToString();
        Supabase.Client _supabase = SBManager.GetSupabase();
        var res = _supabase.From<GridDAO>().Update(new GridDAO() { Grid = gridString });
    }

    public void SetGrid(Grid grid)
    {
        this.grid = grid;
        Generate();
    }

    public void Generate()
    {
        int startx = -width / 2;
        int starty = -height / 2;

        tileSize = (int)tilePrefab.transform.localScale.x;
        
        // create grid
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (grid.GetGrid(x, y) == Grid.WALL)
                {
                    GameObject wall = Instantiate(wallPrefab, new Vector3(startx + (tileSize / 2f) + tileSize * x, wallHeight / 2f, starty + (tileSize / 2f) + tileSize * y), Quaternion.identity);
                    wall.transform.localScale = new Vector3(tileSize, wallHeight, tileSize);
                }
                else
                {
                    GameObject tile = Instantiate(tilePrefab, new Vector3(startx + (tileSize / 2f) + tileSize * x, 0, starty + (tileSize / 2f) + tileSize * y), Quaternion.identity);
                    tiles.Add(tile);
                    surfaces.Add(tile.GetComponent<NavMeshSurface>());

                    if (grid.GetGrid(x, y) == Grid.TABLE)
                    {
                        Instantiate(tablePrefab, tile.transform.position, Quaternion.identity);
                    }
                }
            }
        }
        
        // bake all surfaces
        foreach (NavMeshSurface surface in surfaces)
        {
            surface.BuildNavMesh();
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawn npc
            GameObject npc = Instantiate(npcPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            GameManager.GetInstance().GetPlayer().SetUsername("testttt");
        }
    }
}
