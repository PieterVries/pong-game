using UnityEngine;

public class PongBall : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    // Update is called once per frame
    void Launch()
    {
        Vector2 direction = new Vector2(Random.Range(0, 2) == 0 ? -1 : 1, Random.Range(-0.8f, 0.8f));
        rb.linearVelocity = direction.normalized * speed;
    }

}
