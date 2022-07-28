using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;    // player Transform component

    public float smoothSpeed = 0.125f;  // smooth between 0 and 1
    public Vector3 offset;  // camera offset

    void FixedUpdate()
    {
        // set camera position to player position
        Vector3 newPosition = player.position + offset;
        // .Lerp() is used to smooth the transition between 2 points
        Vector3 smoothPosition = Vector3.Lerp(transform.position, newPosition, smoothSpeed);
        // set camera to new player position smoothly (using lerp)
        transform.position = smoothPosition;

    }
}