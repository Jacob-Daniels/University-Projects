using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    void Update()
    {
        // change the position of the camera to the players position
        transform.position = new Vector3(Player.position.x + offset.x, Player.position.y + offset.y, -10);
    }
}
