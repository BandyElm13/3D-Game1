using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 90f;



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
