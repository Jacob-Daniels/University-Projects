using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // referencing player script variables
    private PlayerController player;
    private Rigidbody2D playerRigidBody;
    private Vector3 playerPos;
    private bool playerStopped;
    // collectable variables
    private Vector3 startPosition;
    private Vector3 newPosition;
    public float moveSpeed;
    private float xDistance;
    private float xPos;
    private bool moveDown = false;
    // variables to check which flys are captured
    public bool isCaptured = false;
    [HideInInspector] public float flyDist;

    // Start is called before the first frame update
    void Start()
    {
        // grab player component
        player = GameObject.Find("PlayerBody").GetComponent<PlayerController>();
        playerRigidBody = GameObject.Find("PlayerBody").GetComponent<Rigidbody2D>();
        // set vector variables from object position
        startPosition = transform.position;
        xPos = startPosition.x;
        newPosition = new Vector3(startPosition.x, startPosition.y + 0.6f, startPosition.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        checkCaptured();
    }

    void checkCaptured()
    {
        // move collectable if it is captured or not
        if (isCaptured)
        {
            moveSpeed = 8f;
            // check if player is not moving
            if (playerRigidBody.velocity.y == 0f && playerRigidBody.velocity.x == 0f)
            {
                // are object and player at same position
                if (transform.position == playerPos)
                {
                    playerStopped = true;
                    // set bug/fly idle position
                    startPosition = new Vector3(playerPos.x, playerPos.y - 0.3f, -2);
                    newPosition = new Vector3(playerPos.x, playerPos.y + 0.3f, -2);
                }
                // if object is idle then move fly/bug
                if (playerStopped == true)
                {
                    moveCaptured();
                }
                else
                {
                    // move object towards player
                    transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * moveSpeed);
                }
            }
            else
            {
                // check which way player is facing to position the fly/collectable
                playerStopped = false;
                Vector3 faceDir = new Vector3(0, 0, 0);
                if (player.transform.eulerAngles == faceDir)
                {
                    playerPos = new Vector3(player.transform.position.x - flyDist, player.transform.position.y + 0.5f, -2);
                }
                else
                {
                    playerPos = new Vector3(player.transform.position.x + flyDist, player.transform.position.y + 0.5f, -2);
                }
                // move object towards player
                transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * moveSpeed);
            }

        }
        else
        {
            // move fly when not captured
            moveEscaped();
        }
    }

    // move object while idle
    void moveEscaped()
    {
        // change boolean value depending on collectables current position
        if (transform.position == newPosition)
        {
            moveDown = true;
            // generate random values for x distance and y position
            xDistance = Random.Range(-0.2f, 0.2f);
            newPosition.y = startPosition.y + Random.Range(0.5f, 1.0f);
        }
        else if (transform.position == startPosition)
        {
            moveDown = false;
            // get random speed and distance
            moveSpeed = Random.Range(1.5f, 1.8f);
            xDistance = Random.Range(-0.2f, 0.2f);
        }

        // check which position the collectable should move to using the boolean variable
        if (moveDown == false)
        {
            newPosition.x = xPos + xDistance;
            transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime * moveSpeed);
        }
        else
        {
            startPosition.x = xPos + xDistance;
            transform.position = Vector3.MoveTowards(transform.position, startPosition, Time.deltaTime * moveSpeed);
        }
    }

    void moveCaptured()
    {
        // get random speed
        moveSpeed = Random.Range(1f, 2f);

        // check direction from current position
        if (transform.position == newPosition)
        {
            moveDown = true;
            // set newPosition values
            newPosition = new Vector3(playerPos.x, playerPos.y + Random.Range(0.2f, 0.3f), playerPos.z);
        }
        else if (transform.position == startPosition)
        {
            moveDown = false;
            // set startPosition values
            startPosition = new Vector3(playerPos.x, playerPos.y - Random.Range(0.2f, 0.3f), playerPos.z);
        }

        // check which position the collectable should move to using the boolean variable
        if (moveDown == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPosition, Time.deltaTime * moveSpeed);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, Time.deltaTime * moveSpeed);
        }
    }
}
