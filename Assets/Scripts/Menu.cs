using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public string levelToLoad = "sample";
    public void playGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
