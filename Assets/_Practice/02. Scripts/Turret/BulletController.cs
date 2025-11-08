using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 50f;

    void Start()
    {
        Destroy(this.gameObject, 3f); // 3초 뒤에 자기자신을 파괴하는 기능
    }

    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}