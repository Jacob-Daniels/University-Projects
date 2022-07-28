using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public PlayerMovement playerMove;
    public ShootProjectile projectile;
    public Transform childObject;
    public SpawnPowerUps SpawnPU;
    public PowerUpUI powerUpUI;

    [Header("PowerUp Variables")]
    public bool increaseSpeed;
    public bool decreaseReload;

    [Header("Rotation")]
    public float angle;
    public float rotateSpeed = 5f;

    void Awake()
    {
        playerMove = GameObject.Find("PlayerBody").GetComponent<PlayerMovement>();
        projectile = GameObject.Find("PlayerBody").GetComponent<ShootProjectile>();
        SpawnPU = GameObject.Find("SpawnPowerUps").GetComponent<SpawnPowerUps>();
        powerUpUI = GameObject.Find("PowerUpText").GetComponent<PowerUpUI>();
        childObject = gameObject.transform.GetChild(0);

        // Random starting angle
        angle = Random.Range(0, 360);
        // Assign power up
        int powerNumber = (int)Random.Range(1, 3);
        switch (powerNumber)
        {
            case 1:
                increaseSpeed = true;
                break;
            case 2:
                decreaseReload = true;
                break;
        }
    }

    private void Update()
    {
        // Rotate Object
        angle += 0.4f;
        Quaternion rotateZ = Quaternion.Euler(0, 0, angle);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotateZ, rotateSpeed * Time.deltaTime);
        childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f - transform.rotation.z);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            // Check Power Up Type
            if (increaseSpeed)
            {
                IncreaseSpeed();
                powerUpUI.DisplayText(transform.position, "Increased Speed!");
            } else if (decreaseReload)
            {
                DecreaseReload();
                powerUpUI.DisplayText(transform.position, "Quicker Reload!");
            }
            // Remove object location from vector list and delete it
            if (SpawnPU.PUPoints.Contains(gameObject.transform.position))
            {
                SpawnPU.PUPoints.Remove(gameObject.transform.position);
            }
            Destroy(gameObject);
        }
    }


    public void IncreaseSpeed()     // Increase player speed
    {
        if (playerMove.moveSpeed < 20)
        {
            playerMove.moveSpeed++;
        }
    }

    public void DecreaseReload()    // Decrease reload time
    {
        if (projectile.maxTimer >= 0.2f)
        {
            projectile.maxTimer -= 0.1f;
        }
    }
}
