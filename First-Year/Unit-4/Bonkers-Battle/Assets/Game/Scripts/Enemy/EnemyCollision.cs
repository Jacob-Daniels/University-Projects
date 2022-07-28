using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [Header("Scripts & Objects")]
    public PlayerCollision playerCollision;
    public EnemyMovement enemyMovement;
    public EnemyDrop enemyDrop;
    public CreateEnemy createEnemy;
    public Score score;

    private void Start()
    {
        // find object with 'PlayerCollision' script
        playerCollision = FindObjectOfType<PlayerCollision>();
        enemyMovement = gameObject.GetComponent<EnemyMovement>();
        enemyDrop = gameObject.GetComponent<EnemyDrop>();
        score = FindObjectOfType<Score>();
        createEnemy = FindObjectOfType<CreateEnemy>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            // Increase score
            score.addScore();
            // Chance for health drop
            enemyDrop.DropChance();
            // Decrease enemy counter and delete object
            if (enemyMovement.enemyName == "Hank")
            {
                Debug.Log("WORKING");
                createEnemy.HankCounter--;
                FindObjectOfType<AudioManager>().Play("HankDeath");
            } else if (enemyMovement.enemyName == "Remy")
            {
                FindObjectOfType<AudioManager>().Play("RemyDeath");
                createEnemy.RemyCounter--;
            }
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Decrease health while colliding
        if (collision.gameObject.tag == "Player")
        {
            switch (enemyMovement.enemyName)
            {
                case "Hank":
                    playerCollision.DecreaseHealth(1);
                    break;
                case "Remy":
                    playerCollision.DecreaseHealth(4);
                    break;
            }
        }
    }
}
