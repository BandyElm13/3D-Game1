using UnityEngine;
using UnityEngine.Rendering;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins { get; private set;}

    public void CoinCollection()
    {
        NumberOfCoins++;
    }
}
