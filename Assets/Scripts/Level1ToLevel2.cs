using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1ToLevel2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LevelTrigger"))
        {
            SceneManager.LoadScene("Level-2");
        }
    }
}
