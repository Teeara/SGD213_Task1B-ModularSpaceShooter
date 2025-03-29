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
        rb.AddForce(direction * acceleration * Time.deltaTime); //write function??? for dir i think (0-1) zero minus one for down Vector2.up ive done this now i think
    }
}
