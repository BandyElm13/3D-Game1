using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI cointext;
    private TextMeshProUGUI timerText;

    private PlayerInventory pi;
    private Timer gt;

    void Start()
    {
    cointext = GetComponent<TextMeshProUGUI>();
    pi = FindAnyObjectByType<PlayerInventory>();
    if (pi != null)
        {
            pi.onPurpleCoinEvent.AddListener(UpdatePurpleCoin);
        }
    }

    public void UpdatePurpleCoin()
    {
        cointext.text = pi.NumberOfCoins.ToString();
    }
}
