using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    // layer array
    public Transform[] bgLayers;
    // layer speeds
    public float Speed1;
    public float Speed2;
    public float Speed3;
    // starting position
    public Vector3 startPos;
    public Vector3 endPos;

    void Start()
    {
        startPos = new Vector3(1940 + 960, 540, 0);
        endPos = new Vector3(-1940 + 960, 0, 0); // - 718
    }

    void FixedUpdate()
    {
        // loop through background layers
        int count = 0;
        foreach (Transform layer in bgLayers)
        {
            // counter tp check layer type
            count++;
            // reposition layer if it is off screen
            if (layer.transform.position.x <= endPos.x) //layer.transform.position.x < -718
            {


                //startPos = new Vector3(2154, 442, 0);
                layer.transform.position = startPos;

            }
            
            // move background layers
            if (count <= 2)
            {
                layer.transform.Translate(-Speed1 * Time.deltaTime, 0, 0);
            }
            else if (count <= 4)
            {
                layer.transform.Translate(-Speed2 * Time.deltaTime, 0, 0);
            }
            else if (count <= 6)
            {
                layer.transform.Translate(-Speed3 * Time.deltaTime, 0, 0);
            }
        }
    }
}