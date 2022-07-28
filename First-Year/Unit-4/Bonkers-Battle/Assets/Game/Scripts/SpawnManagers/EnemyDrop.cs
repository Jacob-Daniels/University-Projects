using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    [Header("Enemy Drop")]
    public GameObject healthPrefab;
    public GameObject powerParent;
    public int dropChance = 3;
    public int maxRange = 6;

    void Start()
    {
        powerParent = GameObject.Find("PowerUpsParent");
    }

    public void DropChance()
    {
        // Generate number to spawn health drop
        int drop = (int)Random.Range(0, maxRange);
        if (drop == dropChance)
        {
            DropPowerUp();
        }
    }

    public void DropPowerUp()
    {
        var healthDrop = Instantiate(healthPrefab, transform.position, Quaternion.identity);
        healthDrop.transform.parent = powerParent.transform;
    }
}
