using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public Timer timer;
    public PlayerInventory pi;
    public int coinsRequired = 1;
    public GameObject Level_Switcher_cube;


    void Start()
    {
        Level_Switcher_cube.SetActive(false);
    }
    void Update()
    {
        if( pi.NumberOfCoins >= coinsRequired)
        {
            Complete();
        }
    }
    public void Complete()
    {
        timer.StopAllCoroutines();
        timer.timerRunning = false;

        Level_Switcher_cube.SetActive(true);
    }

}
