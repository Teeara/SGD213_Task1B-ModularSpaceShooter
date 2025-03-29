
/// <summary>
/// SampleMethod is a sample of how to use abstraction by
/// specification. It converts a provided integer to a float.
/// </summary>
/// <param name="number">any integer</param>
/// <returns>the number parameter as a float</returns>

using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    void Start()
    {
        //Maths to spawn the bullet directly infront of the player
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
        + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }


    public void Shoot()
    {
        if (Input.GetButton("Fire1"))
        {
            float CurrentTime = Time.time;

            // Shooting delay between bullets
            if (CurrentTime - lastFiredTime > fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

                Instantiate(bullet, spawnPosition, transform.rotation);

                lastFiredTime = CurrentTime;
            }

           
        }
    }

    public float SampleMethod(int number) 
    {
        return number;
    }

}
