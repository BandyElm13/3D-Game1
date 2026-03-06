using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins { get; private set;}

    public UnityEvent onPurpleCoinEvent;

    public void CoinCollection()
    {
        NumberOfCoins++;
        onPurpleCoinEvent.Invoke();
    }
}
