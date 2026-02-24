using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class PurpleCoins : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        PlayerInventory pI = other.GetComponent<PlayerInventory>();
        
        if (pI != null)
        {
            pI.CoinCollection();
            Debug.Log("A coin has been Collected");
            gameObject.SetActive(false);

        }
    }
}
