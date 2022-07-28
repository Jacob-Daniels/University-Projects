using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public GameObject[] startObjects;

    [Header("Variables")]
    public bool triggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")   // When triggered hide starting area and play game
        {
            triggered = true;
            foreach (GameObject obj in startObjects)
            {
                if (obj.name == "WallBlock")
                {
                    obj.SetActive(true);
                }
                else
                {
                    obj.SetActive(false);
                }
            }
        }
    }
}
