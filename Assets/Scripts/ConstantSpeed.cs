using UnityEngine;

public class ConstantSpeed : MonoBehaviour
{


    [SerializeField]
    private Vector2 direction;

    [SerializeField]
    private Movement movement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Move(direction);
    }
}
