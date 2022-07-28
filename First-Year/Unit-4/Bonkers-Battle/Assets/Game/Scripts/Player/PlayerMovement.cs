using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    PlayerCollision playerCollision;
    public Rigidbody2D rb;
    public Camera mainCam;

    [Header("Movement")]
    public float moveSpeed = 10f;
    public float currentSpeed;
    public bool inWater = false;
    Vector2 mousePos;
    Vector2 movement;

    private void Start()
    {
        // accessing another script
        playerCollision = GetComponent<PlayerCollision>();
    }
    void Update()
    {
        // Set angularVelocity/Velocity to 0 if changed (Fix bug when enemy pushes player during collision)
        if (rb.angularVelocity != 0 || rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            rb.velocity = new Vector2(0, 0);
            rb.angularVelocity = 0;
        }

        //getting the horizontal and vertical input
        movement.y = Input.GetAxisRaw("Vertical");
        // grab mouse position relative to camera world point
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        // change speed if player is in water
        if (inWater)
        {
            currentSpeed = moveSpeed / 2;
        } else if (!inWater)
        {
            currentSpeed = moveSpeed;
        }

    }

    void FixedUpdate()
    {
        if (playerCollision.playerDead == false)
        {
            // move in direction facing
            if (movement.y > 0f)
            {
                //move the player forwards
                transform.position += transform.up * Time.deltaTime * currentSpeed;
            }
            else if (movement.y < 0f)
            {
                // move the player backwards at half the movespeed
                transform.position += transform.up * -1 * Time.deltaTime * (currentSpeed - (currentSpeed / 2));
            }

            // get the direction towards the mouse poition
            Vector2 lookDirection = mousePos - rb.position;
            // get the angle of Z rotation
            float rotationAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
            // rotate the player
            rb.rotation = rotationAngle;
        } 
    }
}
