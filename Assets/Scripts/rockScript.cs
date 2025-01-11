using System;
using TMPro;
using UnityEngine;
public class rockScript : MonoBehaviour
{
    public uint hitPoints;
    TextMeshPro display;
    Rigidbody2D rb;
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
        display.text = hitPoints.ToString();
        float size = Map(Sigmoid(0.01f, hitPoints), 0.5f, 4);
        transform.localScale = new Vector3(size, size, 1.0f);
        rb.mass = size/2;
    }
}
