using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private string TextMeshPro cointext;

    void Start()
    {
    cointext = GetComponent<TextMeshPro>();
    }

    public void UpdatePurpleCoin(PlayerInventory PI)
    {
        cointext.text = PI.NumberOfCoins.ToString();
    }
}
