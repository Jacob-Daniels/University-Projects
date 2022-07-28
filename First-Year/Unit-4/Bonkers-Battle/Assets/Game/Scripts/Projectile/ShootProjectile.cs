using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    // class variables
    [Header("Scripts, Objects & Components:")]
    public Transform projectilePoint;
    public GameObject projectilePrefab;
    public GameObject projectileParent;

    [Header("Projectile Variables")]
    public float timer;
    public float maxTimer = 1f;
    public bool canShoot = true;
    public float projectileForce = 25f;

    private void Start()
    {
        projectileParent = GameObject.Find("ProjectileParent");
        // Set timer
        timer = maxTimer;
    }

    void Update()
    {
        // Check timer
        checkTimer();

        if (Input.GetButtonDown("Fire1"))
        {
            // call to the Shoot() function when 'space' key is pressed
            if (canShoot)
            {
                timer = 0f;
                canShoot = false;
                Shoot();
            }
        }
    }

    public void checkTimer()
    {
        // Increase timer
        if (timer < maxTimer && canShoot == false)
        {
            timer += Time.deltaTime;
        } else
        {
            timer = maxTimer;
            canShoot = true;
        }
    }

    void Shoot()
    {
        // create the projectile object at the location and angle the 'projectilePoint' object is at.
        GameObject projectile = Instantiate(projectilePrefab, projectilePoint.position, projectilePoint.rotation);
        projectile.transform.parent = projectileParent.transform;
        // grab the projectile component to later add force
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        // access the projectile to add force
        rb.AddForce(projectilePoint.up * projectileForce, ForceMode2D.Impulse);
        // Play audio clip
        FindObjectOfType<AudioManager>().Play("Shoot");
    }
}
