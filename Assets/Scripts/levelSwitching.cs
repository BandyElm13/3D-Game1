using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSwitching : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //get user input
        if (Input.GetKeyDown(KeyCode.Space)) {
            //switch scenes
            Debug.Log("Space Bar Pressed");
            SceneManager.LoadScene("Level-1");
        }
         
    }
}
