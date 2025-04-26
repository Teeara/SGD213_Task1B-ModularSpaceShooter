﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTripleShot : WeaponBase 
{
    [SerializeField] 
    private GameObject player;
    /// <summary>
    /// Shoot will spawn a three bullets, provided enough time has passed compared to our fireDelay.
    /// </summary>
    public override void Shoot() 
    {
        // get the current time
        float currentTime = Time.time;


        print("Shoot triple shot");
        // if enough time has passed since our last shot compared to our fireDelay, spawn our bullet
        if (currentTime - lastFiredTime > fireDelay) 
        {
            float x = -0.5f;
            // create 3 bullets
            for (int i = 0; i < 3; i++) 
            {
                // create our bullet
                GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
                // set their direction
                newBullet.GetComponent<MoveConstantly>().Direction = new Vector2(x + 0.5f * i, 0.5f);


                Collider2D bulletCollider = newBullet.GetComponent<Collider2D>();
                Collider2D playerCollider = player.GetComponent<Collider2D>();

                if (bulletCollider != null && playerCollider != null)
                {
                    Physics2D.IgnoreCollision(bulletCollider, playerCollider);
                }
                else
                {
                    Debug.LogWarning("Missing collider on bullet or player!");
                }
            }

            // update our shooting state
            lastFiredTime = currentTime;
        }
    }
}
