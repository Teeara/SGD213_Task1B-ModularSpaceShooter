

using System;
using UnityEngine;

/// <summary>
/// Manages player inputs for movement and shooting
/// </summary>

public class InputManager : MonoBehaviour
{


    private Movement movement;
    private ShootingScript shooting;

    
    void Start()
    {
        movement = GetComponent<Movement>();
        shooting = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //check input from player 
        float input = Input.GetAxis("Horizontal"); 

        movement.Move(Vector2.right * input);

        //check if player is pressing "Fire1" button, if so shoot bullet
        if (Input.GetButton("Fire1"))
        {
            shooting.Shoot();
        }
    }
}
