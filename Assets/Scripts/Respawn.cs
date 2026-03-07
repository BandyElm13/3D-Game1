using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LevelTrigger"))
        {
            SceneManager.LoadScene("Hub");
        }
    }
}
