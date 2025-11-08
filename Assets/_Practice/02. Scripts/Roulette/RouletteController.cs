using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0f; // 룰렛 회전 조작

    public bool isStop = false; // 룰렛 멈추기 기능 실행 유무
    
    void Update()
    {
        transform.Rotate(-Vector3.forward * rotSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && isStop == false) // 만약 스페이브 키를 눌렀다면, 1번 실행
        {
            rotSpeed = 5f;
        }

        if (Input.GetKeyDown(KeyCode.Return)) // 만약 엔터 키를 눌렀다면, 1번 실행
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f;

            if (rotSpeed <= 0.01f) // 만약 회전 속도가 0.01보다 작아졌다면
            {
                // 회전 종료
                isStop = false;
                rotSpeed = 0f;
            }
        }
    }
}