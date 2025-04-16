using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("rocks"))
        {
            transform.parent.GetComponent<PlayerController>().playerGetHit(collision);
        }
    }
}
