using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCoins { get; private set;}

    public UnityEvent<PlayerInventory> onPurpleCoinEvent;

    public void CoinCollection()
    {
        NumberOfCoins++;
        onPurpleCoinEvent.Invoke(this);
    }
}
