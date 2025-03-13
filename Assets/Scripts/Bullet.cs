using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;

        if (transform.position.y > 20f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        rockScript hit;
        if (collision.TryGetComponent<rockScript>(out hit))
        {
            hit.hitPoints -= damage;
            Destroy(gameObject);
        }
    }
}
