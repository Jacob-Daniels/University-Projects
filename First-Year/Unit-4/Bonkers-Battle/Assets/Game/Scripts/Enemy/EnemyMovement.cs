using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovement : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public Transform playerPos;
    public Rigidbody2D rb;
    public Vector3 firstPos;
    public Vector3 lastPos;

    [Header("Enemy Type")]
    public string enemyName;

    [Header("Movement")]
    public int nextPos = 1;
    public float smoothRotation = 5f;
    public float moveSpeed = 5f;
    public float attackDist = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // get the transform component of the player
        playerPos = GameObject.Find("PlayerBody").transform;
        // set the firstPos vector to the objects position when the program starts
        firstPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        lastPos = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
    }

    void Update()
    {
        // Set angularVelocity/Velocity to 0 if changed (Fix bug when enemy pushes player during collision)
        if (rb.angularVelocity == 0 || rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            rb.velocity = new Vector2(0, 0);
            rb.angularVelocity = 0;
        }
        
        // Move enemy depending on type
        if (enemyName == "Hank")
        {
            HankMovement();
        } else if (enemyName == "Remy")
        {
            RemyMovement();
        }
    }

    public void RemyMovement()
    {
        // Always follow the player
        followPlayer();
    }

    public void HankMovement()
    {
        // check whether player is in range to be attacked by enemy
        if (Vector2.Distance(transform.position, playerPos.transform.position) <= attackDist)
        {
            // set move state to attack
            nextPos = 3;
        }
        else
        {
            if (transform.position == firstPos)
            {
                // set move state to lastPos
                nextPos = 1;
            }
            else if (transform.position == lastPos)
            {
                // set move state to firstPos
                nextPos = 2;
            }
        }

        // move object position depending on boolean
        if (nextPos == 1)   // at lastPos
        {
            // Rotate the object 180 degrees
            Quaternion rotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smoothRotation);
            // move the object to the new position
            transform.position = Vector3.MoveTowards(transform.position, lastPos, Time.deltaTime * moveSpeed);
        }
        else if (nextPos == 2)    // at firstPos
        {
            // rotate the object 180 degrees
            Quaternion rotation = Quaternion.Euler(0, 0, 180);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smoothRotation);
            // move the object to the new position
            transform.position = Vector3.MoveTowards(transform.position, firstPos, Time.deltaTime * moveSpeed);
        }
        else if (nextPos == 3)    // attack player
        {
            followPlayer();
            // reset the firstPos and lastPos vectors encase player escapes
            firstPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            lastPos = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
        }
    }

    public void followPlayer()
    {
        // make enemy face/look towards the player
        Vector3 faceDirection = playerPos.transform.position - transform.position;
        float rotationAngle = Mathf.Atan2(faceDirection.y, faceDirection.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(rotationAngle, Vector3.forward);
        // move enemy towards the player
        transform.position = Vector2.MoveTowards(transform.position, playerPos.transform.position, moveSpeed * Time.deltaTime);
    }
}
