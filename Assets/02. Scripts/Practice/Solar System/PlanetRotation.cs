using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotSpeed = 30f;
    
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
    }
}