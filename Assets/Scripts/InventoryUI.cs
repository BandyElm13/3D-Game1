using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public TextMeshProUGUI cointext;
    private PlayerInventory pi;


    void Start()
    {
    if(cointext == null)
        {
            cointext = GetComponent<TextMeshProUGUI>();
        }
    
    pi = FindAnyObjectByType<PlayerInventory>();
    if (pi != null)
        {
            pi.onPurpleCoinEvent.AddListener(UpdatePurpleCoin);
        }
    }

    public void UpdatePurpleCoin()
    {
        if(pi.NumberOfCoins < 10)
        {
            cointext.text = "0" + pi.NumberOfCoins.ToString();
        } else
        {
            cointext.text = pi.NumberOfCoins.ToString();
        }
    }
}
