using System.Data;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int startTime {get; private set;}

public void gameTimer()
{
    startTime--;
}

}
