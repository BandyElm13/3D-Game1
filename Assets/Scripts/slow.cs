using UnityEngine;
using StarterAssets;
public class slow : MonoBehaviour
{   
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LevelTrigger"))
        {
            ThirdPersonController player = other.GetComponent<ThirdPersonController>();
            player.MoveSpeed = player.MoveSpeed *= 0.5f;
            player.SprintSpeed = player.SprintSpeed *= 0.5f;
        }
         gameObject.SetActive(false);
    }
}
