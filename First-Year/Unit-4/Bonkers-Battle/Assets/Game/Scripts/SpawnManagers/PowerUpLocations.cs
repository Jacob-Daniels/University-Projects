using UnityEngine;
using TMPro;
[System.Serializable]
public class PowerUpLocations
{
    // UIText countdown object
    public GameObject countdown;
    // power up location
    public Vector3 location;

    public float cooldown;
    public bool canSpawn;

}
