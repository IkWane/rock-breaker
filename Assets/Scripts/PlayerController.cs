using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector2 movement;
    Rigidbody2D rb;
    void Awake() {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input
        movement.x = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Apply movement
        rb.linearVelocity = movement * moveSpeed;
    }
}
