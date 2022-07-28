using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [Header("Scripts, Objects & Components")]
    public PlayerMovement playerMovement;
    public GameObject explosionObject;
    public SpriteRenderer rend;

    [Header("Health Variables")]
    public float health;
    public float maxHealth = 10f;
    public bool playerDead = false;

    public void Start()
    {
        // Set health
        health = maxHealth;
        // accessing another script to later edit
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            playerDeath();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            // call to player death method
            playerDeath();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // slow the player down when they collide with water layer
        if (collision.gameObject.layer == 4)
        {
            // Play audio clip
            FindObjectOfType<AudioManager>().Play("Water");
            playerMovement.inWater = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // when player exits the water set the inWater boolean to false
        if (collision.gameObject.layer == 4)
        {
            playerMovement.inWater = false;
        }
    }

    public void DecreaseHealth(float damage)
    {
        // remove health when method is called to
        health -= damage * Time.deltaTime;
    }

    public void IncreaseHealth()
    {
        // Add to health
        if (health + 1 > maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health++;
        }
    }

    public void playerDeath()
    {
        // variable used to stop player moving/rotating when killed
        playerDead = true;
        // Play Audio clip
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        // Explosion effect
        GameObject explosionEffect = Instantiate(explosionObject, transform.position, Quaternion.identity);
        Destroy(explosionEffect, 3f);
        StartCoroutine(deathWait());
        // Background audio
        FindObjectOfType<AudioManager>().Stop("GameMusic");
        FindObjectOfType<AudioManager>().Play("DeathMusic");
        // Load Game Over Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator deathWait()
    {
        yield return new WaitForSeconds(3f);
    }
}
