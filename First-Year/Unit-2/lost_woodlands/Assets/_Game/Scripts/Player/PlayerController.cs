using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // reference other scripts
    // jump cloud
    private Transform jumpCloud;
    private Animator jumpcloudAnim;
    // collectables
    private Collectable accessBug;
    public GameObject[] totalCollectables;
    [HideInInspector] public int bugsCaptured = 0;
    // ui text
    public TextMeshProUGUI collectableText;
    // player variables
    public Rigidbody2D rigidBody;
    public float speed = 5.0f;
    public float jumpForce = 8.0f;
    private Animator bloodAnim;
    private bool grounded;
    Animator animator;
    Vector2 boxExtents;
    // scene variables
    public TextMeshProUGUI EndHelpText;
    private int currentLevel;
    private int nextLevel;

    // Use this for initialization
    void Start()
    {
        // check current scene to load next level
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        // get the extent of the collision box
        boxExtents = GetComponent<BoxCollider2D>().bounds.extents;
        // player components
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        // get blood component
        bloodAnim = GameObject.Find("death_Blood").GetComponent<Animator>();
        // get component for jumpCloud
        jumpcloudAnim = GameObject.Find("Jump Cloud").GetComponent<Animator>();
        jumpCloud = GameObject.Find("Jump Cloud").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // grab player y velocity to check for 'jump' animation
        float ySpeed = rigidBody.velocity.y;
        animator.SetFloat("yspeed", ySpeed);

        // update fly/collectable UI
        string uiString = bugsCaptured + " / " + totalCollectables.Length;
        collectableText.text = uiString;

        // check if we are on the ground using raycast (checks collision from player and ground)
        Vector2 bottom = new Vector2(transform.position.x, transform.position.y - boxExtents.y);
        Vector2 hitBoxSize = new Vector2(boxExtents.x * 2.0f, 0.05f);
        RaycastHit2D result = Physics2D.BoxCast(bottom, hitBoxSize, 0.0f, new Vector3(0.0f, -1.0f), 0.0f, 1 << LayerMask.NameToLayer("Ground"));

        // check if player is 'grounded' then allow player to jump
        grounded = result.collider != null && result.normal.y > 0.9f;
    }

    void FixedUpdate()
    {
        // get the user input of 'left' or 'right' arrow key
        float horizontalMovement = Input.GetAxisRaw("Horizontal");

        // change sprite facing direction
        if (horizontalMovement > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        } else if (horizontalMovement < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        // move player
        rigidBody.velocity = new Vector2(speed * horizontalMovement, rigidBody.velocity.y);

        // make player jump
        if (grounded)
        {

            // set jump Cloud position to player position
            jumpCloud.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            // allow player to jump if on ground
            if (Input.GetAxisRaw("Jump") > 0.0f)
            {
                // play jump animation
                jumpcloudAnim.SetTrigger("UPKey");
                // play jump sound
                FindObjectOfType<AudioManager>().playAudio("playerJump");
                // make player jump
                rigidBody.AddForce(new Vector2(0.0f, jumpForce), ForceMode2D.Impulse);
            }
        }
    }

    // detect if player has collided with collectable
    void OnTriggerEnter2D(Collider2D coll)
    {
        // check for end of level
        if (coll.gameObject.tag == "LevelEnd" && bugsCaptured == totalCollectables.Length)
        {
            // play level complete sound
            FindObjectOfType<AudioManager>().playAudio("levelComplete");
            // hide the level end object
            StartCoroutine(LoadNextLevel());
        } else if (coll.gameObject.tag == "LevelEnd" && bugsCaptured != totalCollectables.Length)
        {
            // display text
            EndHelpText.gameObject.SetActive(true);
        }
        // loop through total flys/bugs
        for (int i = 0; i < totalCollectables.Length; i++)
        {
            // allow script to access variables from collectable script
            accessBug = totalCollectables[i].GetComponent<Collectable>();
            // check if player has collided with fly/bug
            if (coll.gameObject.tag == "CollectBug" && coll.gameObject == totalCollectables[i])
            {
                // set bug/fly distance from player
                if (accessBug.isCaptured == false)
                {
                    // play collectable sound
                    FindObjectOfType<AudioManager>().playAudio("grabCollectable");
                    // capture bug
                    bugsCaptured += 1;
                    accessBug.flyDist = bugsCaptured + (bugsCaptured / 5f);
                }
                // set bug/fly to captured
                accessBug.isCaptured = true;
            }
        }
    }

    // run when player exits a trigger
    void OnTriggerExit2D(Collider2D coll)
    {
        // remove text on exit
        if (coll.gameObject.tag == "LevelEnd" && bugsCaptured != totalCollectables.Length)
        {
            // hide text
            EndHelpText.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // check if player is colliding with an object with 'Death' tag
        if (coll.gameObject.tag == "Death")
        {
            // reloads the current level
            StartCoroutine(DoDeath());
        }
    }

    // when player dies wait before resetting level
    IEnumerator DoDeath()
    {
        // play blood animation
        bloodAnim.SetBool("playerDeath", true);
        // freeze the rigidbody
        rigidBody.constraints = RigidbodyConstraints2D.FreezeAll;
        // hide theplayer
        GetComponent<Renderer>().enabled = false;
        // play death sound
        FindObjectOfType<AudioManager>().playAudio("playerDeath");
        // make application wait 2 seconds
        yield return new WaitForSeconds(1);
        // reload current scene
        SceneManager.LoadScene(currentLevel);
    }


    IEnumerator LoadNextLevel()
    {
        if (nextLevel != SceneManager.sceneCountInBuildSettings)
        {
            // freeze the rigidbody
            rigidBody.constraints = RigidbodyConstraints2D.FreezeAll;
            // hide the player
            GetComponent<Renderer>().enabled = false;
            // wait to load new level
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(nextLevel);
        }
    }
}