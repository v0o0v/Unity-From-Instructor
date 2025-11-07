using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootTf;
    
    private Transform targetTf;
    public Transform turretHead;

    private float rotSpeed = 30f;
    
    private float targetHeight = 0.5f;

    private float timer;
    public float shootCooldown = 3f;
    private bool isRange; // 타겟이 범위 내에 있다/없다
    
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void Update()
    {
        Turn();
        Shoot();
    }

    public void Turn() // 터렛의 회전 기능
    {
        float distance = Vector3.Distance(this.transform.position, targetTf.position);
        
        if (distance <= 10f)
        {
            turretHead.LookAt(targetTf.position + Vector3.up * targetHeight);
            isRange = true;
        }

        if (distance > 10f)
        {
            turretHead.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
            isRange = false;
        }
    }

    public void Shoot() // 터렛의 발사 기능
    {
        timer += Time.deltaTime; // 타이머 기능

        if (timer >= shootCooldown && isRange == true)
        {
            timer = 0f;
            Instantiate(bulletPrefab, shootTf.position, shootTf.rotation); // 총알 생성
        }
    }
}