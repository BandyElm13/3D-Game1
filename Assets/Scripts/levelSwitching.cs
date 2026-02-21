using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSwitching : MonoBehaviour {
    public string[] nextScene  = { "Level-1", "Level-2", "Level-3"};
    private int sceneIndex = 0;

    void Start()
    {
        //reset to the Hub level
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LevelTrigger"))
        {
            if(sceneIndex < nextScene.Length)
            {
            Debug.Log("A scene was loaded");
            SceneManager.LoadScene(nextScene[sceneIndex]);
            sceneIndex++;
            }
        }
    }

}
