using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadGame()
    {
        SceneManager.LoadScene("Spaceship");
        Time.timeScale = 1;
    }

    //Exits the game
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
