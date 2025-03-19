using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector2 movement;
    Rigidbody2D rb;
    bool shooting = false;
    public GameObject BulletPrefab;
    public int bulletDamage;
    public float bulletSpeed;
    public float bulletSize;
    public float shootSpeed;
    float shootCooldown;
    void Awake() {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input
        movement.x = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            shooting = !shooting;
        }

        if (shooting && shootCooldown <= 0)
        {
            GameObject newBullet = Instantiate(BulletPrefab, transform.position + transform.up * 0.5f, Quaternion.identity);
            newBullet.transform.localScale = Vector3.one * bulletSize;
            Bullet bullet = newBullet.GetComponent<Bullet>();
            bullet.speed = bulletSpeed;
            bullet.damage = bulletDamage;
            shootCooldown = 1/shootSpeed;
        }

        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        // Apply movement
        rb.linearVelocity = movement * moveSpeed;
    }
}
