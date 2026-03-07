using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public int curTime = 100;
    public bool timerRunning = false;

    public UnityEvent onTimer;

    void Start()
    {
        timerRunning = true;
        Debug.Log("timer start");
        StartCoroutine(gameTimer());
    }

    public IEnumerator gameTimer() {
    for(int i = curTime; i > 0; i--) {
        curTime = i;
        //Debug.Log("current time = " + i);
        yield return new WaitForSeconds(1f);
    }
    curTime = 0;
    timerRunning = false;
    onTimer.Invoke();
}

}
