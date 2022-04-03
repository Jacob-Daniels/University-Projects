using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    // saw movement variables
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float YOffset;
    public float XOffset;
    public float speed = 1.5f;
    private bool moveToEnd = false;
    // saw animation variables
    public Animator sawAnim;
    public bool resetSpinning = false;

    void Start()
    {
        // set animator variable to component
        sawAnim = gameObject.GetComponent<Animator>();
        // set startPosition and endPosition values
        startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        endPosition = new Vector3(transform.position.x + XOffset, transform.position.y + YOffset, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // move saw
        moveSaw();
    }

    void moveSaw()
    {
        // check which direction to move towards
        if (transform.position == startPosition)
        {
            sawAnim.SetTrigger("resetSaw");
            moveToEnd = true;
        }
        else if (transform.position == endPosition)
        {
            sawAnim.SetTrigger("resetSaw");
            moveToEnd = false;
        }

        // move saw depending boolean state (direction)
        if (moveToEnd == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, Time.deltaTime * speed);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, Time.deltaTime * speed);
        }
    }
}
