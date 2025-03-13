using System;
using TMPro;
using UnityEngine;
public class rockScript : MonoBehaviour
{
    public int hitPoints;
    TextMeshPro display;
    Rigidbody2D rb;
    public RockSpawning spawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        display = transform.GetChild(0).GetComponent<TextMeshPro>();
        rb = GetComponent<Rigidbody2D>();
    }

    private float Sigmoid(float a, float x) {
        return 2/(1+Mathf.Exp(-a * x))-1;
    }

    private float Map(float x, float a, float b) {
        return a + (b - a) * x;
    }

    // Update is called once per frame
    void Update()
    {
        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
        display.text = hitPoints.ToString();
        float size = Map(Sigmoid(0.01f, hitPoints), 1.5f, 9f);
        transform.localScale = new Vector3(size, size, 1.0f);
        rb.mass = size/2;
        if (Mathf.Abs(rb.linearVelocity.y) < 11.0f)
        {
            GetComponent<CircleCollider2D>().sharedMaterial = Resources.Load<PhysicsMaterial2D>("physics materials/rocks bouncy pmat");
        } else {
            GetComponent<CircleCollider2D>().sharedMaterial = Resources.Load<PhysicsMaterial2D>("physics materials/rocks pmat");
        }
    }

    void OnDestroy() {
        spawner.rockAmount--;
    }
    
}
