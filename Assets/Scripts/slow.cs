using UnityEngine;

public class slow : MonoBehaviour
{
    public double speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = speed * 0.5;
    }
}
