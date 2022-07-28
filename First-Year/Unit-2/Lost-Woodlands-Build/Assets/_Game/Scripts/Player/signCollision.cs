using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class signCollision : MonoBehaviour
{
    // sign 1
    public GameObject[] signs;
    //public Text[] signText;
    public TextMeshProUGUI[] signText;

    void Start()
    {
        // hide all signs
        for (int i=0; i < signText.Length; i++)
        {
            signText[i].enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        // display text if player collides with sign
        for (int i=0; i < signs.Length; i++)
        {
            // check which sign player is colliding with and display text
            if (coll.gameObject == signs[i])
            {
                // display sign 1 text
                signText[i].enabled = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        // remove text if player is not colliding with sign
        for (int i = 0; i < signs.Length; i++)
        {
            // check which sign player is colliding with and hide text
            if (coll.gameObject == signs[i])
            {
                // display sign 1 text
                signText[i].enabled = false;
            }
        }
    }

}
