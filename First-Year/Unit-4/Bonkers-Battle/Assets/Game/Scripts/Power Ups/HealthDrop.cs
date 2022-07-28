using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public PlayerCollision playerColl;
    public Transform childObject;
    public PowerUpUI powerUpUI;

    [Header("Rotation")]
    public float angle;
    public float rotateSpeed = 5f;

    void Start()
    {
        playerColl = GameObject.Find("PlayerBody").GetComponent<PlayerCollision>();
        powerUpUI = GameObject.Find("PowerUpText").GetComponent<PowerUpUI>();
        childObject = gameObject.transform.GetChild(0);

        // Random starting angle
        angle = Random.Range(0, 360);
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
            playerColl.IncreaseHealth();
            powerUpUI.DisplayText(transform.position, "Health!");
            Destroy(gameObject);
        }
    }
}
