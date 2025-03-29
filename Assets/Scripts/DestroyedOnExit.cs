using UnityEngine;
using System.Collections;

/// <summary>
/// Destroys the GameObject when it exits the camera's viewport
/// </summary>

public class DestroyedOnExit : MonoBehaviour
{

    // Called when the object leaves the viewport
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
