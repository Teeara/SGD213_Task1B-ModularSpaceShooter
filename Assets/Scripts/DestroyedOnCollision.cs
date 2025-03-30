using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;
using static DestroyedOnCollision;
using UnityEngine.SceneManagement;


/// <summary>
/// Destroys the GameObject when it collides with another object based on its tag type
/// </summary>

public enum TagListType
{
    Blacklist,
    Whitelist
}

public class DestroyedOnCollision : MonoBehaviour
{

    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;

    // A list of tags which we use to determine whether to explode or not
    // Depending on the tagListType (Blacklist or Whitelist)
    [SerializeField]
    private List<string> tags;


    void OnTriggerEnter2D(Collider2D other)
    {

        bool tagInList = tags.Contains(other.gameObject.tag);

        if (tagListType == TagListType.Blacklist
            && tagInList)
        {
            // Destroy if it's a Blacklist and the tag IS in the Blacklist
            Destroy(gameObject);

            if (gameObject.CompareTag("Player"))
            {
                //if player is hit by enemy, 'pause' the game to stop enemies from spawning
                Time.timeScale = 0;
                Debug.Log("Player destroyed! Game Over.");
                SceneManager.LoadScene("GameOver");//, LoadSceneMode.Additive
            }
        }

        

        else if (tagListType == TagListType.Whitelist
            && !tagInList)
        {
            // Destroy if it's a Whitelist and the tag is NOT in the Whitelist
            Destroy(gameObject);

        }
       

    }

}
// 