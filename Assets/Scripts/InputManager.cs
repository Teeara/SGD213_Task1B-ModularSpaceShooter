using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    private Movement movement;
    private ShootingScript shooting;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = GetComponent<Movement>();
        shooting = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal"); //-1 left 1 right attach to player

        movement.Move(Vector2.right * input);

        if (Input.GetButton("Fire1"))
        {
            shooting.Shoot();
        }
    }
}
