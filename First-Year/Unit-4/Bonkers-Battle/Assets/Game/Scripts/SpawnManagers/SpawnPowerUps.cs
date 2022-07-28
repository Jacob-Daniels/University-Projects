using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

public class SpawnPowerUps : MonoBehaviour
{
    [Header("Components")]
    public GameObject player;
    public GameObject powerPrefab;
    public GameObject powerParent;
    public GameObject countdownPrefab;
    public GameObject countdownParent;

    [Header("Tilemap")]
    public Tilemap tilemap;

    [Header("Variables")]
    public List<Vector3> spawnLocations;
    public List<Vector3> PUPoints;
    public PowerUpLocations[] PULocationArray;
    public float spawnCDLimit = 5f;
    public float spawnCooldown;

    private void Awake()
    {
        // Get boundary of the tilemap
        for (int i = tilemap.cellBounds.xMin; i < tilemap.cellBounds.xMax; i++)
        {   // X Bounds
            for (int j = tilemap.cellBounds.yMin; j < tilemap.cellBounds.yMax; j++)
            {   // Y Bounds
                // Check if tilemap has a tile in location
                Vector3Int selectTile = new Vector3Int(i, j, (int)tilemap.transform.position.y);
                Vector3 useTile = tilemap.CellToWorld(selectTile);
                // Add tile vector to list if it has a tile
                if (tilemap.HasTile(selectTile))
                {
                    useTile.x += 0.5f;
                    useTile.y += 0.5f;
                    useTile.z = 0f;
                    spawnLocations.Add(useTile);
                }
            }
        }
        // Set Array Size
        SetArray(ref PULocationArray);
    }

    private void SetArray(ref PowerUpLocations[] PUList)
    {
        int listSize = spawnLocations.Count;
        // Declare size of array
        PUList = new PowerUpLocations[listSize];
        // Set elements in array
        for (int i = 0; i < listSize; i++)
        {
            if (PULocationArray[i] == null)  // If null then populate array
            {
                PULocationArray[i] = new PowerUpLocations();
            }
            // Instantiate countdown object 
            PULocationArray[i].countdown = Instantiate(countdownPrefab, new Vector3(spawnLocations[i].x, spawnLocations[i].y + 0.8f, spawnLocations[i].z), Quaternion.identity);
            PULocationArray[i].countdown.transform.SetParent(countdownParent.transform, true);
            PULocationArray[i].countdown.SetActive(false);
            // Set variables of element in array
            PULocationArray[i].location = spawnLocations[i];
            PULocationArray[i].cooldown = spawnCDLimit;
            PULocationArray[i].canSpawn = true;
        }
    }

    void Start()
    {
        player = GameObject.Find("PlayerBody");

        // Set Cooldown
        spawnCooldown = spawnCDLimit;
    }

    void Update()
    {
        spawnTimer();
    }

    public void spawnTimer()
    {
        foreach (PowerUpLocations PUL in PULocationArray)   // Check through array list to spawn power up
        {
            switch (PUL.canSpawn)
            {
                case true:  // Spawn powerup on location
                    var powerUp = Instantiate(powerPrefab, PUL.location, Quaternion.identity);
                    powerUp.transform.parent = powerParent.transform;
                    PUPoints.Add(powerUp.transform.position);
                    PUL.cooldown = spawnCDLimit;
                    PUL.canSpawn = false;
                    
                    break;
                case false: // Check if power up is in position
                    if (!PUPoints.Contains(PUL.location))
                    {
                        if (PUL.cooldown <= 0f)
                        {
                            PUL.countdown.SetActive(false);
                            PUL.canSpawn = true;
                        } else
                        {
                            PUL.countdown.SetActive(true);
                            PUL.cooldown -= 1 * Time.deltaTime; // decrease timer if not in position
                            int CDInt = (int)PUL.cooldown;
                            string CDString = CDInt.ToString();
                            PUL.countdown.GetComponent<TextMeshProUGUI>().text = CDString;
                        }
                    }
                    break;
            }
        }
    }
}
