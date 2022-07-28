using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [Header("Effects")]
    public GameObject explosionEffect;

    // function to detect collision with on the projectile
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)    // 'wall' layer
        {
            // Play audio clip
            FindObjectOfType<AudioManager>().Play("Explosion");
            // create the explosion object
            GameObject explosionObject = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            // reposition the z axis to be infront of all other objects
            explosionObject.transform.position = new Vector3(transform.position.x, transform.position.y, -9f);

            // delete the current projectile and effect
            Destroy(explosionObject, 0.8f);
            Destroy(gameObject);
        }
    }
}
