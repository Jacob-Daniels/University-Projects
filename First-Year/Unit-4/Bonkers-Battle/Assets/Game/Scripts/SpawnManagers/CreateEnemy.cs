using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CreateEnemy : MonoBehaviour
{
    [Header("Components")]
    public StartTrigger startTrigger;
    public GameObject player;
    public GameObject[] prefab;
    public GameObject[] parent;

    [Header("Tilemap")]
    public Tilemap tilemap;
    public List<Vector3> spawnLocations;

    [Header("Enemies")]
    public int HankLimit = 15;
    public int HankCounter;
    public int RemyLimit = 5;
    public int RemyCounter;

    void Start()
    {
        player = GameObject.Find("PlayerBody");
        startTrigger = GameObject.Find("StartTrigger").GetComponent<StartTrigger>();

        // create list
        spawnLocations = new List<Vector3>();
        
        // get boundary of the current tilemap
        for (int i = tilemap.cellBounds.xMin; i < tilemap.cellBounds.xMax; i++)
        {
            for (int j = tilemap.cellBounds.yMin; j < tilemap.cellBounds.yMax; j++)
            {
                // checking whether the tilemap has a tile and adding the tile location to a list
                Vector3Int selectTile = new Vector3Int(i, j, (int)tilemap.transform.position.y);
                Vector3 useTile = tilemap.CellToWorld(selectTile);
                if (tilemap.HasTile(selectTile))
                {
                    // tile in tilemap
                    spawnLocations.Add(useTile);
                }
            }
        }
    }

    void Update()
    {
        if (startTrigger.triggered)
        {
            // spawn enemies
            if (HankCounter < HankLimit)
            {
                spawnEnemy("Hank");
            }
            if (RemyCounter < RemyLimit)
            {
                spawnEnemy("Remy");
            }
        }
    }

    private void spawnEnemy(string name)
    {
        // Get spawn position and check range of player
        int selectSpawn = (int)Random.Range(0, spawnLocations.Count);

        if (Vector2.Distance(player.transform.position, spawnLocations[selectSpawn]) > 20)
        {
            if (name == "Hank")
            {
                var e = Instantiate(prefab[0], new Vector3(spawnLocations[selectSpawn].x, spawnLocations[selectSpawn].y, 0f), Quaternion.identity);
                e.transform.parent = parent[0].transform;
                HankCounter++;
            } else if (name == "Remy")
            {
                var e = Instantiate(prefab[1], new Vector3(spawnLocations[selectSpawn].x, spawnLocations[selectSpawn].y, 0f), Quaternion.identity);
                e.transform.parent = parent[1].transform;
                RemyCounter++;
            }
        }
    }
}
