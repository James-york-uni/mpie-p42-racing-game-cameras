using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject target = GameObject.Find ("Car 2");
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject target = GameObject.Find ("Car 2");

        Vector3 newPos2 = target.transform.position + offset;
        transform.position = newPos2;
    }
}
