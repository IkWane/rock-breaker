using UnityEngine;

public class RockSpanwing : MonoBehaviour
{
    public GameObject rockPrefab;
    public float spawnInterval;
    public LayerMask excludeMask;
    float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        } 
        else {
            timer = spawnInterval;
            GameObject new_object = Instantiate(
                rockPrefab, 
                transform.position + new Vector3(Random.Range(-50, 50)/10, 0, 0), 
                Quaternion.identity);
            new_object.GetComponent<rockScript>().hitPoints = (uint)Random.Range(10, 100);
            Rigidbody2D new_rigidbody = new_object.GetComponent<Rigidbody2D>();
            new_rigidbody.AddTorque(Random.Range(0, 1)*2-1 * 100);
            new_rigidbody.AddForce(Vector2.left * Random.Range(-10, 10)/10 * 200);
            new_rigidbody.excludeLayers = excludeMask;
        }
    }
}
