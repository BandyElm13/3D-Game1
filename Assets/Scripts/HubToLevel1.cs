using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSwitching : MonoBehaviour {

    void Start()
    {
        //reset to the Hub level
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LevelTrigger"))
        {
            Debug.Log("A scene was loaded");
            SceneManager.LoadScene("Level-1");
            }
    }

}
