
/// <summary>
/// Handles player movement by applying force
/// </summary>
/// 
using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 75f;

    private Rigidbody2D rb; 

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //applies movement forces
    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * acceleration * Time.deltaTime); // apply force in specified direction
    }
}
