using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 75f;

    private Rigidbody2D rb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * acceleration * Time.deltaTime);
    }
}
